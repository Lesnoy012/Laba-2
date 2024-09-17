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
        const int N = 300000000;
        int? indexNeOptim = null;
        int? indexOptim = null;
        int[] arr = new int[N+1];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++) arr[i] = rnd.Next(0, N - 1);
        }
        private void button_left_Click(object sender, EventArgs e) 
        {
            int key = (int)input_key_NeOptim.Value;

            int StartTimeNeOptim = Environment.TickCount;
            {
                for (int i = 0; i < N; i++)
                {
                    if (arr[i] == key)
                    {
                        indexNeOptim = i;
                        break;
                    }
                }
            }
            int ResultTimeNeOptim = Environment.TickCount - StartTimeNeOptim;
            textBox_time_NeOptim.Text = ResultTimeNeOptim.ToString();

            if (indexNeOptim == null)
            {
                textBox_index_NeOptim.Text = "Элемент не найден";
            }
            else
            {
                textBox_index_NeOptim.Text = indexNeOptim.ToString();
            }


            arr[N] = key;
            int StartTimeOptim = Environment.TickCount;
            {
                for (int i = 0;;)
                {
                    if (arr[i] == key)
                    {
                        if (i == N)
                        {
                            break;
                        }
                        else
                        {
                            indexOptim = i;
                            break;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            int ResultTimeOptim = Environment.TickCount - StartTimeOptim;
            textBox_time_Optim.Text = ResultTimeOptim.ToString();

            if (indexOptim == null)
            {
                textBox_index_Optim.Text = "Элемент не найден";
            }
            else
            {
                textBox_index_Optim.Text = indexOptim.ToString();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
