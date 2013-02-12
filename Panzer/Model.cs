using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Panzer
{
    class Model
    {
        public int sizeField
            , amountPanzer
            , amountApples
            , speedGame;
        public GameStatus gameStatus;

        List<Panzer> panzers;

        public Wall wall;

        static Random R;

        internal List<Panzer> Panzers
        {
            get { return panzers; }
        }

        public Model(int sizeField, int amountPanzer, int amountApples, int speedGame)
        {
            this.sizeField = sizeField;
            this.amountPanzer = amountPanzer;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            R = new Random();

            panzers = new List<Panzer>();
            CreatePanzers();
            wall = new Wall();
        }

        private void CreatePanzers()
        {
            int x, y;
            while (panzers.Count < amountPanzer)
            {
                x = R.Next(6) * 40;
                y = R.Next(6) * 40;

                bool flag = true;

                foreach (Panzer t in panzers)
                    if (t.X == x && t.Y == y)
                    {
                        flag = false;
                        break;
                    }
                if(flag)
                    panzers.Add(new Panzer(sizeField,x,y));
            }
            
        }

        public void Play()
        {
            while (gameStatus == GameStatus.playing)
            {
                foreach(Panzer t in panzers)
                    t.Run();
                Thread.Sleep(speedGame);
            }
        }
    }
}
