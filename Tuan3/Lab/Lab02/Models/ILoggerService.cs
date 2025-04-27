namespace Lab02.Models

{
    public interface ILoggerService
    {
        void LogViewAccess(string viewName);
    }
    public class LoggerServices : ILoggerService
    {


        public void LogViewAccess(string viewName)
        {
            Console.WriteLine($"Truy cập view: {viewName} vào lúc {DateTime.Now}");
        }
    }
}
