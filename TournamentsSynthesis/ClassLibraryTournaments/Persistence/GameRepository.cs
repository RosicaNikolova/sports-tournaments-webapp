using ClassLibraryTournaments.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public class GameRepository : IGameRepository
    {
        public List<User> GetPlayersForTournament(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    List<User> players = new List<User>();
                    string sql = "select userId from tournamentplayer where tournamentId=@tournamentId;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", id);
                    conn.Open();
                    User player = null;

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        player = new User();
                        player.Id = dateReader.GetInt32("userId");
                        players.Add(player);
                    }
                    return players;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void SaveGames(List<Game> games, int tournamentId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into games (tournamentId, player1Id, player2Id) values(@tournamentId, @player1Id, @player2Id);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", tournamentId);

                    foreach (Game game in games)
                    {
                        cmd.Parameters.AddWithValue("player1Id", game.Player1Id);
                        cmd.Parameters.AddWithValue("player2Id", game.Player2Id);
                 
                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }
    }
}
