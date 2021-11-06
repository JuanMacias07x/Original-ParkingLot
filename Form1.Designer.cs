
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
            this.lblDriver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNyA = new System.Windows.Forms.TextBox();
            this.tBD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.rBSiA = new System.Windows.Forms.RadioButton();
            this.rBNoA = new System.Windows.Forms.RadioButton();
            this.gBAfiliado = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gBAfiliado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(136, 9);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(78, 20);
            this.lblDriver.TabIndex = 0;
            this.lblDriver.Text = "Conductor";
            this.lblDriver.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y apellidos:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tBNyA
            // 
            this.tBNyA.Location = new System.Drawing.Point(89, 61);
            this.tBNyA.Name = "tBNyA";
            this.tBNyA.Size = new System.Drawing.Size(189, 27);
            this.tBNyA.TabIndex = 2;
            // 
            // tBD
            // 
            this.tBD.Location = new System.Drawing.Point(89, 114);
            this.tBD.Name = "tBD";
            this.tBD.Size = new System.Drawing.Size(189, 27);
            this.tBD.TabIndex = 4;
            this.tBD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(89, 91);
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
            this.gBAfiliado.Location = new System.Drawing.Point(39, 147);
            this.gBAfiliado.Name = "gBAfiliado";
            this.gBAfiliado.Size = new System.Drawing.Size(128, 110);
            this.gBAfiliado.TabIndex = 7;
            this.gBAfiliado.TabStop = false;
            this.gBAfiliado.Text = "Afiliado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(521, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 84);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afiliado";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Camioneta/Microbus";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Particular";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marca:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(521, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Placa/matrícula";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehículo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(188, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afiliado";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 54);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 24);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mujer";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 24);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Hombre";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(18, 80);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(60, 24);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Otro";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingreso y disponibilidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBAfiliado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBD);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBNyA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDriver);
            this.Name = "Form1";
            this.Text = "ParkingLot";
            this.gBAfiliado.ResumeLayout(false);
            this.gBAfiliado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label5;
    }
}

