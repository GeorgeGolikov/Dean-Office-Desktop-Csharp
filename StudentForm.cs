﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project
{
    public partial class StudentForm : Form
    {
        private string userID;
        private string userFIO;

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(string userID, string userFIO)
        {
            InitializeComponent();

            this.userID = userID;
            this.userFIO = userFIO;
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void dataGrid1_Navigate_1(object sender, NavigateEventArgs ne)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
