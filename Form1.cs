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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        public void btnAHI_Click(object sender, EventArgs e)
        {

            //conductor

            Conductor.Nombre = tBNyA.Text;
            Conductor.Documento = tBD.Text;

            if (rBHG.Checked == true)
                Conductor.Sexo = "Masculino";
            if (rBMG.Checked == true)
                Conductor.Sexo = "Femenino";
            if (rBOG.Checked == true)
                Conductor.Sexo = "Otro";
            if (rBSiA.Checked == true)
                Conductor.Afiliado = "Es afiliado";
            if (rBNoA.Checked == true)
                Conductor.Afiliado = "No es afiliado";

            //vehiculo

            Vehiculo.Marca = tbMarca.Text;
            Vehiculo.Placa = tbPM.Text;
            Vehiculo.HoraEn = (int)Convert.ToDouble(tbHI);

            if (rBPV.Checked == true)
                Vehiculo.Tipo = "El vehículo es particular";
            if (rBCMV.Checked == true)
                Vehiculo.Tipo = "El vehículo es Camioneta/MicroBus";
        } 
    }
}
