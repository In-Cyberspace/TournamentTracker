using Gtk;

namespace TrackerDesktopUI
{
    internal static class GeneralMethods
    {
        internal static ScrolledWindow CreateListView(string column,
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

        internal static void LabelColoursFonts(Container container, byte[] args,
            Label[] labels = null)
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

            if (labels != null)
            {
                foreach (Widget item in labels)
                {
                    item.ModifyFont(Pango.FontDescription.FromString("Source" +
                                " Code Pro Regular 20"));
                }
            }
        }

        internal static EventBox ClickableLabel(string lblTitle)
        {
            Pango.AttrList attr = new Pango.AttrList();
            attr.Insert(new Pango.AttrUnderline(Pango.Underline.Single));
            attr.Insert(new Pango.AttrFontDesc(
                Pango.FontDescription.FromString("Source Code Pro " +
                "Regular 14")));
            Label label = new Label(lblTitle)
            {
                Attributes = attr
            };
            label.ModifyFg(StateType.Active, new Gdk.Color(255, 255, 255));
            label.ModifyFg(StateType.Normal, new Gdk.Color(255, 255, 255));
            label.ModifyFg(StateType.Prelight, new Gdk.Color(255, 255, 255));

            EventBox eventBox = new EventBox
            {
                label
            };
            eventBox.ModifyBg(StateType.Active, new Gdk.Color(36, 36, 36));
            eventBox.ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));

            return eventBox;
        }
    }
}
