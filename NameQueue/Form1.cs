using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameQueue
{
    public partial class Form1 : Form
    {
        Queue queue = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                if (!queue.IsFull())
                {
                    queue.Enqueue(inputBox.Text);
                    actionLabel.Text = "Enqueued: " + inputBox.Text;
                }
                else
                    actionLabel.Text = "Could not enqueue as queue is full";
            }
            else
                actionLabel.Text = "Could not enqueue as field is empty";
        }

        private void peekButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Peek Value: " + queue.Peek();
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = "Dequeued: " + queue.Dequeue();
        }

        private void printListButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Current Queue: " + queue.PrintValues();
        }

        private void lengthButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Itmes in Queue: " + queue.GetLength();
        }
    }
}
