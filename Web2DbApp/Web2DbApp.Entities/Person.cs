using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web2DbApp.Entities
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public class Person
    {
        private string firstname;
        private string lastname;
        private string titleOfCountesey;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="firstname"><see cref="Person"/> firstname.</param>
        /// <param name="lastname"><see cref="Person"/> lastname.</param>
        /// <param name="titleOfCountesey"><see cref="Person"/> titleOfCountesey.</param>
        public Person(string firstname, string lastname, string titleOfCountesey)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.titleOfCountesey = titleOfCountesey;
        }

        /// <summary>
        /// Gets <see cref="Person"/> Firstname.
        /// </summary>
        public string Firstname
        {
            get
            {
                return firstname;
            }
        }

        /// <summary>
        /// Gets <see cref="Person"/> Lastname.
        /// </summary>
        public string Lastname
        {
            get
            {
                return lastname;
            }
        }

        /// <summary>
        /// Gets <see cref="Person"/> TitleOfCountesey.
        /// </summary>
        public string TitleOfCountesey
        {
            get
            {
                return titleOfCountesey;
            }
        }

        /// <summary>
        /// String representing a <see cref="Person"/>.
        /// </summary>
        /// <returns>Returns string representing a <see cref="Person"/></returns>
        public override string ToString()
        {
            return $"{firstname} {lastname} {titleOfCountesey}";
        }
    }
}
