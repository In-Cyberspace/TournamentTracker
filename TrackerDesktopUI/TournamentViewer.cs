using System;
using Gtk;

namespace TrackerDesktopUI
{
    public partial class TournamentViewer : Gtk.Window
    {
        //Gdk.Color winBgColour, lblFgColour;
        
        public TournamentViewer() :
                base(Gtk.WindowType.Toplevel)
        {
            // Colours and containers
            Gdk.Color winBgColour = new Gdk.Color(36, 36, 36);
            Gdk.Color lblFgColour = new Gdk.Color(255, 255, 255);

            Fixed leftFix = new Fixed();
            Fixed rightFix = new Fixed();

            HBox hBox = new HBox(false, 0);

            //VBox leftBox = new VBox(false, 0);
            //VBox rightBox = new VBox(false, 0);

            // Checkbox, combobox, entries, listbox, score buttons
            // (maybe create custom widgets for some stuff)
            Button btnScore = new Button("Score");
            CheckButton roundsCheck = new CheckButton("Unplayed Only");
            ComboBox cmbRounds = new ComboBox();
            Entry entryScoreOne = new Entry();
            Entry entryScoreTwo = new Entry();

            // Labels
            Label lblViewerMain = new Label("Tournament:");
            lblViewerMain.ModifyFg(StateType.Normal, lblFgColour);

            Label lblViewerRound = new Label("Round");
            lblViewerRound.ModifyFg(StateType.Normal, lblFgColour);

            Label lblViewerScoreOne = new Label("Score");
            lblViewerScoreOne.ModifyFg(StateType.Normal, lblFgColour);

            Label lblViewerScoreTwo = new Label("Score");
            lblViewerScoreTwo.ModifyFg(StateType.Normal, lblFgColour);

            Label lblViewerTournamentName = new Label("<none>");
            lblViewerTournamentName.ModifyFg(StateType.Normal, lblFgColour);
            // lblTournamentName.Visible = false;

            Label lblViewerTeamOne = new Label("Team One");
            lblViewerTeamOne.ModifyFg(StateType.Normal, lblFgColour);

            Label lblViewerTeamTwo = new Label("Team Two");
            lblViewerTeamTwo.ModifyFg(StateType.Normal, lblFgColour);

            Label lblViewerVersus = new Label("VS");
            lblViewerVersus.ModifyFg(StateType.Normal, lblFgColour);

            // Window setup
            ModifyBg(StateType.Normal, winBgColour);
            SetDefaultSize(550, 600);
            SetPosition(WindowPosition.Center);
            Title = "Tournament Viewer";

            // Populating the left box
            leftFix.Put(lblViewerMain, 5, 5);
            leftFix.Put(lblViewerTournamentName, 80, 5);

            // Populating the right box
            rightFix.Put(lblViewerTeamOne, 15, 200);
            rightFix.Put(lblViewerScoreOne, 15, 240);
            rightFix.Put(entryScoreOne, 50, 235);

            rightFix.Put(lblViewerVersus, 15, 335);
            rightFix.Put(btnScore, 50, 330); //x 160

            rightFix.Put(lblViewerTeamTwo, 15, 400);
            rightFix.Put(lblViewerScoreTwo, 15, 440);
            rightFix.Put(entryScoreTwo, 50, 435);

            hBox.Add(leftFix);
            hBox.Add(rightFix);

            Add(hBox);

            ShowAll();
            // -----
            
            // Build();

            //eventbox5.ModifyBg(StateType.Normal, winBgColour);
            //eventbox6.ModifyBg(StateType.Normal, winBgColour);
            // lblTournamentViewerMain.Colormap.AllocColor(ref lblColour, writeable:false,
            //    best_match:true);
        }
    }
}
