﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSISP_TASK_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string resultNumber = "";
            for(int i = 0; i < 4; i++)
            {
                resultNumber += random.Next(0, 10);
            }
            randomNumbersLabel.Text = resultNumber;
        }
    }
}
