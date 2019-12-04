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
            Button btnCreatePrize = new Button("Create Prize");
            Button btnCreateDeleteTeams = new Button("Delete Selected");
            Button btnCreateDeletePrizes = new Button("Delete Selected");
            Button btnCreateMain = new Button("Create Tournament");

            ComboBoxEntry cmbCreateTeam = new ComboBoxEntry(new string[]
            { "One", "Two", "Three" });

            Entry entryCreateName = new Entry();
            Entry entryCreateFee = new Entry();

            Label lblCreateMain = new Label("Create Tournament");
            Label lblCreateName = new Label("Tournament Name");
            Label lblCreateFee = new Label("Entry Fee");
            Label lblCreateSelectTeam = new Label("Select Team");
            Label lblCreateTeamPlayers = new Label("Team/Players");

            //ListStore storeCreateTeams = 
        }
    }

    public partial class CreateTournament : Gtk.Window
    {
        protected ListStore TeamsList()
        {
            ListStore store = new ListStore(typeof(string));

            foreach (string item in new List<string>() {"Team/Player 1",
            "Team/Player 2", "Team/Player 3"})
            {
                store.AppendValues(item);
            }

            return store;
        }

        protected void AddColumns(TreeView treeView)
        {
            CellRendererText rendererText = new CellRendererText();
            TreeViewColumn column = new TreeViewColumn("Team/Player",
                rendererText, "text", 0);
            treeView.AppendColumn(column);
        }
    }
}
