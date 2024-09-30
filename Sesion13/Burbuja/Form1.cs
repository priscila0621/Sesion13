﻿using System;
using System.Windows.Forms;
using Burbuja.operaciones;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            numbers[i++] = number;
            ShowNumbers();
        }
        private void ShowNumbers()
        {
            if (numbers.Length > 0)
            {
                lbNumbers.Items.Clear();
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                lbNumbers.Items.Add(numbers[i]);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MetBurbuja burbuja = new MetBurbuja();
            burbuja.OrdenarBurbuja(numbers);
            ShowNumbers();
        }
    }
}
