using Gtk;
using System.Collections.Generic;

namespace TrackerDesktopUI
{
    public partial class CreateTournament : Gtk.Window
    {
        public CreateTournament() :
                base(Gtk.WindowType.Toplevel)
        {
            // Containers
            HBox hBox = new HBox(false, 0);

            Fixed @fixed = new Fixed();

            // Widgets
            Button btnCreateAddTeam = new Button("Add Team");
            Button btnCreateNewTeam = new Button("Create New");
            Button btnCreatePrize = new Button("Create Prize");
            Button btnCreateDeleteTeams = new Button("Delete Selected");
            Button btnCreateDeletePrizes = new Button("Delete Selected");
            Button btnCreateMain = new Button("Create Tournament");

            ComboBoxEntry cmbCreateTeam = new ComboBoxEntry(new string[] { "Te"
                + "am 1", "Team 2", "etc..." });

            Entry entryCreateName = new Entry();
            Entry entryCreateFee = new Entry();

            Label lblCreateMain = new Label("Create Tournament");
            Label lblCreateName = new Label("Tournament Name");
            Label lblCreateFee = new Label("Entry Fee");
            Label lblCreateSelectTeam = new Label("Select Team");

            ScrolledWindow PrizesList = GeneralMethods.CreateListView("Prizes",
                new string[] { "Prize 1", "Prize 2", "etc..." });
            PrizesList.SetSizeRequest(300, 200);
            ScrolledWindow TeamsList = GeneralMethods.CreateListView("Teams/" +
                "Players", new string[] {"Team 1", "Team 2", "etc..."});
            TeamsList.SetSizeRequest(300, 300);

            // Populating the top half of the fixed container
            @fixed.Put(lblCreateMain, 10, 5);

            @fixed.Put(btnCreateMain, 200, 50);

            @fixed.Put(TeamsList, 10, 100);

            @fixed.Put(lblCreateName, 320, 110);
            @fixed.Put(entryCreateName, 320, 130);

            @fixed.Put(lblCreateFee, 320, 190);
            @fixed.Put(entryCreateFee, 320, 210);

            @fixed.Put(lblCreateSelectTeam, 320, 270);
            @fixed.Put(cmbCreateTeam, 320, 290);
            @fixed.Put(btnCreateAddTeam, 320, 330);
            @fixed.Put(btnCreateNewTeam, 400, 330);
            @fixed.Put(btnCreateDeleteTeams, 320, 370);

            // Populating the bottom half of the fixed container
            @fixed.Put(PrizesList, 10, 450);

            @fixed.Put(btnCreatePrize, 320, 580);
            @fixed.Put(btnCreateDeletePrizes, 320, 620);

            // Assigning widget colours and fonts
            GeneralMethods.LabelColoursFonts(@fixed, new byte[] { 255, 255,
                255}, new Label[] { lblCreateMain });

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
