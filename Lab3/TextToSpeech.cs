using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;

namespace Lab3
{
    class TextToSpeech
    {
        // File used for SayToFile()
        public string OutputFile { get; set; }

        // Keeps the app from becoming unresponsive due to event spamming.
        private bool talking; 

        private SpeechSynthesizer synth = new SpeechSynthesizer();


        public TextToSpeech()
        {
            synth.SpeakCompleted += (s, e) => 
            { 
                talking = false; 
                // Reset the output.
                synth.SetOutputToDefaultAudioDevice();
            };
            // Set a default OutputFile.
            OutputFile = "tts.wav";
        }

        public void Say(string s)
        {
            if (!talking)
            {
                talking = true;
                synth.SpeakAsync(s);
            }
        }

        public void SayToFile(string s)
        {
            if (!talking)
            {
                talking = true;
                synth.SetOutputToWaveFile(OutputFile);
                synth.SpeakAsync(s);
            }
        }
    }
}
