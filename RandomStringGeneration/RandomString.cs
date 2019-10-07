using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStringGeneration
{
    public abstract class RandomString
    {
        protected Random rNG;
        protected string alphabet;
        abstract public string Generate(int length);

        public RandomString()
        {
            rNG = new Random();
            this.alphabet = "abcdefghijklmopqrsuvwxyz";
        }
    }
}
