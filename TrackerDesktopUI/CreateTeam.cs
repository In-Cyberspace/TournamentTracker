using Gtk;
using System;

namespace TrackerDesktopUI
{
    public partial class CreateTeam : Gtk.Window
    {
        public CreateTeam() :
                base(Gtk.WindowType.Toplevel)
        {
            // Containers
            HBox hBox = new HBox(false, 0);

            Fixed @fixed = new Fixed();

            // Widgets
            Button btnTeamAddMember = new Button("Add Member");
            Button btnTeamCreateNewMember = new Button("Create Member");
            Button btnTeamCreateTeam = new Button("Create Team");

            ComboBoxEntry cmbTeamSelectMember = new ComboBoxEntry(
                new string[] { "Member 1", "Member 2", "etc..." });

            Entry entryTeamName = new Entry();
            Entry entryTeamFirst = new Entry();
            Entry entryTeamLast = new Entry();
            Entry entryTeamEmail = new Entry();
            Entry entryTeamCellphone = new Entry();

            Label lblTeamMain = new Label("Create Team");
            Label lblTeamName = new Label("Team Name");
            Label lblTeamSelectMember = new Label("Select Team Member");
            Label lblTeamAddNewMember = new Label("Add New Member");
            Label lblTeamFirst = new Label("First Name");
            Label lblTeamLast = new Label("Last Name");
            Label lblTeamEmail = new Label("Email");
            Label lblTeamCellphone = new Label("Cellphone");

            ScrolledWindow scrolledPlayersList =
                GeneralMethods.CreateListView("Players",
                new string[] { "Member 1", "Member 2", "etc..." });
            scrolledPlayersList.SetSizeRequest(200, 320);

            // Populating the fixed container
            @fixed.Put(lblTeamMain, 10, 10);

            @fixed.Put(lblTeamName, 10, 50);
            @fixed.Put(entryTeamName, 10, 70);

            @fixed.Put(lblTeamSelectMember, 10, 110);
            @fixed.Put(cmbTeamSelectMember, 10, 130);

            @fixed.Put(btnTeamAddMember, 50, 165);

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

            // Assigning widget colors and fonts
            byte[] RGBlabels = { 255, 255, 255};
            GeneralMethods.LabelColoursFonts(@fixed, RGBlabels);
            GeneralMethods.LabelColoursFonts(@fixed, RGBlabels,
                new Label[] { lblTeamMain });
            lblTeamAddNewMember.ModifyFont(Pango.FontDescription.FromString(
                "Source Code Pro Regular 16"));

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(500, 500);
            SetPosition(WindowPosition.Center);
            Title = "Team Creator";

            hBox.Add(@fixed);

            Add(hBox);
        }
    }
}
