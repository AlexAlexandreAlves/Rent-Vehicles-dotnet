using System;
using System.Windows.Forms;
using System.Drawing;

namespace Views
{
    namespace lib
    {

        public class LibsLabel : Label
        {
            public LibsLabel(
                string Text,
                Point Location,
                Size Size)
            {
                this.Text = Text;
                this.Location = Location;
                this.Size = Size;
            }

        }
        public class LibsTextBoX : TextBox
        {
            public LibsTextBoX(
            Point Location,
            Size Size)
            {
                this.Location = Location;
                this.Size = Size;
            }

        }

        public class LibsButtons : Button
        {
            public LibsButtons(
                string Text,
                Point Location,
                Size Size)
            {
                this.Text = Text;
                this.Location = Location;
                this.Size = Size;
            }
        }

        public class LibsImage : PictureBox
        {
            public LibsImage(
                Point Location,
                Size Size)
            {
                this.Location = Location;
                this.Size = Size;
            }
        }


        public class LibsMaskedTextBox : MaskedTextBox
        {
            public LibsMaskedTextBox(
            Point Location,
            Size Size,
            string Mask)

            {
                this.Location = Location;
                this.Size = Size;
                this.Mask = Mask;

            }

        }

        public class LibsListView : ListView
        {
            public LibsListView(
                Point Location,
                Size size)
            {
                this.Location = Location;
                this.Size = Size;
                this.View = View.Details;


            }
        }

        public class LibsCalendarView : MonthCalendar
        {
            public LibsCalendarView(
            Point Location)
            {
                this.Location = Location;
            }

        }

        public class LibsProgressBarView : ProgressBar
        {
            public LibsProgressBarView(
            Point Location,
            Size Size)
            {
                this.Location = Location;
                this.Size = Size;
            }

        }

        public class LibsTimePickerView : DateTimePicker
        {
            public LibsTimePickerView(
            Point Location,
            Size Size)
            {
                this.Location = Location;
                this.Size = Size;
            }

        }
        public class LibsComboBox : ComboBox
        {
            public LibsComboBox(
                Point Location,
                Size Size,
                string[] options
            )
            {
                this.Location = Location;
                this.Size = Size;
                foreach (string item in options)
                {
                    this.Items.Add(item);
                }
            }

        }
        public class LibsCBBox : ComboBox
        {
            public LibsCBBox(
                Point Location,
                Size Size,
                string[] opt

            )
            {
                this.Location = Location;
                this.Size = Size;
                foreach (string item in opt)
                {
                    this.Items.Add(item);
                }

            }
        }



    }

}