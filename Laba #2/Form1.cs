﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba__2
{
    public partial class Form1 : Form
    {
        const int n = 10000000;
        int[] arr = new int[n];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int StartTime = Environment.TickCount;
            {
                Random rnd = new Random();
                for (int i = 0; i < n; i++) arr[i] = rnd.Next(0, n);
            }

            int ResultTime = Environment.TickCount - StartTime;
            textBox_time_NeOptim.Text = ResultTime.ToString();
        }
        private void button_left_Click(object sender, EventArgs e)
        {
            int key = (int)input_key_NeOptim.Value;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == key)
                {
                    textBox_index_NeOptim.Text = i.ToString();
                    break;
                }
            }
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
