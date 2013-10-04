using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        TextToSpeech tts = new TextToSpeech();
        Joystick joy = new Joystick();

        Vector boxVelocity = new Vector(3.5, 3.5);
        Vector stickDir = new Vector();
        System.Drawing.Point boxPos = new System.Drawing.Point();

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
            // This poll function take a lambda and only calls it if the joystick
            // is connected and no there are no errors 
            joy.Poll((state) =>
            {
                #region Buttons
                bool[] btns = state.GetButtons();
                for (int i = 0; i < btns.Length; i++)
                {
                    if (btns[i] && (i == 0 || i == 2))
                    {
                        tts.Say(String.Format("Joystick Button {0} pressed", i));
                    }
                }
                #endregion

                #region Stick
                // Get the unit-vector of the joysticks left stick.
                stickDir.X = 1; //state.X;
                stickDir.Y = state.Y;
                stickDir.Normalize();

                boxPos.X += (int)stickDir.X * (int)boxVelocity.X;
                boxPos.Y += (int)stickDir.Y * (int)boxVelocity.Y;
                playerPictureBox.Location = boxPos;
                #endregion              
            });

            
        }
    }
}
