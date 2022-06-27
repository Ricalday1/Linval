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

                String sql = "SELECT id, name, identity FROM Heroesvillanos2 where name like @name";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    SqlParameter nameParam = new SqlParameter("@name",  System.Data.SqlDbType.VarChar );
                    nameParam.Value =  "%" +  name + "%";
                    nameParam.Direction = System.Data.ParameterDirection.Input;
                    command.Parameters.Add(nameParam);
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

        public long Create(Heroevillano heroevillano)
        {

            
              
            try
            {


                using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
                {

                    connection.Open();
                    var SqlCreate = "Insert into heroesvillanos2 (id "
                            + ",name"
                            + ",identity"
                            + ", alignment"
                            + ", eyecolor"
                            + ", haircolor"
                            + ", gender"
                            + ", status "
                            + ", appearance "
                            + ", firstappearance "
                            + ", year "
                            + ", universe"
                            + ", tagline "
                            + ", vote_average"
                            + ", vote_count"
                            +" )"
                            + " Values ( "
                            + " @id "
                            + " , @name"
                            + " , @identity"
                            + " , @alignment "
                            + " , @eyecolor"
                            + " , @haircolor "
                            + " , @gender"
                            + " , @status"
                            + " , @appearance "
                            + " , @firstappearance "
                            + " , @year "
                            + " , @universe "
                            )";


                    SqlCommand sqlCommand = new SqlCommand(SqlCreate, connection);

                    sqlCommand.Parameters.Add( new SqlParameter("@id", heroevillano.Id));

                    sqlCommand.Parameters.Add(new SqlParameter("@name", heroevillano.Name));
                    sqlCommand.Parameters.Add(new SqlParameter("@identity", heroevillano.Identity));
                    sqlCommand.Parameters.Add(new SqlParameter("@alignment", heroevillano.Alignment));
                    sqlCommand.Parameters.Add(new SqlParameter("@eyecolor", heroevillano.EyeColor));
                    sqlCommand.Parameters.Add(new SqlParameter("@haircolor", heroevillano.HairColorPopularity));
                    sqlCommand.Parameters.Add(new SqlParameter("@gender", heroevillano.Gender));
                    sqlCommand.Parameters.Add(new SqlParameter("@status", heroevillano.Gender));
                    sqlCommand.Parameters.Add(new SqlParameter("@appearance", heroevillano.Appearance));
                    sqlCommand.Parameters.Add(new SqlParameter("@firstappearance", heroevillano.FirstAppearence));
                    sqlCommand.Parameters.Add(new SqlParameter("@year", heroevillano.Year));
                    sqlCommand.Parameters.Add(new SqlParameter("@universe", heroevillano.Universe));
                    
                     
                    sqlCommand.ExecuteNonQuery();
                    return heroevillano.Id;

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
