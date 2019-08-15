namespace BancoTierraMedia
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.saludo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lugares = new System.Windows.Forms.ComboBox();
            this.razas = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.DatosPrestamo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPersonales.SuspendLayout();
            this.DatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saludo.Location = new System.Drawing.Point(12, 24);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(146, 29);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido, ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(93, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lugar de origen:";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(184, 30);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(166, 20);
            this.monto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto del préstamo:";
            // 
            // lugares
            // 
            this.lugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lugares.FormattingEnabled = true;
            this.lugares.Location = new System.Drawing.Point(155, 85);
            this.lugares.Name = "lugares";
            this.lugares.Size = new System.Drawing.Size(166, 21);
            this.lugares.TabIndex = 6;
            // 
            // razas
            // 
            this.razas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.razas.FormattingEnabled = true;
            this.razas.Location = new System.Drawing.Point(155, 28);
            this.razas.Name = "razas";
            this.razas.Size = new System.Drawing.Size(166, 21);
            this.razas.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(717, 399);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 50);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(103, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cuotas:";
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(184, 84);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(166, 21);
            this.cuotas.TabIndex = 9;
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarSolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(333, 327);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(131, 59);
            this.btnConfirmarSolicitud.TabIndex = 11;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.BtnConfirmarSolicitud_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datos personales:";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosPersonales.BackColor = System.Drawing.Color.SandyBrown;
            this.DatosPersonales.Controls.Add(this.lugares);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.label5);
            this.DatosPersonales.Controls.Add(this.razas);
            this.errorProvider1.SetIconPadding(this.DatosPersonales, 10);
            this.DatosPersonales.Location = new System.Drawing.Point(27, 131);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(340, 140);
            this.DatosPersonales.TabIndex = 13;
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosPrestamo.BackColor = System.Drawing.Color.SandyBrown;
            this.DatosPrestamo.Controls.Add(this.label2);
            this.DatosPrestamo.Controls.Add(this.monto);
            this.DatosPrestamo.Controls.Add(this.cuotas);
            this.DatosPrestamo.Controls.Add(this.label1);
            this.errorProvider1.SetIconPadding(this.DatosPrestamo, 10);
            this.DatosPrestamo.Location = new System.Drawing.Point(398, 131);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Size = new System.Drawing.Size(371, 144);
            this.DatosPrestamo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(404, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Detalle del préstamo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatosPrestamo);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.DatosPrestamo.ResumeLayout(false);
            this.DatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lugares;
        private System.Windows.Forms.ComboBox razas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.Panel DatosPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}