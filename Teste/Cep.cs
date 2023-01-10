using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Teste
{
    public class Cep
    {
        public static bool Validar(string cep)
        {
            var regExp = new Regex(@"^\d{5}-\d{3}");
            return regExp.IsMatch(cep);
        }
    }
}
