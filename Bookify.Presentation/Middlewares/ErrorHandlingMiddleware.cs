namespace Bookify.Presentation.Middlewares
{
	public class ErrorHandlingMiddleware
	{
		private readonly ILoggerService _loggerService;
		private readonly RequestDelegate _next;

		public ErrorHandlingMiddleware(ILoggerService loggerService, RequestDelegate next)
		{
			_loggerService = loggerService;
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			try
			{
				await _next(context);
			}
			catch (Exception ex)
			{
				_loggerService.LogError(ex.Message);
			    HandleError(context,ex);
			}
		}

		private void HandleError(HttpContext context, Exception ex)
		{
			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

			var ErrorResponse = new ErrorViewModel()
			{
				ErrorMessage = ex.Message,
			};

			switch (ex)
			{
				case ItemNotFound:
					ErrorResponse.ErrorCode = (int)HttpStatusCode.NotFound;
					break;
				case BadRequest:
					ErrorResponse.ErrorCode = (int)HttpStatusCode.BadRequest;
					break;
				case ItemAlreadyExist:
					ErrorResponse.ErrorCode = (int)HttpStatusCode.Conflict;
					break;
				case InvalidOperation:
					ErrorResponse.ErrorCode = (int)HttpStatusCode.BadRequest;
					break;
				default:
					ErrorResponse.ErrorMessage = "Internal Server Error";
					break;
			}

			context.Response.Redirect($"/Home/CustomError?statusCode={ErrorResponse.ErrorCode}&message={Uri.EscapeDataString(ErrorResponse.ErrorMessage)}");
		}
	}
}
