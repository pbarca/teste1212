﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace teste1212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> n = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, 51);
                while (n.Contains(tmp));
                n.Add(tmp);
            }
            List<int> s = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, 13);
                while (s.Contains(tmp));
                s.Add(tmp);
            }
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();
            e1.Text = s[0].ToString();
            e2.Text = s[1].ToString();
        }
    }
}
