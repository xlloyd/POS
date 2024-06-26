﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FormCategoryAdd : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]    //ROUND CORNER
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public FormCategoryAdd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCategoryAdd_Load(object sender, EventArgs e)
        {

        }
         public int id = 0;
        private void guna2Button2Save_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where CatID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Save successfully...");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}

