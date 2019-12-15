using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akinator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            button1.Text = "Начать игру";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        int step = 0;


        void game()
        {
            if (step == 0)
            {
                textBox1.Visible = true;
                label1.Visible = true;
                pictureBox1.Visible = false;
                label1.Text = "Введи 'да' или 'нет'";

                richTextBox1.Text = "Этот персонаж девочка?\nНужно ответить 'Да' или 'Нет'";
                button1.Text = "Следующий вопрос!";
                step++;
            }
            else if (step == 1)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Я знаю персоножа которого ты загадал!\n Это Венди!!";
                    pictureBox1.Image = Properties.Resources._267px_Wendy_sp;
                    pictureBox1.Visible = true;
                    step = 6;

                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Этот персонаж всегда в капюшоне?\nНужно ответить 'Да' или 'Нет'";
                    step++;
                }
            }
            else if (step == 2)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Я знаю кого ты загадал!\nЭто Кенни.\nО боже нет! Они убили Кенни!!\nСВОЛОЧИ!!!";
                    pictureBox1.Image = Properties.Resources.kenny;
                    pictureBox1.Visible = true;
                    step = 6;
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Этот персонаж толстый?\nНужно ответить 'Да' или 'Нет'";
                    step++;
                }
            }
            else if (step == 3)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Я знаю персонажа которого ты загадал!\nЭто Картман!!!";
                    pictureBox1.Image = Properties.Resources._274px_Cartman_sp;
                    pictureBox1.Visible = true;
                    step = 6;
                }
                else if (textBox1.Text.ToLower() == "нет")

                {
                    richTextBox1.Text = "Этот персонаж еврей?\nНужно написать 'Да' или 'Нет'";
                    step++;
                }
            }
            else if (step == 4)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Я знаю персонажа которого ты загадал!\nЭто Кайл!!";
                    pictureBox1.Image = Properties.Resources._274px_Kyle2;
                    pictureBox1.Visible = true;
                    step = 6;
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Я знаю персонажа которого ты загадал!\nЭто Стэн!!!";
                    pictureBox1.Image = Properties.Resources.StanMarsh;
                    pictureBox1.Visible = true;
                    step = 6;
                }
            }

            else if (step == 6)
            {
                step = 0;
                button1.PerformClick();
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            game();
        }
    }
}

