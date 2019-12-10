using Gtk;

namespace TrackerDesktopUI
{
    public partial class CreatePrize : Gtk.Window
    {
        public CreatePrize() :
                base(Gtk.WindowType.Toplevel)
        {
            // Containers
            Fixed @fixed = new Fixed();

            HBox hBox = new HBox(false, 0);

            // Widgets
            Button btnPrizeCreate = new Button("Create Prize");

            Entry entryPrizePlaceNumber = new Entry();
            Entry entryPrizePlaceName = new Entry();
            Entry entryPrizePlaceAmount = new Entry();
            Entry entryPrizePercentage = new Entry();

            Label lblPrzeMain = new Label("Create Prize");
            Label lblPrizePlaceNumber = new Label("Place Number");
            Label lblPrizePlaceName = new Label("Place Name");
            Label lblPrizePlaceAmount = new Label("Place Amount");
            Label lblOR = new Label("- OR -");
            Label lblPrizePercentage = new Label("Prize Percentage");

            // Populating the fixed container
            @fixed.Put(lblPrzeMain, 10, 10);

            @fixed.Put(lblPrizePlaceNumber, 40, 60);
            @fixed.Put(entryPrizePlaceNumber, 200, 60);

            @fixed.Put(lblPrizePlaceName, 40, 100);
            @fixed.Put(entryPrizePlaceName, 200, 100);

            @fixed.Put(lblPrizePlaceAmount, 40, 140);
            @fixed.Put(entryPrizePlaceAmount, 200, 140);

            @fixed.Put(lblOR, 160, 180);

            @fixed.Put(lblPrizePercentage, 40, 220);
            @fixed.Put(entryPrizePercentage, 200, 220);

            @fixed.Put(btnPrizeCreate, 160, 280);

            // Assigning widget colora and fonts
            GeneralMethods.LabelColoursFonts(@fixed,
                new byte[] { 255, 255, 255}, new Label[] { lblPrzeMain });

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(400,400);
            SetPosition(WindowPosition.Center);
            Title = "Prize Creator";

            hBox.Add(@fixed);

            Add(hBox);
        }
    }
}
