using System;

namespace CpusApi.Common.Exceprions
{
    class BusinessException : Exception
    {
        public BusinessException(string message)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
