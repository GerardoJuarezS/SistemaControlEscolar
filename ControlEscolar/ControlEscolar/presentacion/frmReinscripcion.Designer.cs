namespace ControlEscolar.presentacion
{
    partial class frmReinscripcion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbADMON = new System.Windows.Forms.RadioButton();
            this.rbHSC = new System.Windows.Forms.RadioButton();
            this.rbTICS = new System.Windows.Forms.RadioButton();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.semestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsIdSemestre = new ControlEscolar.dsIdSemestre();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.cbMatricula = new System.Windows.Forms.ComboBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMatricula = new ControlEscolar.dsMatricula();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMateriasAnteriores = new System.Windows.Forms.DataGridView();
            this.semestreTableAdapter = new ControlEscolar.dsIdSemestreTableAdapters.semestreTableAdapter();
            this.alumnoTableAdapter = new ControlEscolar.dsMatriculaTableAdapters.alumnoTableAdapter();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dsIdGrupo = new ControlEscolar.dsIdGrupo();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new ControlEscolar.dsIdGrupoTableAdapters.grupoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdSemestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatricula)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAnteriores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbGrupo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.lblSemestre);
            this.groupBox1.Controls.Add(this.cbSemestre);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbMatricula);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Reinscripcion";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbADMON);
            this.flowLayoutPanel1.Controls.Add(this.rbHSC);
            this.flowLayoutPanel1.Controls.Add(this.rbTICS);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 81);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // rbADMON
            // 
            this.rbADMON.AutoSize = true;
            this.rbADMON.Location = new System.Drawing.Point(3, 3);
            this.rbADMON.Name = "rbADMON";
            this.rbADMON.Size = new System.Drawing.Size(130, 22);
            this.rbADMON.TabIndex = 34;
            this.rbADMON.TabStop = true;
            this.rbADMON.Text = "Administracion";
            this.rbADMON.UseVisualStyleBackColor = true;
            // 
            // rbHSC
            // 
            this.rbHSC.AutoSize = true;
            this.rbHSC.Location = new System.Drawing.Point(3, 31);
            this.rbHSC.Name = "rbHSC";
            this.rbHSC.Size = new System.Drawing.Size(225, 22);
            this.rbHSC.TabIndex = 32;
            this.rbHSC.TabStop = true;
            this.rbHSC.Text = "Higiene y Salud Comunitaria";
            this.rbHSC.UseVisualStyleBackColor = true;
            // 
            // rbTICS
            // 
            this.rbTICS.AutoSize = true;
            this.rbTICS.Location = new System.Drawing.Point(3, 59);
            this.rbTICS.Name = "rbTICS";
            this.rbTICS.Size = new System.Drawing.Size(244, 22);
            this.rbTICS.TabIndex = 33;
            this.rbTICS.TabStop = true;
            this.rbTICS.Text = "Tecnologias De La Informacion";
            this.rbTICS.UseVisualStyleBackColor = true;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(658, 97);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(66, 16);
            this.lblSemestre.TabIndex = 23;
            this.lblSemestre.Text = "Semestre";
            // 
            // cbSemestre
            // 
            this.cbSemestre.DataSource = this.semestreBindingSource;
            this.cbSemestre.DisplayMember = "IdSemestre";
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Location = new System.Drawing.Point(184, 37);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(121, 26);
            this.cbSemestre.TabIndex = 4;
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::ControlEscolar.Properties.Resources.diskette;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(314, 169);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 59);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(654, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 18);
            this.label18.TabIndex = 22;
            this.label18.Text = "Semestre";
            // 
            // cbMatricula
            // 
            this.cbMatricula.DataSource = this.alumnoBindingSource;
            this.cbMatricula.DisplayMember = "Matricula";
            this.cbMatricula.FormattingEnabled = true;
            this.cbMatricula.Location = new System.Drawing.Point(18, 37);
            this.cbMatricula.Name = "cbMatricula";
            this.cbMatricula.Size = new System.Drawing.Size(121, 26);
            this.cbMatricula.TabIndex = 3;
            this.cbMatricula.SelectedIndexChanged += new System.EventHandler(this.cbMatricula_SelectedIndexChanged);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.dsMatricula;
            // 
            // dsMatricula
            // 
            this.dsMatricula.DataSetName = "dsMatricula";
            this.dsMatricula.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(467, 100);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(45, 16);
            this.lblGrupo.TabIndex = 21;
            this.lblGrupo.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semestre a Cursar";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAM.Location = new System.Drawing.Point(728, 37);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(110, 16);
            this.lblAM.TabIndex = 20;
            this.lblAM.Text = "Apellido Materno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(527, 37);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(108, 16);
            this.lblAP.TabIndex = 19;
            this.lblAP.Text = "Apellido Paterno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(389, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Apellido Paterno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Grupo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(716, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Apellido Materno";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.dgvMateriasAnteriores);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(30, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calificaciones obtenidas";
            // 
            // dgvMateriasAnteriores
            // 
            this.dgvMateriasAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAnteriores.Location = new System.Drawing.Point(6, 21);
            this.dgvMateriasAnteriores.Name = "dgvMateriasAnteriores";
            this.dgvMateriasAnteriores.Size = new System.Drawing.Size(838, 211);
            this.dgvMateriasAnteriores.TabIndex = 0;
            // 
            // semestreTableAdapter
            // 
            this.semestreTableAdapter.ClearBeforeFill = true;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // cbGrupo
            // 
            this.cbGrupo.DataSource = this.grupoBindingSource;
            this.cbGrupo.DisplayMember = "IdGrupo";
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(108, 99);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(121, 26);
            this.cbGrupo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Matricula";
            // 
            // dsIdGrupo
            // 
            this.dsIdGrupo.DataSetName = "dsIdGrupo";
            this.dsIdGrupo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "grupo";
            this.grupoBindingSource.DataSource = this.dsIdGrupo;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReinscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlEscolar.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReinscripcion";
            this.Text = "Control Escolar - Reinscripcion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReinscripcion_FormClosed);
            this.Load += new System.EventHandler(this.frmReinscripcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdSemestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatricula)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAnteriores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbADMON;
        private System.Windows.Forms.RadioButton rbHSC;
        private System.Windows.Forms.RadioButton rbTICS;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbMatricula;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private dsIdSemestre dsIdSemestre;
        private System.Windows.Forms.BindingSource semestreBindingSource;
        private dsIdSemestreTableAdapters.semestreTableAdapter semestreTableAdapter;
        private dsMatricula dsMatricula;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private dsMatriculaTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.DataGridView dgvMateriasAnteriores;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label3;
        private dsIdGrupo dsIdGrupo;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private dsIdGrupoTableAdapters.grupoTableAdapter grupoTableAdapter;
    }
}