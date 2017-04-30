namespace WFA_NASA2017
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRecorridos = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainerDetecciones = new System.Windows.Forms.SplitContainer();
            this.dgvDetecciones = new System.Windows.Forms.DataGridView();
            this.clnBtnAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainerVant = new System.Windows.Forms.SplitContainer();
            this.picDetecciones = new System.Windows.Forms.PictureBox();
            this.picRecorridos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecorridos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetecciones)).BeginInit();
            this.splitContainerDetecciones.Panel1.SuspendLayout();
            this.splitContainerDetecciones.Panel2.SuspendLayout();
            this.splitContainerDetecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetecciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVant)).BeginInit();
            this.splitContainerVant.Panel1.SuspendLayout();
            this.splitContainerVant.Panel2.SuspendLayout();
            this.splitContainerVant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDetecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecorridos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecorridos
            // 
            this.dgvRecorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecorridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecorridos.Location = new System.Drawing.Point(0, 0);
            this.dgvRecorridos.Name = "dgvRecorridos";
            this.dgvRecorridos.Size = new System.Drawing.Size(412, 602);
            this.dgvRecorridos.TabIndex = 0;
            this.dgvRecorridos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecorridos_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 634);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainerDetecciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detecciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainerDetecciones
            // 
            this.splitContainerDetecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDetecciones.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDetecciones.Name = "splitContainerDetecciones";
            // 
            // splitContainerDetecciones.Panel1
            // 
            this.splitContainerDetecciones.Panel1.Controls.Add(this.dgvDetecciones);
            // 
            // splitContainerDetecciones.Panel2
            // 
            this.splitContainerDetecciones.Panel2.Controls.Add(this.label8);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.textBox1);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.comboBox1);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.label7);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.label4);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.txtCoor);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.label3);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.txtEstado);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.label2);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.textBox2);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.label1);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.button1);
            this.splitContainerDetecciones.Panel2.Controls.Add(this.picDetecciones);
            this.splitContainerDetecciones.Size = new System.Drawing.Size(1240, 602);
            this.splitContainerDetecciones.SplitterDistance = 850;
            this.splitContainerDetecciones.TabIndex = 5;
            // 
            // dgvDetecciones
            // 
            this.dgvDetecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnBtnAccion});
            this.dgvDetecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetecciones.Location = new System.Drawing.Point(0, 0);
            this.dgvDetecciones.Name = "dgvDetecciones";
            this.dgvDetecciones.Size = new System.Drawing.Size(850, 602);
            this.dgvDetecciones.TabIndex = 0;
            this.dgvDetecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetecciones_CellContentClick);
            // 
            // clnBtnAccion
            // 
            this.clnBtnAccion.HeaderText = "Acudir";
            this.clnBtnAccion.Name = "clnBtnAccion";
            this.clnBtnAccion.Text = "Acudir";
            this.clnBtnAccion.UseColumnTextForButtonValue = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Notas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 558);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 34);
            this.textBox1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "V.A.N.T.D.I.",
            "GOES 13",
            "Celular"});
            this.comboBox1.Location = new System.Drawing.Point(89, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "V.A.N.T.D.I.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(16, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Velocidad";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(73, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "19 km/h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dirección";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Norte";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Coordenadas";
            // 
            // txtCoor
            // 
            this.txtCoor.Location = new System.Drawing.Point(89, 402);
            this.txtCoor.Name = "txtCoor";
            this.txtCoor.Size = new System.Drawing.Size(182, 20);
            this.txtCoor.TabIndex = 9;
            this.txtCoor.Text = "S 32°59\'44.999\" - O 60°38\'22.236\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(89, 431);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(182, 20);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.Text = "Derivado a Bomberos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperatura (Máx.)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(131, 532);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "240.1 C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainerVant);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recorridos V.A.N.T.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainerVant
            // 
            this.splitContainerVant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVant.Location = new System.Drawing.Point(3, 3);
            this.splitContainerVant.Name = "splitContainerVant";
            // 
            // splitContainerVant.Panel1
            // 
            this.splitContainerVant.Panel1.Controls.Add(this.dgvRecorridos);
            // 
            // splitContainerVant.Panel2
            // 
            this.splitContainerVant.Panel2.Controls.Add(this.picRecorridos);
            this.splitContainerVant.Size = new System.Drawing.Size(1240, 602);
            this.splitContainerVant.SplitterDistance = 412;
            this.splitContainerVant.TabIndex = 4;
            // 
            // picDetecciones
            // 
            this.picDetecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDetecciones.Location = new System.Drawing.Point(0, 0);
            this.picDetecciones.Name = "picDetecciones";
            this.picDetecciones.Size = new System.Drawing.Size(386, 340);
            this.picDetecciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDetecciones.TabIndex = 1;
            this.picDetecciones.TabStop = false;
            // 
            // picRecorridos
            // 
            this.picRecorridos.Dock = System.Windows.Forms.DockStyle.Top;
            this.picRecorridos.Location = new System.Drawing.Point(0, 0);
            this.picRecorridos.Name = "picRecorridos";
            this.picRecorridos.Size = new System.Drawing.Size(824, 390);
            this.picRecorridos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecorridos.TabIndex = 1;
            this.picRecorridos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Nasa 2017 - And YOU can Help Fight Fires! - CUIDA PARQUES - MODULO DE DETECCIÓN E" +
    "N CENTRO DE MONITOREO ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecorridos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainerDetecciones.Panel1.ResumeLayout(false);
            this.splitContainerDetecciones.Panel2.ResumeLayout(false);
            this.splitContainerDetecciones.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetecciones)).EndInit();
            this.splitContainerDetecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetecciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainerVant.Panel1.ResumeLayout(false);
            this.splitContainerVant.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVant)).EndInit();
            this.splitContainerVant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDetecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecorridos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecorridos;
        private System.Windows.Forms.PictureBox picRecorridos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainerDetecciones;
        private System.Windows.Forms.DataGridView dgvDetecciones;
        private System.Windows.Forms.PictureBox picDetecciones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainerVant;
        private System.Windows.Forms.DataGridViewButtonColumn clnBtnAccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

