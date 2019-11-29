using System;
using System.Reflection;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Gdk.Color winBgColour, lblFgColour;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        // Build();
        SetDefaultSize(350, 400);
        SetPosition(WindowPosition.Center);

        winBgColour = new Gdk.Color(36, 36, 36);
    //    lblFgColour = new Gdk.Color(255, 255, 255);

        Title = "Dashboard";
        
    //    lblDashboardMain.Text = "Tournament Dashboard";
    //    lblLoadTournament.Text = "Load Existing Tournament";
    //    btnLoadTournament.Label = "Load Tournament";
    //    btnCreateTournament.Label = "Create Tournament";

        ModifyBg(StateType.Normal, winBgColour);
        //    foreach (Widget widget in DashboardVbox1)
        //    {
        //        if (widget is Label)
        //        {
        //            widget.ModifyFg(StateType.Normal, lblFgColour);
        //        }
        //    }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
