namespace ControlEscolar.presentacion
{
    partial class frmDocentesMaterias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDocenteMateria = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbRFC = new System.Windows.Forms.ComboBox();
            this.docentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRfc = new ControlEscolar.dsRfc();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.rbADMON = new System.Windows.Forms.RadioButton();
            this.rbTICS = new System.Windows.Forms.RadioButton();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.semestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsIdSemestre = new ControlEscolar.dsIdSemestre();
            this.rbHSC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.semestreTableAdapter = new ControlEscolar.dsIdSemestreTableAdapters.semestreTableAdapter();
            this.docentesTableAdapter = new ControlEscolar.dsRfcTableAdapters.docentesTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteMateria)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRfc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::ControlEscolar.Properties.Resources.diskette;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(12, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 63);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvDocenteMateria);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(439, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 213);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materias Impartidas Por Docentes";
            // 
            // dgvDocenteMateria
            // 
            this.dgvDocenteMateria.AllowUserToAddRows = false;
            this.dgvDocenteMateria.AllowUserToDeleteRows = false;
            this.dgvDocenteMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocenteMateria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocenteMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocenteMateria.Location = new System.Drawing.Point(3, 18);
            this.dgvDocenteMateria.Name = "dgvDocenteMateria";
            this.dgvDocenteMateria.ReadOnly = true;
            this.dgvDocenteMateria.Size = new System.Drawing.Size(491, 192);
            this.dgvDocenteMateria.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblAMaterno);
            this.groupBox2.Controls.Add(this.lblAPaterno);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.cbRFC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 149);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Docentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(432, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(223, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MistyRose;
            this.label9.Location = new System.Drawing.Point(61, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Location = new System.Drawing.Point(421, 96);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(117, 16);
            this.lblAMaterno.TabIndex = 4;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Location = new System.Drawing.Point(218, 95);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(115, 16);
            this.lblAPaterno.TabIndex = 3;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // cbRFC
            // 
            this.cbRFC.DataSource = this.docentesBindingSource;
            this.cbRFC.DisplayMember = "Rfc";
            this.cbRFC.FormattingEnabled = true;
            this.cbRFC.Location = new System.Drawing.Point(187, 42);
            this.cbRFC.Name = "cbRFC";
            this.cbRFC.Size = new System.Drawing.Size(206, 24);
            this.cbRFC.TabIndex = 1;
            this.cbRFC.SelectedIndexChanged += new System.EventHandler(this.cbRFC_SelectedIndexChanged);
            // 
            // docentesBindingSource
            // 
            this.docentesBindingSource.DataMember = "docentes";
            this.docentesBindingSource.DataSource = this.dsRfc;
            // 
            // dsRfc
            // 
            this.dsRfc.DataSetName = "dsRfc";
            this.dsRfc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "RFC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(406, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "__________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(197, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "__________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(16, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "__________________";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "";
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.rbADMON);
            this.groupBox1.Controls.Add(this.rbTICS);
            this.groupBox1.Controls.Add(this.cbSemestre);
            this.groupBox1.Controls.Add(this.rbHSC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMateria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 268);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(247, 138);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(47, 16);
            this.lb1.TabIndex = 60;
            this.lb1.Text = "label5";
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(200, 164);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(47, 16);
            this.lb2.TabIndex = 59;
            this.lb2.Text = "label4";
            this.lb2.Visible = false;
            // 
            // rbADMON
            // 
            this.rbADMON.AutoSize = true;
            this.rbADMON.Location = new System.Drawing.Point(9, 142);
            this.rbADMON.Name = "rbADMON";
            this.rbADMON.Size = new System.Drawing.Size(121, 20);
            this.rbADMON.TabIndex = 58;
            this.rbADMON.TabStop = true;
            this.rbADMON.Text = "Administracion";
            this.rbADMON.UseVisualStyleBackColor = true;
            // 
            // rbTICS
            // 
            this.rbTICS.AutoSize = true;
            this.rbTICS.Location = new System.Drawing.Point(9, 115);
            this.rbTICS.Name = "rbTICS";
            this.rbTICS.Size = new System.Drawing.Size(223, 20);
            this.rbTICS.TabIndex = 57;
            this.rbTICS.TabStop = true;
            this.rbTICS.Text = "Tecnologias De La Informacion";
            this.rbTICS.UseVisualStyleBackColor = true;
            // 
            // cbSemestre
            // 
            this.cbSemestre.AccessibleDescription = "Muestra los Semestres";
            this.cbSemestre.AccessibleName = "semestre";
            this.cbSemestre.DataSource = this.semestreBindingSource;
            this.cbSemestre.DisplayMember = "IdSemestre";
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Location = new System.Drawing.Point(9, 42);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(314, 24);
            this.cbSemestre.TabIndex = 3;
            this.cbSemestre.SelectedIndexChanged += new System.EventHandler(this.cbSemestre_SelectedIndexChanged);
            // 
            // semestreBindingSource
            // 
            this.semestreBindingSource.DataMember = "semestre";
            this.semestreBindingSource.DataSource = this.dsIdSemestre;
            // 
            // dsIdSemestre
            // 
            this.dsIdSemestre.DataSetName = "dsIdSemestre";
            this.dsIdSemestre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbHSC
            // 
            this.rbHSC.AutoSize = true;
            this.rbHSC.Location = new System.Drawing.Point(9, 84);
            this.rbHSC.Name = "rbHSC";
            this.rbHSC.Size = new System.Drawing.Size(209, 20);
            this.rbHSC.TabIndex = 56;
            this.rbHSC.TabStop = true;
            this.rbHSC.Text = "Higiene y Salud Comunitaria";
            this.rbHSC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semestre";
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(9, 209);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(314, 24);
            this.cbMateria.TabIndex = 1;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // semestreTableAdapter
            // 
            this.semestreTableAdapter.ClearBeforeFill = true;
            // 
            // docentesTableAdapter
            // 
            this.docentesTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ControlEscolar.Properties.Resources.document_search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(339, 309);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 63);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::ControlEscolar.Properties.Resources.document_delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(231, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 63);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::ControlEscolar.Properties.Resources.notification_done;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(113, 309);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 63);
            this.btnActualizar.TabIndex = 64;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmDocentesMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlEscolar.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 402);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDocentesMaterias";
            this.Text = "Control Escolar - Docentes Materias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDocentesMaterias_FormClosed);
            this.Load += new System.EventHandler(this.frmDocentesMaterias_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteMateria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRfc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdSemestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDocenteMateria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbADMON;
        private System.Windows.Forms.RadioButton rbTICS;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.RadioButton rbHSC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dsIdSemestre dsIdSemestre;
        private System.Windows.Forms.BindingSource semestreBindingSource;
        private dsIdSemestreTableAdapters.semestreTableAdapter semestreTableAdapter;
        private dsRfc dsRfc;
        private System.Windows.Forms.BindingSource docentesBindingSource;
        private dsRfcTableAdapters.docentesTableAdapter docentesTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}