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

            ListStore Rounds = GeneralMethods.CreateList(new string[]
            { "Round 1", "Round 2", "Round 3", "Round 4", "Round 5" });

            TreeView treeView = new TreeView(Rounds)
            {
                RulesHint = true
            };

            ScrolledWindow roundsList = new ScrolledWindow
            {
                ShadowType = ShadowType.EtchedIn
            };
            roundsList.SetSizeRequest(250, 400);
            roundsList.SetPolicy(PolicyType.Automatic, PolicyType.Automatic);
            roundsList.Add(treeView);

            GeneralMethods.AddColumns("Round matchups", treeView); // AddColumns(treeView);

            // Populating the left half of the fixed container
            // (midpoint is 275)
            @fixed.Put(lblViewerMain, 10, 10);
            @fixed.Put(lblViewerTournamentName, 85, 10);
            @fixed.Put(lblViewerRound, 10, 45);
            @fixed.Put(cmbRounds, 50, 35);
            @fixed.Put(cbtnRounds, 50, 70);

            @fixed.Put(roundsList, 10, 100);

            // Populating the right half of the fixed container
            // (midpoint is 275)
            @fixed.Put(lblViewerTeamOne, 290, 200);
            @fixed.Put(lblViewerScoreOne, 290, 240);
            @fixed.Put(entryScoreOne, 325, 235);

            @fixed.Put(lblViewerVersus, 290, 335);
            @fixed.Put(btnScore, 325, 328);

            @fixed.Put(lblViewerTeamTwo, 290, 400);
            @fixed.Put(lblViewerScoreTwo, 290, 440);
            @fixed.Put(entryViewerScoreTwo, 325, 435);

            // Assigning widget colours
            GeneralMethods.LabelColours(cbtnRounds,
                new byte[] { 255, 255, 255 });
            GeneralMethods.LabelColours(@fixed, new byte[] { 255, 255, 255 });

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
