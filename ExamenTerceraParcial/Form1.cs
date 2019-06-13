using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExamenTerceraParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         IList<Equipo> listaequipo = new List<Equipo>();
        IList<Jugador> listajugadore = new List<Jugador>();
        jornada jornadas = new jornada();
        private void btnaequipo_Click(object sender, EventArgs e)
        {
            string equipo = Convert.ToString(txtnequipo.Text);
            jornadas.Agregar(equipo);
            comboequipo1.Items.Add(equipo);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guarda = new SaveFileDialog();
            guarda.FileName = "Jornada.txt";
            guarda.Filter = "Text File | *.txt";
            if (guarda.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escritura = new StreamWriter(guarda.OpenFile());
                escritura.WriteLine("Datos de la jornada");
                escritura.WriteLine("//Liga//");
                escritura.WriteLine("//////////////////////////////////////////////");
                for (int i = 0; i < listaequipo.Items[i].Count; i++)
                {
                    escritura.WriteLine(listaequipo.Items[i].ToString());
                }
                    escritura.Dispose();

                escritura.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnjuegen_Click(object sender, EventArgs e)
        {
            string valor = comboequipo1.SelectedItem.ToString();
            string valor2 = comboequipo2.SelectedItem.ToString();
            if (valor == valor2)
            {
                MessageBox.Show("no se pueden elegir el mismo equipo");
            }
            else
            {

            }
        }
    }
}
