namespace GameStoreWebApi.Models
{
    public class User
    {
        // This should have properties like Id, Username, PasswordHash, and PasswordSalt
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public byte[] UserPassword { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;

        // This should have a constructor that takes a username and password
        public User(string username, byte[] userPassword)
        {
            Username = username;
            UserPassword = userPassword;
        }

        // This should have a constructor that takes a username, password hash, and password salt
        public User(string username, byte[] passwordHash, byte[] passwordSalt)
        {
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        // This should have a constructor that takes an id, username, password hash, and password salt
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        // This should have a constructor that takes an id, username, and user password
        public User(int id, string username, byte[] userPassword)
        {
            Id = id;
            Username = username;
            UserPassword = userPassword;
        }

        // This should have a constructor that takes an id, username, password hash, password salt, and user password
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt, byte[] userPassword)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            UserPassword = userPassword;
        }

        // This should have a constructor that takes a username, password hash, password salt, and user password
        public User(string username, byte[] passwordHash, byte[] passwordSalt, byte[] userPassword)
        {
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            UserPassword = userPassword;
        }

        // This should have a constructor that takes an id, username, password hash, password salt, and user password
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt, byte[] userPassword, byte[] userPasswordHash, byte[] userPasswordSalt)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            UserPassword = userPassword;
        }

        // This should have a constructor that takes a username, password hash, password salt, and user password
        public User(string username, byte[] passwordHash, byte[] passwordSalt, byte[] userPassword, byte[] userPasswordHash, byte[] userPasswordSalt)
        {
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            UserPassword = userPassword;
        }

        // This should have a constructor that takes an id, username, password hash, password salt, and user password
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt, byte[] userPassword, byte[] userPasswordHash, byte[] userPasswordSalt, byte[] userPasswordHash2, byte[] userPasswordSalt2)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            UserPassword = userPassword;
        }

        




    }
}
