using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web2DbApp.Entities;
using Web2DbApp.Services;
using Web2DbApp.DataAccess;
using System.Data;

namespace Web2DbApp.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            MockDataProvider data = new MockDataProvider();
            List<Person> persons = (data.GetPeople(20));
            if (persons != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID", typeof(int)),
                new DataColumn("Firstname", typeof(string)),
                new DataColumn("Lastname", typeof(string)),
                new DataColumn("Title", typeof(string)) });
                int ID = 1;
                foreach (Person p in persons)
                {
                    dt.Rows.Add(ID, p.Firstname, p.Lastname, p.TitleOfCountesey);
                    ID++;
                }
                Executor executor = new Executor();
                executor.Execute("InsertPerson", dt);
            }
            Repository repository = new Repository();
            PrintAll(repository.GetAll());
            Console.ReadLine();
        }

        /// <summary>
        /// Prints a list of <see cref="Person"/> in console.
        /// </summary>
        /// <param name="persons"><see cref="Person"/> list to print in console.</param>
        static void PrintAll(List<Person> persons)
        {
            int count = 1;
            foreach (Person p in persons)
            {
                Console.WriteLine(count + ": " + p.ToString());
                count++;
            }
        }
    }
}
