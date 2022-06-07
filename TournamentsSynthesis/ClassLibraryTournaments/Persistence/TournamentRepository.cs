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
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, minPlayer, maxPlayers, status, LastRegisterDate, location from tournament where status=@status;";
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
                        tournament.RegistrationCloses = (DateTime)dateReader.GetMySqlDateTime("LastRegisterDate");
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
                    string sql = "select idTournament, sportType, tournamentSystem, startDate, endDate, LastRegisterDate, location, status, description from tournament where idTournament=@idTournament;";
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
                        tournament.Description = dateReader.GetString("description");
                        tournament.Status = (Status)Enum.Parse(typeof(Status), dateReader.GetString("status"));
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

        public Dictionary<User, int> GetRankingForTournament(int id)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    Dictionary<User, int> ranking = new Dictionary<User, int>();
                    string sql = "SELECT g.winnerId, COUNT(g.winnerId) as points, g.tournamentId, u.firstName, u.lastName from games as g JOIN usertournaments as u on g.winnerId = u.idUser WHERE g.tournamentId =@tournamentId GROUP BY g.winnerId ORDER by points DESC;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("tournamentId", id);
                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        User user = new User();
                        user.Id = dateReader.GetInt32("winnerId");
                        user.FirstName = dateReader.GetString("firstName");
                        user.LastName = dateReader.GetString("lastName");
                        int points = dateReader.GetInt32("points");
                        ranking.Add(user, points);
                    }
                    return ranking;
                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public Dictionary<int, User> GetNamesOfPlayersForTournament(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    Dictionary<int, User> players = new Dictionary<int, User>();
                    string sql = "SELECT u.firstName, u.lastName, u.idUser from tournamentplayer as p join usertournaments as u on p.userId = u.idUser WHERE p.tournamentId = @tournamentId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("tournamentId", id);
                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        User user = new User();
                        user.Id = dateReader.GetInt32("idUser");
                        user.FirstName = dateReader.GetString("firstName");
                        user.LastName = dateReader.GetString("lastName");
                        players.Add(user.Id, user);
                    }
                    return players;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public List<Tournament> GetTournamentsForPlayer(int userId)
        {
            try
            {
                List<Tournament> tournaments = new List<Tournament>();
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select t.idTournament, t.sportType, t.tournamentSystem, t.startDate, t.endDate, t.LastRegisterDate, t.location, t.status, t.description from tournament as t join tournamentplayer as p on t.idTournament = p.tournamentId where p.userId=@userId;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("userId", userId);
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
                        tournament.Description = dateReader.GetString("description");
                        tournament.Status = (Status)Enum.Parse(typeof(Status), dateReader.GetString("status"));
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


        public Dictionary<int, User> GetNamesOfOponents(int userId)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    Dictionary<int, User> players = new Dictionary<int, User>();
                    string sql = "SELECT firstName, lastName, idUser from usertournaments where idUser in(select player1Id from games where player1Id=@playerId or player2Id =@playerId group by player1Id) or idUser in(select player2Id from games where player1Id=@playerId or player2Id=@playerId group by player2Id);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("playerId", userId);
                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        User user = new User();
                        user.Id = dateReader.GetInt32("idUser");
                        user.FirstName = dateReader.GetString("firstName");
                        user.LastName = dateReader.GetString("lastName");
                        players.Add(user.Id, user);
                    }
                    return players;
                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public void DeleteRegisteredPlayersForTournament(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from tournamentplayer where tournamentId=@tournamentId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public List<Tournament> GetAllOpenOrCancelledTournaments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, minPlayer, maxPlayers, status, location from tournament where status=@status or status=@statusCancelled;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("status", Status.open.ToString());
                    cmd.Parameters.AddWithValue("statusCancelled", Status.cancelled.ToString());

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
    }
}
