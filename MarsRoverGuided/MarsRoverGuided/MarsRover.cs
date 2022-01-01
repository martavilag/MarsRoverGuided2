using System;
using System.Globalization;

namespace MarsRoverGuided
{
    public class MarsRover
    {
        private readonly string _initialState;
        private string _direction;
        private readonly Position _position;

        public MarsRover(string initialState)
        {
            _initialState = initialState;
            _position = new Position();
        }

        public object Execute(string commands)
        {
            Int32.TryParse(_initialState.Split(":")[0], out _position._x);
            Int32.TryParse(_initialState.Split(":")[1], out _position._y);
            _direction = _initialState.Split(":")[2];

            if (commands == "M")
            {
                switch (_direction)
                {
                    case "N":
                        return $"{_position._x}:{_position._y+1}:{_direction}";
                    case "W":
                        return $"{_position._x-1}:{_position._y}:{_direction}";
                    case "E":
                        return $"{_position._x+1}:{_position._y}:{_direction}";
                }
            }
                
            return $"{_position._x}:{_position._y}:{_direction}";
        }
    }
}