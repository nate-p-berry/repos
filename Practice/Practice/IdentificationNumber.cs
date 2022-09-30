using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class IdentificationNumber
    {
        int _id;

        public IdentificationNumber(int id)
        {
            _id = id;
        }

        public static string GetId(IdentificationNumber id)
        {
            return id._id.ToString();
        }

        public static string CreateId(int position)
        {
            char[] newId = new char[5];
            char[] primes = string.Concat(PrimeNumbers.primeNumbers).ToCharArray();
            string primeString = primes.ToString();
            for (int i = 0; i < 5; i++)
            {
                newId[i] = primes[position + i];
            }
            return string.Concat(newId);
        }
    }
}
