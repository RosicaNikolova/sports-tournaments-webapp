using ClassLibraryTournaments.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public class TournamentStatusRepository : ITournamentStatusRepository
    {
        public void ChangeTournamentStatus(int id, Status status)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update tournament set status=@status where idTournament=@idTournament;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idTournament", id);
                    cmd.Parameters.AddWithValue("status", status.ToString());
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
            try
            {
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
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }
    }
}
