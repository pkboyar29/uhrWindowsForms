using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace uhr
{
    public partial class clock : UserControl
    {
        Graphics g;
        Bitmap bmp;
        int widthClock, heightClock, xClock, yClock;
        int widthBonding;
        Pen penClock = new Pen(Color.Black);
        Pen penSecond = new Pen(Color.Black);
        Pen penMinute = new Pen(Color.Black);
        Pen penHour = new Pen(Color.Black);
        public clock()
        {
            InitializeComponent();
        }
        public Color ClockColor
        {
            set { penClock.Color = value; }
            get { return penClock.Color; }
        }
        public Color hColor
        {
            set { penHour.Color = value; }
            get => penHour.Color;
        }
        public Color mColor
        {
            set { penMinute.Color = value; }
            get => penMinute.Color;
        }
        public Color sColor
        {
            set { penSecond.Color = value; }
            get => penSecond.Color;
        }
        private void clock_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Width+1, Height+1);
            g = CreateGraphics();
            timer1.Start();
            widthBonding = 12;
            penClock.Width = 11;
            penSecond.Width = 3;
            penMinute.Width = 6;
            penHour.Width = 9;

            widthClock = Width;
            heightClock = Height;
            if (widthClock != heightClock)
            {
                if (widthClock < heightClock) heightClock = Width;
                else widthClock = Height;
            }
            Check_Resize();
        }
        void ClockFaceLinesPaint()
        {
            int[] coordP1 = new int[2];
            int[] coordP2 = new int[2];
            int lengthHand = 0;
            int val = 0;
            int length = (int)penClock.Width;

            for(int i=0;i<60;i++)
            {
                val = i*6;
                length = (int)penClock.Width;

                if (i % 5 == 0) length *= 2;
                if (i == 0 || i == 15 || i == 30 || i == 45) length += length*2;

                if (val >= 0 && val <= 100)
                {
                    lengthHand = widthClock / 2 - length;
                    coordP1[0] = Width / 2 + (int)(lengthHand * Math.Sin(Math.PI * val / 180));
                    coordP1[1] = Height / 2  - (int)(lengthHand * Math.Cos(Math.PI * val / 180));
                }
                else
                {
                    lengthHand = widthClock / 2 - length;
                    coordP1[0] = Width / 2 - (int)(lengthHand * -Math.Sin(Math.PI * val / 180));
                    coordP1[1] = Height / 2 - (int)(lengthHand * Math.Cos(Math.PI * val / 180));
                }

                if (val >= 0 && val <= 100)
                {
                    lengthHand = length;
                    coordP2[0] = coordP1[0] + (int)(lengthHand * Math.Sin(Math.PI * val / 180));
                    coordP2[1] = coordP1[1] - (int)(lengthHand * Math.Cos(Math.PI * val / 180));
                }
                else
                {
                    lengthHand = length;
                    coordP2[0] = coordP1[0] - (int)(lengthHand * -Math.Sin(Math.PI * val / 180));
                    coordP2[1] = coordP1[1] - (int)(lengthHand * Math.Cos(Math.PI * val / 180));
                }

                Point p1 = new Point(coordP1[0], coordP1[1]);
                Point p2 = new Point(coordP2[0], coordP2[1]);

                g.DrawLine(penClock, p1, p2);
                //.g.D
            }
        }

        void ClockFacePaint()
        {
            widthClock = Width;
            heightClock = Height;
            if (widthClock != heightClock)
            {
                if (widthClock < heightClock) heightClock = Width;
                else widthClock = Height;
            }
            widthClock -= 15;
            heightClock -= 15;
            xClock = Width / 2 - widthClock / 2;
            yClock = Height / 2 - heightClock / 2;
            g.DrawEllipse(penClock, xClock, yClock, widthClock, heightClock);
            ClockFaceLinesPaint();
            //Point p = new Point(Width / 2, Height / 2);
            //g.DrawArc(penClock, (Width / 2) - 2, (Height / 2) - 2, 4, 4, 90, 90);
            g.DrawEllipse(new Pen(ClockColor, widthBonding), (Width / 2) - 2, (Height / 2) - 2, 4, 4);
        }

        private void clock_Resize(object sender, EventArgs e)
        {
            Check_Resize();
        }
        void Check_Resize()
        {
            if (widthClock >= 180 && widthClock < 300)
            {
                widthBonding = 12;
                penClock.Width = 7;
                penSecond.Width = 2;
                penMinute.Width = 4;
                penHour.Width = 6;
            }
            if (widthClock >= 80 && widthClock < 180)
            {
                widthBonding = 6;
                penClock.Width = 4;
                penSecond.Width = 1;
                penMinute.Width = 2;
                penHour.Width = 3;
            }
            if (widthClock < 80)
            {
                widthBonding = 4;
                penClock.Width = 3;
                penSecond.Width = 0.5f;
                penMinute.Width = 1;
                penHour.Width = 2;
            }
        }
        void Second_Paint(int s)
        {
            Point p1 = new Point(Width/2, Height/2);
            int[] p2Coord = new int[2];
            p2Coord = msCoord(s, widthClock/2);
            Point p2 = new Point(p2Coord[0], p2Coord[1]);
            g.DrawLine(penSecond, p1, p2);
        }
        void Minute_Paint(int m)
        {
            Point p1 = new Point(Width / 2, Height / 2);
            int[] p2Coord = new int[2];
            p2Coord = msCoord(m, widthClock/3);
            Point p2 = new Point(p2Coord[0], p2Coord[1]);
            g.DrawLine(penMinute, p1, p2);
        }
        void Hour_Paint(int h, int m)
        {
            Point p1 = new Point(Width / 2, Height / 2);
            int[] p2Coord = new int[2];
            p2Coord = hCoord(h % 12, m, widthClock / 4);
            Point p2 = new Point(p2Coord[0], p2Coord[1]);
            g.DrawLine(penHour, p1, p2);
        }
        private int[] msCoord(int m, int len)
        {
            int[] coord = new int[2];
            //каждая минута и секунда = 6 градусов
            m *= 6;
            coord[0] = Width / 2 + (int)(len * Math.Sin(Math.PI * m / 180));
            coord[1] = Height / 2 - (int)(len * Math.Cos(Math.PI * m / 180));
            return coord;
        }
        private int[] hCoord(int h, int m, int len)
        {
            int[] coord = new int[2];
            //каждый час = 30 градусов, каждая минута = 0.5 градуса
            int val = (int)((h * 30) + (m * 0.5));
            coord[0] = Width / 2 + (int)(len * Math.Sin(Math.PI * val / 180));
            coord[1] = Height / 2 - (int)(len * Math.Cos(Math.PI * val / 180));
            return coord;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            g.Clear(BackColor);
            ClockFacePaint();
            Second_Paint(s);
            Minute_Paint(m);
            Hour_Paint(h,m);
            pictureBox1.Image = bmp;
            g.Dispose();
        }
    }
}
