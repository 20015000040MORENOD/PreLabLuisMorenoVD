﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLabLuisMorenoVD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabla1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tabla1.SelectedRows.Count > 0) 
            {
                
                DataGridViewRow Seleccion = Tabla1.SelectedRows[0];
                Seleccion.Cells[0].Value = textBox1.Text;
                Seleccion.Cells[1].Value = textBox2.Text;
                Seleccion.Cells[2].Value = textBox3.Text;
                Seleccion.Cells[3].Value = textBox4.Text;
                Seleccion.Cells[4].Value = textBox5.Text;
                Seleccion.Cells[5].Value = textBox6.Text;
                Seleccion.Cells[6].Value = textBox7.Text;
                Seleccion.Cells[7].Value = textBox8.Text;
                Seleccion.Cells[8].Value = textBox9.Text;
                Seleccion.Cells[9].Value = textBox10.Text;
                Seleccion.Cells[10].Value = textBox11.Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Tabla1.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("¿Desa continuar?", "Se eliminara la fila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    Tabla1.Rows.RemoveAt(Tabla1.SelectedRows[0].Index);
                }
            }
        }    

        private void button4_Click(object sender, EventArgs e)
          {
            Form3 cambio = new Form3();
            cambio.Show();
            this.Hide();
          }
    }
}
