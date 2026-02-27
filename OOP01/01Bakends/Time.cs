namespace _01Bakends
{
    public class Time
    {
        // Fields
        private int _hours;
        private int _minutes;
        private int _seconds;
        private int _milliseconds;

        public int Hour
        {
            get => _hours;
        }

        public int Minute
        {
            get => _minutes;
        }

        public int Second
        {
            get => _seconds;
        }

        public int Millisecond
        {
            get => _milliseconds;
        }

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
        private void ValidHour(int hour)
        {
            if (hour < 0 || hour > 23)
                throw new ArgumentException($"The hour: {hour}, is not valid.");
        }

        private void ValidMinute(int minute)
        {
            if (minute < 0 || minute > 59)
                throw new ArgumentException($"The minute: {minute}, is not valid.");
        }

        private void ValidSecond(int second)
        {
            if (second < 0 || second > 59)
                throw new ArgumentException($"The second: {second}, is not valid.");
        }

        private void ValidMillisecond(int millisecond)
        {
            if (millisecond < 0 || millisecond > 999)
                throw new ArgumentException($"The millisecond: {millisecond}, is not valid.");
        }

        public Time(int hours, int minutes, int seconds, int milliseconds)
        {
            ValidHour(hours);
            ValidMinute(minutes);
            ValidSecond(seconds);
            ValidMillisecond(milliseconds);

            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
            _milliseconds = milliseconds;
        }

        // Methods
        public override string ToString()
        {
            int displayHour = _hours;
            string period = _hours >= 12 ? "PM" : "AM";

            if (_hours > 12)
                displayHour = _hours - 12;

            return $"{displayHour:D2}:{_minutes:D2}:{_seconds:D2}.{_milliseconds:D3} {period}";
        }

        public int ToMilliseconds()
        {
            return (_hours * 60 * 60 * 1000)
                 + (_minutes * 60 * 1000)
                 + (_seconds * 1000)
                 + _milliseconds;
        }

        public int ToSeconds()
        {
            return (_hours * 60 * 60)
                 + (_minutes * 60)
                 + _seconds;
        }

        public int ToMinutes()
        {
            return (_hours * 60)
                 + _minutes;
        }

        public bool IsOtherDay(Time other)
        {
            int totalMilliseconds = this.ToMilliseconds() + other.ToMilliseconds();
            return totalMilliseconds >= 24 * 60 * 60 * 1000;
        }

        public Time Add(Time other)
        {
            int ms = _milliseconds + other._milliseconds;
            int s = _seconds + other._seconds;
            int m = _minutes + other._minutes;
            int h = _hours + other._hours;

            if (ms > 999)
            {
                s += ms / 1000;
                ms = ms % 1000;
            }

            if (s > 59)
            {
                m += s / 60;
                s = s % 60;
            }

            if (m > 59)
            {
                h += m / 60;
                m = m % 60;
            }

            if (h > 23)
            {
                h = h % 24;
            }

            return new Time(h, m, s, ms);
        }
    }
}
