﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Another Hello!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Third Hello!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Fourth Hello!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Fifth Hello!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
