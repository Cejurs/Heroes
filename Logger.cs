using Heroes.Abstract;

namespace Heroes
{
    internal class Logger : ILogger
    {
        private readonly ConsoleColor _color;
        public Logger(ConsoleColor consoleColor) 
        {
            _color =  consoleColor;
        }
        public void Log(string message)
        {
            Console.BackgroundColor = _color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
