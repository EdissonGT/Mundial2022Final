namespace BaseMundial
{
    partial class FormRondas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRondas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtgolronda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcodsele = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnobombo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnoronda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgRondas = new System.Windows.Forms.DataGridView();
            this.btbmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txttaramarillas = new System.Windows.Forms.TextBox();
            this.txttiroarco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttirodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttarrojas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRondas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(950, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1176, 695);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 45);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtgolronda
            // 
            this.txtgolronda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgolronda.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgolronda.Location = new System.Drawing.Point(810, 162);
            this.txtgolronda.Name = "txtgolronda";
            this.txtgolronda.Size = new System.Drawing.Size(135, 39);
            this.txtgolronda.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(548, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 41);
            this.label12.TabIndex = 109;
            this.label12.Text = "Goles por Ronda :";
            // 
            // txtcodsele
            // 
            this.txtcodsele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodsele.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodsele.Location = new System.Drawing.Point(344, 162);
            this.txtcodsele.Name = "txtcodsele";
            this.txtcodsele.Size = new System.Drawing.Size(173, 39);
            this.txtcodsele.TabIndex = 108;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 41);
            this.label11.TabIndex = 107;
            this.label11.Text = "Código de Selección :";
            // 
            // txtnobombo
            // 
            this.txtnobombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnobombo.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnobombo.Location = new System.Drawing.Point(721, 93);
            this.txtnobombo.Name = "txtnobombo";
            this.txtnobombo.Size = new System.Drawing.Size(179, 39);
            this.txtnobombo.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 41);
            this.label9.TabIndex = 105;
            this.label9.Text = "No. de Bombo :";
            // 
            // txtnoronda
            // 
            this.txtnoronda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoronda.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoronda.Location = new System.Drawing.Point(258, 93);
            this.txtnoronda.Name = "txtnoronda";
            this.txtnoronda.Size = new System.Drawing.Size(179, 39);
            this.txtnoronda.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 41);
            this.label8.TabIndex = 103;
            this.label8.Text = "No. de Ronda :";
            // 
            // dgRondas
            // 
            this.dgRondas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRondas.Location = new System.Drawing.Point(42, 403);
            this.dgRondas.Name = "dgRondas";
            this.dgRondas.RowHeadersWidth = 51;
            this.dgRondas.RowTemplate.Height = 24;
            this.dgRondas.Size = new System.Drawing.Size(886, 325);
            this.dgRondas.TabIndex = 102;
            // 
            // btbmodificar
            // 
            this.btbmodificar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbmodificar.Location = new System.Drawing.Point(1038, 199);
            this.btbmodificar.Name = "btbmodificar";
            this.btbmodificar.Size = new System.Drawing.Size(198, 73);
            this.btbmodificar.TabIndex = 101;
            this.btbmodificar.Text = "Editar";
            this.btbmodificar.UseVisualStyleBackColor = true;
            this.btbmodificar.Click += new System.EventHandler(this.btbmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(1038, 285);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(198, 73);
            this.btneliminar.TabIndex = 100;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1038, 115);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 73);
            this.btnagregar.TabIndex = 99;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1038, 29);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(198, 73);
            this.btnbuscar.TabIndex = 98;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txttaramarillas
            // 
            this.txttaramarillas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttaramarillas.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaramarillas.Location = new System.Drawing.Point(319, 303);
            this.txttaramarillas.Name = "txttaramarillas";
            this.txttaramarillas.Size = new System.Drawing.Size(180, 39);
            this.txttaramarillas.TabIndex = 97;
            // 
            // txttiroarco
            // 
            this.txttiroarco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttiroarco.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiroarco.Location = new System.Drawing.Point(258, 235);
            this.txttiroarco.Name = "txttiroarco";
            this.txttiroarco.Size = new System.Drawing.Size(179, 39);
            this.txttiroarco.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 41);
            this.label4.TabIndex = 95;
            this.label4.Text = "Tarjetas Amarillas :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 41);
            this.label3.TabIndex = 94;
            this.label3.Text = "Tiros al Arco :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(555, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 56);
            this.label2.TabIndex = 91;
            this.label2.Text = "Ronda";
            // 
            // txttirodes
            // 
            this.txttirodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttirodes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttirodes.Location = new System.Drawing.Point(750, 235);
            this.txttirodes.Name = "txttirodes";
            this.txttirodes.Size = new System.Drawing.Size(179, 39);
            this.txttirodes.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 111;
            this.label1.Text = "Tiros al Desviado :";
            // 
            // txttarrojas
            // 
            this.txttarrojas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttarrojas.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarrojas.Location = new System.Drawing.Point(748, 303);
            this.txttarrojas.Name = "txttarrojas";
            this.txttarrojas.Size = new System.Drawing.Size(180, 39);
            this.txttarrojas.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 41);
            this.label5.TabIndex = 113;
            this.label5.Text = "Tarjetas Rojas :";
            // 
            // FormRondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 745);
            this.Controls.Add(this.txttarrojas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttirodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgolronda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcodsele);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnobombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnoronda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgRondas);
            this.Controls.Add(this.btbmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txttaramarillas);
            this.Controls.Add(this.txttiroarco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRondas";
            this.Text = "FormRondas";
            this.Load += new System.EventHandler(this.FormRondas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRondas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtgolronda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcodsele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnobombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnoronda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgRondas;
        private System.Windows.Forms.Button btbmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txttaramarillas;
        private System.Windows.Forms.TextBox txttiroarco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttirodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttarrojas;
        private System.Windows.Forms.Label label5;
    }
}