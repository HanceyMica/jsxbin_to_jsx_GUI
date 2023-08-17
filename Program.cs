namespace jsxbin_to_jsx_GUI
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration..
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        static void PrintHelp()
        {
            Console.WriteLine("Usage: [-v] jsxbin_to_jsx JSXBIN JSX");
            Console.WriteLine("Example: jsxbin_to_jsx -v encoded.jsxbin decoded.jsx");
            Console.WriteLine("Flags:");
            Console.WriteLine("-v print tree structure to stdout");
        }
    }
}