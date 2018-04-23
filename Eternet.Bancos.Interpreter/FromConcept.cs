using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Eternet.Bancos.Interpreter.DataFinder
{
    public class FromConcept
    {
        public static List<string> ExtractNumbersFromConcept(string str)
        {
            return Regex.Split(str, @"\D+").Where(s => !string.IsNullOrEmpty(s)).ToList();

            //foreach (string number in numbers)
            //{
            //    if (!string.IsNullOrEmpty(number))
            //    {
            //        result.Add(long.Parse(number));
            //    }
            //}

        }

        public static List<string> ExtractStringsFromConcept(string str)
        {
            return Regex.Split(str, @"\d+").Where(s => !string.IsNullOrEmpty(s)).ToList();

        }

        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }

        public static bool ValidaDni(string dni)
        {
            if (dni == null)
            {
                return false;
            }
            else
            {
                return dni.Length == 8;
            }
        }
    }
}
