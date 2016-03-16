using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace StopWatchTask
{
    public partial class TaskTracker : Form
    {

        Stopwatch watch = new Stopwatch();
        public TaskTracker()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rajiv", "Task Tracker");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Start") {
                Start.Text = "Stop";
                Start.BackColor = Color.Red;
                watch.Start();
            }
            else if (Start.Text == "Stop") {
                Start.Text = "Start";
                Start.BackColor = Color.GreenYellow;
                watch.Stop();
            }
            textBox1.Text = "" + watch.Elapsed;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }
    }
}
