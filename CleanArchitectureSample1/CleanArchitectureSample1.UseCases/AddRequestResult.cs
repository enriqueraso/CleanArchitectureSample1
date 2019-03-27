using System;

namespace CleanArchitectureSample1.UseCases
{
    internal class AddRequestResult : IAddRequestResult
    {
        public bool Result { get; internal set; }
        public string Message { get; internal set; }

        internal static IAddRequestResult Fail(string message)
        {
            return new AddRequestResult() { Result = false, Message = message };
        }

        internal static IAddRequestResult Success()
        {
            return new AddRequestResult() { Result = true };
        }
    }
}