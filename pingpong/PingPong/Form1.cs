using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmPong : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int Score = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //versteckt den Cursor
            Cursor.Hide();

            //entfernt alle Rahmen
            this.FormBorderStyle = FormBorderStyle.None;
            //Form wird an erster stelle platziert
            this.TopMost = true;
            //Vollbild
            this.Bounds = Screen.PrimaryScreen.Bounds;
            //platzierung des Schlägers
            Schläger.Left = pnlSpiel.Left - (pnlSpiel.Left / 10);
            
            txtPunkte.Text = Convert.ToString(Score);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //mitte vom Schläger
            Schläger.Left = Cursor.Position.X - (Schläger.Height / 2);
            picBall.Left += speed_left;
            picBall.Top += speed_top;

            //Schläger kollision
            if (picBall.Bottom >= Schläger.Top && picBall.Bottom <= Schläger.Bottom && picBall.Left >= Schläger.Left && picBall.Right <= Schläger.Right )
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                Score += 10;
            }

            if (picBall.Left <= pnlSpiel.Left)
            {
                timer1.Enabled = false;
            }

            if (picBall.Right >= pnlSpiel.Right)
            {
                speed_left = -speed_left;
            }

            if (picBall.Top <= pnlSpiel.Top)
            {
                speed_top = -speed_top;
            }

            if (picBall.Bottom >= pnlSpiel.Bottom)
            {
                speed_left = -speed_left;
            }
        }


        private void frmPong_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Escape)
            {
                //escape drücken zum beenden
                this.Close();
            }
        }

      
    }
}
