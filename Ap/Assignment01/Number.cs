namespace Assignment01
{
    public class Number
    {
        private int _value;

        public Number(int value)
        {
            Value = value;
        }

        public int Value
        {
            get => _value;
            set => _value = value;
        }

        public int GetNearestFib()
        {
            int prev = 0, next = 1;
            while (next < Value)
            {
                int temp = prev;
                prev = next;
                next = prev + temp;
            }

            return next + prev < Value * 2 ? next : prev ;
        }
    }
}