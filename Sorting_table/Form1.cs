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
using System.Threading;

namespace Sorting_table
{
    public partial class Form1 : Form
    {
        Bubble bubble = new Bubble();
        Shell shell = new Shell();
        QuickSort quick = new QuickSort();
        Stopwatch stopwatch = new Stopwatch();
        RandomArray randomArray = new RandomArray();

        bool quickfin = false;
        bool bubblefin = false;
        bool shellfin = false;

        private void BubbleProgressBar(int x)
        {
            if (InvokeRequired)
            {
                Bubble.Progress progress1 = this.BubbleProgressBar;
                this.Invoke(progress1, x);
            }
            bubbleProgress.Value = x;
        }
        private void ShellProgressBar(int x)
        {
            if (InvokeRequired)
            {
                Shell.Progress progress1 = this.ShellProgressBar;
                this.Invoke(progress1, x);
            }
            shellProgress.Value = x;
        }
        private void QuickProgressBar(int x)
        {
            if (InvokeRequired)
            {
                QuickSort.Progress progress1 = this.QuickProgressBar;
                this.Invoke(progress1, x);
            }
            quickProgress.Value = x;
        }

        public Form1()
        {
            InitializeComponent();
            bubble.progress = BubbleProgressBar;
            shell.progress = ShellProgressBar;
            quick.progress = QuickProgressBar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(sizeArrayBox.SelectedItem);
            int[] arr1 = randomArray.makeArray(n);
            int[] arr2 = new int[n];
            arr1.CopyTo(arr2, 0); //так правильно
            int[] arr3 = new int[n];
            arr1.CopyTo(arr3, 0);

            label3.Text = "";
            label4.Text = "";
            label5.Text = "";


            Thread PuzzThread = new Thread(() => { bubble.DoSorting(arr1); bubblefin = true; });
            Thread ShellThread = new Thread(() => { shell.DoSorting(arr2); shellfin = true; });
            Thread QuickThread = new Thread(() => { quick.DoSorting(arr3, 0, arr3.Length - 1); quickfin = true; });

            timer1.Start();
         
            PuzzThread.Start();
            ShellThread.Start();
            QuickThread.Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //проверяем закончили ли треды и выводим время
            if (bubblefin)
                label3.Text = "finished";
            if (shellfin)
                label4.Text = "finished";
            if (quickfin)
                label5.Text = "finished";
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
