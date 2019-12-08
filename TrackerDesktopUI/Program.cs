using Gtk;

namespace TrackerDesktopUI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            TournamentViewer TVwin = new TournamentViewer();
            CreateTournament CTwin = new CreateTournament();
            // win.ShowAll();
            CTwin.ShowAll();
            // TVwin.ShowAll();
            Application.Run();
        }
    }
}
