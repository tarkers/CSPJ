using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
namespace p_snake
{
    static class Sound
    {
        static System.Media.SoundPlayer sound_play;
        static readonly string tmp = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        static readonly string resourcePath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(tmp).ToString()).ToString() + @"\Resources\";
        static readonly WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public static void Set_Background()
        {

            wplayer.URL =resourcePath+"background.mp3";
            wplayer.settings.autoStart = true;
            wplayer.settings.volume = 80;
            wplayer.settings.setMode("loop", true);

        }
        public static void BackgroundPlay(bool play=true)
        {
            if (play)
            {
                wplayer.controls.play();
            }
            else
            {
                wplayer.controls.pause();
            }
        }
        public static void SetBackgroundVolume(int volume)
        {
            wplayer.settings.volume = volume;
        }
        public static void PressButton()
        {
            sound_play = new System.Media.SoundPlayer(Properties.Resources.press_button);
            sound_play.Play();

        }
        public static void PlayMouseOver()
        {
            sound_play = new System.Media.SoundPlayer(Properties.Resources.mouse_over);
            sound_play.Play();

        }
        public static void ShootBalloon(bool is_balloon)
        {
            sound_play = is_balloon ? new System.Media.SoundPlayer(Properties.Resources.shoot_balloon) : new System.Media.SoundPlayer(Properties.Resources.explosion_sound);
            sound_play.Play();
        }
        public static void SnakeEat()
        {
            sound_play = new System.Media.SoundPlayer(Properties.Resources.eat);
            sound_play.Play();
        }
    }
}
