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
                    string sql = "select idTournament, sportType, tournamentSystem, description, startDate, endDate, minPlayer, maxPlayers, location from tournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        tournament.Id = dateReader.GetInt32("idTournament");
                        tournament.SportType = dateReader.GetString("sportType");
                        string tournamentSystem = dateReader.GetString("tournamentSystem");
                        if(tournamentSystem == "Round Robin")
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
