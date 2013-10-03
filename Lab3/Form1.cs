using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        TextToSpeech tts = new TextToSpeech();

        public Lab3()
        {
            InitializeComponent();
        }

        private void ttsBtn_Click(object sender, EventArgs e)
        {
            tts.Say(ttsTextBox.Text);
        }
    }
}
