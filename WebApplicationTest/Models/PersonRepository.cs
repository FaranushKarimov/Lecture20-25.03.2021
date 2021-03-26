using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace WebApplicationTest.Models
{
    public class PersonRepository : Reposiroty<Person>
    {
        public PersonRepository() : base()
        {

        }


        public int? Create(Person person)
        {
            try
            {
                using (IDbConnection context = new SqlConnection(ConnectionString))
                {
                    string command = $"INSERT INTO Person(Lastname, Firstname, MiddleName) VALUES('{person.LastName}', '{person.FirstName}', '{person.MiddleName}')";
                    int Id = context.Query<int>(command + "SELECT CAST(SCOPE_IDENTITY() as int)").FirstOrDefault();
                    return Id;
                }

            }
            catch (Exception)
            {
                return null; 
            }

        }
        public int? Update(Person person, int Id)
        {
            try
            {
                using (IDbConnection context = new SqlConnection(ConnectionString))
                {
                    string command = $"UPDATE PERSON SET Lastname = '{person.LastName}',Firstname = '{person.FirstName}',MiddleName = '{person.MiddleName}' WHERE Id = {Id}";
                    return context.Query<int>(command).FirstOrDefault(); 
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
        public int? Delete(int Id)
        {
            try
            {
                using (IDbConnection context = new SqlConnection(ConnectionString))
                {
                    string command = $"DELETE FROM Person WHERE Id = {Id}";
                    return context.Query<int>(command).FirstOrDefault();
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
