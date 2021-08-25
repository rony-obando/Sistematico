using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estudiantes;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        public Estudiante1 estudiante;
        public int[] Tnotas = {0,0,0,0,0,0};
        
        public Form1()
        {
            estudiante = new Estudiante1();
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            string nombres, carnet, apellidos;
            nombres=TxBNombres.Text;
            apellidos = TxBApellidos.Text;
            carnet = TxBCarnet.Text;
            estudiante.Nombres = nombres;
            estudiante.Apellidos = apellidos;
            estudiante.Carnet = carnet;
            double promedio = 0;
            for(int i = 0; i < Tnotas.Length; i++)
            {
                promedio = promedio+Tnotas[i];
            }
            promedio = promedio / 6;
            MessageBox.Show($@" Carnet: {TxBCarnet.Text}{Environment.NewLine}
Nombres: {TxBCarnet.Text}{Environment.NewLine}
Apellidos: {TxBApellidos.Text}{Environment.NewLine}
Promedio: {promedio}");
        }
        public int a = 0;
        private void TxBNotas_KeyDown(object sender, KeyEventArgs e)
        {
            int notas;
            if (Keys.Enter == e.KeyCode)
            {
                if (string.IsNullOrWhiteSpace(TxBNotas.Text))
                {
                    MessageBox.Show("Error,No puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!int.TryParse(TxBNotas.Text, out notas))
                {
                    MessageBox.Show($@"Error, Esto: {TxBNotas.Text} no es una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (int.Parse(TxBNotas.Text) > 100 || int.Parse(TxBNotas.Text) < 0)
                {
                    MessageBox.Show($@"Error, Esto: {TxBNotas.Text} no es una nota valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {   
                    notas = int.Parse(TxBNotas.Text);
                    if (a > Tnotas.Length-1)
                    {
                        MessageBox.Show("Error, no se puede meter mas de 6 notas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        Tnotas[a] = notas;
                        a++;
                        Nnotas.Text = $"Nota numero: {a}";
                        TxBNotas.Text = string.Empty;
                    }
                }
                
              

            }
        
        }
       /* public decimal promedio()
        {
            a = a / 6;
            return a;
        }*/
    }
}
