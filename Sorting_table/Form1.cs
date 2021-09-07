using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sorting_table
{
    public partial class Form1 : Form
    {
        Bubble bubble = new Bubble();
        Shell shell = new Shell();
        QuickSort quick = new QuickSort();
        Stopwatch stopwatch = new Stopwatch();
        RandomArray randomArray = new RandomArray();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(sizeArrayBox.SelectedItem);
            int[] arr1 = randomArray.makeArray(n);
            int[] arr2 = arr1;
            int[] arr3 = arr1;

            stopwatch.Restart();
            bubble.DoSorting(arr1);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            /*for (int i = 0; i < n; i++)
            {
                textBox1.Text = textBox1.Text + Environment.NewLine + arr1[i];
            }*/
            label3.Text = Convert.ToString(ts.TotalMilliseconds) + " ms";

            stopwatch.Restart();
            shell.DoSorting(arr2);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            /*for (int i = 0; i < n; i++)
            {
                textBox2.Text = textBox2.Text + Environment.NewLine + arr2[i];
            }*/
            label4.Text = Convert.ToString(ts.TotalMilliseconds) + " ms";

            stopwatch.Restart();
            quick.DoSorting(arr3, 0, arr3.Length / 2);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            /*for (int i = 0; i < n; i++)
            {
                textBox3.Text = textBox3.Text + Environment.NewLine + arr3[i];
            }*/
            label5.Text = Convert.ToString(ts.TotalMilliseconds) + " ms";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
