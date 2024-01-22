using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    internal class Bomb : Enemy
    {
        public Bomb(PictureBox[] sprites)
        {
            this.sprites = (PictureBox[])sprites.Clone();
        }
        public void StartBombAnimation(int interval, string type = "normal")
        {
            Animation bomb_animation = new Animation(sprites, interval);
            bomb_animation.StartAnimation();
        }
    }
}
