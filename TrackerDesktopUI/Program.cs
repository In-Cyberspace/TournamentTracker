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
            // win.Show();
            TVwin.Show();
            Application.Run();
        }
    }
}