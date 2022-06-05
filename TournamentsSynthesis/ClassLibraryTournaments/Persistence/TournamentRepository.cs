using ClassLibraryTournaments.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public class TournamentRepository : ITournamentRepository
    {     
        public List<Tournament> GetAllTournaments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, LastRegisterDate, minPlayer, maxPlayers, status, location from tournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        tournament.Id = dateReader.GetInt32("idTournament");
                        string sport = dateReader.GetString("sportType");
                        if(sport == "Badminton")
                        {
                            tournament.SportType = new BadmintonSportType();
                        }
                        string tournamentSystem = dateReader.GetString("tournamentSystem");
                        if(tournamentSystem == "Round-Robin")
                        {
                            tournament.TournamentSystem = new RoundRobin();
                        }
                        else
                        {
                            tournament.TournamentSystem = new DoubleRoundRobin();
                        }
                        tournament.Description = dateReader.GetString("description");
                        tournament.StartDate = (DateTime)dateReader.GetMySqlDateTime("startDate");
                        tournament.EndDate = (DateTime)dateReader.GetMySqlDateTime("endDate");
                        tournament.RegistrationCloses = (DateTime)dateReader.GetMySqlDateTime("LastRegisterDate");
                        tournament.MinPlayers = dateReader.GetInt32("minPlayer");
                        tournament.MaxPlayers = dateReader.GetInt32("maxPlayers");
                        tournament.Location = dateReader.GetString("location");
                        tournament.Status = (Status)Enum.Parse(typeof(Status),dateReader.GetString("status"));
                        tournaments.Add(tournament);
                    }
                    return tournaments;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void SaveTournament(Tournament tournament)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "insert into tournament (sportType, tournamentSystem, description, startDate, endDate, LastRegisterDate, minPlayer, maxPlayers, location, status) values (@sportType,@tournamentSystem,@description,@startDate,@endDate, @LastRegisterDate, @minPlayer,@maxPlayers,@location, @status)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("sportType", tournament.SportType);
                    cmd.Parameters.AddWithValue("tournamentSystem", tournament.TournamentSystem.ToString());
                    cmd.Parameters.AddWithValue("description", tournament.Description);
                    cmd.Parameters.AddWithValue("startDate", tournament.StartDate);
                    cmd.Parameters.AddWithValue("endDate", tournament.EndDate);
                    cmd.Parameters.AddWithValue("minPlayer", tournament.MinPlayers);
                    cmd.Parameters.AddWithValue("maxPlayers", tournament.MaxPlayers);
                    cmd.Parameters.AddWithValue("location", tournament.Location);
                    cmd.Parameters.AddWithValue("LastRegisterDate", tournament.RegistrationCloses);
                    cmd.Parameters.AddWithValue("status", Status.open.ToString());


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void UpdateTournament(Tournament tournament)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update tournament set sportType=@sportType, tournamentSystem=@tournamentSystem, description=@description, startDate=@startDate, endDate=@endDate, LastRegisterDate=@LastRegisterDate, minPlayer=@minPlayer, maxPlayers=@maxPlayers, location=@location where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", tournament.Id);
                    cmd.Parameters.AddWithValue("sportType", tournament.SportType.ToString());
                    cmd.Parameters.AddWithValue("tournamentSystem", tournament.TournamentSystem.ToString());
                    cmd.Parameters.AddWithValue("description", tournament.Description);
                    cmd.Parameters.AddWithValue("startDate", tournament.StartDate);
                    cmd.Parameters.AddWithValue("endDate", tournament.EndDate);
                    cmd.Parameters.AddWithValue("minPlayer", tournament.MinPlayers);
                    cmd.Parameters.AddWithValue("maxPlayers", tournament.MaxPlayers);
                    cmd.Parameters.AddWithValue("location", tournament.Location);
                    cmd.Parameters.AddWithValue("LastRegisterDate", tournament.RegistrationCloses);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void DeleteTournament(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from tournament where idTournament=@idTournament";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public List<Tournament> GetAllPendingTournaments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, minPlayer, maxPlayers, status, location from tournament where status=@status;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("status", Status.pending.ToString());

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        tournament.Id = dateReader.GetInt32("idTournament");
                        string sport = dateReader.GetString("sportType");
                        if (sport == "Badminton")
                        {
                            tournament.SportType = new BadmintonSportType();
                        }
                        string tournamentSystem = dateReader.GetString("tournamentSystem");
                        if (tournamentSystem == "Round-Robin")
                        {
                            tournament.TournamentSystem = new RoundRobin();
                        }
                        else
                        {
                            tournament.TournamentSystem = new DoubleRoundRobin();
                        }
                        tournament.Description = dateReader.GetString("description");
                        tournament.StartDate = (DateTime)dateReader.GetMySqlDateTime("startDate");
                        tournament.EndDate = (DateTime)dateReader.GetMySqlDateTime("endDate");
                        tournament.MinPlayers = dateReader.GetInt32("minPlayer");
                        tournament.MaxPlayers = dateReader.GetInt32("maxPlayers");
                        tournament.Location = dateReader.GetString("location");
                        tournaments.Add(tournament);
                    }
                    return tournaments;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }

        }

        public void SetStatusToOngoing(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update tournament set status=@status where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", id);
                    cmd.Parameters.AddWithValue("status", Status.ongoing.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public List<Tournament> GetAllOngoingTournaments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, minPlayer, maxPlayers, status, location from tournament where status=@status;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("status", Status.ongoing.ToString());

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        tournament.Id = dateReader.GetInt32("idTournament");
                        string sport = dateReader.GetString("sportType");
                        if (sport == "Badminton")
                        {
                            tournament.SportType = new BadmintonSportType();
                        }
                        string tournamentSystem = dateReader.GetString("tournamentSystem");
                        if (tournamentSystem == "Round-Robin")
                        {
                            tournament.TournamentSystem = new RoundRobin();
                        }
                        else
                        {
                            tournament.TournamentSystem = new DoubleRoundRobin();
                        }
                        tournament.Description = dateReader.GetString("description");
                        tournament.StartDate = (DateTime)dateReader.GetMySqlDateTime("startDate");
                        tournament.EndDate = (DateTime)dateReader.GetMySqlDateTime("endDate");
                        tournament.MinPlayers = dateReader.GetInt32("minPlayer");
                        tournament.MaxPlayers = dateReader.GetInt32("maxPlayers");
                        tournament.Location = dateReader.GetString("location");
                        tournaments.Add(tournament);
                    }
                    return tournaments;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void SetStatusToFinished(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update tournament set status=@status where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", id);
                    cmd.Parameters.AddWithValue("status", Status.finished.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }


        public int GetNumberOfRegisteredPlayersForTournament(int id)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "SELECT Count(*) as PlayersCount FROM tournamentplayer where tournamentId = @tournamentId Group By tournamentId;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", id);

                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    int registerPlayers = Convert.ToInt32(result);
                    return registerPlayers;
                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public void SetStatusToCancelled(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update tournament set status=@status where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", id);
                    cmd.Parameters.AddWithValue("status", Status.cancelled.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void SetStatusToPending(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update tournament set status=@status where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", id);
                    cmd.Parameters.AddWithValue("status", Status.pending.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public List<Tournament> GetAllOpenTournaments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, minPlayer, maxPlayers, status, location from tournament where status=@status;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("status", Status.open.ToString());

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        tournament.Id = dateReader.GetInt32("idTournament");
                        string sport = dateReader.GetString("sportType");
                        if (sport == "Badminton")
                        {
                            tournament.SportType = new BadmintonSportType();
                        }
                        string tournamentSystem = dateReader.GetString("tournamentSystem");
                        if (tournamentSystem == "Round-Robin")
                        {
                            tournament.TournamentSystem = new RoundRobin();
                        }
                        else
                        {
                            tournament.TournamentSystem = new DoubleRoundRobin();
                        }
                        tournament.Description = dateReader.GetString("description");
                        tournament.StartDate = (DateTime)dateReader.GetMySqlDateTime("startDate");
                        tournament.EndDate = (DateTime)dateReader.GetMySqlDateTime("endDate");
                        tournament.MinPlayers = dateReader.GetInt32("minPlayer");
                        tournament.MaxPlayers = dateReader.GetInt32("maxPlayers");
                        tournament.Location = dateReader.GetString("location");
                        tournaments.Add(tournament);
                    }
                    return tournaments;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public Dictionary<int, int> GetAvailablePlaces()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    Dictionary<int, int> availablePlaces = new Dictionary<int, int>();
                    string sql = "SELECT p.tournamentId, t.maxPlayers - COUNT(p.tournamentId) as AvailablePlaces from tournamentplayer as p join tournament as t on p.tournamentId = t.idTournament where t.status = @status GROUP BY p.tournamentId;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("status", Status.open.ToString());

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        int tournamentId = dateReader.GetInt32("tournamentId");
                        int placesAvailable = dateReader.GetInt32("AvailablePlaces");
                        availablePlaces.Add(tournamentId, placesAvailable);
                    }
                    return availablePlaces;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public Tournament GetTournamentById(int idTournament)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select idTournament, sportType, tournamentSystem, startDate, endDate, LastRegisterDate, location from tournament where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("idTournament", idTournament);
                    conn.Open();
                    Tournament tournament = null;

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        tournament = new Tournament();
                        tournament.Id = dateReader.GetInt32("idTournament");
                        string sport = dateReader.GetString("sportType");
                        if (sport == "Badminton")
                        {
                            tournament.SportType = new BadmintonSportType();
                        }
                        string tournamentSystem = dateReader.GetString("tournamentSystem");
                        if (tournamentSystem == "Round-Robin")
                        {
                            tournament.TournamentSystem = new RoundRobin();
                        }
                        else
                        {
                            tournament.TournamentSystem = new DoubleRoundRobin();
                        }
                        tournament.StartDate = (DateTime)dateReader.GetMySqlDateTime("startDate");
                        tournament.EndDate = (DateTime)dateReader.GetMySqlDateTime("endDate");
                        tournament.RegistrationCloses = (DateTime)dateReader.GetMySqlDateTime("LastRegisterDate");
                        tournament.Location = dateReader.GetString("location");
                    }
                    return tournament;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public bool PlayerNotRegistered(int idTournament, int idPlayer)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select userId from tournamentplayer where tournamentId=@tournamentId and userId=@userId;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("tournamentId", idTournament);
                    cmd.Parameters.AddWithValue("userId", idPlayer);
                    conn.Open();
                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        return false;
                    }
                    return true;
                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public void RegisterPlayer(int idTournament, int idPlayer)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "insert into tournamentplayer (tournamentId, userId) values (@tournamentId,@userId);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", idTournament);
                    cmd.Parameters.AddWithValue("userId", idPlayer);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        
    }
}
