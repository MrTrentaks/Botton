﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кнопочки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Text = textBox1.Text + "Оранжевый";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Text = textBox1.Text + "Красный";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Text = textBox1.Text + "Синий";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Text = textBox1.Text + "Жёлтый";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Text = textBox1.Text + "Фиолетоый";

        }
    }
}
