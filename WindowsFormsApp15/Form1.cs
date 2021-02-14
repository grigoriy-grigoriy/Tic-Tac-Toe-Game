using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        private bool Comp1;

        private bool start;

        private bool finich;

        private Random r;

        private int x_Rezultat_Val;

        private int o_Rezultat_Val;


        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            x_Rezultat_Val = o_Rezultat_Val = 0;
            r = new Random();
            finich = false;
            start = false;
            Comp1 = false;
            InitButtonsEvents();
        }

        private void InitButtonsEvents()
        {
            foreach (Button but in gamePolePanel.Controls)
                but.Click += But_Click;
        }

        private void But_Click(object sender, EventArgs e)
        {
            if (!finich)
            {
                Button but = (Button)sender;
                setButtonValue(but);
                checkFinal();
                if (!finich && Comp1)
                    cpuWork();
            }
        }

        private void startVsPlayer_Click(object sender, EventArgs e)
        {
            clearGameField();
            Comp1 = false;
            finich = false;
            start = false;
        }


        private void startVsCpu_Click(object sender, EventArgs e)
        {
            clearGameField();
            Comp1 = true;
            finich = false;
            start = false;
        }

        private void clearGameField()
        {
            foreach (Button but in gamePolePanel.Controls)
            {
                but.Text = "";
                but.ForeColor = Color.Black;
            }
        }

        /// <param name="but"> для обработки</param>
        private void setButtonValue(Button but)
        {
            if (but.Text.Length > 0)
                MessageBox.Show("Сюда нельзя! :)");
            else
            {
                if (start)
                {
                    but.Text = "X";
                    but.ForeColor = Color.Blue;
                }
                else
                {
                    but.Text = "0";
                    but.ForeColor = Color.Red;
                }
                start = !start;
            }
        }


    }
}
