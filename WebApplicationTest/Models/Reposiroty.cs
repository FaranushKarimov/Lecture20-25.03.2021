using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationTest.Models
{
    public abstract class Reposiroty<Model>
    {
        public string ConnectionString { get; set; }
        public Reposiroty()
        {
            ConnectionString = "Data Source=LORD;Initial Catalog=ASP.NET;Integrated Security=True;";
        }
        public List<Model> Select()
        {
            try
            {
                using ( IDbConnection context = new SqlConnection(ConnectionString))
                {
                    return context.Query<Model>($"SELECT * FROM {typeof(Model).Name}").ToList(); 
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; 
            }
        }
    }
}
