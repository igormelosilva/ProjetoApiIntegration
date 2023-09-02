using api.Global;
using api.Models;
using Npgsql;
namespace api.Database
{
    public class DbImovel
    {
        public bool Add(Imovel imovel)
        {
            bool result = false;

            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO imovel (city, district, dormitory, room, wc, parking, type) " +
                                      @"VALUES (@city, @district, @dormitory, @room, @wc, @parking, @type);";

                    cmd.Parameters.AddWithValue("@city", imovel.cidade);
                    cmd.Parameters.AddWithValue("@district", imovel.bairro);
                    cmd.Parameters.AddWithValue("@dormitory", imovel.dormitorio);
                    cmd.Parameters.AddWithValue("@room", imovel.sala);
                    cmd.Parameters.AddWithValue("@wc", imovel.banheiro);
                    cmd.Parameters.AddWithValue("@parking", imovel.vaga);
                    cmd.Parameters.AddWithValue("@type", imovel.tipo);



                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                    }
                    result = true;
                }

            }
            catch (Exception ex)
            { }
            return result;
        }


        public Imovel Get(int id)
        {

            Imovel imovel = new Imovel();
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM imovel " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            imovel.id = Convert.ToInt32(reader["id"]);
                            imovel.cidade = reader["city"].ToString();
                            imovel.bairro = reader["district"].ToString();
                            imovel.dormitorio = Convert.ToInt32(reader["dormitory"]);
                            imovel.sala = Convert.ToInt32(reader["room"]);
                            imovel.banheiro = Convert.ToInt32(reader["wc"]);
                            imovel.vaga = Convert.ToInt32(reader["parking"]);
                            imovel.tipo = Convert.ToInt32(reader["type"]);



                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return imovel;
        }

        public List<Imovel> GetAll()
        {
            List<Imovel> result = new List<Imovel>();
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * " +
                                      @"FROM imovel " +
                                      @"ORDER BY id;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Imovel imovel = new Imovel();

                            imovel.id = Convert.ToInt32(reader["id"]);
                            imovel.cidade = reader["city"].ToString();
                            imovel.bairro = reader["district"].ToString();
                            imovel.dormitorio = Convert.ToInt32(reader["dormitory"]);
                            imovel.sala = Convert.ToInt32(reader["room"]);
                            imovel.banheiro = Convert.ToInt32(reader["wc"]);
                            imovel.vaga = Convert.ToInt32(reader["parking"]);
                            imovel.tipo = Convert.ToInt32(reader["type"]);



                            result.Add(imovel);

                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public bool Delete(string id)
        {
            bool result = false;
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"DELETE FROM agendamentos " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }


        public bool Update(Imovel imovel)
        {
            bool result = false;
            DataBaseAcess dba = new DataBaseAcess();

            try
            {

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"UPDATE agendamentos " +
                                      @"SET city = @city, district = @district, dormitory = @dormitory, room = @room, wc = @wc, parking = @parking, type = @type " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@city", imovel.cidade);
                    cmd.Parameters.AddWithValue("@district", imovel.bairro);
                    cmd.Parameters.AddWithValue("@dormitory", imovel.dormitorio);
                    cmd.Parameters.AddWithValue("@room", imovel.sala);
                    cmd.Parameters.AddWithValue("@wc", imovel.banheiro);
                    cmd.Parameters.AddWithValue("@parking", imovel.vaga);
                    cmd.Parameters.AddWithValue("@type", imovel.tipo);


                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }

            }
            catch (Exception ex)
            { }

            return result;
        }

    }
}
