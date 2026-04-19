namespace jsxbin_to_jsx_GUI
{
    class Program
    {
        [STAThread]
        static void Main(String[] args)
        {
            if (args.Length > 0 && (args[0] == "--help" || args[0] == "-h" || args[0] == "/?"))
            {
                PrintHelp();
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        static void PrintHelp()
        {
            Console.WriteLine("Usage: jsxbin_to_jsx_gui.exe [OPTIONS]");
            Console.WriteLine("Options:");
            Console.WriteLine("  --help, -h, /?  显示帮助信息");
            Console.WriteLine("Examples:");
            Console.WriteLine("  jsxbin_to_jsx_gui.exe        启动GUI");
            Console.WriteLine("  jsxbin_to_jsx_gui.exe --help 显示帮助");
        }
    }
}