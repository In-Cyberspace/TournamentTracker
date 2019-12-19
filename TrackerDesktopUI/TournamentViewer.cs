using Gtk;

namespace TrackerDesktopUI
{
    public partial class TournamentViewer : Gtk.Window
    {
        // Declaring and initializing containers
        readonly Fixed @fixed = new Fixed();

        readonly HBox hBox = new HBox(false, 0);

        // Declaring and initializing widgets
        readonly Button btnScore = new Button("Score");

        readonly CheckButton cbtnRounds = new CheckButton("Unplayed Only");

        readonly ComboBoxEntry cmbRounds =
            new ComboBoxEntry(new string[] {"Arch", "macOS", "Manjaro"});  // place holder for rounds dropdow

        readonly Entry entryScoreOne = new Entry();
        readonly Entry entryViewerScoreTwo = new Entry();

        readonly Label lblViewerMain = new Label("Tournament:");
        readonly Label lblViewerRound = new Label("Round");
        readonly Label lblViewerScoreOne = new Label("Score");
        readonly Label lblViewerScoreTwo = new Label("Score");
        readonly Label lblViewerTournamentName = new Label("<none>");
        readonly Label lblViewerTeamOne = new Label("<team one>");
        readonly Label lblViewerTeamTwo = new Label("<team two>");
        readonly Label lblViewerVersus = new Label("VS");

        readonly ScrolledWindow roundsList = GeneralMethods.CreateListView(
            "Round matchups", new string[] { "Round 1", "Round 2", "Round 3",
                "Round 4", "etc..." });      // place holder

        public TournamentViewer() :
                base(Gtk.WindowType.Toplevel)
        {
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
                new byte[] { 255, 255, 255 });
            GeneralMethods.LabelColoursFonts(@fixed, new byte[] { 255, 255,
                255 }, new Label[] { lblViewerTournamentName, lblViewerMain });

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(550, 600);
            SetPosition(WindowPosition.Center);
            Title = "Tournament Viewer";

            hBox.Add(@fixed);

            Add(hBox);

            ShowAll();
            // -----

            // Build();

            //eventbox5.ModifyBg(StateType.Normal, winBgColour);
            //eventbox6.ModifyBg(StateType.Normal, winBgColour);
        }
    }
}
