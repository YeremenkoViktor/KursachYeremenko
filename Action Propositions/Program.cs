namespace Action_Propositions
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static AccountManager accountManager = new AccountManager("Data Source=AccountsDatabase.db");
        public static Form1 Form = new Form1();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(Form);
        }
    }
}