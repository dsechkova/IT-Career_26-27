using System;
using System.Collections.Generic;
using System.Text;

namespace P04___RacionalNums
{
    internal class RacionalNumber
    {
        private int numerator;
        private int denumerator;

        private int nod;

        public RacionalNumber(int numerator, int denumerator)
        {
            this.nod = BigestDivider(numerator, denumerator);
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value / nod; }
        }
        public int Denumerator
        {
            get { return denumerator; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Denumerator can't be less than 0.");
                }
                denumerator = value / nod;
            }
        }

        private int BigestDivider(int numerator, int denumerator)
        {
            while (denumerator != numerator)
            {
                if (denumerator > numerator)
                {
                    denumerator %= numerator;
                    if (denumerator == 0)
                    {
                        return numerator;
                    }
                }
                else
                {
                    numerator %= denumerator;
                    if (numerator == 0)
                    {
                        return denumerator;
                    }
                }

            }
            return numerator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}";
        }
    }
}
