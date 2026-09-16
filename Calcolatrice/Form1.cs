using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        static private Color OPERATION_BG = Color.LightGray;
        static private Color NUMBER_BG = Color.WhiteSmoke;
        static private Color EQUAL_BG = Color.LightSeaGreen;

        public struct btnStruct 
        {
            public char Content;
            public Color BgColor;
            public btnStruct(char content,Color Bgcolor)
            {
                this.Content = content;
                this.BgColor = Bgcolor;
            }
        }
        private btnStruct[,] buttons =
        {


           {new btnStruct('%',OPERATION_BG),new btnStruct('\u0152',OPERATION_BG),new btnStruct('C',OPERATION_BG),new btnStruct('\u232B',OPERATION_BG)},
           {new btnStruct('\u215F', OPERATION_BG),new btnStruct('\u00B2', OPERATION_BG),new btnStruct('\u221A', OPERATION_BG),new btnStruct('\u00F7', OPERATION_BG)      },
           {new btnStruct('7', NUMBER_BG),new btnStruct('8', NUMBER_BG),new btnStruct('9', NUMBER_BG),new btnStruct('x', OPERATION_BG)},
           {new btnStruct('4', NUMBER_BG),new btnStruct('5', NUMBER_BG),new btnStruct('6', NUMBER_BG),  new btnStruct('-', OPERATION_BG)    },
           {new btnStruct('1', NUMBER_BG),new btnStruct('2', NUMBER_BG),new btnStruct('3', NUMBER_BG),new btnStruct('+', OPERATION_BG)},
           {new btnStruct('\u00B1', NUMBER_BG),new btnStruct('0', NUMBER_BG),new btnStruct(',', NUMBER_BG),new btnStruct('=', EQUAL_BG)},


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
                    btn.Text=buttons[i,j].Content.ToString();
                    btn.BackColor = buttons[i, j].BgColor;
                    Controls.Add(btn);
                    posx+= btnWidth;
                }
                posY += btnHeight;
            }
        }
    }
}
