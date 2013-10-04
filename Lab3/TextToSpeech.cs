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
        bool talking;
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public TextToSpeech()
        {
            // Keeps the app from becoming unresponsive due to event spamming.
            synth.SpeakCompleted += (s, e) => { talking = false; };
        }

        public void Say(String s)
        {
            if (!talking)
            {
                talking = true;
                synth.SpeakAsync(s);
            }
        }
    }
}
