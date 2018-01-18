using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Web2DbApp.Services
{
    /// <summary>
    /// Validtor used to validate.
    /// </summary>
    public class Validtor
    {
        /// <summary>
        /// Validates a person.
        /// </summary>
        /// <param name="first">Person firstname.</param>
        /// <param name="last">Person lastname.</param>
        /// <param name="title">Person title.</param>
        /// <returns>Returns true or false.</returns>
        public bool ValidPerson(string first,string last,string title)
        {
            if(Regex.IsMatch(first, "^[a-zA-Z]") & Regex.IsMatch(last, "^[a-zA-Z]") & Regex.IsMatch(title, "^[a-zA-Z]")&Char.IsUpper(first.First()))
            {
                return true;
            }
            return false;
        }
    }
}
