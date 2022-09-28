namespace BaseMundial
{
    partial class FormEstaPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstaPartidos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgEstadPartido = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtrieoarco = new System.Windows.Forms.TextBox();
            this.txtgol = new System.Windows.Forms.TextBox();
            this.txtcodsele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnoronda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttaramariilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttarrojas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttiroesquina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBombo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadPartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(1149, 707);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 38);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(724, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estadisticas de Partidos";
            // 
            // dgEstadPartido
            // 
            this.dgEstadPartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstadPartido.Location = new System.Drawing.Point(24, 416);
            this.dgEstadPartido.Name = "dgEstadPartido";
            this.dgEstadPartido.RowHeadersWidth = 51;
            this.dgEstadPartido.RowTemplate.Height = 24;
            this.dgEstadPartido.Size = new System.Drawing.Size(942, 278);
            this.dgEstadPartido.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(992, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // btbmodificar
            // 
            this.btbmodificar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbmodificar.Location = new System.Drawing.Point(1018, 253);
            this.btbmodificar.Name = "btbmodificar";
            this.btbmodificar.Size = new System.Drawing.Size(198, 73);
            this.btbmodificar.TabIndex = 98;
            this.btbmodificar.Text = "Editar";
            this.btbmodificar.UseVisualStyleBackColor = true;
            this.btbmodificar.Click += new System.EventHandler(this.btbmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(1018, 339);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(198, 73);
            this.btneliminar.TabIndex = 97;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1018, 169);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 73);
            this.btnagregar.TabIndex = 96;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1018, 83);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(198, 73);
            this.btnbuscar.TabIndex = 95;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtrieoarco
            // 
            this.txtrieoarco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrieoarco.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrieoarco.Location = new System.Drawing.Point(250, 302);
            this.txtrieoarco.Name = "txtrieoarco";
            this.txtrieoarco.Size = new System.Drawing.Size(165, 39);
            this.txtrieoarco.TabIndex = 92;
            // 
            // txtgol
            // 
            this.txtgol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgol.Location = new System.Drawing.Point(128, 165);
            this.txtgol.Name = "txtgol";
            this.txtgol.Size = new System.Drawing.Size(129, 39);
            this.txtgol.TabIndex = 91;
            // 
            // txtcodsele
            // 
            this.txtcodsele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodsele.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodsele.Location = new System.Drawing.Point(281, 99);
            this.txtcodsele.Name = "txtcodsele";
            this.txtcodsele.Size = new System.Drawing.Size(119, 39);
            this.txtcodsele.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 41);
            this.label5.TabIndex = 87;
            this.label5.Text = "Tiros al Arco :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 41);
            this.label4.TabIndex = 86;
            this.label4.Text = "Goles :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 41);
            this.label3.TabIndex = 85;
            this.label3.Text = "Codigo Seleccion :";
            // 
            // txtnoronda
            // 
            this.txtnoronda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoronda.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoronda.Location = new System.Drawing.Point(664, 99);
            this.txtnoronda.Name = "txtnoronda";
            this.txtnoronda.Size = new System.Drawing.Size(244, 39);
            this.txtnoronda.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 41);
            this.label10.TabIndex = 83;
            this.label10.Text = "No.  de Ronda :";
            // 
            // txttaramariilas
            // 
            this.txttaramariilas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttaramariilas.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaramariilas.Location = new System.Drawing.Point(316, 227);
            this.txttaramariilas.Name = "txttaramariilas";
            this.txttaramariilas.Size = new System.Drawing.Size(176, 39);
            this.txttaramariilas.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 41);
            this.label1.TabIndex = 101;
            this.label1.Text = "Tarjetas Amarillas :";
            // 
            // txttarrojas
            // 
            this.txttarrojas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttarrojas.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarrojas.Location = new System.Drawing.Point(722, 229);
            this.txttarrojas.Name = "txttarrojas";
            this.txttarrojas.Size = new System.Drawing.Size(186, 39);
            this.txttarrojas.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 41);
            this.label7.TabIndex = 103;
            this.label7.Text = "Tarjetas Rojas  :";
            // 
            // txttiroesquina
            // 
            this.txttiroesquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttiroesquina.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiroesquina.Location = new System.Drawing.Point(716, 302);
            this.txttiroesquina.Name = "txttiroesquina";
            this.txttiroesquina.Size = new System.Drawing.Size(192, 39);
            this.txttiroesquina.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 41);
            this.label8.TabIndex = 105;
            this.label8.Text = "Tiros de Esquina :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 41);
            this.label6.TabIndex = 107;
            this.label6.Text = "Tiros Desviados  :";
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(315, 369);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(100, 22);
            this.txtdes.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 41);
            this.label9.TabIndex = 109;
            this.label9.Text = "No.  Bombo :";
            // 
            // txtBombo
            // 
            this.txtBombo.Location = new System.Drawing.Point(682, 181);
            this.txtBombo.Name = "txtBombo";
            this.txtBombo.Size = new System.Drawing.Size(100, 22);
            this.txtBombo.TabIndex = 110;
            // 
            // FormEstaPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1265, 752);
            this.Controls.Add(this.txtBombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttiroesquina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttarrojas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttaramariilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEstadPartido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtrieoarco);
            this.Controls.Add(this.txtgol);
            this.Controls.Add(this.txtcodsele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnoronda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormEstaPartidos";
            this.Text = "FormDetallesGol";
            this.Load += new System.EventHandler(this.FormEstaPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadPartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEstadPartido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtrieoarco;
        private System.Windows.Forms.TextBox txtgol;
        private System.Windows.Forms.TextBox txtcodsele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnoronda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttaramariilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttarrojas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttiroesquina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBombo;
    }
}