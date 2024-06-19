using System.IO;
using System.Threading;

namespace Utils {
    public class PlayAudio {
        public static void Play_Audio_mp3(string SoundFileName) {
            string CurrentPath = Directory.GetCurrentDirectory();
            Thread PlayAudioThread = new Thread(new ThreadStart(() => {
                WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
                mediaPlayer.URL = Path.Combine(CurrentPath, "Sound", $"{SoundFileName}.mp3");
                mediaPlayer.controls.play();
            }));
            PlayAudioThread.Start();
        }
        public static void Play_Audio_ogg(string SoundFileName) {
            string CurrentPath = Directory.GetCurrentDirectory();
            Thread PlayAudioThread = new Thread(new ThreadStart(() => {
                WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
                mediaPlayer.URL = Path.Combine(CurrentPath, "Sound", $"{SoundFileName}.ogg");
                mediaPlayer.controls.play();
            }));
            PlayAudioThread.Start();
        }
        public static void Play_Audio_wav(string SoundFileName) {
            string CurrentPath = Directory.GetCurrentDirectory();
            Thread PlayAudioThread = new Thread(new ThreadStart(() => {
                WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
                mediaPlayer.URL = Path.Combine(CurrentPath, "Sound", $"{SoundFileName}.wav");
                mediaPlayer.controls.play();
            }));
            PlayAudioThread.Start();
        }
    }
}
