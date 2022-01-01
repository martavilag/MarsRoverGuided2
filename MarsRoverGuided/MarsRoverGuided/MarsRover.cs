using System;
using System.Globalization;

namespace MarsRoverGuided
{
    public class MarsRover
    {
        private readonly string _initialState;
        private int x;
        private int y;

        public MarsRover(string initialState)
        {
            _initialState = initialState;
        }

        public object Execute(string commands)
        {
            Int32.TryParse(_initialState.Split(":")[0], out x);
            Int32.TryParse(_initialState.Split(":")[1], out y);
            string direction = _initialState.Split(":")[2];

            if (commands == "M")
                return $"{x}:{y+1}:{direction}";
            return _initialState;
        }
    }
}