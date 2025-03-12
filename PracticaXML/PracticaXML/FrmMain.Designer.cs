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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btComarques = new System.Windows.Forms.Button();
            this.dgvMunicipis = new System.Windows.Forms.DataGridView();
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
            this.nupAny = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbArchivo = new System.Windows.Forms.TextBox();
            this.chbCategoria = new System.Windows.Forms.CheckBox();
            this.cbUnitat = new System.Windows.Forms.CheckBox();
            this.cbDepartament = new System.Windows.Forms.CheckBox();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obsequi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LliuratPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebutPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinatA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipis)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAny)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.btComarques);
            this.groupBox4.Location = new System.Drawing.Point(564, 633);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(653, 84);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Crear arxius xml";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(237, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Municipis";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(418, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Recollida";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btComarques
            // 
            this.btComarques.BackColor = System.Drawing.Color.Chocolate;
            this.btComarques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComarques.ForeColor = System.Drawing.Color.Black;
            this.btComarques.Location = new System.Drawing.Point(60, 24);
            this.btComarques.Name = "btComarques";
            this.btComarques.Size = new System.Drawing.Size(158, 45);
            this.btComarques.TabIndex = 2;
            this.btComarques.Text = "Comarques";
            this.btComarques.UseVisualStyleBackColor = false;
            // 
            // dgvMunicipis
            // 
            this.dgvMunicipis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departamento,
            this.Obsequi,
            this.Data,
            this.LliuratPer,
            this.RebutPer,
            this.DestinatA});
            this.dgvMunicipis.Location = new System.Drawing.Point(564, 246);
            this.dgvMunicipis.Name = "dgvMunicipis";
            this.dgvMunicipis.Size = new System.Drawing.Size(653, 381);
            this.dgvMunicipis.TabIndex = 9;
            this.dgvMunicipis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMunicipis_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(147, 710);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 46);
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
            this.groupBox3.Location = new System.Drawing.Point(564, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "totals";
            // 
            // tbMunicipis
            // 
            this.tbMunicipis.Location = new System.Drawing.Point(431, 35);
            this.tbMunicipis.Name = "tbMunicipis";
            this.tbMunicipis.ReadOnly = true;
            this.tbMunicipis.Size = new System.Drawing.Size(139, 20);
            this.tbMunicipis.TabIndex = 3;
            // 
            // tbComarca
            // 
            this.tbComarca.Location = new System.Drawing.Point(134, 35);
            this.tbComarca.Name = "tbComarca";
            this.tbComarca.ReadOnly = true;
            this.tbComarca.Size = new System.Drawing.Size(115, 20);
            this.tbComarca.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Municipis seleccionats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 544);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tria les dades a consular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fins a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Desde";
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(92, 57);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(164, 20);
            this.dateDesde.TabIndex = 23;
            // 
            // dateFins
            // 
            this.dateFins.Location = new System.Drawing.Point(330, 57);
            this.dateFins.Name = "dateFins";
            this.dateFins.Size = new System.Drawing.Size(184, 20);
            this.dateFins.TabIndex = 22;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(361, 102);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(112, 17);
            this.rbCategoria.TabIndex = 21;
            this.rbCategoria.Text = "Categoria Obsequi";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbUnitat
            // 
            this.rbUnitat.AutoSize = true;
            this.rbUnitat.Location = new System.Drawing.Point(215, 102);
            this.rbUnitat.Name = "rbUnitat";
            this.rbUnitat.Size = new System.Drawing.Size(99, 17);
            this.rbUnitat.TabIndex = 20;
            this.rbUnitat.Text = "Unitat Organica";
            this.rbUnitat.UseVisualStyleBackColor = true;
            this.rbUnitat.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbDepartament
            // 
            this.rbDepartament.AutoSize = true;
            this.rbDepartament.Location = new System.Drawing.Point(73, 102);
            this.rbDepartament.Name = "rbDepartament";
            this.rbDepartament.Size = new System.Drawing.Size(86, 17);
            this.rbDepartament.TabIndex = 19;
            this.rbDepartament.Text = "Departament";
            this.rbDepartament.UseVisualStyleBackColor = true;
            this.rbDepartament.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Filtrar per";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(39, 143);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(449, 21);
            this.comboBox.TabIndex = 14;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // llObsequis
            // 
            this.llObsequis.FormattingEnabled = true;
            this.llObsequis.Location = new System.Drawing.Point(39, 170);
            this.llObsequis.Name = "llObsequis";
            this.llObsequis.ScrollAlwaysVisible = true;
            this.llObsequis.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.llObsequis.Size = new System.Drawing.Size(449, 368);
            this.llObsequis.TabIndex = 9;
            // 
            // nupAny
            // 
            this.nupAny.Location = new System.Drawing.Point(393, 94);
            this.nupAny.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nupAny.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nupAny.Name = "nupAny";
            this.nupAny.Size = new System.Drawing.Size(80, 20);
            this.nupAny.TabIndex = 3;
            this.nupAny.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupAny.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbArchivo);
            this.groupBox1.Controls.Add(this.chbCategoria);
            this.groupBox1.Controls.Add(this.cbUnitat);
            this.groupBox1.Controls.Add(this.cbDepartament);
            this.groupBox1.Controls.Add(this.nupAny);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fitxer XML";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(668, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Examinar...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbArchivo
            // 
            this.tbArchivo.Location = new System.Drawing.Point(73, 57);
            this.tbArchivo.Name = "tbArchivo";
            this.tbArchivo.Size = new System.Drawing.Size(540, 20);
            this.tbArchivo.TabIndex = 0;
            // 
            // chbCategoria
            // 
            this.chbCategoria.AutoSize = true;
            this.chbCategoria.Location = new System.Drawing.Point(259, 95);
            this.chbCategoria.Name = "chbCategoria";
            this.chbCategoria.Size = new System.Drawing.Size(113, 17);
            this.chbCategoria.TabIndex = 17;
            this.chbCategoria.Text = "Categoria Obsequi";
            this.chbCategoria.UseVisualStyleBackColor = true;
            // 
            // cbUnitat
            // 
            this.cbUnitat.AutoSize = true;
            this.cbUnitat.Location = new System.Drawing.Point(144, 95);
            this.cbUnitat.Name = "cbUnitat";
            this.cbUnitat.Size = new System.Drawing.Size(100, 17);
            this.cbUnitat.TabIndex = 16;
            this.cbUnitat.Text = "Unitat Organica";
            this.cbUnitat.UseVisualStyleBackColor = true;
            // 
            // cbDepartament
            // 
            this.cbDepartament.AutoSize = true;
            this.cbDepartament.Location = new System.Drawing.Point(24, 95);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.Size = new System.Drawing.Size(87, 17);
            this.cbDepartament.TabIndex = 15;
            this.cbDepartament.Text = "Departament";
            this.cbDepartament.UseVisualStyleBackColor = true;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // Obsequi
            // 
            this.Obsequi.HeaderText = "Obsequi";
            this.Obsequi.Name = "Obsequi";
            this.Obsequi.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // LliuratPer
            // 
            this.LliuratPer.HeaderText = "Lliurat Per";
            this.LliuratPer.Name = "LliuratPer";
            this.LliuratPer.ReadOnly = true;
            // 
            // RebutPer
            // 
            this.RebutPer.HeaderText = "Rebut Per";
            this.RebutPer.Name = "RebutPer";
            this.RebutPer.ReadOnly = true;
            // 
            // DestinatA
            // 
            this.DestinatA.HeaderText = "Destinat a";
            this.DestinatA.Name = "DestinatA";
            this.DestinatA.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 759);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvMunicipis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipis)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAny)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btComarques;
        private System.Windows.Forms.DataGridView dgvMunicipis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMunicipis;
        private System.Windows.Forms.TextBox tbComarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox llObsequis;
        private System.Windows.Forms.NumericUpDown nupAny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbCategoria;
        private System.Windows.Forms.CheckBox cbUnitat;
        private System.Windows.Forms.CheckBox cbDepartament;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbUnitat;
        private System.Windows.Forms.RadioButton rbDepartament;
        private System.Windows.Forms.DateTimePicker dateFins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obsequi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn LliuratPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RebutPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinatA;
    }
}

