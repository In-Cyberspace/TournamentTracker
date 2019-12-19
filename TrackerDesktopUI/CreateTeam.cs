using Gtk;

namespace TrackerDesktopUI
{
    public partial class CreateTeam : Gtk.Window
    {
        // Containers
        readonly HBox hBox = new HBox(false, 0);

        readonly Fixed @fixed = new Fixed();

        // Widgets
        readonly Button btnTeamAddMember = new Button("Add Member");
        readonly Button btnTeamCreateNewMember = new Button("Create Member");
        readonly Button btnTeamCreateTeam = new Button("Create Team");
        readonly Button btnTeamDelete = new Button("Delete Selected");

        readonly ComboBoxEntry cmbTeamSelectMember = new ComboBoxEntry(
            new string[] { "Member 1", "Member 2", "etc..." });

        readonly Entry entryTeamName = new Entry();
        readonly Entry entryTeamFirst = new Entry();
        readonly Entry entryTeamLast = new Entry();
        readonly Entry entryTeamEmail = new Entry();
        readonly Entry entryTeamCellphone = new Entry();

        readonly Label lblTeamMain = new Label("Create Team");
        readonly Label lblTeamName = new Label("Team Name");
        readonly Label lblTeamSelectMember = new Label("Select Team Member");
        readonly Label lblTeamAddNewMember = new Label("Add New Member");
        readonly Label lblTeamFirst = new Label("First Name");
        readonly Label lblTeamLast = new Label("Last Name");
        readonly Label lblTeamEmail = new Label("Email");
        readonly Label lblTeamCellphone = new Label("Cellphone");

        readonly ScrolledWindow scrolledPlayersList =
            GeneralMethods.CreateListView("Players",
            new string[] { "Member 1", "Member 2", "etc..." });
        
        public CreateTeam() :
                base(Gtk.WindowType.Toplevel)
        {
            // Populating the fixed container
            @fixed.Put(lblTeamMain, 10, 10);

            @fixed.Put(lblTeamName, 10, 50);
            @fixed.Put(entryTeamName, 10, 70);

            @fixed.Put(lblTeamSelectMember, 10, 110);
            @fixed.Put(cmbTeamSelectMember, 10, 130);

            @fixed.Put(btnTeamAddMember, 10, 165);
            @fixed.Put(btnTeamDelete, 100, 165);

            @fixed.Put(lblTeamAddNewMember, 10, 220);

            @fixed.Put(lblTeamFirst, 10, 250);
            @fixed.Put(entryTeamFirst, 100, 250);

            @fixed.Put(lblTeamLast, 10, 280);
            @fixed.Put(entryTeamLast, 100, 280);

            @fixed.Put(lblTeamEmail, 10, 310);
            @fixed.Put(entryTeamEmail, 100, 310);

            @fixed.Put(lblTeamCellphone, 10, 340);
            @fixed.Put(entryTeamCellphone, 100, 340);

            @fixed.Put(btnTeamCreateNewMember, 50, 380);

            @fixed.Put(scrolledPlayersList, 270, 70);

            @fixed.Put(btnTeamCreateTeam, 210, 440);

            // Assigning widget colors and fonts and sizes
            byte[] RGBlabels = { 255, 255, 255};
            GeneralMethods.LabelColoursFonts(@fixed, RGBlabels);
            GeneralMethods.LabelColoursFonts(@fixed, RGBlabels,
                new Label[] { lblTeamMain });
            lblTeamAddNewMember.ModifyFont(Pango.FontDescription.FromString(
                "Source Code Pro Regular 16"));
            scrolledPlayersList.SetSizeRequest(200, 320);

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(500, 500);
            SetPosition(WindowPosition.Center);
            Title = "Team Creator";

            hBox.Add(@fixed);

            Add(hBox);

            ShowAll();
        }
    }
}
