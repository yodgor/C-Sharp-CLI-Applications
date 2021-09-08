namespace ch4_12
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date (int MONTH, int DAY, int YEAR)
        {
            Month = MONTH;
            Day = DAY;
            Year = YEAR;
        }

        public string DisplayDate()
        {
            return $"{Month}/{Day}/{Year}";
        }

    }
} 