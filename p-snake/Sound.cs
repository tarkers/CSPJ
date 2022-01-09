using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_snake
{
    static class Sound
    {
        static System.Media.SoundPlayer sound_play;
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
