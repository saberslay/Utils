﻿using System.Speech.Synthesis;

namespace Utils {
    public class Speech {
        private static SpeechSynthesizer synth = new SpeechSynthesizer();
        public static void Speak_VoiceGender_Neutral(string message) {
            synth.SelectVoiceByHints(VoiceGender.Neutral);
            synth.Speak(message);
        }
        public static void Speak_VoiceGender_Female(string message) {
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak(message);
        }
        public static void Speak_VoiceGender_Male(string message) {
            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.Speak(message);
        }
        public static void Speak_VoiceGender_NotSet(string message) {
            synth.SelectVoiceByHints(VoiceGender.NotSet);
            synth.Speak(message);
        }
    }
}