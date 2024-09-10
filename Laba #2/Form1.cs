using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            int key = (int)input_key_NeOptim.Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 10000000;
            int[] arr = new int[n];

            int StartTime = Environment.TickCount;
            {
                Random rnd = new Random();
                for (int i = 0; i < n; i++) arr[i] = rnd.Next(0, n);
            }

            int ResultTime = Environment.TickCount - StartTime;
            textBox_time_NeOptim.Text = ResultTime.ToString();
        }
    }
}
