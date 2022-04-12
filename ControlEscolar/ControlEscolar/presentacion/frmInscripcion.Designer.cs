namespace ControlEscolar.presentacion
{
    partial class frmInscripcion
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.linklblPadecimiento = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbADMON = new System.Windows.Forms.RadioButton();
            this.rbTICS = new System.Windows.Forms.RadioButton();
            this.rbHSC = new System.Windows.Forms.RadioButton();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.semestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsIdSemestre = new ControlEscolar.dsIdSemestre();
            this.label22 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsIdGrupo = new ControlEscolar.dsIdGrupo();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pbFotografia = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linklblalergia = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.btnAgregarMunicipio = new System.Windows.Forms.Button();
            this.btnAgregarDistrito = new System.Windows.Forms.Button();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.txtNumeroDeCasa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNss = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grupoTableAdapter = new ControlEscolar.dsIdGrupoTableAdapters.grupoTableAdapter();
            this.semestreTableAdapter = new ControlEscolar.dsIdSemestreTableAdapters.semestreTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdSemestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::ControlEscolar.Properties.Resources.diskette;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(43, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 63);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // linklblPadecimiento
            // 
            this.linklblPadecimiento.AutoSize = true;
            this.linklblPadecimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblPadecimiento.Location = new System.Drawing.Point(289, 542);
            this.linklblPadecimiento.Name = "linklblPadecimiento";
            this.linklblPadecimiento.Size = new System.Drawing.Size(87, 16);
            this.linklblPadecimiento.TabIndex = 38;
            this.linklblPadecimiento.TabStop = true;
            this.linklblPadecimiento.Text = "Padecimiento";
            this.linklblPadecimiento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblPadecimiento_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rbADMON);
            this.groupBox3.Controls.Add(this.rbTICS);
            this.groupBox3.Controls.Add(this.rbHSC);
            this.groupBox3.Controls.Add(this.cbSemestre);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cbGrupo);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtMatricula);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.pbFotografia);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(560, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 291);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Academicos";
            // 
            // rbADMON
            // 
            this.rbADMON.AutoSize = true;
            this.rbADMON.Location = new System.Drawing.Point(9, 265);
            this.rbADMON.Name = "rbADMON";
            this.rbADMON.Size = new System.Drawing.Size(121, 20);
            this.rbADMON.TabIndex = 31;
            this.rbADMON.TabStop = true;
            this.rbADMON.Text = "Administracion";
            this.rbADMON.UseVisualStyleBackColor = true;
            // 
            // rbTICS
            // 
            this.rbTICS.AutoSize = true;
            this.rbTICS.Location = new System.Drawing.Point(9, 238);
            this.rbTICS.Name = "rbTICS";
            this.rbTICS.Size = new System.Drawing.Size(223, 20);
            this.rbTICS.TabIndex = 30;
            this.rbTICS.TabStop = true;
            this.rbTICS.Text = "Tecnologias De La Informacion";
            this.rbTICS.UseVisualStyleBackColor = true;
            // 
            // rbHSC
            // 
            this.rbHSC.AutoSize = true;
            this.rbHSC.Location = new System.Drawing.Point(9, 207);
            this.rbHSC.Name = "rbHSC";
            this.rbHSC.Size = new System.Drawing.Size(209, 20);
            this.rbHSC.TabIndex = 29;
            this.rbHSC.TabStop = true;
            this.rbHSC.Text = "Higiene y Salud Comunitaria";
            this.rbHSC.UseVisualStyleBackColor = true;
            // 
            // cbSemestre
            // 
            this.cbSemestre.DataSource = this.semestreBindingSource;
            this.cbSemestre.DisplayMember = "IdSemestre";
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Location = new System.Drawing.Point(6, 166);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(95, 24);
            this.cbSemestre.TabIndex = 27;
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 16);
            this.label22.TabIndex = 28;
            this.label22.Text = "Semestre";
            // 
            // cbGrupo
            // 
            this.cbGrupo.DataSource = this.grupoBindingSource;
            this.cbGrupo.DisplayMember = "IdGrupo";
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(9, 109);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(92, 24);
            this.cbGrupo.TabIndex = 1;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "grupo";
            this.grupoBindingSource.DataSource = this.dsIdGrupo;
            // 
            // dsIdGrupo
            // 
            this.dsIdGrupo.DataSetName = "dsIdGrupo";
            this.dsIdGrupo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 16);
            this.label21.TabIndex = 26;
            this.label21.Text = "Grupo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(9, 57);
            this.txtMatricula.MaxLength = 15;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(92, 22);
            this.txtMatricula.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "Matricula";
            // 
            // pbFotografia
            // 
            this.pbFotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotografia.Location = new System.Drawing.Point(146, 54);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.Size = new System.Drawing.Size(185, 150);
            this.pbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotografia.TabIndex = 23;
            this.pbFotografia.TabStop = false;
            this.pbFotografia.Click += new System.EventHandler(this.pbFotografia_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fotografia";
            // 
            // linklblalergia
            // 
            this.linklblalergia.AutoSize = true;
            this.linklblalergia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblalergia.Location = new System.Drawing.Point(410, 544);
            this.linklblalergia.Name = "linklblalergia";
            this.linklblalergia.Size = new System.Drawing.Size(48, 16);
            this.linklblalergia.TabIndex = 37;
            this.linklblalergia.TabStop = true;
            this.linklblalergia.Text = "Alergia";
            this.linklblalergia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblalergia_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAgregarLocalidad);
            this.groupBox2.Controls.Add(this.btnAgregarMunicipio);
            this.groupBox2.Controls.Add(this.btnAgregarDistrito);
            this.groupBox2.Controls.Add(this.cbLocalidad);
            this.groupBox2.Controls.Add(this.cbMunicipio);
            this.groupBox2.Controls.Add(this.cbDistrito);
            this.groupBox2.Controls.Add(this.txtNumeroDeCasa);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtColonia);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(536, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 254);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion";
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.BackColor = System.Drawing.Color.Gray;
            this.btnAgregarLocalidad.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(197, 190);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(34, 29);
            this.btnAgregarLocalidad.TabIndex = 51;
            this.btnAgregarLocalidad.Text = "+";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = false;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.btnAgregarLocalidad_Click);
            // 
            // btnAgregarMunicipio
            // 
            this.btnAgregarMunicipio.BackColor = System.Drawing.Color.Gray;
            this.btnAgregarMunicipio.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMunicipio.Location = new System.Drawing.Point(197, 126);
            this.btnAgregarMunicipio.Name = "btnAgregarMunicipio";
            this.btnAgregarMunicipio.Size = new System.Drawing.Size(34, 29);
            this.btnAgregarMunicipio.TabIndex = 50;
            this.btnAgregarMunicipio.Text = "+";
            this.btnAgregarMunicipio.UseVisualStyleBackColor = false;
            this.btnAgregarMunicipio.Click += new System.EventHandler(this.btnAgregarMunicipio_Click);
            // 
            // btnAgregarDistrito
            // 
            this.btnAgregarDistrito.BackColor = System.Drawing.Color.Gray;
            this.btnAgregarDistrito.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDistrito.Location = new System.Drawing.Point(197, 51);
            this.btnAgregarDistrito.Name = "btnAgregarDistrito";
            this.btnAgregarDistrito.Size = new System.Drawing.Size(34, 29);
            this.btnAgregarDistrito.TabIndex = 49;
            this.btnAgregarDistrito.Text = "+";
            this.btnAgregarDistrito.UseVisualStyleBackColor = false;
            this.btnAgregarDistrito.Click += new System.EventHandler(this.btnAgregarDistrito_Click);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(9, 193);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(174, 24);
            this.cbLocalidad.TabIndex = 15;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(9, 131);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(174, 24);
            this.cbMunicipio.TabIndex = 14;
            this.cbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbMunicipio_SelectedIndexChanged);
            // 
            // cbDistrito
            // 
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(9, 55);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(174, 24);
            this.cbDistrito.TabIndex = 13;
            this.cbDistrito.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNumeroDeCasa
            // 
            this.txtNumeroDeCasa.Location = new System.Drawing.Point(243, 192);
            this.txtNumeroDeCasa.MaxLength = 10;
            this.txtNumeroDeCasa.Name = "txtNumeroDeCasa";
            this.txtNumeroDeCasa.Size = new System.Drawing.Size(142, 22);
            this.txtNumeroDeCasa.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Numero de Casa";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(243, 54);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(142, 22);
            this.txtColonia.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Colonia";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(243, 123);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(142, 22);
            this.txtCalle.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Calle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Localidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Municipio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Distrito";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtTutor);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtApellidoMaterno);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCurp);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNss);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 432);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(20, 398);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 16);
            this.label20.TabIndex = 22;
            this.label20.Text = "Fecha De Nacimiento";
            // 
            // txtTutor
            // 
            this.txtTutor.Location = new System.Drawing.Point(263, 398);
            this.txtTutor.MaxLength = 150;
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(185, 22);
            this.txtTutor.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 371);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "Padre Y/O Tutor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(263, 128);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(120, 22);
            this.txtCelular.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(20, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(20, 337);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(170, 24);
            this.cbEstado.TabIndex = 4;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sexo";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(20, 196);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(114, 22);
            this.txtApellidoMaterno.TabIndex = 2;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.cbSexo.Location = new System.Drawing.Point(260, 59);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 6;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Materno";
            // 
            // txtCurp
            // 
            this.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurp.Location = new System.Drawing.Point(260, 339);
            this.txtCurp.MaxLength = 18;
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(186, 22);
            this.txtCurp.TabIndex = 10;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(20, 129);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(114, 22);
            this.txtApellidoPaterno.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "CURP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono";
            // 
            // txtNss
            // 
            this.txtNss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNss.Location = new System.Drawing.Point(20, 271);
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(114, 22);
            this.txtNss.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(260, 199);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(123, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Numero De Seguro Social";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(260, 265);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(186, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo Electronico";
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // semestreTableAdapter
            // 
            this.semestreTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ControlEscolar.Properties.Resources.document_search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(243, 455);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 63);
            this.btnBuscar.TabIndex = 39;
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
            this.btnEliminar.Location = new System.Drawing.Point(341, 457);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 61);
            this.btnEliminar.TabIndex = 40;
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
            this.btnActualizar.Location = new System.Drawing.Point(138, 455);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 63);
            this.btnActualizar.TabIndex = 41;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlEscolar.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 581);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.linklblPadecimiento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.linklblalergia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInscripcion";
            this.Text = "Control Escolar - Inscripcion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInscripcion_FormClosed);
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdSemestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIdGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.LinkLabel linklblPadecimiento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbADMON;
        private System.Windows.Forms.RadioButton rbTICS;
        private System.Windows.Forms.RadioButton rbHSC;
        public System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbFotografia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linklblalergia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumeroDeCasa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelular;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtApellidoMaterno;
        public System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCurp;
        public System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNss;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private dsIdGrupo dsIdGrupo;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private dsIdGrupoTableAdapters.grupoTableAdapter grupoTableAdapter;
        private dsIdSemestre dsIdSemestre;
        private System.Windows.Forms.BindingSource semestreBindingSource;
        private dsIdSemestreTableAdapters.semestreTableAdapter semestreTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.Button btnAgregarMunicipio;
        private System.Windows.Forms.Button btnAgregarDistrito;
    }
}