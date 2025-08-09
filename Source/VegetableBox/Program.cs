namespace VegetableBox
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmLogin());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1️⃣ Show Login Form first
            using (FrmLogin loginForm = new FrmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK) // Only proceed if login was successful
                {
                    // 2️⃣ Run the main MDI form
                    Application.Run(new MdiVegetableBox());
                }
                else
                {
                    // Login failed or cancelled
                    Application.Exit();
                }
            }
        }
    }
}