using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SearchAndSortAlgorithms
{
    public partial class Form1 : Form
    {

        int[] array = new int[6];
        int searchval;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchval = Convert.ToInt32(textBox1.Text);
            int min = 0;
            int max = array.Length + 1;
            int mid = ((min + max + 1) / 2);
            int index = -1;

            do
            {
                if (searchval == array[mid])
                {
                    index = mid;
                    label_Yes.Text += "\n" + searchval.ToString() + " was found at position " + index.ToString();
                }
                else if (searchval < array[mid])
                {
                    max = mid - 1;
                }
                else if (searchval > array[mid])
                {
                    min = min + 1;
                }
                mid = ((min + max + 1) / 2);
            } while ((min <= max) && (index == -1));
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index;
            int min;
            int temp;
            int smallestindex;
            for (index = 0; index < array.Length; index++)
            {
                smallestindex = index;
                for(min = index; min < array.Length; min++)
                {
                    if(array[min] < array[smallestindex])
                    {
                        smallestindex = min;
                    }
                }
                temp = array[smallestindex];
                array[smallestindex] = array[index];
                array[index] = temp;
                label_Yes.Text += "\n";
                foreach (int num in array)
                {
                    label_Yes.Text += num.ToString() + " ";
                }
            }
            label_Yes.Text += "\n" + "Sorted: ";
            for (int ii = 0; ii < array.Length; ii++)
            {
                label_Yes.Text += array[ii].ToString() + " ";
            }
        }

        private void button_InsertSort_Click(object sender, EventArgs e)
        {
            int index = 0;
            int temp;
            for(int ii = 1; ii <= array.Length - 1 ; ii++)
            {
                temp = array[ii];
                index = ii - 1;
                while (index >= 0 && array[index] > temp)
                {
                    array[index + 1] = array[index];
                    index--;
                }
                array[index + 1] = temp;
                label_Yes.Text += "\n";
                for(int iii = 0; iii < array.Length; iii++)
                {
                    label_Yes.Text += array[iii] + " ";
                }
                index++;
            }

            label_Yes.Text += "\n" + "Sorted: ";
            for (int iii = 0; iii < array.Length; iii++)
            {
                label_Yes.Text += array[iii] + " ";
            }
        }

        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            MergeSort(array, 0, array.Length - 1);
            label_Yes.Text += "\n" + "Sorted: ";
            for (int ii = 0; ii < array.Length; ii++)
            {
                label_Yes.Text += array[ii].ToString() + " ";
            }
        }

        private void Merge(int[] input, int left, int right, int middle)
        {

            int temp;

            for(int ii = middle + 1; ii <= right; ii++)
            {
                for(int kk = ii - 1; kk >= left; kk--)
                {
                    if(input[kk] > input[kk + 1])
                    {
                        temp = input[kk];
                        input[kk] = input[kk + 1];
                        input[kk + 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                    label_Yes.Text += "\n";
                    for (int bb = 0; bb < array.Length; bb++)
                    {
                        label_Yes.Text += array[bb].ToString() + " ";
                    }
                }
            }
        }

        private void MergeSort(int[] input, int left, int right)
        {
            if (left == right)
            {
                return;
            }
            int middle = (left + right) / 2;
            MergeSort(input, left, middle);
            MergeSort(input, middle + 1, right);
            Merge(input, left, right, middle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random gen = new Random();
            for (int ii = 0; ii < array.Length; ii++)
            {
                array[ii] = gen.Next(0, 100);
            }
            for(int ii = 0; ii < array.Length; ii++)
            {
                label_Yes.Text += " " + array[ii];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random gen = new Random();
            for (int ii = 0; ii < array.Length; ii++)
            {
                array[ii] = gen.Next(0, 100);
            }
            label_Yes.Text += "\n";
            for (int ii = 0; ii < array.Length; ii++)
            {
                label_Yes.Text += " " + array[ii];
            }
        }
    }
}
