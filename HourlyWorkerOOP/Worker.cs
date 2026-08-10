namespace AbstractWorker
{
    internal abstract class Worker
    {
        private readonly string name;
        private readonly string surname;

        protected Worker(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public override string ToString()
        {
            return $"{name} {surname}";
        }

        public abstract double CalcPay();
    }
}
