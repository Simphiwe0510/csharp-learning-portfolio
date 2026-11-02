namespace AbstractWorker
{
    internal class HourlyWorker : Worker
    {
        private readonly int hours;
        private readonly double rate;

        public HourlyWorker(string name, string surname, int hours, double rate)
            : base(name, surname)
        {
            if (hours < 0)
            {
                throw new ArgumentException("Hours cannot be negative.");
            }

            if (rate <= 0)
            {
                throw new ArgumentException("Rate must be greater than zero.");
            }

            this.hours = hours;
            this.rate = rate;
        }

        public override double CalcPay()
        {
            return hours * rate;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Hours: {hours} | Rate: {rate:F2} | Pay: {CalcPay():F2}";
        }
    }
}