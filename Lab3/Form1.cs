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
using System.Media;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        #region Members
        private TextToSpeech tts = new TextToSpeech();
        private Joystick joy = new Joystick();
        //private WavPlayer wav = new WavPlayer("sound1.wav");

        // The velocity at which both boxes can move at.
        private Vector boxVelocity = new Vector(3.5, 3.5);
        
        // The players box
        private Vector stickDir = new Vector(0, 0);
        private System.Drawing.Point playerBoxPos = new System.Drawing.Point();

        // The pcs box
        private Vector pcDir = new Vector(0, 0);
        private System.Drawing.Point pcBoxPos = new System.Drawing.Point();

        private ToolStripStatusLabel[] statusLabels;
        #endregion
        
        public Lab3()
        {
            InitializeComponent();

            statusLabels = new ToolStripStatusLabel[]
            {
                toolStripStatusLabel1,
                toolStripStatusLabel2,
                toolStripStatusLabel3
            };

            InitializeJoystick();
            playBox.Select();
        }

        private void InitializeJoystick()
        {
            if (joy.Connected)
                ReportStatus("Joystick Connected", 1);
            else
                ReportStatus("Joystick Not Found", 1);
        }

        private void ReportStatus(string statusMessage, int i)
        {
            if ((statusMessage != null) && (statusMessage != String.Empty))
            {
                statusLabels[i - 1].Text = statusMessage;
            }
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
                stickDir.X = state.X;
                stickDir.Y = state.Y;
                stickDir.Normalize();

                playerBoxPos.X += (int)stickDir.X * (int)boxVelocity.X;
                playerBoxPos.Y += (int)stickDir.Y * (int)boxVelocity.Y;
                playerPictureBox.Location = playerBoxPos;
                #endregion              
            });

            // Move the pc picture box.
            pcBoxPos.X += (int)pcDir.X * (int)boxVelocity.X;
            pcBoxPos.Y += (int)pcDir.Y * (int)boxVelocity.Y;
            pcPictureBox.Location = pcBoxPos;
            
            // Handle collisions
            if (pcPictureBox.Bounds.Contains(playerPictureBox.Bounds))
            {
                tts.Say("Picturebox Collision!");
            }

            #region Player Bound Check
            if (playerPictureBox.Bounds.Right > playBox.Bounds.Right)
            {
                playerBoxPos.X = playBox.Bounds.Right;
                playerPictureBox.Location = playerBoxPos;
            }
            else if (playerPictureBox.Bounds.Left < playBox.Bounds.Left)
            {
                playerBoxPos.X = playBox.Bounds.Left;
                playerPictureBox.Location = playerBoxPos;
            }
 
            if (playerPictureBox.Bounds.Bottom > playBox.Bounds.Bottom)
            {
                playerBoxPos.Y = playBox.Bounds.Bottom;
                playerPictureBox.Location = playerBoxPos;
            }
            else if (playerPictureBox.Bounds.Top < playBox.Bounds.Top)
            {
                playerBoxPos.Y = playBox.Bounds.Top;
                playerPictureBox.Location = playerBoxPos;
            }
            #endregion

            #region PC Bound Check
            if (pcPictureBox.Bounds.Right > playBox.Bounds.Right)
            {
                pcDir.X = -1;
            }
            else if (pcPictureBox.Bounds.Left < playBox.Bounds.Left)
            {
                pcDir.X = 1;
            }

            if (pcPictureBox.Bounds.Bottom > playBox.Bounds.Bottom)
            {
                pcDir.Y = -1;
            }
            else if (pcPictureBox.Bounds.Top < playBox.Bounds.Top)
            {
                pcDir.Y = 1;
            }
            #endregion

            // Set status label 2 to the wav output file. 
            // A more efficient way of doing this would be to add an
            // EventHandler to the TextToSpeech class which would update
            // the status label on filename change.
            ReportStatus(String.Format("TTS .wav output: {0}", tts.OutputFile), 2);
        }

        private void playWavBtn_Click(object sender, EventArgs e)
        {
            // To avoid repetition, store a call to SoundPlayer.Play wrapped in a try catch.
            Action<string> play = (s) =>
            {
                try   { new SoundPlayer(s).Play(); }
                catch { ReportStatus("Could not play " + s, 3); }
            };

            switch (wavListBox.SelectedIndex)
            {
                case 0: // Sound
                    play("sound.wav");
                    break;
                case 1: // Text
                    play(tts.OutputFile);
                    break;
            }
        }

        private void wavConvertBtn_Click(object sender, EventArgs e)
        {
            tts.SayToFile(wavTextBox.Text);
        }
    }
}
