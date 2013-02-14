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
            , amountStars
            , speedGame;
        public GameStatus gameStatus;

        List<Panzer> panzers;
        List<Stars> stars;
        Pers pers;

        public Wall wall;

        static Random R;

        internal List<Panzer> Panzers
        {
            get { return panzers; }
        }

        internal List<Stars> Stars
        {
            get { return stars; }
        }

        internal Pers Pers
        {
            get { return pers; }
        }

        public Model(int sizeField, int amountPanzer, int amountApples, int speedGame)
        {
            this.sizeField = sizeField;
            this.amountPanzer = amountPanzer;
            this.amountStars = amountApples;
            this.speedGame = speedGame;

            R = new Random();

            panzers = new List<Panzer>();
            stars = new List<Stars>();

            CreateStars();
            CreatePanzers();

            pers = new Pers(sizeField);
            wall = new Wall();
        }

        private void CreateStars()
        {
            int x, y;
            while (stars.Count < amountStars)
            {
                x = R.Next(6) * 40;
                y = R.Next(6) * 40;

                bool flag = true;

                foreach (Stars s in stars)
                    if (s.X == x && s.Y == y)
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                   stars.Add(new Stars(x, y));
            }
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
                Pers.Run();
                for(int i=0;i<panzers.Count-1;i++)
                    for(int j=i+1;j<panzers.Count;j++)
                        if (
                            ((Math.Abs(panzers[i].X - panzers[j].X) <= 20) && (panzers[i].Y==panzers[j].Y))
                            ||
                            ((Math.Abs(panzers[i].Y - panzers[j].Y) <= 20) && (panzers[i].X == panzers[j].X))
                            ||
                            ((Math.Abs(panzers[i].X - panzers[j].X) <= 20) && (Math.Abs(panzers[i].Y - panzers[j].Y) <= 20))
                            )
                        {
                            panzers[i].TurnAround();
                            panzers[j].TurnAround();
                        }
                Thread.Sleep(speedGame);
            }
        }
    }
}
