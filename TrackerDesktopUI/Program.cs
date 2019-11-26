using System;
using Gtk;

namespace TrackerDesktopUI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow("Tournament Viewer", 255, 255, 255,
                36, 36, 36);
            win.Show();
            Application.Run();
        }
    }
}