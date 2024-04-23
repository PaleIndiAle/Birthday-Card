using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthday_Card
{
    public partial class Form1 : Form
    {
        // Kids Cheer MP3
        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Cheer);

        //Start coordinates of all animated assets
        int conY = 500;
        int conX = 400;
        int conY2 = 500;
        int conX2 = -80;
        public Form1()
        {
            InitializeComponent();
        }

        // Upon Start show a cake, birthday candle, text "Cake?"
        private void Form1_Shown(object sender, EventArgs e)
        {
            // Every font and color used here
            Graphics g = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White, 10);
            Pen whitePen2 = new Pen(Color.White, 2);
            Pen cocoPen = new Pen(Color.Chocolate, 10);
            Pen blackPen = new Pen(Color.Black, 5);
            Pen redPen = new Pen(Color.Red, 2);
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush cocoBrush = new SolidBrush(Color.Chocolate);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // Background color
            g.Clear(Color.Tan);

            // Cake
            g.DrawRectangle(cocoPen, 110, 200, 192, 100);
            g.FillRectangle(cocoBrush, 110, 200, 192, 100);
            g.DrawEllipse(cocoPen, 108, 245, 194, 100);
            g.FillEllipse(cocoBrush, 108, 245, 194, 100);
            g.DrawEllipse(whitePen, 105, 140, 200, 140);
            g.FillEllipse(whiteBrush, 105, 140, 200, 140);
            g.DrawEllipse(whitePen2, 120, 200, 20, 20);
            g.FillEllipse(redBrush, 120, 200, 20, 20);
            g.DrawEllipse(whitePen2, 170, 170, 20, 20);
            g.FillEllipse(redBrush, 170, 170, 20, 20);
            g.DrawEllipse(whitePen2, 250, 170, 20, 20);
            g.FillEllipse(redBrush, 250, 170, 20, 20);
            g.DrawEllipse(whitePen2, 250, 220, 20, 20);
            g.FillEllipse(redBrush, 250, 220, 20, 20);
            g.DrawEllipse(whitePen2, 170, 240, 20, 20);
            g.FillEllipse(redBrush, 170, 240, 20, 20);

            // Candle
            g.DrawPie(redPen, 190, 120, 40, 40, 50, 80);
            g.FillPie(redBrush, 190, 120, 40, 40, 50, 80);
            g.DrawRectangle(blackPen, 200, 160, 20, 60);
            g.FillRectangle(whiteBrush, 200, 160, 20, 60);

            // "Cake? CAKE??? IS THAT CAKE????" text
            g.DrawString("Cake?", drawFont, whiteBrush, 145, 290);
        }

        // Upon Click slide up a "Happy Birthday" and three party poppers
        private void Form1_Click(object sender, EventArgs e)
        {
            // Every font and color used here
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen redPen = new Pen(Color.Red, 2);
            Pen bluePen = new Pen(Color.Blue, 2);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            // Background Color
            g.Clear(Color.Tan);

            // Slide up "Happy Birthday"
            while (conY > 190)
            {
                g.Clear(Color.Tan);
                conY = conY - 3;
                g.DrawString("Happy Birthday!", drawFont, blackBrush, 50, conY);
                Thread.Sleep(5);
            }

            // Slide up three party popppers individually
            if (conY <= 190)
            {
                while (conX > 280)
                {
                    g.Clear(Color.Tan);
                    conX = conX - 3;
                    g.DrawString("Happy Birthday!", drawFont, blackBrush, 50, conY);
                    g.DrawPie(redPen, conX, 320, 140, 160, 220, 60);
                    g.FillPie(blueBrush, conX, 320, 140, 160, 220, 60);
                    Thread.Sleep(5);
                }
                while (conY2 > 340)
                {
                    g.Clear(Color.Tan);
                    conY2 = conY2 - 3;
                    g.DrawString("Happy Birthday!", drawFont, blackBrush, 50, conY);
                    g.DrawPie(redPen, conX, 320, 140, 160, 220, 60);
                    g.FillPie(blueBrush, conX, 320, 140, 160, 220, 60);
                    g.DrawPie(redPen, 130, conY2, 140, 160, 240, 60);
                    g.FillPie(blueBrush, 130, conY2, 140, 160, 240, 60);
                    Thread.Sleep(5);
                }
                while (conX2 < -20)
                {
                    g.Clear(Color.Tan);
                    conX2 = conX2 + 3;
                    g.DrawString("Happy Birthday!", drawFont, blackBrush, 50, conY);
                    g.DrawPie(redPen, conX, 320, 140, 160, 220, 60);
                    g.FillPie(blueBrush, conX, 320, 140, 160, 220, 60);
                    g.DrawPie(redPen, 130, conY2, 140, 160, 240, 60);
                    g.FillPie(blueBrush, 130, conY2, 140, 160, 240, 60);
                    g.DrawPie(redPen, conX2, 320, 140, 160, 270, 60);
                    g.FillPie(blueBrush, conX2, 320, 140, 160, 270, 60);
                    Thread.Sleep(5);
                }
                // Play a cheering SFX
                soundPlayer.Play();
            }
        }
    }
}
