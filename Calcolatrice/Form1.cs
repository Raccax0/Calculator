using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        private char[,] buttons =
        {
            {'%','\u0152','C','\u232B'},
            {'\u215F','\u00B2','\u221A','\u00F7'},
            {'7','8','9','x'},
            {'4','5','6','-'},
            {'1','2','3','+'},
            {'\u00B1','0',',','='},

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeButtons();
        }

        private void MakeButtons()
        {
            int btnWidth = 80,btnHeight = 60;
            int posY = 106;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                int posx = 0;
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Width=btnWidth;
                    btn.Height=btnHeight;
                    btn.Top=posY;
                    btn.Left=posx;
                    btn.Font = new Font("Segoe UI",16);
                    btn.Text=buttons[i,j].ToString();
                    Controls.Add(btn);
                    posx+= btnWidth;
                }
                posY += btnHeight;
            }
        }
    }
}
