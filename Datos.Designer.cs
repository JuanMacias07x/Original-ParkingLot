
namespace Original_ParkingLot
{
    partial class Datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTBguardar = new System.Windows.Forms.RichTextBox();
            this.rTBguardar2 = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTBguardar
            // 
            this.rTBguardar.Location = new System.Drawing.Point(12, 12);
            this.rTBguardar.Name = "rTBguardar";
            this.rTBguardar.Size = new System.Drawing.Size(380, 383);
            this.rTBguardar.TabIndex = 0;
            this.rTBguardar.Text = "";
            this.rTBguardar.TextChanged += new System.EventHandler(this.rTBguardar_TextChanged);
            // 
            // rTBguardar2
            // 
            this.rTBguardar2.Location = new System.Drawing.Point(398, 12);
            this.rTBguardar2.Name = "rTBguardar2";
            this.rTBguardar2.Size = new System.Drawing.Size(390, 383);
            this.rTBguardar2.TabIndex = 1;
            this.rTBguardar2.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 409);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 29);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar/volver";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(298, 409);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(94, 29);
            this.btnGuarda.TabIndex = 3;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(398, 409);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(94, 29);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Location = new System.Drawing.Point(681, 409);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(107, 29);
            this.btnCerrar2.TabIndex = 5;
            this.btnCerrar2.Text = "Cerrar/volver";
            this.btnCerrar2.UseVisualStyleBackColor = true;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuarda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rTBguardar2);
            this.Controls.Add(this.rTBguardar);
            this.Name = "Datos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Datos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBguardar;
        private System.Windows.Forms.RichTextBox rTBguardar2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCerrar2;
    }
}