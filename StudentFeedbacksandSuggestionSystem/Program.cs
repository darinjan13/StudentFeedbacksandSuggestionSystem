using System;
using System.Windows.Forms;

namespace StudentFeedbacksandSuggestionSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            FormManager formManager = new FormManager(mainForm); // Create an instance of FormManager

            // Start the application using FormManager
            formManager.Start();

            Application.Run();
        }
    }
}
