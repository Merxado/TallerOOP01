namespace _01Bakends
{
    public class Time
    {
        // Fields
        private int _hours;
        private int _minutes;
        private int _seconds;
        private int _milliseconds;

        // Constructors
        public Time() : this(0, 0, 0, 0)
        {
        }

        public Time(int hours) : this(hours, 0, 0, 0)
        {
        }

        public Time(int hours, int minutes) : this(hours, minutes, 0, 0)    
        {
        }

        public Time(int hours, int minutes, int seconds) : this(hours, minutes, seconds, 0)
        {
        }

        public Time(int hours, int minutes, int seconds, int milliseconds)
        {
            if (hours < 0 || hours > 23)
                throw new ArgumentException("Hours must be between 0 and 23");

            if (minutes < 0 || minutes > 59)
                throw new ArgumentException("Minutes must be between 0 and 59");

            if (seconds < 0 || seconds > 59)
                throw new ArgumentException("Seconds must be between 0 and 59");

            if (milliseconds < 0 || milliseconds > 999)
                throw new ArgumentException("Milliseconds must be between 0 and 999");

            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
            _milliseconds = milliseconds;
        }

        // Methods
        public override string ToString()
        {
            return "";
        }

        public int ToMilliseconds()
        {
            return 0;
        }

        public int ToSeconds()
        {
            return 0;
        }

        public int ToMinutes()
        {
            return 0;
        }

        public bool IsOtherDay(Time other)
        {
            return false;
        }

        public Time Add(Time other)
        {
            return null;
        }
    }
}
