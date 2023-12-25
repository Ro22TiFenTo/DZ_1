using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson1
{
    public class RobotScripts
    {
        public bool cout { get; private set; }

        public void Run(RobotUI robotUI)
        {
            Exapmle(robotUI); // запускаю тестовый скрипт
        }


        private void Exapmle(RobotUI robotUI)
        {
            // robotUI.SetRobotDelay(100); // ты можешь утсанавиливать свою задержку между действиями робота (1000 - одна секунда)

            robotUI.SetRobotDelay(5);

            robotUI.SetRootColor(Color.Black); // устанавливает цвет робота
            robotUI.FillRobotCell(); // красит ячейку цветом робота
            robotUI.MoveRobotRight(); // передвигает робота вправо

            // robotUI.MoveRobotLeft(); // передвигает робота влево
            // robotUI.MoveRobotUp(); // передвигает робота вверх
            // robotUI.MoveRobotBootom(); // передвигает робота вниз
            int counter_1 = 0;
            while (counter_1 < 15)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_1++;
            }
            int counter_2 = 0;
            while (counter_2 < 15)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_2++;
            }
            int counter_3 = 0;
            while (counter_3 < 16)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_3++;
            }
            int counter_4 = 0;
            while (counter_4 < 14)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_4++;

            }
            int counter_5 = 0;
            while (counter_5 < 14)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_5++;

            }
            int counter_6 = 0;
            while (counter_6 < 13)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_6++;
            }
            int counter_7 = 0;
            while (counter_7 < 13)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_7++;
            }
            int counter_8 = 0;
            while (counter_8 < 12)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_8++;

            }
            int counter_9 = 0;
            while (counter_9 < 12)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_9++;

            }
            int counter_10 = 0;
            while (counter_10 < 11)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_10++;
            }
            int counter_11 = 0;
            while (counter_11 < 11)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_11++;
            }
            int counter_12 = 0;
            while (counter_12 < 10)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_12++;

            }
            int counter_13 = 0;
            while (counter_13 < 10)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_13++;

            }
            int counter_14 = 0;
            while (counter_14 < 09)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_14++;
            }
            int counter_15 = 0;
            while (counter_15 < 09)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_15++;
            }
            int counter_16 = 0;
            while (counter_16 < 08)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_16++;

            }
            int counter_17 = 0;
            while (counter_17 < 8)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_17++;

            }
            int counter_18 = 0;
            while (counter_18 < 07)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_18++;
            }
            int counter_19 = 0;
            while (counter_19 < 07)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_19++;
            }
            int counter_20 = 0;
            while (counter_20 < 06)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_20++;

            }
            int counter_21 = 0;
            while (counter_21 < 6)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_21++;

            }
            int counter_22 = 0;
            while (counter_22 < 05)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_22++;
            }
            int counter_23 = 0;
            while (counter_23 < 05)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_23++;
            }
            int counter_24 = 0;
            while (counter_24 < 04)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_24++;

            }
            int counter_25 = 0;
            while (counter_25 < 4)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotRight();
                counter_25++;

            }
            int counter_26 = 0;
            while (counter_26 < 03)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotBootom();
                counter_26++;
            }
            int counter_27 = 0;
            while (counter_27 < 03)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotLeft();
                counter_27++;
            }
            int counter_28 = 0;
            while (counter_28 < 02)

            {
                robotUI.SetRootColor(Color.Black);
                robotUI.FillRobotCell();
                robotUI.MoveRobotUp();
                counter_28++;

            }
            robotUI.SetRootColor(Color.Black);
            robotUI.FillRobotCell();
            robotUI.MoveRobotRight();
            robotUI.SetRootColor(Color.Black);
            robotUI.FillRobotCell();
            robotUI.MoveRobotRight();
            robotUI.SetRootColor(Color.Black);
            robotUI.FillRobotCell();
            robotUI.MoveRobotBootom();
            robotUI.SetRootColor(Color.Black);
            robotUI.FillRobotCell();
            robotUI.MoveRobotLeft();
            robotUI.SetRootColor(Color.Black);
            robotUI.FillRobotCell();
            robotUI.MoveRobotUp();
        }
    }
}
