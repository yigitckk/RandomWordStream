

    public class PrimeStream : IntStream
    {
        public PrimeStream(int maxValue) : base(0)
        {
            CurrentNumber = 1; 
        }

        public override int next()
        {
            while (true)
            {
                CurrentNumber++;
                if (IsPrime(CurrentNumber))
                    return CurrentNumber;
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }


        public override bool eos() { 
        
            return false;
        }


        public override void reset()
        {
            base.reset();
        }


}


