﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "9";
        }

        private void ButtonPUNTO_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + ".";
        }
    }
}