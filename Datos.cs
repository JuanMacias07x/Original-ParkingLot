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

namespace Original_ParkingLot
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarC = new SaveFileDialog();
            guardarC.Filter = "Documento de texto|*.txt";
            guardarC.Title = "Guardar RtB";
            guardarC.FileName = "Conductor 1";
            var resultado = guardarC.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardarC.FileName);
                foreach (object line in rTBguardar.Lines) 
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
            SaveFileDialog guardarV = new SaveFileDialog();
            guardarV.Filter = "Documento de texto|*.txt";
            guardarV.Title = "Guardar RtB";
            guardarV.FileName = "Vehículo 1";
            var resultadoV = guardarV.ShowDialog();
            if (resultadoV == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardarV.FileName);
                foreach (object line in rTBguardar2.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }
       

        private void rTBguardar_TextChanged(object sender, EventArgs e)
        {
            rTBguardar.Text = "Datos del conductor: " + "\n" + "Nombre: " + Conductor.Nombre + "\n" + "Documento: " + Conductor.Documento + "\n" + "Sexo: " + Conductor.Sexo + "\n" + "¿Es afiliado?: " + Conductor.Afiliado;
            rTBguardar2.Text = "Datos del vehículo: " + "\n" + "Placa: " + Vehiculo.Placa + "\n" + "Tipo de vehículo: " + Vehiculo.Tipo + "\n" + "Marca: " + Vehiculo.Marca + "\n" + "Hora de entrada: " + Vehiculo.HoraEn + "\n" + "Hora de salida: " + Vehiculo.HoraSa;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rTBguardar.Text = "Datos del conductor: " + "\n" + "Nombre: " + Conductor.Nombre + "\n" + "Documento: " + Conductor.Documento + "\n" + "Sexo: " + Conductor.Sexo + "\n" + "¿Es afiliado?: " + Conductor.Afiliado; 
            rTBguardar2.Text = "Datos del vehículo: " + "\n" + "Placa: " + Vehiculo.Placa + "\n" + "Tipo de vehículo: " + Vehiculo.Tipo + "\n" + "Marca: " + Vehiculo.Marca + "\n" + "Hora de entrada: " + Vehiculo.HoraEn + "\n" + "Hora de salida: " + Vehiculo.HoraSa;
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
