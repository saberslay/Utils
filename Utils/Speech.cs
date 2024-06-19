using System.Threading;
using System.Speech.Synthesis;

namespace Utils.Synthesis {
    public class Speech {
        private static SpeechSynthesizer synth = new SpeechSynthesizer();
        public static void Speak_VoiceGender_Neutral(string message) {
            Thread Speak_VoiceGender_Neutral_Thread = new Thread(new ThreadStart(() => {
                synth.SelectVoiceByHints(VoiceGender.Neutral);
                synth.Speak(message);
            }));
            Speak_VoiceGender_Neutral_Thread.Start();
        }
    }
}