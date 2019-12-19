using Gtk;
using System;
using TrackerLibrary;

namespace TrackerDesktopUI
{
    public partial class CreatePrize : Gtk.Window
    {
        // Containers
        readonly Fixed @fixed = new Fixed();

        readonly HBox hBox = new HBox(false, 0);

        // Widgets
        readonly Button btnPrizeCreate = new Button("Create Prize");

        readonly Entry entryPrizePlaceNumber = new Entry();
        readonly Entry entryPrizePlaceName = new Entry();
        readonly Entry entryPrizePlaceAmount = new Entry();
        readonly Entry entryPrizePercentage = new Entry();

        readonly Label lblPrizeMain = new Label("Create Prize");
        readonly Label lblPrizePlaceNumber = new Label("Place Number");
        readonly Label lblPrizePlaceName = new Label("Place Name");
        readonly Label lblPrizePlaceAmount = new Label("Place Amount");
        readonly Label lblOR = new Label("- OR -");
        readonly Label lblPrizePercentage = new Label("Prize Percentage");

        public CreatePrize() :
                base(Gtk.WindowType.Toplevel)
        {
            // Populating the fixed container
            @fixed.Put(lblPrizeMain, 10, 10);

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
                new byte[] { 255, 255, 255 }, new Label[] { lblPrizeMain });

            // Window setup
            ModifyBg(StateType.Normal, new Gdk.Color(36, 36, 36));
            SetDefaultSize(400,400);
            SetPosition(WindowPosition.Center);
            Title = "Prize Creator";

            hBox.Add(@fixed);

            Add(hBox);

            ShowAll();
        }

        private void OnClick(object sender, EventArgs args)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    entryPrizePlaceName.Text,
                    entryPrizePlaceNumber.Text,
                    entryPrizePlaceAmount.Text,
                    entryPrizePercentage.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            if (!int.TryParse(entryPrizePlaceNumber.Text, out int placenumber))
            {
                output = false;
            }

            output &= placenumber >= 1;

            output &= entryPrizePlaceName.Text.Length != 0;

            output &= (decimal.TryParse(entryPrizePlaceAmount.Text, out _) &&
                double.TryParse(entryPrizePercentage.Text, out _));

            output &= (prizeAmount > 0 || prizePercentage > 0);

            output &= (prizePercentage >= 0 && prizePercentage <= 100);

            return output;
        }
    }
}
