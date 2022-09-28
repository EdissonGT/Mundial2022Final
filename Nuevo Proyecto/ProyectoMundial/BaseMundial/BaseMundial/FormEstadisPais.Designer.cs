namespace BaseMundial
{
    partial class FormEstadisPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisPais));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgGol = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txttipogol = new System.Windows.Forms.TextBox();
            this.txtnimgol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodjuga = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnoronda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnobombo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodsele = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtasisgol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(1162, 709);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 38);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(-137, -136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadisticas de los Jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(336, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estadisticas de Goles";
            // 
            // dgGol
            // 
            this.dgGol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGol.Location = new System.Drawing.Point(25, 408);
            this.dgGol.Name = "dgGol";
            this.dgGol.RowHeadersWidth = 51;
            this.dgGol.RowTemplate.Height = 24;
            this.dgGol.Size = new System.Drawing.Size(942, 325);
            this.dgGol.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1012, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btbmodificar
            // 
            this.btbmodificar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbmodificar.Location = new System.Drawing.Point(1022, 274);
            this.btbmodificar.Name = "btbmodificar";
            this.btbmodificar.Size = new System.Drawing.Size(198, 73);
            this.btbmodificar.TabIndex = 80;
            this.btbmodificar.Text = "Editar";
            this.btbmodificar.UseVisualStyleBackColor = true;
            this.btbmodificar.Click += new System.EventHandler(this.btbmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(1022, 360);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(198, 73);
            this.btneliminar.TabIndex = 79;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1022, 190);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 73);
            this.btnagregar.TabIndex = 78;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1022, 104);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(198, 73);
            this.btnbuscar.TabIndex = 77;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txttipogol
            // 
            this.txttipogol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipogol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipogol.Location = new System.Drawing.Point(253, 303);
            this.txttipogol.Name = "txttipogol";
            this.txttipogol.Size = new System.Drawing.Size(702, 39);
            this.txttipogol.TabIndex = 71;
            // 
            // txtnimgol
            // 
            this.txtnimgol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnimgol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnimgol.Location = new System.Drawing.Point(253, 240);
            this.txtnimgol.Name = "txtnimgol";
            this.txtnimgol.Size = new System.Drawing.Size(146, 39);
            this.txtnimgol.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 41);
            this.label4.TabIndex = 64;
            this.label4.Text = "Tipo de Gol :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 41);
            this.label3.TabIndex = 63;
            this.label3.Text = "Min. de Gol :";
            // 
            // txtcodjuga
            // 
            this.txtcodjuga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodjuga.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodjuga.Location = new System.Drawing.Point(350, 134);
            this.txtcodjuga.Name = "txtcodjuga";
            this.txtcodjuga.Size = new System.Drawing.Size(173, 39);
            this.txtcodjuga.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 41);
            this.label10.TabIndex = 61;
            this.label10.Text = "Código de Jugador :";
            // 
            // txtnoronda
            // 
            this.txtnoronda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoronda.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoronda.Location = new System.Drawing.Point(780, 134);
            this.txtnoronda.Name = "txtnoronda";
            this.txtnoronda.Size = new System.Drawing.Size(179, 39);
            this.txtnoronda.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(557, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 41);
            this.label8.TabIndex = 83;
            this.label8.Text = "No. de Ronda :";
            // 
            // txtnobombo
            // 
            this.txtnobombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnobombo.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnobombo.Location = new System.Drawing.Point(279, 190);
            this.txtnobombo.Name = "txtnobombo";
            this.txtnobombo.Size = new System.Drawing.Size(179, 39);
            this.txtnobombo.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 41);
            this.label9.TabIndex = 85;
            this.label9.Text = "No. de Bombo :";
            // 
            // txtcodsele
            // 
            this.txtcodsele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodsele.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodsele.Location = new System.Drawing.Point(786, 190);
            this.txtcodsele.Name = "txtcodsele";
            this.txtcodsele.Size = new System.Drawing.Size(173, 39);
            this.txtcodsele.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(478, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 41);
            this.label11.TabIndex = 87;
            this.label11.Text = "Código de Selección :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(445, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 41);
            this.label12.TabIndex = 89;
            this.label12.Text = "Asistencia de Gol :";
            // 
            // txtasisgol
            // 
            this.txtasisgol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtasisgol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasisgol.Location = new System.Drawing.Point(714, 242);
            this.txtasisgol.Name = "txtasisgol";
            this.txtasisgol.Size = new System.Drawing.Size(241, 39);
            this.txtasisgol.TabIndex = 90;
            // 
            // FormEstadisPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 754);
            this.Controls.Add(this.txtasisgol);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcodsele);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnobombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnoronda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgGol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txttipogol);
            this.Controls.Add(this.txtnimgol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodjuga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisPais";
            this.Text = "FormEstadisPais";
            this.Load += new System.EventHandler(this.FormEstadisPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgGol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txttipogol;
        private System.Windows.Forms.TextBox txtnimgol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodjuga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnoronda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnobombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodsele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtasisgol;
    }
}