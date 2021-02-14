using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // ------------------------------------

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 450);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);
            this.PerformLayout();
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.gamePolePanel = new System.Windows.Forms.Panel();
            this.Pole_22 = new System.Windows.Forms.Button();
            this.Pole_12 = new System.Windows.Forms.Button();
            this.Pole_02 = new System.Windows.Forms.Button();
            this.Pole_21 = new System.Windows.Forms.Button();
            this.Pole_11 = new System.Windows.Forms.Button();
            this.Pole_01 = new System.Windows.Forms.Button();
            this.Pole_20 = new System.Windows.Forms.Button();
            this.Pole_10 = new System.Windows.Forms.Button();
            this.Pole_00 = new System.Windows.Forms.Button();
            this.startVsPlayer = new System.Windows.Forms.Button();
            this.start_comp = new System.Windows.Forms.Button();
            this.x_Rezultat_Label = new System.Windows.Forms.Label();
            this.o_Rezultat_Label = new System.Windows.Forms.Label();
            this.x_Rezultat = new System.Windows.Forms.Label();
            this.o_Rezultat = new System.Windows.Forms.Label();
            this.gamePolePanel.SuspendLayout();
            this.SuspendLayout();
            // ----------------------------------------

            this.gamePolePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePolePanel.Controls.Add(this.Pole_22);
            this.gamePolePanel.Controls.Add(this.Pole_12);
            this.gamePolePanel.Controls.Add(this.Pole_02);
            this.gamePolePanel.Controls.Add(this.Pole_21);
            this.gamePolePanel.Controls.Add(this.Pole_11);
            this.gamePolePanel.Controls.Add(this.Pole_01);
            this.gamePolePanel.Controls.Add(this.Pole_20);
            this.gamePolePanel.Controls.Add(this.Pole_10);
            this.gamePolePanel.Controls.Add(this.Pole_00);
            this.gamePolePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePolePanel.Name = "gamePolePanel";
            this.gamePolePanel.Size = new System.Drawing.Size(200, 194);
            this.gamePolePanel.TabIndex = 0;
            // ----------------------------------------
            this.box = new TextBox();
            box.Location = new Point(260, 20);
            box.Size = new Size(300, 80);
            box.Multiline = true;
            box.ScrollBars = ScrollBars.Both;
            box.BorderStyle = BorderStyle.None;

            box.Text = "           Вас приветствует игра крестики нолики. Сюда можете записывать результаты";



        }
    }

}