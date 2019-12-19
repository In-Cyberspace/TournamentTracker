using Gtk;
using TrackerDesktopUI;

public partial class MainWindow : Gtk.Window
{
    // Containers
    readonly Fixed @fixed = new Fixed();

    readonly HBox hBox = new HBox(false, 0);

    // Widgets
    readonly Button btnDashboardLoadTournament = new Button("Load Tournament");
    readonly Button btnDashboardCreateTournament =
        new Button("Create Tournament");
    
    readonly ComboBoxEntry cmbDashboardLoadExisting = new ComboBoxEntry(
        new string[] { "Tournament 1", "Tournament 2", "etc..." });

    readonly Label lblDashboardMain = new Label("Tournament Dashboard");
    readonly Label lblDashboardLoadExisting =
        new Label("Load Existing Tournament");
    
    public MainWindow() :
            base(Gtk.WindowType.Toplevel)
    {
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

        ShowAll();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
