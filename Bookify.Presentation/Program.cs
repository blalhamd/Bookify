var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.RegisterConfig(builder.Configuration);

#region Very Very Important and Must apply on System after Edit and Delete Users to resign it
builder.Services.Configure<SecurityStampValidatorOptions>(options =>
      options.ValidationInterval = TimeSpan.Zero);
#endregion

builder.Services.AddScoped<IUserClaimsPrincipalFactory<AppUser>, AppUserClaimsPrincipleFactory>();

builder.Services.AddControllersWithViews();

#region this is line is responsible for add [ValidateAntiforgeryToken] on all methods that "need" this Attribute like Post,PUT,Delete not Get and in case you want to ignore Post method from adding this attribue on it, go to it and add [IgnoreAntiforgeryToken]
builder.Services.AddMvc(options =>
	options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute())
	);
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	//app.UseExceptionHandler("/Home/Error");
	app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}"); // belong Error Page..
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

#region This is Important Middleware to make all cookies secure

app.UseCookiePolicy(new CookiePolicyOptions
{
	Secure = CookieSecurePolicy.Always
});

#endregion

#region This is Important Middleware to prevent using my website in Frame..

app.Use(async (context, next) =>
{
	context.Response.Headers.Add(key: "X-Frame-Options", value: "Deny");

	await next();
});
#endregion

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.UseMiddleware<ErrorHandlingMiddleware>();

app.Run();
