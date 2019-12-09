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
            CreateTeam Teamwin = new CreateTeam();
            // win.ShowAll();
            // CTwin.ShowAll();
            // TVwin.ShowAll();
            Teamwin.ShowAll();
            Application.Run();
        }
    }
}
