namespace Lab02.Models
{
    public class LoggerService
    {
        private readonly ILoggerService _logger;

        public LoggerService(ILoggerService logger)
        {
            _logger = logger;
        }

        public void LogViewAccess(string viewName)
        {
            _logger.LogViewAccess(viewName);
        }
    }
}
 