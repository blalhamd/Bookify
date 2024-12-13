namespace Bookify.Business.Services
{
	public class LoggerService : ILoggerService
	{
		private readonly ILogger _logger;
		private readonly IConfiguration _Configuration;

		public LoggerService(IConfiguration configuration)
		{
			_Configuration = configuration;
			_logger = new LoggerConfiguration()
				                    .ReadFrom.Configuration(_Configuration, new ConfigurationReaderOptions() { SectionName = "Serilog" })
									.Enrich.FromLogContext()
									.MinimumLevel.Debug() // before production, change it to Information.......Very Important
									.CreateLogger();
		}

		public void Log(LogType type, string message, params object?[]? values)
		{
			try
			{
				switch (type)
				{
					case LogType.Error:
						_logger.Error(message,values);
						break;
						case LogType.Warning:
						_logger.Warning(message,values);
						break;
					case LogType.Info:
						_logger.Information(message,values);
						break;
				   default:
						_logger.Error($"Error: {message}");
						break;
				}
			}
			catch (Exception ex)
			{
				try
				{
					EventLog eventLog = new EventLog(this.GetType().FullName, System.Environment.MachineName);

					eventLog.WriteEntry(ex.ToString(), EventLogEntryType.Error);
				}
				catch { }
			}
		}

		public void LogError(string message, params object?[]? values)
		{
			 Log(LogType.Error, message, values);
		}

		public void LogInfo(string message, params object?[]? values)
		{
			 Log(LogType.Info, message, values);
		}

		public void LogWarning(string message, params object?[]? values)
		{
		    Log(LogType.Warning, message, values);
		}
	}
}
