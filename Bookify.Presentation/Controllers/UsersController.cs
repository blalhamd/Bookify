namespace Bookify.Presentation.Controllers
{
    [Authorize(Roles = DefaultRole.Admin)]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IEmailBodyBuilder _emailBuilder;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        public UsersController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IEmailSender emailSender, IMapper mapper, IWebHostEnvironment webHostEnvironment, IEmailBodyBuilder emailBuilder)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _webHostEnvironment = webHostEnvironment;
            _emailBuilder = emailBuilder;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.Select(x => new UserViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                UserName = x.UserName!,
                Email = x.Email!
            })
                .ToListAsync();

            if(users is null)
            {
                return NotFound();
            }

            return View(users);
        }

        public async Task<IActionResult> Create()
        {
            var roles = await _roleManager.Roles.Select(x => new SelectListItem
            {
                Value = x.Name, // because AddToRole(user,NameOfRoleNotId)
                Text = x.Name
            })
                .ToListAsync();

            var model = new CreateUserViewModel()
            {
                Roles = roles
            };

            return View(model);
        }

        #region Create User without divide action
        //[HttpPost]
        //public async Task<IActionResult> Create(CreateUserViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var email = await _userManager.FindByEmailAsync(model.Email);

        //    if (email is not null)
        //    {
        //        ModelState.AddModelError("Error: ", "Email is already in use");

        //        return View(model);
        //    }

        //    var UserName = await _userManager.FindByNameAsync(model.Email.Split('@')[0]);

        //    if (UserName is not null)
        //    {
        //        ModelState.AddModelError("Error: ", "UserName is already in use");

        //        return View(model);
        //    }


        //    var user = _mapper.Map<AppUser>(model);
        //    user.UserName = model.Email.Split('@')[0];

        //    var result = await _userManager.CreateAsync(user, model.Password);

        //    if (result.Succeeded)
        //    {
        //        if (model.SelectedRoles is not null)
        //        {
        //            await _userManager.AddToRolesAsync(user, model.SelectedRoles.AsEnumerable());
        //        }

        //        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        //        var callbackUrl = Url.Page(
        //            "/Account/ConfirmEmail",
        //            pageHandler: null,
        //            values: new { area = "Identity", userId = user.Id, code = code },
        //            protocol: Request.Scheme);

        //        // Full URL for image
        //        string imageUrl = $"{Request.Scheme}://{Request.Host}/assets/images/Screenshot.png"; // for images that on server
        //        string? imageFromGoogle = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTc9APxkj0xClmrU3PpMZglHQkx446nQPG6lA&s";

        //        // Replace placeholders in email template
        //        var body = await _emailBuilder.GenerateEmailBody(imageFromGoogle, header: $"Hi {user.FirstName}, We’re proud to have you join us!",
        //                                      body: "Please Confirm Your Email",
        //                                      link: $"{HtmlEncoder.Default.Encode(callbackUrl!)}",
        //                                      linkTitle: "Activate account");

        //        await _emailSender.SendEmailAsync(user.Email!, "Confirm your email", body);

        //        TempData["successmessage"] = "User Added Successfully";
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //    {
        //        var error = result.Errors.First();
        //        ModelState.AddModelError("Error: ", error.Description);
        //    }

        //    return View(model);
        //}
        #endregion

        #region Create User Action with Divide action on small methods
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Validate email and username availability
            if (!await IsEmailAvailable(model.Email) || !await IsUserNameAvailable(model.Email))
            {
                return View(model);
            }

            // Create user
            var user = await MapUser(model);
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await AssignRoles(user, model.SelectedRoles);

                // Generate confirmation email
                var emailBody = await GenerateEmailBody(user);

                await _emailSender.SendEmailAsync(user.Email!, "Confirm your email", emailBody);

                TempData["successmessage"] = "User Added Successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var error = result.Errors.First();
                ModelState.AddModelError("Error: ", error.Description);
            }

            return View(model);
        }

        // Helper Method 1: Check if email is available
        private async Task<bool> IsEmailAvailable(string email)
        {
            var existingEmail = await _userManager.FindByEmailAsync(email);
            if (existingEmail != null)
            {
                ModelState.AddModelError("Error: ", "Email is already in use");
                return false;
            }
            return true;
        }

        // Helper Method 2: Check if username is available
        private async Task<bool> IsUserNameAvailable(string email)
        {
            var userName = email.Split('@')[0];
            var existingUserName = await _userManager.FindByNameAsync(userName);
            if (existingUserName != null)
            {
                ModelState.AddModelError("Error: ", "UserName is already in use");
                return false;
            }
            return true;
        }

        // Helper Method 3: Map ViewModel to User
        private async Task<AppUser> MapUser(CreateUserViewModel model)
        {
            var user = _mapper.Map<AppUser>(model);
            user.UserName = model.Email.Split('@')[0];
            return user;
        }

        // Helper Method 4: Assign Roles to User
        private async Task AssignRoles(AppUser user, IEnumerable<string>? roles)
        {
            if (roles != null)
            {
                await _userManager.AddToRolesAsync(user, roles.AsEnumerable());
            }
        }

        // Helper Method 5: Generate Email Body
        private async Task<string> GenerateEmailBody(AppUser user)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = user.Id, code = code },
                protocol: Request.Scheme);

            string imageUrl = $"{Request.Scheme}://{Request.Host}/assets/images/Screenshot.png";
            string? imageFromGoogle = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTc9APxkj0xClmrU3PpMZglHQkx446nQPG6lA&s";

            var body = await _emailBuilder.GenerateEmailBody("emailTemplate.html", imageFromGoogle,header: $"Hi {user.FirstName}, We’re proud to have you join us!",
                body: "Please Confirm Your Email",
                link: $"{HtmlEncoder.Default.Encode(callbackUrl!)}",
                linkTitle: "Activate account");

            return body;
        }

        #endregion

        public async Task<IActionResult> Edit(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var UserViewModel = await GetUserViewModel(user,null);

            return View(UserViewModel);
        }

        [HttpPost("Users/Edit")]
        public async Task<IActionResult> Edit(int id,CreateUserViewModel model)
        {
            var existedUser = await _userManager.FindByIdAsync(id.ToString());

            if (existedUser == null)
            {
                ModelState.AddModelError("", "User not found");
                return View(nameof(Edit), await GetUserViewModel(null, model));
            }

            if (!ModelState.IsValid)
            {
                return View(nameof(Edit), await GetUserViewModel(existedUser,model));
            }

            var user = _mapper.Map(model,existedUser);

            user!.UserName = model.Email.Split('@')[0];

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                if (model.SelectedRoles is not null)
                {
                    await _userManager.AddToRolesAsync(user, model.SelectedRoles.AsEnumerable());
                }

                await _userManager.UpdateSecurityStampAsync(user); // this is very very important to LogOut User to resign it.

                TempData["successmessage"] = "User Updated Successfully";
                return RedirectToAction(nameof(Index));
            }

            var error = result.Errors.First();
            ModelState.AddModelError("Error: ", error.Description);

            return View(nameof(Edit), await GetUserViewModel(existedUser, model));
        }

        private async Task<UserViewModel> GetUserViewModel(AppUser? appUser,CreateUserViewModel? model)
        {
            var roles = await _roleManager.Roles.Select(x => new SelectListItem
            {
                Value = x.Name,
                Text = x.Name
            })
                .ToListAsync();

            var userViewModel = appUser is not null ? _mapper.Map<UserViewModel>(appUser) : _mapper.Map<UserViewModel>(model);

            var selectedRoles = appUser is not null ? await _userManager.GetRolesAsync(appUser) : model?.SelectedRoles;

            userViewModel.SelectedRoles = selectedRoles!;
            userViewModel.Roles = roles;

            return userViewModel;
        }

        [HttpPost("Users/ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            
            if (user is null)
            {
                return NotFound();
            }

            user.IsDeleted = !user.IsDeleted;

            await _userManager.UpdateAsync(user);

            await _userManager.UpdateSecurityStampAsync(user); // this is very very important to LogOut User to resign it.

            TempData["successmessage"] = "User Toggled Successfully.";

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> AllowEmail(CreateUserViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            var isAllowed = user is null;

            return Json(isAllowed);
        }

        public async Task<IActionResult> ResetPasswordForm(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user is null)
                return NotFound();

            var model = new ResetPasswordViewModel { Id = user.Id };

            return View(model);
        }

        [HttpPost("Users/ResetPassword")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByIdAsync(model.Id.ToString());

            if (user is null)
                return NotFound();

            var currentPassword = user.PasswordHash;

            await _userManager.RemovePasswordAsync(user);

            var result = await _userManager.AddPasswordAsync(user,model.Password);
            
            if(result.Succeeded)
            {
                await _userManager.UpdateAsync(user);

                TempData["successmessage"] = "Password changed Successfully";
                return RedirectToAction(nameof(Index));
            }

            user.PasswordHash = currentPassword; // نرجع الباسورد تاني مكانه في حاله عمليه اضافه الجديد فشلت بعد الازاله
            await _userManager.UpdateAsync(user);

            var error = string.Join(',', result.Errors.Select(x=> x.Description).ToList());

            ModelState.AddModelError(string.Empty, error);

            return View(model);
        }

        [HttpGet("Users/UnLockUser/{email}")]
        public async Task<IActionResult> UnLockUser(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user is null)
                return NotFound();

            var IsLocked = await _userManager.IsLockedOutAsync(user);

            if (IsLocked)
            {
                await _userManager.SetLockoutEndDateAsync(user, lockoutEnd: null);
                TempData["successmessage"] = "User Unlocked Successfully";
            }
            else
            {
                TempData["successmessage"] = "User is already Unlocked";
            }

            return RedirectToAction(nameof(Index));
        }

       
    }
}
