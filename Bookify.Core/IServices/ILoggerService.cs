namespace Bookify.Core.IServices
{
	public interface ILoggerService
	{
		void Log(LogType type,string message, params object?[]? values);
		void LogInfo(string message, params object?[]? values);
		void LogError(string message, params object?[]? values);
		void LogWarning(string message, params object?[]? values);
	}
}
