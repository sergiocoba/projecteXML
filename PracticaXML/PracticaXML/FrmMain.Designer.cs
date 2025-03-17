namespace PracticaXML
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btDepartaments = new System.Windows.Forms.Button();
            this.btUnitat = new System.Windows.Forms.Button();
            this.btObsequis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMunicipis = new System.Windows.Forms.TextBox();
            this.tbComarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.dateFins = new System.Windows.Forms.DateTimePicker();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbUnitat = new System.Windows.Forms.RadioButton();
            this.rbDepartament = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.llObsequis = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbArchivo = new System.Windows.Forms.TextBox();
            this.dgvObsequis = new System.Windows.Forms.DataGridView();
            this.Departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlg = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsequis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btDepartaments);
            this.groupBox4.Controls.Add(this.btUnitat);
            this.groupBox4.Controls.Add(this.btObsequis);
            this.groupBox4.Location = new System.Drawing.Point(575, 633);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(745, 84);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Crear arxius xml";
            // 
            // btDepartaments
            // 
            this.btDepartaments.BackColor = System.Drawing.Color.Yellow;
            this.btDepartaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepartaments.ForeColor = System.Drawing.Color.Black;
            this.btDepartaments.Location = new System.Drawing.Point(276, 24);
            this.btDepartaments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDepartaments.Name = "btDepartaments";
            this.btDepartaments.Size = new System.Drawing.Size(185, 45);
            this.btDepartaments.TabIndex = 4;
            this.btDepartaments.Text = "Departaments";
            this.btDepartaments.UseVisualStyleBackColor = false;
            this.btDepartaments.Click += new System.EventHandler(this.button5_Click);
            // 
            // btUnitat
            // 
            this.btUnitat.BackColor = System.Drawing.Color.Lime;
            this.btUnitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnitat.ForeColor = System.Drawing.Color.Black;
            this.btUnitat.Location = new System.Drawing.Point(487, 24);
            this.btUnitat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btUnitat.Name = "btUnitat";
            this.btUnitat.Size = new System.Drawing.Size(178, 45);
            this.btUnitat.TabIndex = 3;
            this.btUnitat.Text = "Unitats Organiques";
            this.btUnitat.UseVisualStyleBackColor = false;
            this.btUnitat.Click += new System.EventHandler(this.btUnitat_Click);
            // 
            // btObsequis
            // 
            this.btObsequis.BackColor = System.Drawing.Color.Chocolate;
            this.btObsequis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btObsequis.ForeColor = System.Drawing.Color.Black;
            this.btObsequis.Location = new System.Drawing.Point(70, 24);
            this.btObsequis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btObsequis.Name = "btObsequis";
            this.btObsequis.Size = new System.Drawing.Size(185, 45);
            this.btObsequis.TabIndex = 2;
            this.btObsequis.Text = "Obsequis";
            this.btObsequis.UseVisualStyleBackColor = false;
            this.btObsequis.Click += new System.EventHandler(this.btObsequis_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 710);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mostrar dades";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMunicipis);
            this.groupBox3.Controls.Add(this.tbComarca);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(575, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(744, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "totals";
            // 
            // tbMunicipis
            // 
            this.tbMunicipis.Location = new System.Drawing.Point(503, 35);
            this.tbMunicipis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMunicipis.Name = "tbMunicipis";
            this.tbMunicipis.ReadOnly = true;
            this.tbMunicipis.Size = new System.Drawing.Size(162, 21);
            this.tbMunicipis.TabIndex = 3;
            // 
            // tbComarca
            // 
            this.tbComarca.Location = new System.Drawing.Point(157, 35);
            this.tbComarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbComarca.Name = "tbComarca";
            this.tbComarca.ReadOnly = true;
            this.tbComarca.Size = new System.Drawing.Size(134, 21);
            this.tbComarca.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Municipis seleccionats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comarca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateDesde);
            this.groupBox2.Controls.Add(this.dateFins);
            this.groupBox2.Controls.Add(this.rbCategoria);
            this.groupBox2.Controls.Add(this.rbUnitat);
            this.groupBox2.Controls.Add(this.rbDepartament);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.llObsequis);
            this.groupBox2.Location = new System.Drawing.Point(14, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(553, 544);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tria les dades a consular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fins a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Desde";
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(70, 57);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(190, 21);
            this.dateDesde.TabIndex = 23;
            // 
            // dateFins
            // 
            this.dateFins.Location = new System.Drawing.Point(317, 57);
            this.dateFins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateFins.Name = "dateFins";
            this.dateFins.Size = new System.Drawing.Size(214, 21);
            this.dateFins.TabIndex = 22;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(400, 102);
            this.rbCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(131, 17);
            this.rbCategoria.TabIndex = 21;
            this.rbCategoria.Text = "Categoria Obsequi";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbUnitat
            // 
            this.rbUnitat.AutoSize = true;
            this.rbUnitat.Location = new System.Drawing.Point(240, 102);
            this.rbUnitat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbUnitat.Name = "rbUnitat";
            this.rbUnitat.Size = new System.Drawing.Size(113, 17);
            this.rbUnitat.TabIndex = 20;
            this.rbUnitat.Text = "Unitat Organica";
            this.rbUnitat.UseVisualStyleBackColor = true;
            this.rbUnitat.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbDepartament
            // 
            this.rbDepartament.AutoSize = true;
            this.rbDepartament.Location = new System.Drawing.Point(85, 102);
            this.rbDepartament.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbDepartament.Name = "rbDepartament";
            this.rbDepartament.Size = new System.Drawing.Size(100, 17);
            this.rbDepartament.TabIndex = 19;
            this.rbDepartament.Text = "Departament";
            this.rbDepartament.UseVisualStyleBackColor = true;
            this.rbDepartament.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Filtrar per";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(8, 143);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(523, 21);
            this.comboBox.TabIndex = 14;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // llObsequis
            // 
            this.llObsequis.FormattingEnabled = true;
            this.llObsequis.Location = new System.Drawing.Point(8, 170);
            this.llObsequis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.llObsequis.Name = "llObsequis";
            this.llObsequis.ScrollAlwaysVisible = true;
            this.llObsequis.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.llObsequis.Size = new System.Drawing.Size(523, 368);
            this.llObsequis.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbArchivo);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1305, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fitxer XML";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(780, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Examinar...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbArchivo
            // 
            this.tbArchivo.Location = new System.Drawing.Point(85, 57);
            this.tbArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbArchivo.Name = "tbArchivo";
            this.tbArchivo.Size = new System.Drawing.Size(630, 21);
            this.tbArchivo.TabIndex = 0;
            // 
            // dgvObsequis
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvObsequis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObsequis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObsequis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObsequis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvObsequis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvObsequis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObsequis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departament,
            this.Column4,
            this.fecha,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObsequis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObsequis.Location = new System.Drawing.Point(575, 233);
            this.dgvObsequis.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObsequis.Name = "dgvObsequis";
            this.dgvObsequis.RowHeadersVisible = false;
            this.dgvObsequis.RowHeadersWidth = 51;
            this.dgvObsequis.RowTemplate.Height = 24;
            this.dgvObsequis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObsequis.Size = new System.Drawing.Size(745, 384);
            this.dgvObsequis.TabIndex = 22;
            // 
            // Departament
            // 
            this.Departament.HeaderText = "Departament";
            this.Departament.Name = "Departament";
            this.Departament.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Obsequi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Data";
            this.fecha.Name = "fecha";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lliurat per";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rebut Per";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Destinat a";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dlg
            // 
            this.dlg.Filter = "(*.xml)|*.xml\"";
            this.dlg.Title = "Guardar arxiu XML";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 759);
            this.Controls.Add(this.dgvObsequis);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "Obsequits rebuts per alts carrecs";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsequis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btDepartaments;
        private System.Windows.Forms.Button btUnitat;
        private System.Windows.Forms.Button btObsequis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMunicipis;
        private System.Windows.Forms.TextBox tbComarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox llObsequis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbUnitat;
        private System.Windows.Forms.RadioButton rbDepartament;
        private System.Windows.Forms.DateTimePicker dateFins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.DataGridView dgvObsequis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.SaveFileDialog dlg;
    }
}

