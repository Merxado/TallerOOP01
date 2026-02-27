namespace _01Bakends
{
    public class Date
    {
        // Fields 
        private int _day;
        private int _month;
        private int _year;

        // Properties 
        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Constructor
        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        // Methods
        public override string ToString()
        {
            return $"{_day}/{_month}/{_year}";
        }

        // Validations 
        private void ValidateYear(int year)
        {
            if (year <= 0)
                throw new ArgumentException("El año debe ser mayor que 0");
        }

        private void ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("El mes debe estar entre 1 y 12");
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private void ValidateDay(int day, int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
                daysInMonth[1] = 29;

            if (day < 1 || day > daysInMonth[month - 1])
                throw new ArgumentException("Día no válido para el mes y año indicados");
        }
    }
}