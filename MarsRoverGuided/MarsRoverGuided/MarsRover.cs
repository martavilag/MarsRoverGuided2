using System;
using System.Globalization;

namespace MarsRoverGuided
{
    public class MarsRover
    {
        private readonly string _initialState;
        private int _x;
        private int _y;
        private string _direction;

        public MarsRover(string initialState)
        {
            _initialState = initialState;
        }

        public object Execute(string commands)
        {
            Int32.TryParse(_initialState.Split(":")[0], out _x);
            Int32.TryParse(_initialState.Split(":")[1], out _y);
            _direction = _initialState.Split(":")[2];

            if (commands == "M")
            {
                if (_direction == "N")
                    return $"{_x}:{_y+1}:{_direction}";
                if (_direction == "W")
                    return $"{_x-1}:{_y}:{_direction}";
            }
                
            return $"{_x}:{_y}:{_direction}";
        }
    }
}