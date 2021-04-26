namespace Bandwidth.StandardTests
{
    public static class TestConstants
    {
        // Bandwidth provided username.
        public static readonly string Username = System.Environment.GetEnvironmentVariable("BW_USERNAME");
        
        // Bandwidth provided password.
        public static readonly string Password = System.Environment.GetEnvironmentVariable("BW_PASSWORD");

        // Bandwidth provided messaging application id.
        public static readonly string MessagingApplicationId = System.Environment.GetEnvironmentVariable("BW_MESSAGING_APPLICATION_ID");

        // Bandwidth provided account id.
        public static readonly string AccountId = System.Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

        // The phone number to send the message from.
        public static readonly string From = System.Environment.GetEnvironmentVariable("BW_NUMBER");
        
        // The phone number to send the message to.
        public static readonly string To = System.Environment.GetEnvironmentVariable("USER_NUMBER");
    }
}
