namespace DapperSample.Persistence.Queries
{
    public static class BookQueries
    {
        static string INSERT = @"INSERT INTO Book (Id, AuthorId, Title, Description) 
                VALUES (@Id, @AuthorId, @Title, @Description)";

        static string SELECT = @"SELECT Id, AuthorId, Title, Description FROM Book";
    }
}
