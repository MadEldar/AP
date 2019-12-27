namespace Assignment01
{
    public class Number
    {
        private int _value;

        public Number(int value)
        {
            SetValue(value);
        }

        public void SetValue(int value)
        {
            this._value = value;
        }

        public int GetValue()
        {
            return this._value;
        }

        public int GetNearestFib()
        {
            int prev = 0, next = 1;
            while (prev + next < GetValue())
            {
                int temp = prev;
                prev = next;
                next = prev + temp;
            }

            return next;
        }
    }
}