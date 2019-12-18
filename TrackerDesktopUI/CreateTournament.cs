using Gtk;
using System.Collections.Generic;

namespace TrackerDesktopUI
{
    public partial class CreateTournament : Gtk.Window
    {
        // Containers
        readonly Fixed @fixed = new Fixed();

        readonly HBox hBox = new HBox(false, 0);

        // Widgets
        readonly Button btnCreateAddTeam = new Button("Add Team");
        readonly Button btnCreatePrize = new Button("Create Prize");
        readonly Button btnCreateDeleteTeams = new Button("Delete Selected");
        readonly Button btnCreateDeletePrizes = new Button("Delete Selected");
        readonly Button btnCreateMain = new Button("Create Tournament");

        readonly ComboBoxEntry cmbCreateTeam =
            new ComboBoxEntry(new string[] { "Team 1", "Team 2", "etc..." });

        readonly Entry entryCreateName = new Entry();
        readonly Entry entryCreateFee = new Entry("0");

        readonly EventBox clicklblCreateTeam =
            GeneralMethods.ClickableLabel("create new");

        readonly Label lblCreateMain = new Label("Create Tournament");
        readonly Label lblCreateName = new Label("Tournament Name");
        readonly Label lblCreateFee = new Label("Entry Fee");
        readonly Label lblCreateSelectTeam = new Label("Select Team");

        readonly ScrolledWindow PrizesList = GeneralMethods.CreateListView(
            "Prizes", new string[] { "Prize 1", "Prize 2", "etc..." });
        readonly ScrolledWindow TeamsList = GeneralMethods.CreateListView(
            "Teams/Players", new string[] { "Team 1", "Team 2", "etc..." });

        public CreateTournament() :
                base(Gtk.WindowType.Toplevel)
        {
            // Populating the top half of the fixed container
            @fixed.Put(lblCreateMain, 10, 5);

            @fixed.Put(btnCreateMain, 200, 50);

            @fixed.Put(TeamsList, 10, 100);

            @fixed.Put(lblCreateName, 320, 110);
            @fixed.Put(entryCreateName, 320, 130);

            @fixed.Put(lblCreateFee, 320, 190);
            @fixed.Put(entryCreateFee, 320, 210);

            @fixed.Put(lblCreateSelectTeam, 320, 270);
            @fixed.Put(clicklblCreateTeam, 450, 270);
            @fixed.Put(cmbCreateTeam, 320, 290);
            @fixed.Put(btnCreateAddTeam, 320, 330);
            @fixed.Put(btnCreateDeleteTeams, 320, 370);

            // Populating the bottom half of the fixed container
            @fixed.Put(PrizesList, 10, 450);

            @fixed.Put(btnCreatePrize, 320, 580);
            @fixed.Put(btnCreateDeletePrizes, 320, 620);

            // Assigning widget colours and fonts and sizes
            GeneralMethods.LabelColoursFonts(@fixed,
                new byte[] { 255, 255, 255}, new Label[] { lblCreateMain });
            PrizesList.SetSizeRequest(300, 200);
            TeamsList.SetSizeRequest(300, 300);

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(600, 700);
            SetPosition(WindowPosition.Center);
            Title = "Tournament Creator";

            hBox.Add(@fixed);

            Add(hBox);
        }
    }
}
