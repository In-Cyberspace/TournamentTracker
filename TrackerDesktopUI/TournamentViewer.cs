using Gtk;

namespace TrackerDesktopUI
{
    public partial class TournamentViewer : Gtk.Window
    {
        public TournamentViewer() :
                base(Gtk.WindowType.Toplevel)
        {
            // Declaring and initializing containers
            Fixed @fixed = new Fixed();

            HBox hBox = new HBox(false, 0);

            // Declaring and initializing widgets
            Button btnScore = new Button("Score");

            CheckButton cbtnRounds = new CheckButton("Unplayed Only");

            ComboBoxEntry cmbRounds = new ComboBoxEntry(new string[] {"Arch",
                "macOS", "Manjaro"});                                               // place holder for rounds dropdow

            Entry entryScoreOne = new Entry();
            Entry entryViewerScoreTwo = new Entry();

            Label lblViewerMain = new Label("Tournament:");
            Label lblViewerRound = new Label("Round");
            Label lblViewerScoreOne = new Label("Score");
            Label lblViewerScoreTwo = new Label("Score");
            Label lblViewerTournamentName = new Label("<none>");
            Label lblViewerTeamOne = new Label("<team one>");
            Label lblViewerTeamTwo = new Label("<team two>");
            Label lblViewerVersus = new Label("VS");

            ScrolledWindow roundsList = GeneralMethods.CreateListView("Round" +
                " matchups", new string[] { "Round 1", "Round 2", "Round 3",
                    "Round 4", "etc..." });                                         // place holder
            roundsList.SetSizeRequest(250, 400);

            // Populating the left half of the fixed container
            // (midpoint is 275)
            @fixed.Put(lblViewerMain, 10, 10);
            @fixed.Put(lblViewerTournamentName, 145, 10);
            @fixed.Put(lblViewerRound, 10, 45);
            @fixed.Put(cmbRounds, 55, 40);
            @fixed.Put(cbtnRounds, 50, 70);

            @fixed.Put(roundsList, 10, 100);

            // Populating the right half of the fixed container
            // (midpoint is 275)
            @fixed.Put(lblViewerTeamOne, 290, 200);
            @fixed.Put(lblViewerScoreOne, 290, 240);
            @fixed.Put(entryScoreOne, 335, 235);

            @fixed.Put(lblViewerVersus, 290, 335);
            @fixed.Put(btnScore, 325, 328);

            @fixed.Put(lblViewerTeamTwo, 290, 400);
            @fixed.Put(lblViewerScoreTwo, 290, 440);
            @fixed.Put(entryViewerScoreTwo, 335, 435);

            // Assigning widget colours and fonts
            GeneralMethods.LabelColoursFonts(cbtnRounds,
                new byte[] { 255, 255, 255 }, new Label[] {});
            GeneralMethods.LabelColoursFonts(@fixed, new byte[] { 255, 255,
                255 }, new Label[] { lblViewerTournamentName, lblViewerMain });

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(550, 600);
            SetPosition(WindowPosition.Center);
            Title = "Tournament Viewer";

            hBox.Add(@fixed);

            Add(hBox);

            //ShowAll();
            // -----

            // Build();

            //eventbox5.ModifyBg(StateType.Normal, winBgColour);
            //eventbox6.ModifyBg(StateType.Normal, winBgColour);
        }
    }
}
