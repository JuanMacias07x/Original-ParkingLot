﻿
namespace Original_ParkingLot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDriver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNyA = new System.Windows.Forms.TextBox();
            this.tBD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.rBSiA = new System.Windows.Forms.RadioButton();
            this.rBNoA = new System.Windows.Forms.RadioButton();
            this.gBAfiliado = new System.Windows.Forms.GroupBox();
            this.gBV = new System.Windows.Forms.GroupBox();
            this.rBCMV = new System.Windows.Forms.RadioButton();
            this.rBPV = new System.Windows.Forms.RadioButton();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBGenero = new System.Windows.Forms.GroupBox();
            this.rBOG = new System.Windows.Forms.RadioButton();
            this.rBMG = new System.Windows.Forms.RadioButton();
            this.rBHG = new System.Windows.Forms.RadioButton();
            this.lblIyD = new System.Windows.Forms.Label();
            this.lblHI = new System.Windows.Forms.Label();
            this.lblHS = new System.Windows.Forms.Label();
            this.btnAHI = new System.Windows.Forms.Button();
            this.btnCerrarPrin = new System.Windows.Forms.Button();
            this.eNd = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePNyA = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbHI = new System.Windows.Forms.MaskedTextBox();
            this.tbHS = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.gBAfiliado.SuspendLayout();
            this.gBV.SuspendLayout();
            this.gBGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eNd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePNyA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(51, 9);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(78, 20);
            this.lblDriver.TabIndex = 0;
            this.lblDriver.Text = "Conductor";
            this.lblDriver.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y apellidos:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tBNyA
            // 
            this.tBNyA.Location = new System.Drawing.Point(4, 61);
            this.tBNyA.Name = "tBNyA";
            this.tBNyA.Size = new System.Drawing.Size(189, 27);
            this.tBNyA.TabIndex = 2;
            this.tBNyA.TextChanged += new System.EventHandler(this.tBNyA_TextChanged);
            // 
            // tBD
            // 
            this.tBD.Location = new System.Drawing.Point(4, 124);
            this.tBD.Name = "tBD";
            this.tBD.Size = new System.Drawing.Size(189, 27);
            this.tBD.TabIndex = 4;
            this.tBD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(4, 101);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(111, 20);
            this.lblD.TabIndex = 3;
            this.lblD.Text = "N° Documento:";
            this.lblD.Click += new System.EventHandler(this.label2_Click);
            // 
            // rBSiA
            // 
            this.rBSiA.AutoSize = true;
            this.rBSiA.Location = new System.Drawing.Point(18, 26);
            this.rBSiA.Name = "rBSiA";
            this.rBSiA.Size = new System.Drawing.Size(42, 24);
            this.rBSiA.TabIndex = 5;
            this.rBSiA.TabStop = true;
            this.rBSiA.Text = "Sí";
            this.rBSiA.UseVisualStyleBackColor = true;
            // 
            // rBNoA
            // 
            this.rBNoA.AutoSize = true;
            this.rBNoA.Location = new System.Drawing.Point(18, 54);
            this.rBNoA.Name = "rBNoA";
            this.rBNoA.Size = new System.Drawing.Size(50, 24);
            this.rBNoA.TabIndex = 6;
            this.rBNoA.TabStop = true;
            this.rBNoA.Text = "No";
            this.rBNoA.UseVisualStyleBackColor = true;
            // 
            // gBAfiliado
            // 
            this.gBAfiliado.Controls.Add(this.rBNoA);
            this.gBAfiliado.Controls.Add(this.rBSiA);
            this.gBAfiliado.Location = new System.Drawing.Point(4, 287);
            this.gBAfiliado.Name = "gBAfiliado";
            this.gBAfiliado.Size = new System.Drawing.Size(189, 93);
            this.gBAfiliado.TabIndex = 7;
            this.gBAfiliado.TabStop = false;
            this.gBAfiliado.Text = "Afiliado";
            // 
            // gBV
            // 
            this.gBV.Controls.Add(this.rBCMV);
            this.gBV.Controls.Add(this.rBPV);
            this.gBV.Location = new System.Drawing.Point(255, 157);
            this.gBV.Name = "gBV";
            this.gBV.Size = new System.Drawing.Size(189, 84);
            this.gBV.TabIndex = 13;
            this.gBV.TabStop = false;
            this.gBV.Text = "Vehículo";
            // 
            // rBCMV
            // 
            this.rBCMV.AutoSize = true;
            this.rBCMV.Location = new System.Drawing.Point(18, 54);
            this.rBCMV.Name = "rBCMV";
            this.rBCMV.Size = new System.Drawing.Size(169, 24);
            this.rBCMV.TabIndex = 6;
            this.rBCMV.TabStop = true;
            this.rBCMV.Text = "Camioneta/Microbus";
            this.rBCMV.UseVisualStyleBackColor = true;
            // 
            // rBPV
            // 
            this.rBPV.AutoSize = true;
            this.rBPV.Location = new System.Drawing.Point(18, 26);
            this.rBPV.Name = "rBPV";
            this.rBPV.Size = new System.Drawing.Size(91, 24);
            this.rBPV.TabIndex = 5;
            this.rBPV.TabStop = true;
            this.rBPV.Text = "Particular";
            this.rBPV.UseVisualStyleBackColor = true;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(255, 124);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(189, 27);
            this.tbMarca.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marca:";
            // 
            // tbPM
            // 
            this.tbPM.Location = new System.Drawing.Point(255, 61);
            this.tbPM.Name = "tbPM";
            this.tbPM.Size = new System.Drawing.Size(189, 27);
            this.tbPM.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Placa/matrícula";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehículo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gBGenero
            // 
            this.gBGenero.Controls.Add(this.rBOG);
            this.gBGenero.Controls.Add(this.rBMG);
            this.gBGenero.Controls.Add(this.rBHG);
            this.gBGenero.Location = new System.Drawing.Point(4, 157);
            this.gBGenero.Name = "gBGenero";
            this.gBGenero.Size = new System.Drawing.Size(189, 124);
            this.gBGenero.TabIndex = 8;
            this.gBGenero.TabStop = false;
            this.gBGenero.Text = "Género";
            // 
            // rBOG
            // 
            this.rBOG.AutoSize = true;
            this.rBOG.Location = new System.Drawing.Point(18, 80);
            this.rBOG.Name = "rBOG";
            this.rBOG.Size = new System.Drawing.Size(60, 24);
            this.rBOG.TabIndex = 7;
            this.rBOG.TabStop = true;
            this.rBOG.Text = "Otro";
            this.rBOG.UseVisualStyleBackColor = true;
            // 
            // rBMG
            // 
            this.rBMG.AutoSize = true;
            this.rBMG.Location = new System.Drawing.Point(18, 54);
            this.rBMG.Name = "rBMG";
            this.rBMG.Size = new System.Drawing.Size(68, 24);
            this.rBMG.TabIndex = 6;
            this.rBMG.TabStop = true;
            this.rBMG.Text = "Mujer";
            this.rBMG.UseVisualStyleBackColor = true;
            // 
            // rBHG
            // 
            this.rBHG.AutoSize = true;
            this.rBHG.Location = new System.Drawing.Point(18, 26);
            this.rBHG.Name = "rBHG";
            this.rBHG.Size = new System.Drawing.Size(85, 24);
            this.rBHG.TabIndex = 5;
            this.rBHG.TabStop = true;
            this.rBHG.Text = "Hombre";
            this.rBHG.UseVisualStyleBackColor = true;
            this.rBHG.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblIyD
            // 
            this.lblIyD.AutoSize = true;
            this.lblIyD.Location = new System.Drawing.Point(487, 9);
            this.lblIyD.Name = "lblIyD";
            this.lblIyD.Size = new System.Drawing.Size(169, 20);
            this.lblIyD.TabIndex = 14;
            this.lblIyD.Text = "Ingreso y disponibilidad";
            this.lblIyD.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblHI
            // 
            this.lblHI.AutoSize = true;
            this.lblHI.Location = new System.Drawing.Point(485, 31);
            this.lblHI.Name = "lblHI";
            this.lblHI.Size = new System.Drawing.Size(98, 20);
            this.lblHI.TabIndex = 15;
            this.lblHI.Text = "Hora ingreso:";
            this.lblHI.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Location = new System.Drawing.Point(485, 101);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(88, 20);
            this.lblHS.TabIndex = 17;
            this.lblHS.Text = "Hora salida:";
            // 
            // btnAHI
            // 
            this.btnAHI.Location = new System.Drawing.Point(258, 341);
            this.btnAHI.Name = "btnAHI";
            this.btnAHI.Size = new System.Drawing.Size(184, 38);
            this.btnAHI.TabIndex = 19;
            this.btnAHI.Text = "Aceptar ";
            this.btnAHI.UseVisualStyleBackColor = true;
            this.btnAHI.Click += new System.EventHandler(this.btnAHI_Click);
            // 
            // btnCerrarPrin
            // 
            this.btnCerrarPrin.Location = new System.Drawing.Point(530, 341);
            this.btnCerrarPrin.Name = "btnCerrarPrin";
            this.btnCerrarPrin.Size = new System.Drawing.Size(146, 39);
            this.btnCerrarPrin.TabIndex = 24;
            this.btnCerrarPrin.Text = "Cerrar";
            this.btnCerrarPrin.UseVisualStyleBackColor = true;
            this.btnCerrarPrin.Click += new System.EventHandler(this.btnCerrarPrin_Click);
            // 
            // eNd
            // 
            this.eNd.ContainerControl = this;
            // 
            // ePNyA
            // 
            this.ePNyA.ContainerControl = this;
            // 
            // tbHI
            // 
            this.tbHI.Location = new System.Drawing.Point(485, 63);
            this.tbHI.Mask = "00:00";
            this.tbHI.Name = "tbHI";
            this.tbHI.Size = new System.Drawing.Size(189, 27);
            this.tbHI.TabIndex = 25;
            this.tbHI.ValidatingType = typeof(System.DateTime);
            // 
            // tbHS
            // 
            this.tbHS.Location = new System.Drawing.Point(485, 124);
            this.tbHS.Mask = "00:00";
            this.tbHS.Name = "tbHS";
            this.tbHS.Size = new System.Drawing.Size(189, 27);
            this.tbHS.TabIndex = 26;
            this.tbHS.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(485, 157);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMostrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostrarFecha.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostrarFecha.Location = new System.Drawing.Point(530, 197);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(80, 21);
            this.lblMostrarFecha.TabIndex = 28;
            this.lblMostrarFecha.Text = "label5";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(258, 244);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(47, 20);
            this.lblCosto.TabIndex = 29;
            this.lblCosto.Text = "Costo";
            this.lblCosto.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(253, 267);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(189, 27);
            this.tbCosto.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblMostrarFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tbHS);
            this.Controls.Add(this.tbHI);
            this.Controls.Add(this.btnCerrarPrin);
            this.Controls.Add(this.btnAHI);
            this.Controls.Add(this.lblHS);
            this.Controls.Add(this.lblHI);
            this.Controls.Add(this.lblIyD);
            this.Controls.Add(this.gBGenero);
            this.Controls.Add(this.gBV);
            this.Controls.Add(this.gBAfiliado);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBD);
            this.Controls.Add(this.tbPM);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBNyA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDriver);
            this.Name = "Form1";
            this.Text = "ParkingLot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBAfiliado.ResumeLayout(false);
            this.gBAfiliado.PerformLayout();
            this.gBV.ResumeLayout(false);
            this.gBV.PerformLayout();
            this.gBGenero.ResumeLayout(false);
            this.gBGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eNd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePNyA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNyA;
        private System.Windows.Forms.TextBox tBD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.RadioButton rBSiA;
        private System.Windows.Forms.RadioButton rBNoA;
        private System.Windows.Forms.GroupBox gBAfiliado;
        private System.Windows.Forms.GroupBox gBV;
        private System.Windows.Forms.RadioButton rBCMV;
        private System.Windows.Forms.RadioButton rBPV;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gBGenero;
        private System.Windows.Forms.RadioButton rBMG;
        private System.Windows.Forms.RadioButton rBHG;
        private System.Windows.Forms.RadioButton rBOG;
        private System.Windows.Forms.Label lblIyD;
        private System.Windows.Forms.Label lblHI;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.Button btnAHI;
        private System.Windows.Forms.Button btnCerrarPrin;
        private System.Windows.Forms.ErrorProvider eNd;
        private System.Windows.Forms.ErrorProvider ePNyA;
        private System.Windows.Forms.MaskedTextBox tbHS;
        private System.Windows.Forms.MaskedTextBox tbHI;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox tbCosto;
    }
}

