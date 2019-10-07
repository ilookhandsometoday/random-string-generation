using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStringGeneration
{
    public class RandomLatinString : RandomString
    {
        public RandomLatinString() : base() { }

        public override string Generate(int length)
        {
            if (length == 0)
            {
                return string.Empty;
            }

            if (length < 0)
            {
                Exception e = new FormatException("Длина строки не может быть меньше нуля");
                throw (e);
            }
            char[] protoString = new char[length];
            for (int i = 0; i < length; i++)
                protoString[i] = alphabet[rNG.Next(0, alphabet.Length - 1)];
            return new string(protoString);
        }
    }
}
