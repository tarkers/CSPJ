using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_snake
{
    static class Sound
    {
        public  static void PressButton()
        {
            System.Media.SoundPlayer sound_play = new System.Media.SoundPlayer(Properties.Resources.press_button);
            sound_play.Play();

        }
        public static void PlayMouseOver()
        {
            System.Media.SoundPlayer sound_play = new System.Media.SoundPlayer(Properties.Resources.mouse_over);
            sound_play.Play();

        }
    }
}
