using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_table
{
    public partial class Form1 : Form
    {
        Bubble bubble = new Bubble();
        Shell shell = new Shell();
        RandomArray randomArray = new RandomArray();
        
        public Form1()
        {
            InitializeComponent();
            int n = Convert.ToInt32(sizeArrayBox.SelectedItem);
            int[] arr1 = randomArray.makeArray(n);
            int[] arr2 = randomArray.makeArray(n);
            int[] arr3 = randomArray.makeArray(n);
            bubble.DoSorting(arr1);
            for(int i = 0; i < n; i++)
            {
                textBox1.Text = textBox1.Text + Environment.NewLine + arr1[i];
            }
            shell.DoSorting(arr2);
            for (int i = 0; i < n; i++)
            {
                textBox2.Text = textBox2.Text + Environment.NewLine + arr2[i];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
