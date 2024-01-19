using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_helperHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(3);
            game.Shuffler();
            game.getKart();
            game.startGame();
        }
    }
}
