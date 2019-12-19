using Gtk;

namespace TrackerDesktopUI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

 
            // TournamentViewer TVwin = new TournamentViewer();
            // CreateTournament CTwin = new CreateTournament();
            // CreateTeam Teamwin = new CreateTeam();
            CreatePrize Prizewin = new CreatePrize();
            // CTwin.ShowAll();
            // TVwin.ShowAll();
            // Teamwin.ShowAll();

            // win.ShowAll();
            Application.Run();
        }
    }
}
