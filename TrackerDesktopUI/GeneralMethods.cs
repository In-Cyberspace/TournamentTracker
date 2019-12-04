using Gtk;

namespace TrackerDesktopUI
{
    internal static class GeneralMethods
    {
        public static void AddColumns(string inColumn, TreeView treeView)
        {
            TreeViewColumn column = new TreeViewColumn(inColumn,
                new CellRendererText(), "text", 0);
            treeView.AppendColumn(column);
        }

        public static ListStore CreateList(string[] args)
        {
            ListStore store = new ListStore(typeof(string));

            foreach (string item in args)
            {
                store.AppendValues(item);
            }

            return store;
        }

        public static void LabelColours(Container inContainer, byte[] args)
        {
            Gdk.Color colour = new Gdk.Color(args[0], args[1], args[2]);

            foreach (Widget item in inContainer)
            {
                if (item is Label)
                {
                    item.ModifyFg(StateType.Active, colour);
                    item.ModifyFg(StateType.Normal, colour);
                    item.ModifyFg(StateType.Prelight, colour);
                }
            }
        }
    }
}
