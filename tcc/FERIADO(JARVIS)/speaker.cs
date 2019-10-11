using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace FERIADO_JARVIS_
{
  public class speaker
    {
        private static SpeechSynthesizer sp = new SpeechSynthesizer();
        public static void speak (string text)
        {
            //caso esteja falando
            if(sp.State == SynthesizerState.Speaking)
            sp.SpeakAsync(text);
            sp.SpeakAsyncCancelAll();
            sp.Speak(text);
        }
        public static void speak(params string[] texts)
        {
            Random rnd = new Random();
            speak(texts[rnd.Next(0, texts.Length)]);
        }
        
    }
}
