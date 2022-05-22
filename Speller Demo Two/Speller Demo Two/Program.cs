    namespace Speller_Demo_Two
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  https://www.c-sharpcorner.com/UploadFile/1e050f/text-to-speech-converter-in-C-Sharp/
        /// Use these these words
        /// https://grammar.yourdictionary.com/spelling-and-word-lists/misspelled.html
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}