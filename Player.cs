using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string name = "arhan";
        public int health = 49;
        private int h = 45;

        public void SetHealth(int h)
        {
            health = h;
        }

        public int GetHealth()
        {
            return h;
        }
    }
}
