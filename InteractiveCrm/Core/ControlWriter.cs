using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveCrm
{
    internal class ControlWriter : TextWriter
    {
        private readonly Control _textbox;

        public ControlWriter(Control textbox)
        {
            _textbox = textbox;
            _textbox.Text = string.Empty;
        }

        public override void Write(char value)
        {
            _textbox.Text += value;
        }

        public override void Write(string value)
        {
            _textbox.Text += value;
        }

        public override void Write(int value)
        {
            _textbox.Text += value;
        }

        public void Clear()
        {
            _textbox.Text = string.Empty;
        }

        public override Encoding Encoding => Encoding.UTF8;
    }
}
