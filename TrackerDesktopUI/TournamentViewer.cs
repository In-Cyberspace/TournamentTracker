using System.Collections.Generic;
using Gtk;

namespace TrackerDesktopUI
{
    public partial class TournamentViewer : Gtk.Window
    {
        public TournamentViewer() : base(Gtk.WindowType.Toplevel)
        {
            // Declaring and initializing containers
            Fixed @fixed = new Fixed();

            HBox hBox = new HBox(false, 0);

            // Declaring and initializing widgets
            // (maybe create custom widgets for some stuff)
            Button btnScore = new Button("Score");

            CheckButton cbtnRounds = new CheckButton("Unplayed Only");

            ComboBox cmbRounds = new ComboBox(new string[] {"Arch",
                "macOS", "Manjaro"});                                               // place holder for rounds dropdow

            Entry entryScoreOne = new Entry();
            Entry entryScoreTwo = new Entry();

            Label lblViewerMain = new Label("Tournament:");
            Label lblViewerRound = new Label("Round");
            Label lblViewerScoreOne = new Label("Score");
            Label lblViewerScoreTwo = new Label("Score");
            Label lblViewerTournamentName = new Label("<none>");
            Label lblViewerTeamOne = new Label("Team One");
            Label lblViewerTeamTwo = new Label("Team Two");
            Label lblViewerVersus = new Label("VS");

            ListStore Rounds = TempRoundsList();

            TreeView treeView = new TreeView(Rounds);
            treeView.RulesHint = true;

            ScrolledWindow roundsList = new ScrolledWindow();
            roundsList.ShadowType = ShadowType.EtchedIn;
            roundsList.SetPolicy(PolicyType.Automatic, PolicyType.Automatic);
            roundsList.Add(treeView);

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
            @fixed.Put(entryScoreTwo, 325, 435);

            // Assigning widget colours
            Gdk.Color lblFgColour = new Gdk.Color(255, 255, 255);

            foreach (Widget item in @fixed)
            {
                if (item is Label)
                {
                    item.ModifyFg(StateType.Normal, lblFgColour);
                }
            }
            foreach (Widget item in cbtnRounds)
            {
                if (item is Label)
                {
                    item.ModifyFg(StateType.Normal, lblFgColour);
                    item.ModifyFg(StateType.Active, lblFgColour);
                    item.ModifyFg(StateType.Prelight, lblFgColour);
                }
            }

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

    public partial class TournamentViewer : Gtk.Window
    {
        /// <summary>
        /// Temporary place holder for the rounds list store.
        /// </summary>
        protected class TempRounds
        {
            public List<string> rounds = new List<string> { "Round 1",
            "Round 2", "Round 3" };
        }

        public ListStore TempRoundsList()
        {
            ListStore store = new ListStore(typeof(string));

            foreach (string item in new TempRounds().rounds)
            {
                store.AppendValues(item);
            }

            return store;
        }
    }
}
