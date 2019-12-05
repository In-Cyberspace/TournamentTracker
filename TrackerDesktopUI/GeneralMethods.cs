using Gtk;

namespace TrackerDesktopUI
{
    internal static class GeneralMethods
    {
        public static ScrolledWindow CreateListView(string column,
            string[] args)
        {
            ListStore store = new ListStore(typeof(string));

            foreach (string item in args)
            {
                store.AppendValues(item);
            }

            TreeViewColumn treeViewColumn = new TreeViewColumn(column,
                new CellRendererText(), "text", 0);

            TreeView tree = new TreeView(store)
            {
                RulesHint = true
            };
            tree.AppendColumn(treeViewColumn);

            ScrolledWindow scrolled = new ScrolledWindow()
            {
                ShadowType = ShadowType.EtchedIn
            };
            scrolled.Add(tree);
            scrolled.SetPolicy(PolicyType.Automatic, PolicyType.Automatic);

            return scrolled;
        }

        public static void LabelColoursFonts(Container container, byte[] args,
            Label[] labels) ///// insert main label
        {
            Gdk.Color colour = new Gdk.Color(args[0], args[1], args[2]);

            foreach (Widget item in container)
            {
                if (item is Label)
                {
                    item.ModifyFg(StateType.Active, colour);
                    item.ModifyFg(StateType.Normal, colour);
                    item.ModifyFg(StateType.Prelight, colour);
                    item.ModifyFont(Pango.FontDescription.FromString("Source" +
                            " Code Pro Regular 14"));
                }
            }

            foreach (Widget item in labels)
            {
                item.ModifyFont(Pango.FontDescription.FromString("Source " +
                            "Code Pro Regular 20"));
            }
        }
    }
}
