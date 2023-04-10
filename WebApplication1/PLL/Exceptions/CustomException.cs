// AlexeyQwake Qwake

using System;

namespace WebApplication1
{
    public class CustomException : Exception
    {
        public CustomException(string message)
        {
            var ex = new Exception(message);
        }
    }
}