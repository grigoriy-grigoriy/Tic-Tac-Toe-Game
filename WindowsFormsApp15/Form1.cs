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

        /// <summary>
        /// Проверка завершения игры 
        /// </summary>
        private void checkFinal()
        {
            string[][] winResults = new string[][]
            {
                new string[] {"00", "01", "02"},
                new string[] {"10", "11", "12"},
                new string[] {"20", "21", "22"},
                new string[] {"00", "10", "20"},
                new string[] {"01", "11", "21"},
                new string[] {"02", "12", "22"},
                new string[] {"00", "11", "22"},
                new string[] {"02", "11", "20"}
            };
            List<string> xValues = new List<string>();
            List<string> OValues = new List<string>();

            foreach (Button but in gamePolePanel.Controls)
            {
                if (but.Text == "X")
                    xValues.Add(but.Name.Replace("Pole_", ""));
                else if (but.Text == "0")
                    OValues.Add(but.Name.Replace("Pole_", ""));
            }
            if (checkWin(winResults, xValues))
            {
                finich = true;
                MessageBox.Show("Победил тот кто играл крестиками!");
                x_Rezultat_Val++;
                updateVinResults();
            }

            else if (checkWin(winResults, OValues))
            {
                finich = true;
                MessageBox.Show("Победил тот кто играл ноликами!");
                o_Rezultat_Val++;
                updateVinResults();
            }
            else if (OValues.Count + xValues.Count == 9)
            {
                finich = true;
                MessageBox.Show("Ничья! попробуем еще");
            }
        }
        /// <summary>
        /// Обновляем значения побед
        /// </summary>
        private void updateVinResults()
        {

            x_Rezultat.Text = x_Rezultat_Val.ToString();
            o_Rezultat.Text = o_Rezultat_Val.ToString();
        }

        /// <summary>
        /// </summary>
        /// <param name="winResults">Выигрышные комбинации</param>
        /// <param name="values">Набранные комбинации</param>
        /// <returns>True - победа</returns>
        private bool checkWin(string[][] winResults, List<string> values)
        {
            bool ex = true;

            for (int i = 0; i < winResults.Length; i++)
            {
                ex = true;
                for (int j = 0; j < winResults[i].Length; j++)
                {
                    ex = ex && values.Contains(winResults[i][j]);
                }
                if (ex)
                    break;
            }

            return ex;
        }


    }
}
