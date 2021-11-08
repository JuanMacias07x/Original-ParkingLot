﻿using System;
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
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de texto|*.txt";
            guardar.Title = "Guardar RtB";
            guardar.FileName = "Sin título 1";
            var resultado = guardar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in rTBguardar.Lines) 
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }

        private void rTBguardar_TextChanged(object sender, EventArgs e)
        {
            rTBguardar.Text = "Datos del conductor: " + "\n" + "Nombre: " + Conductor.Nombre + "\n" + "Documento: " + Conductor.Documento + "\n" + "Sexo: " + Conductor.Sexo + "\n" + "¿Es afiliado?: " + Conductor.Afiliado;
            rTBguardar2.Text = "Datos del vehículo: " + "\n" + "Placa: " + Vehiculo.Placa + "\n" + "Tipo de vehículo: " + Vehiculo.Tipo + "\n" + "Marca: " + Vehiculo.Marca + "\n" + "Hora de entrada: " + Vehiculo.HoraEn;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rTBguardar.Text = "Datos del conductor: " + "\n" + "Nombre: " + Conductor.Nombre + "\n" + "Documento: " + Conductor.Documento + "\n" + "Sexo: " + Conductor.Sexo + "\n" + "¿Es afiliado?: " + Conductor.Afiliado; 
            rTBguardar2.Text = "Datos del vehículo: " + "\n" + "Placa: " + Vehiculo.Placa + "\n" + "Tipo de vehículo: " + Vehiculo.Tipo + "\n" + "Marca: " + Vehiculo.Marca + "\n" + "Hora de entrada: " + Vehiculo.HoraEn;
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }
    }
}
