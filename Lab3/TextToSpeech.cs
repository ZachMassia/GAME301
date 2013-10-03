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
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public void Say(String s)
        {
            synth.SpeakAsync(s);
        }
    }
}
