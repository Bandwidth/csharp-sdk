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

        // Bandwidth provided voice application id.
        public static readonly string VoiceApplicationId = System.Environment.GetEnvironmentVariable("BW_VOICE_APPLICATION_ID");

        // Bandwidth provided account id.
        public static readonly string AccountId = System.Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

        // The phone number to send the message from.
        public static readonly string From = System.Environment.GetEnvironmentVariable("BW_NUMBER");
        
        // The phone number to send the message to.
        public static readonly string To = System.Environment.GetEnvironmentVariable("USER_NUMBER");

        // The publicly available base callback URL.
        public static readonly string BaseCallbackUrl = System.Environment.GetEnvironmentVariable("BASE_CALLBACK_URL");

        // Unique run id used to generate unique test ids.
        public static readonly string RunId = System.Environment.GetEnvironmentVariable("GITHUB_RUN_ID") ?? "local-run-id";

        // Milliseconds of time to pause between voice requests.
        public static readonly int Timeout = 500;
    }
}
