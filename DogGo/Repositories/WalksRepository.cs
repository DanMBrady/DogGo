using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using DogGo.Models;
namespace DogGo.Repositories
{
    public class WalksRepository : IWalksRepository
    {
        private readonly IConfiguration _config;

        public WalksRepository(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public List<Walks> GetWalksByWalkerId(int walkerId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"select walks.id as Id,Date,Duration,WalkerId,Owner.Name as Name from walks 
                                        join dog on dogid = dog.id
                                        join owner on ownerId =owner.id 
                                        where WalkerId = @walkerId";
                    cmd.Parameters.AddWithValue("@walkerId", walkerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Walks> walks = new List<Walks>();
                        while (reader.Read())
                        {
                            Walks walk = new Walks
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkerId= reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                Owner = new Owner
                                {
                                    Name=reader.GetString(reader.GetOrdinal("Name"))
                                }
                            };
                            walks.Add(walk);
                        }
                        return walks;
                    }
                }
            }
        }

    }
}
