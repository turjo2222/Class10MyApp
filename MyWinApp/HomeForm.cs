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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helo "+ nameTextBox.Text+ " " + itemComboBox.Text);
            showTextBox.Text = "Helo " + nameTextBox.Text + " " + itemComboBox.Text;
        }
    }
}
