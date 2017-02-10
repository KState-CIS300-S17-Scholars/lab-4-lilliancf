using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxFindPrimeButton_Click(object sender, EventArgs e)
        {
            uxOutput.Text = "";
            int bound = Convert.ToInt32(uxInput.Text);
            SieveList list = new SieveList();
            list.BuildList(bound);
            list.FindPrimes();
            foreach (int num in list)
            {
                uxOutput.Text += num + " ";
            }
        }
    }
}
