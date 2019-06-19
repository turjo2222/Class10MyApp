﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class ListForm : Form
    {
        List<int> numbers = new List<int>();
        List<string> names = new List<string>();
        public ListForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

            numbers.Add(Convert.ToInt32(numberTextBox.Text));
            names.Add(nameTextBox.Text);
           

            string message = "For\n";
            for (int i = 0; i < numbers.Count; i++)
            {
                message = message +names[i] + " "+ numbers[i] + "\n";
            }

            message = message + "Foreach\n";
            int index = 0;
            foreach (int number in numbers)
            {
                message = message +names[index] +" "+ number + "\n";
                index++;
            }
            showRichTextBox.Text = message;

        }
    }
}
