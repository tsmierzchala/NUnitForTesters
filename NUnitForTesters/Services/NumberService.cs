using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitForTesters.Services
{
    public class NumberService
    {
        // Funkcja nie powinna dla żadnej wartości inta zwrócić napisu
        // "That should not happen at all"
        // napisz testy automatyczne w klasie NumberServiceTests które znajdą błąd
        public string IsItTheAnswerToUltimateQuestionOfLife(int number)
        {
            return number switch
            {
                int n when n < 0 || n > 100 => "Definetely no!",
                int n when (n > 0 && n < 10) || (n > 90) => "Rather no",
                int n when n >= 10 && n < 20 || (n > 80) => "Well no...",
                int n when n >= 20 && n < 30 || (n > 60) => "No but close...",
                int n when n >= 30 && n < 40 || (n > 50) => "No but close...",
                int n when (n >= 40 && n < 42) || (n > 42 && n <= 50) => "Almost there!",
                42 => "Exactly!",
                _ => "That should not happen at all",
            };
        }

        public bool IsPrime(int i)
        {
            if (i == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}
