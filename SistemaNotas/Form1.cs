using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericPort_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericMat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if(
            MessageBox.Show("Deseja Sair?","Sair do Programa",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            };
        }

        private void numericNota_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double valor;
            valor = (double.Parse(numericPort.Text) + double.Parse(numericMat.Text)) / 2;
            if(valor >= 7)
            {
                labelResultado.Text = "Aprovado";
                labelResultado.ForeColor = Color.Green;
                labelResultado.Location = new Point(190, 215);
            }
            if(valor < 4)
            {
                labelResultado.Text = "Reprovado"; 
                labelResultado.ForeColor = Color.Red;
                labelResultado.Location = new Point(180, 215);
            }
            if (valor >= 4 && valor < 7)
            {
                labelResultado.Text = "Recuperação";
                labelResultado.ForeColor = Color.Gold;
                labelResultado.Location = new Point(170, 214);
            }
            
            labelMedia.Text = valor.ToString();
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            labelResultado.ForeColor = Color.Black;
            numericPort.Value = 0;
            labelMedia.Text = "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMedia_Click(object sender, EventArgs e)
        {

        }
    }
}
