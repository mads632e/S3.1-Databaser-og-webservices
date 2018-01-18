using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web2DbApp.Entities;

namespace Web2DbApp.Services
{
    /// <summary>
    /// JsonPerson used to hold a list of <see cref="Person"/>.
    /// </summary>
    public class Results
    {
        /// <summary>
        /// Holds list of <see cref="Person"/>.
        /// </summary>
        public List<Person> results { get; set; }
    }
}
