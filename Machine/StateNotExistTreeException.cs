using System;

namespace Machine
{
    class StateNotExistTreeException : Exception
    {
        public StateNotExistTreeException() { }

        public StateNotExistTreeException(string message) : base(message) { }
    }
}
