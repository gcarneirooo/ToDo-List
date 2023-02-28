using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butIncluir_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                listBox.Items.Add($"{dateTime.Value:d} - {textBox.Text}");
            }


            else
            {
                MessageBox.Show("Escreva um item");
                textBox.Clear();
            }
        }

        private void butRemover_Click(object sender ,EventArgs e)
        {
            if (listBox.SelectedItem != null)
                listBox.Items.Remove(listBox.SelectedItem);
            else
                MessageBox.Show("Escolha um item na caixa de opções");
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
