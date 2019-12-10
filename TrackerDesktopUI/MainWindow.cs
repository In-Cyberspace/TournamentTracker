using Gtk;
using TrackerDesktopUI;

public partial class MainWindow : Gtk.Window
{
    Gdk.Color winBgColour, lblFgColour;

    public MainWindow() :
            base(Gtk.WindowType.Toplevel)
    {
        // Containers
        Fixed @fixed = new Fixed();

        HBox hBox = new HBox(false, 0);

        // Widgets
        Button btnDashboardLoadTournament = new Button("Load Tournament");
        Button btnDashboardCreateTournament = new Button("Create Tournament");

        ComboBoxEntry cmbDashboardLoadExisting = new ComboBoxEntry(
            new string[] { "Tournament 1", "Tournament 2", "etc..." });

        Label lblDashboardMain = new Label("Tournament Dashboard");
        Label lblDashboardLoadExisting = new Label("Load Existing Tournament");

        // Populating the fixed container
        @fixed.Put(lblDashboardMain, 10, 10);

        @fixed.Put(lblDashboardLoadExisting, 10, 60);
        @fixed.Put(cmbDashboardLoadExisting, 10, 90);
        @fixed.Put(btnDashboardLoadTournament, 200, 90);

        @fixed.Put(btnDashboardCreateTournament, 110, 180);

        // Assigning widget colours and fonts
        GeneralMethods.LabelColoursFonts(@fixed,
            new byte[] { 255, 255, 255 }, new Label[] { lblDashboardMain });

        // Window setup
        ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
        SetDefaultSize(350, 300);
        SetPosition(WindowPosition.Center);
        Title = "Dashboard";

        hBox.Add(@fixed);

        Add(hBox);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
