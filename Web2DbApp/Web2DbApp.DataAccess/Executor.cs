using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web2DbApp.DataAccess
{
    /// <summary>
    /// Executor used for executing sqlQuerys.
    /// </summary>
    public class Executor
    {
        /// <summary>
        /// Database connectionString.
        /// </summary>
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Web2DbApp; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="procedureName">Stored procedure name.</param>
        /// <param name="dt">Datatable with parameters for the stored procedure.</param>
        public void Execute(string procedureName,DataTable dt)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@User_List", dt);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Gets and returns a <see cref="DataSet"/> from database.
        /// </summary>
        /// <param name="stringQuery">sqlQuery for <see cref="SqlDataAdapter"/>.</param>
        /// <returns>Returns <see cref="DataSet"/>.</returns>
        public DataSet Execute(string stringQuery)
        {
            DataSet dsPersons = new DataSet("Persons");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter daPerson = new SqlDataAdapter(stringQuery, connection))
                {
                    daPerson.Fill(dsPersons,"Person");
                }
            }
            return dsPersons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Executor"/> class.
        /// </summary>
        public Executor()
        {

        }
    }
}
