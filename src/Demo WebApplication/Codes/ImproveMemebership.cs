namespace Demo_WebApplication.Codes
{
    public class ImproveMemebership: IMembership
    {
        public void CreateAccount(string username, string password)
        {
            // Implement the logic to create an account
            // For example, you can save the account information to a database
            // This is just a placeholder implementation
            Console.WriteLine($"Account created for username: {username}");
        }
    }
}
