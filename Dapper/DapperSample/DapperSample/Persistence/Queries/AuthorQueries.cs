namespace DapperSample.Persistence.Queries
{
    public static class AuthorQueries
    {
        public static string INSERT = @"INSERT INTO Author (Id, Name, Email) VALUES (@Id, @Name, @Email)";

        public static string SELECT = @"SELECT Id, Name, Email FROM Author";
    }
}
