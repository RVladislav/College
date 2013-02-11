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

        public Panzer panzer;

        public Wall wall;

        public Model(int sizeField, int amountPanzer, int amountApples, int speedGame)
        {
            this.sizeField = sizeField;
            this.amountPanzer = amountPanzer;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            panzer = new Panzer(sizeField);
            wall = new Wall();
        }

        public void Play()
        {
            while (gameStatus == GameStatus.playing)
            {
                panzer.Run();
                Thread.Sleep(speedGame);
            }
        }
    }
}
