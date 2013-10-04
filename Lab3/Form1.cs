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
        Joystick joy = new Joystick();

        public Lab3()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.N:
                    tts.Say("N key");
                    break;
                case Keys.Z:
                    tts.Say("Zed key"); // Canadian pronounciation ;)
                    break;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    tts.Say("Left mouse button");
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    tts.Say("Right mouse button");
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            joy.Poll((s) =>
            {
                bool[] btns = s.GetButtons();
                for (int i = 0; i < btns.Length; i++)
                {
                    if (btns[i] && (i == 0 || i == 2))
                    {
                        tts.Say(String.Format("Joystick Button {0} pressed", i));
                    }
                }
            });
        }
    }
}
