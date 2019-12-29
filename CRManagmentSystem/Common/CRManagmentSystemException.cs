using System;

namespace CRManagmentSystem.Common
{
    public class CRManagmentSystemException : Exception
    {

        public CRManagmentSystemException()
            : base()
        {

        }

        public CRManagmentSystemException(string message) : base(message)
        {
        }

        public CRManagmentSystemException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
