using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhymeFinder
{
    public partial class FormInputText : Form
    {
        public string InputedText { get; set; }

        public FormInputText()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            InputedText = textBoxInput.Text;
            this.Close();
        }
    }
}
