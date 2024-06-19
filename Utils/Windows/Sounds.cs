using System.Media;
using System.Threading;

namespace Utils.Windows {
    public class Sounds {
        private static string Path = @"c:\Windows\Media\";
        public static void wuac() {
            Thread wuac = new Thread(new ThreadStart(() => {
                SoundPlayer player = new SoundPlayer($"{Path}Windows User Account Control.wav");
                player.Play();
            }));
            wuac.Start();
        }
        public static void notify() {
            Thread notify = new Thread(new ThreadStart(() => {
                SoundPlayer player = new SoundPlayer($"{Path}notify.wav");
                player.Play();
            }));
            notify.Start();
        }
        public static void WHI() {
            Thread WHI = new Thread(new ThreadStart(() => {
                SoundPlayer player = new SoundPlayer($"{Path}Windows Hardware Insert.wav");
                player.Play();
            }));
            WHI.Start();
        }
        public static void WHR() {
            Thread WHR = new Thread(new ThreadStart(() => {
                SoundPlayer player = new SoundPlayer($"{Path}Windows Hardware Remove.wav");
                player.Play();
            }));
            WHR.Start();
        }
    }
}
