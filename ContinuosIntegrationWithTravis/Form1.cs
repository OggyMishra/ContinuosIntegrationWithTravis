using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContinuosIntegrationWithTravis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getrandom = new Random();
            label1.Text = GetRandomNumber(10, 1000, getrandom).ToString();
        }

        public static int GetRandomNumber(int min, int max, Random getrandom)
        {
            Console.Write("dhoom");
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
            
        }

        private Random getrandom;
        private static readonly object syncLock = new object();
        
    }
}
