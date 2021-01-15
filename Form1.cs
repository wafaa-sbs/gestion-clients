﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestion_clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-OEO7RV6\MSSQLSERVER01;Initial Catalog=gestion_client;Integrated Security=True");
        DataSet DS = new DataSet();      
        SqlDataAdapter DA;
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataTable dtclient;
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            try
            {
                DA = new SqlDataAdapter("Select * from clients", cnx);
                
                DA.Fill(DS, "clients");
                dtclient = DS.Tables["clients"];
                
                dataGridView1.DataSource = DS.Tables["clients"];
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow r = dtclient.NewRow();
            r[0] = id.Text;
            r[1] = name.Text;
            r[2] = lastname.Text;
            r[3] = adresse.Text;
            r[4] = ville.Text;
            dtclient.Rows.Add(r);
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = getIndice();
            dtclient.Rows[a][1] = name.Text;
            dtclient.Rows[a][2] = lastname.Text;
            dtclient.Rows[a][3] = adresse.Text;
            dtclient.Rows[a][4] = ville.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                adresse.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                ville.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                
            }
            catch (Exception)
            {

            }
        }


        //int Id;
        int getIndice()
        {
            int indice = 0;
           
            try
            {

                for (int i = 0; i < dtclient.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtclient.Rows[i][0]) == Convert.ToInt32(id.Text))
                    {
                        indice = i;
                    }
                }

            }
            catch (Exception)
            {
                
            }
            return indice;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            int b = getIndice();
            dtclient = DS.Tables["clients"];
            dtclient.Rows[b].Delete();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(DA);
            DA.Update(DS, "clients");
        }

        private void btn_trie_Click(object sender, EventArgs e)
        {
            DA = new SqlDataAdapter("Select * from clients where ville ='" + cbville.Text + "'", cnx);
            DA.Fill(DS, "clients");
            dataGridView1.DataSource = DS.Tables["clients"];
        }

        private void combo_villes_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                int cville = Convert.ToInt32(combo_villes.SelectedValue);
                dv.RowFilter = "villes=" + cville;
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {

            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbville.Text.Length != 0)
            {
                DA = new SqlDataAdapter("Select * from clients where ville ='" + cbville.Text + "'", cnx);
                DS.Tables["clients"].Clear();
                DA.Fill(DS, "clients");
                dataGridView1.DataSource = DS.Tables["clients"];
            }
            /*else if (txt_chercher.Text.Length != 0)
            {

                DA = new SqlDataAdapter("SELECT * FROM clients WHERE nom = '" + txt_chercher.Text + "'", cnx);
                DS.Tables["clients"].Clear();
                DA.Fill(DS, "clients");
                dataGridView1.DataSource = DS.Tables["clients"];
            }*/
        }
    }
}
