// AlexeyQwake Qwake

namespace WebApplication1
{
    public interface ILogger
    {
        public void WriteEvent(string eventMessage);
        public void WriteError(string errorMessage);
    }
}