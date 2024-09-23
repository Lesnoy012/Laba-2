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
        const int N = 100;
        int[] unsortedArray = new int[N + 1];
        int[] sortedArray = new int[N + 1];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++) sortedArray[i] = unsortedArray[i] = rnd.Next(1, N);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - 1; j++) 
                { 
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        int temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temp;
                    }
                }
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            int key = (int)input_key_NeOptim.Value;
            int indexNeOptimFind = 0;
            int StartTimeNeOptim = Environment.TickCount;
            {
                while (unsortedArray[indexNeOptimFind] != key && indexNeOptimFind != N)
                {
                    indexNeOptimFind++;
                }

                if (indexNeOptimFind != N)
                {
                    textBox_index_NeOptim.Text = indexNeOptimFind.ToString();
                }
                else
                {
                    textBox_index_NeOptim.Text = "Ключ не найден";
                }
            }
            int ResultTimeNeOptim = Environment.TickCount - StartTimeNeOptim;
            textBox_time_NeOptim.Text = ResultTimeNeOptim.ToString();


            unsortedArray[N] = key;
            int indexOptimFind = 0;
            int StartTimeOptim = Environment.TickCount;
            {
                while (unsortedArray[indexOptimFind] != key)
                {
                    indexOptimFind++;
                }

                if (indexOptimFind != N)
                {
                    textBox_index_Optim.Text = indexOptimFind.ToString();

                }
                else
                {
                    textBox_index_Optim.Text = "Ключ не найден";

                }
            }
            int ResultTimeOptim = Environment.TickCount - StartTimeOptim;
            textBox_time_Optim.Text = ResultTimeOptim.ToString();

        }

        private void button_right_Click(object sender, EventArgs e)
        {
            //Неотсортированный массив
            int key = (int)input_key_sorted.Value;
            unsortedArray[N] = key;
            int indexUnsortedArray = 0;
            int StartTimeUnsorted = Environment.TickCount;
            {
                while (unsortedArray[indexUnsortedArray] != key)
                {
                    indexUnsortedArray++;
                }

                if (indexUnsortedArray != N)
                {
                    textBox_index_unsorted.Text = indexUnsortedArray.ToString();
                }
                else
                {
                    textBox_index_unsorted.Text = "Ключ не найден";

                }
            }
            int ResultTimeUnsorted = Environment.TickCount - StartTimeUnsorted;
            textBox_time_unsorted.Text = ResultTimeUnsorted.ToString();


            //Сортированный массив
            sortedArray[N] = key + 1;
            int indexSortedArray = 0;
            int StartTimeSorted = Environment.TickCount;
            {
                while (sortedArray[indexSortedArray] < key)
                {
                    indexSortedArray++;
                }

                if (sortedArray[indexSortedArray] == key)
                {
                    textBox_index_sorted.Text = indexSortedArray.ToString();
                }
                else
                {
                    textBox_index_sorted.Text = "Ключ не найден";
                }
            }
            int ResultTimeSorted = Environment.TickCount - StartTimeSorted;
            textBox_time_sorted.Text = ResultTimeSorted.ToString();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
