using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Gdk.Color winBgColour, lblColour;

    public MainWindow(string tvTitle, byte lblv1, byte lblv2, byte lblv3,
        byte Bgv1, byte Bgv2, byte Bgv3) : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Title = tvTitle;
        winBgColour = new Gdk.Color(Bgv1, Bgv2, Bgv3);
        lblColour = new Gdk.Color(lblv1, lblv2, lblv3);
        ModifyBg(StateType.Normal, winBgColour);
        lblTournamentViewerMain.ModifyFg(StateType.Normal, lblColour);
        lblTournamentViewerRound.ModifyFg(StateType.Normal, lblColour);
        lblTournamentName.ModifyFg(StateType.Normal, lblColour);
        lblTournamentName.Visible = false;
        eventbox5.ModifyBg(StateType.Normal, winBgColour);
        eventbox6.ModifyBg(StateType.Normal, winBgColour);
        // lblTournamentViewerMain.Colormap.AllocColor(ref lblColour, writeable:false,
        //    best_match:true);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
