using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Window : Form
    {

        private Graphics _graphics;
        private RobotUI _robotUI;

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(1, 1);
            Size = new Size(801, 801);
            _graphics = CreateGraphics();
            _robotUI = new RobotUI(_graphics);
            _robotUI.RedrawRequsted += RobotUI_RedrawRequsted;

            new Thread(StartRobotProgram).Start();
        }


        private void RobotUI_RedrawRequsted(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate { InvokePaint(this, null); });
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            _robotUI.OnPaint();
        }

        private void StartRobotProgram()
        {
            new RobotScripts().Run(_robotUI);
        }
    }
}
