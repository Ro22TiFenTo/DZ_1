using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson1
{
    public class RobotUI
    {
        public const int MatrixSize = 16;

        private const int CellSize = 50;
        private const int DefaultRobotDelayInMs = 500;

        private readonly Brush EmptyCellColor = Brushes.Aqua;

        private Brush _robotColor = Brushes.Black;
        private Graphics _graphics;


        private Brush[,] _matrix = new Brush[MatrixSize, MatrixSize];

        public event EventHandler RedrawRequsted;

        private int _robotX = 0;
        private int _robotY = 0;
        private int _robotDelayInMs = DefaultRobotDelayInMs;


        public RobotUI(Graphics graphics)
        {
            _graphics = graphics;
        }


        public void SetRootColor(Color color)
        {
            _robotColor = new SolidBrush(color);
            RequestRedraw();
        }


        public void FillRobotCell()
        {
            _matrix[_robotX, _robotY] = _robotColor;
            RequestRedraw();
            Thread.Sleep(_robotDelayInMs);
        }


        public void MoveRobotRight()
        {
            if (_robotX == MatrixSize - 1)
                return;

            _robotX += 1;
            RequestRedraw();
            Thread.Sleep(_robotDelayInMs);
        }


        public void MoveRobotLeft()
        {
            if (_robotX == 0)
                return;

            _robotX -= 1;
            RequestRedraw();
            Thread.Sleep(_robotDelayInMs);
        }


        public void MoveRobotBootom()
        {
            if (_robotY == MatrixSize - 1)
                return;

            _robotY += 1;
            RequestRedraw();
            Thread.Sleep(_robotDelayInMs);
        }


        public void MoveRobotUp()
        {
            if (_robotY == 0)
                return;

            _robotY -= 1;
            RequestRedraw();
            Thread.Sleep(_robotDelayInMs);
        }

        
        public void SetRobotDelay(int delayInMs)
        {
            _robotDelayInMs = delayInMs;
        }


        private void RequestRedraw()
        {
            RedrawRequsted.Invoke(this, new EventArgs());

        }


        public void OnPaint()
        {
            for (int x = 0; x < MatrixSize; x++)
            {
                for (int y = 0; y < MatrixSize; y++)
                {
                    if (_matrix[x, y] != null)
                    {
                        _graphics.FillRectangle(_matrix[x, y], x * CellSize, y * CellSize, CellSize, CellSize);
                    }
                    else
                    {
                        _graphics.FillRectangle(EmptyCellColor, x * CellSize + 1, y * CellSize + 1, CellSize - 1, CellSize - 1);
                        _graphics.DrawRectangle(new Pen(Color.LightGray, 1), x * CellSize, y * CellSize, CellSize, CellSize);
                    }
                }
            }

            _graphics.DrawRectangle(new Pen(_robotColor, 3), (_robotX * CellSize), (_robotY * CellSize), CellSize, CellSize);
        }
    }
}
