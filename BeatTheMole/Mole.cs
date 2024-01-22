using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    internal class Mole : Enemy
    {
        public Mole(PictureBox[] sprites)
        {
            this.sprites = (PictureBox[])sprites.Clone();
        }
        public void StartMoleAnimation(int interval)
        {
            Animation mole_animation = new Animation(sprites, interval);
            mole_animation.StartAnimation();
        }
    }
}
