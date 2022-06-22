using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Heroesvillanos.SqlManager
{
    public class SqlRepository: IRepository
    {
        private SqlConnectionStringBuilder sqlConnectionStringBuilder
        {
            get
            {
                return new SqlConnectionStringBuilder()
                {
                    DataSource = @"EUNICE\SQLExpress",
                    IntegratedSecurity = true,
                    InitialCatalog = "Heroesvillanos"
                };
            }
        }

        
        public List<Heroevillano> GetAll()
        {
            List<Heroevillano> heroesvillanos = new List<Heroevillano>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                 
                connection.Open();
                String sql = "SELECT id, name, identity FROM Heroesvillanos2";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            heroesvillanos.Add(new Heroevillano()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                //Identity =  reader.GetString(2)
                            }) ;                            
                        }
                    }
                }
            }

            return heroesvillanos;
        }

        public List<Heroevillano> GetHeroevillanoByName(string name)
        {
            List<Heroevillano> heroesvillanos = new List<Heroevillano>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                connection.Open();

                String sql = "SELECT id, name, identity FROM Heroesvillanos2 where name like @title";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    SqlParameter titleParam = new SqlParameter("@title",  System.Data.SqlDbType.VarChar );
                    titleParam.Value =  "%" +  title + "%";
                    titleParam.Direction = System.Data.ParameterDirection.Input;
                    command.Parameters.Add(titleParam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            heroesvillanos.Add(new Heroevillano()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                //Identity =  reader.GetString(2)
                            });
                        }
                    }
                }
            }

            return heroesvillanos;
        }
    }
}