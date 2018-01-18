using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web2DbApp.Entities;

namespace Web2DbApp.DataAccess
{
    /// <summary>
    /// Repository used for getting data from database.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// initialize an instance of <see cref="Executor"/> class.
        /// </summary>
        private Executor executor = new Executor();

        /// <summary>
        /// Calls <see cref="Executor"/> for a <see cref="Person"/> class list.
        /// </summary>
        /// <returns>Returns <see cref="Person"/> list.</returns>
        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            DataSet dsPersons = executor.Execute("Select * From Person");
            DataTable dtPersons = dsPersons.Tables["Person"];
            foreach(DataRow drCurrent in dtPersons.Rows)
            {
                persons.Add(new Person(drCurrent["Firstname"].ToString(), drCurrent["Lastname"].ToString(), drCurrent["Title"].ToString()));
            }
            return persons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        public Repository()
        {

        }

        public void Save(List<Person> persons)
        {

        }
    }
}
