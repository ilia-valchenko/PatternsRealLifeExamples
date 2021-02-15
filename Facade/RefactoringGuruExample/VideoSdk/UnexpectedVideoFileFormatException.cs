using System;

namespace Facade.RefactoringGuruExample.VideoSdk
{
    // You can think of the class below as of a class from an external library
    // which you cannot modify.
    public class UnexpectedVideoFileFormatException : Exception
    {
        public UnexpectedVideoFileFormatException() : base()
        {
        }

        public UnexpectedVideoFileFormatException(string message) : base(message)
        {
        }

        public UnexpectedVideoFileFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}