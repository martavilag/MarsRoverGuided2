namespace MarsRoverGuided
{
    public class MarsRover
    {
        private readonly string _initialState;

        public MarsRover(string initialState)
        {
            _initialState = initialState;
        }

        public object Execute(string commands)
        {
            return _initialState;
        }
    }
}