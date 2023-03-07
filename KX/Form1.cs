﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        bool player1 = true;
        int number = 0;
        char znak1;
        char znak2;
        string name1;
        string name2;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Check()
        #region Sprawdzanie
        {
            if (button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                Win();
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button4.Text == button6.Text)
            {
                Win();
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                Win();
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text)
            {
                Win();
            }
            else if (button2.Text != "" && button2.Text == button6.Text && button2.Text == button8.Text)
            {
                Win();
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text)
            {
                Win();
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text)
            {
                Win();
            }
            else if (button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text)
            {
                Win();
            }
            else if(number == 9)
            {
                MessageBox.Show("REMIS!","Koniec Gry",MessageBoxButtons.OK);
                RemisNum.Text = ((int.Parse(RemisNum.Text)) + 1).ToString();
                Button[] all = new Button[9];
                all[0] = button1;
                all[1] = button2;
                all[2] = button3;
                all[3] = button4;
                all[4] = button5;
                all[5] = button6;
                all[6] = button7;
                all[7] = button8;
                all[8] = button9;

                foreach (Button b in all)
                {
                    b.Enabled = true;
                    b.Text = "";
                }
                number = 0;
            }
            #endregion
        }
        #region Wygrana
        private void Win()
        {
            MessageBox.Show("Wygrywa gracz: " + (player1 ? $"{znak1}" : $"{znak2}"), "Wygrana",MessageBoxButtons.OK);
            if (player1)
            {
                Punkt_1.Text = ((int.Parse(Punkt_1.Text)) + 1).ToString();
            }
            else
            {
                Punkt_2.Text = ((int.Parse(Punkt_2.Text)) + 1).ToString();
            }
            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;

            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
           number = 0;
            #endregion
        }
        #region Resetowanie
        public void Reset()
        {
            number = 0;
            znak1 = ' ';
            znak2 = ' ';
            name1 = "";
            name2 = "";


            ResetBtn.Enabled = false;
            NewGameBtn.Enabled = true;
            Char_1.Enabled = true;
            Char_2.Enabled = true;
            Name_1.Enabled = true;
            Name_2.Enabled = true;

            Punkt_1.Text = "0";
            Punkt_2.Text = "0";
            RemisNum.Text = "0";

            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;

            foreach(Button b in all)
            {
                b.Enabled = false;
                b.Text = "";
            }
            #endregion
        }
        #region Nowa gra
        public void NewGame()
        {
            ResetBtn.Enabled = true;
            NewGameBtn.Enabled = false;
            player1 = true;
            Name_1.Enabled = false;
            Name_2.Enabled = false;
            Char_1.Enabled = false;
            Char_2.Enabled = false;
            

            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;

            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }

            try
            {
                znak1 = Convert.ToChar(Char_1.Text);
                znak2 = Convert.ToChar(Char_2.Text);
                name1 = Name_1.Text;
                name2 = Name_2.Text;
                
            }
            catch
            {
                Reset();
                MessageBox.Show("Zostały wpisane błędne znaki!");
            }
            if(znak1 == znak2)
            {
                Reset();
                MessageBox.Show("Nie mogą być takie same znaki!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Char_1.Text = String.Empty;
            Char_2.Text = String.Empty;
            Name_1.Text = String.Empty;
            Name_2.Text = String.Empty;
            #endregion
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        #region Button 1-9
        private void button1_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if(number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number++;
            ((Button)sender).Text = player1 ? $"{znak1}" : $"{znak2}";
            ((Button)sender).Enabled = false;
            if (number >= 5)
            {
                Check();
            }
            player1 = !player1;
        }
        #endregion
    }
}
