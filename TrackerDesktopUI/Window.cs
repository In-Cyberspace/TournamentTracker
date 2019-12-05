using Gtk;

namespace TrackerDesktopUI
{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            // Containers
            HBox hBox = new HBox(false, 0);

            Fixed @fixed = new Fixed();

            // Widgets
        }
    }
}
