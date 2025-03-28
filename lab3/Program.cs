using Task_3;

namespace lab3
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
			Application.Run(new Form1()); // mao ni ang form 1
			//Application.Run(new Task_2());
            //Application.Run(new Task_3());
        }
	}
}