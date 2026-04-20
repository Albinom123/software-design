namespace lab4
{
	internal static class Program
	{
		/// <summary>
		///  Application startup helper (renamed from Main to avoid duplicate entry-point CS0017).
		/// </summary>
		[STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // This line is what makes the Form appear!
        }
        static void StartApplication()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}