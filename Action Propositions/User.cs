using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Propositions
{
    public abstract class Account {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
    public class PersonAccount: Account
    {
        public void Clear (){ Id = -1; Username = ""; Password = ""; IsAdmin = false; }
    }
    public class AccountManager
    {
        private PersonAccount _currentUser;
        private readonly string _connectionString;

        public AccountManager(string connectionString)
        {
            _currentUser = new PersonAccount();
            _connectionString = connectionString;
        }

        public bool Register(string username, string password)
        {

            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Username FROM Accounts WHERE Username = @Username";
                selectCmd.Parameters.AddWithValue("@Username", username);

                using (var reader = selectCmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        var insertCmd = connection.CreateCommand();
                        insertCmd.CommandText = "INSERT INTO Accounts (Username, Password, IsAdmin) VALUES (@Username, @Password, @IsAdmin)";
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.Parameters.AddWithValue("@IsAdmin", false);
                        insertCmd.ExecuteNonQuery();
                        _currentUser.Username = username;
                        _currentUser.Password = password;
                        _currentUser.IsAdmin = false;
                        _currentUser.Id = -1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

               
            }
        }

        public bool Login(string username, string password)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Username, Password, IsAdmin FROM Accounts WHERE Username = @Username";
                selectCmd.Parameters.AddWithValue("@Username", username);

                using (var reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read() && reader.GetString(1) == password)
                    {
                        _currentUser.Clear();
                        // Пользователь авторизован
                        var account = new PersonAccount
                        {
                            Username = reader.GetString(0),
                            Password = reader.GetString(1),
                            IsAdmin = reader.GetBoolean(2)
                        };
                        _currentUser = account; // сохраняем данные пользователя в поле _currentUser
                        return true;
                    }
                    else
                    {
                        // Неверное имя пользователя или пароль
                        return false;
                    }
                }
            }
        }
        public void Delete(string username)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "Delete FROM Accounts WHERE Username = @Username";
                deleteCmd.Parameters.AddWithValue("@Username", username);
                deleteCmd.ExecuteNonQuery();
            }
        }
        public string GetCurrentUsername()
        {
            if (_currentUser != null)
            {
                return _currentUser.Username;
            }
            else
            {
                return null;
            }
        }

        public bool IsCurrentUserAdmin()
        {
            if (_currentUser != null)
            {
                return _currentUser.IsAdmin;
            }
            else
            {
                return false;
            }
        }


        public bool CreateAdminUser(string username, string password)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Username FROM Accounts WHERE Username = @Username";
                selectCmd.Parameters.AddWithValue("@Username", username);

                using (var reader = selectCmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        var insertCmd = connection.CreateCommand();
                        insertCmd.CommandText = "INSERT INTO Accounts (Username, Password, IsAdmin) VALUES (@Username, @Password, @IsAdmin)";
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.Parameters.AddWithValue("@IsAdmin", true);
                        insertCmd.ExecuteNonQuery();
                        _currentUser.Username = username;
                        _currentUser.Password = password;
                        _currentUser.IsAdmin = false;
                        _currentUser.Id = -1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
        }
    }

}
