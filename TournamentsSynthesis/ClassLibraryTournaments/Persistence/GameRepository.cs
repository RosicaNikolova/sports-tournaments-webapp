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
                    string sql = "SELECT * FROM tournamentplayer as t JOIN usertournaments as u on t.userId = u.idUser where t.tournamentId = @tournamentId  ORDER BY u.lastName ASC;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", id);
                    conn.Open();
                    User player = null;

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    while (dateReader.Read())
                    {
                        player = new User();
                        player.Id = dateReader.GetInt32("userId");
                        player.FirstName = dateReader.GetString("firstName");
                        player.LastName = dateReader.GetString("lastName");
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
            foreach (Game game in games)
            {
                //try
                //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into games (tournamentId, player1Id, player2Id, result1, result2) values(@tournamentId, @player1Id, @player2Id, @result1, @result2);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tournamentId", tournamentId);
                    cmd.Parameters.AddWithValue("player1Id", game.Player1Id);
                    cmd.Parameters.AddWithValue("player2Id", game.Player2Id);
                    cmd.Parameters.AddWithValue("result1", 0);
                    cmd.Parameters.AddWithValue("result2", 0);
                    

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public List<Game> GetGamesForTournament(int id)
        {
            //try
            //{
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                List<Game> games = new List<Game>();
                string sql = "select * from games where tournamentId=@tournamentId;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tournamentId", id);
                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                while (dateReader.Read())
                {
                    Game game = new Game();
                    game.GameId = dateReader.GetInt32("gameId");
                    game.Player1Id = dateReader.GetInt32("player1Id");
                    game.Player2Id = dateReader.GetInt32("player2Id");
                    game.Result1 = dateReader.GetInt32("result1");
                    game.Result2 = dateReader.GetInt32("result2");
                    game.SportType = new BadmintonSportType();
                    games.Add(game);
                }
                return games;
            }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public void SaveResults(List<Game> games)
        {
            //try
            //{
                foreach (Game game in games)
                {
                    using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                    {
                        string sql = "update games set result1=@result1, result2=@result2, winnerId=@winnerId where gameId=@gameId;";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("gameId", game.GameId);
                        cmd.Parameters.AddWithValue("result1", game.Result1);
                        cmd.Parameters.AddWithValue("result2", game.Result2);
                        cmd.Parameters.AddWithValue("winnerId", game.WinnerId);
                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                }
                
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public bool CheckIfAllResultsAreEntered(int id)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                List<Game> games = new List<Game>();
                string sql = "select result1, result2 from games where tournamentId=@tournamentId and (result1=@result1 or result2=@result2);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tournamentId", id);
                cmd.Parameters.AddWithValue("result1", 0);
                cmd.Parameters.AddWithValue("result2", 0);

                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                while (dateReader.Read())
                {
                    return false;
                }
                return true;
                
            }
        }

        public Dictionary<int, List<Game>> GetGamesForPlayer(int userId)
        {
            //try
            //{
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                Dictionary<int, List<Game>> games = new Dictionary<int, List<Game>>();
                string sql = "SELECT * from games where player1Id=@userId or player2Id=@userId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("userId", userId);
                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                while (dateReader.Read())
                {
                    int tournamentId = dateReader.GetInt32("tournamentId");
                    Game game = new Game();
                    game.GameId = dateReader.GetInt32("gameId");
                    game.Player1Id = dateReader.GetInt32("player1Id");
                    game.Player2Id = dateReader.GetInt32("player2Id");
                    game.Result1 = dateReader.GetInt32("result1");
                    game.Result2 = dateReader.GetInt32("result2");
                    if (games.ContainsKey(tournamentId))
                    {
                        games[tournamentId].Add(game);
                    }
                    else
                    {
                        games.Add(tournamentId, new List<Game>());
                        games[tournamentId].Add(game);
                    }
                }
                return games;
            }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }
    }
}
