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

    }

}