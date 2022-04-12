namespace ControlEscolar.presentacion
{
    partial class frmAltaDocente
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIdProfesion = new System.Windows.Forms.ComboBox();
            this.profesionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNombreProfesion = new ControlEscolar.dsNombreProfesion();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pbFotografia = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.btnAgregarMunicipio = new System.Windows.Forms.Button();
            this.btnAgregarDistrito = new System.Windows.Forms.Button();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtNumeroDeCasa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdDireccion = new System.Windows.Forms.Label();
            this.LBLRFC = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.profesionesTableAdapter = new ControlEscolar.dsNombreProfesionTableAdapters.profesionesTableAdapter();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNombreProfesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::ControlEscolar.Properties.Resources.diskette;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(70, 462);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 61);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbIdProfesion);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtRFC);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.pbFotografia);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(536, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 226);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Academicos";
            // 
            // cbIdProfesion
            // 
            this.cbIdProfesion.DataSource = this.profesionesBindingSource;
            this.cbIdProfesion.DisplayMember = "NombreProfesion";
            this.cbIdProfesion.FormattingEnabled = true;
            this.cbIdProfesion.Location = new System.Drawing.Point(9, 128);
            this.cbIdProfesion.Name = "cbIdProfesion";
            this.cbIdProfesion.Size = new System.Drawing.Size(142, 26);
            this.cbIdProfesion.TabIndex = 19;
            this.cbIdProfesion.SelectedIndexChanged += new System.EventHandler(this.cbIdProfesion_SelectedIndexChanged);
            // 
            // profesionesBindingSource
            // 
            this.profesionesBindingSource.DataMember = "profesiones";
            this.profesionesBindingSource.DataSource = this.dsNombreProfesion;
            // 
            // dsNombreProfesion
            // 
            this.dsNombreProfesion.DataSetName = "dsNombreProfesion";
            this.dsNombreProfesion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 26;
            this.label20.Text = "Profesion";
            // 
            // txtRFC
            // 
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Location = new System.Drawing.Point(9, 57);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(142, 25);
            this.txtRFC.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "RFC";
            // 
            // pbFotografia
            // 
            this.pbFotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotografia.Location = new System.Drawing.Point(200, 57);
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
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(197, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fotografia";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAgregarLocalidad);
            this.groupBox2.Controls.Add(this.btnAgregarMunicipio);
            this.groupBox2.Controls.Add(this.btnAgregarDistrito);
            this.groupBox2.Controls.Add(this.cbLocalidad);
            this.groupBox2.Controls.Add(this.txtNumeroDeCasa);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtColonia);
            this.groupBox2.Controls.Add(this.cbMunicipio);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbDistrito);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(536, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 254);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion";
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(180, 189);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(34, 29);
            this.btnAgregarLocalidad.TabIndex = 48;
            this.btnAgregarLocalidad.Text = "+";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = true;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.btnAgregarLocalidad_Click);
            // 
            // btnAgregarMunicipio
            // 
            this.btnAgregarMunicipio.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMunicipio.Location = new System.Drawing.Point(180, 120);
            this.btnAgregarMunicipio.Name = "btnAgregarMunicipio";
            this.btnAgregarMunicipio.Size = new System.Drawing.Size(34, 29);
            this.btnAgregarMunicipio.TabIndex = 47;
            this.btnAgregarMunicipio.Text = "+";
            this.btnAgregarMunicipio.UseVisualStyleBackColor = true;
            this.btnAgregarMunicipio.Click += new System.EventHandler(this.btnAgregarMunicipio_Click);
            // 
            // btnAgregarDistrito
            // 
            this.btnAgregarDistrito.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDistrito.Location = new System.Drawing.Point(180, 57);
            this.btnAgregarDistrito.Name = "btnAgregarDistrito";
            this.btnAgregarDistrito.Size = new System.Drawing.Size(34, 29);
            this.btnAgregarDistrito.TabIndex = 46;
            this.btnAgregarDistrito.Text = "+";
            this.btnAgregarDistrito.UseVisualStyleBackColor = true;
            this.btnAgregarDistrito.Click += new System.EventHandler(this.btnAgregarDistrito_Click);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(9, 193);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(165, 24);
            this.cbLocalidad.TabIndex = 45;
            this.cbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbLocalidad_SelectedIndexChanged);
            // 
            // txtNumeroDeCasa
            // 
            this.txtNumeroDeCasa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDeCasa.Location = new System.Drawing.Point(247, 193);
            this.txtNumeroDeCasa.Name = "txtNumeroDeCasa";
            this.txtNumeroDeCasa.Size = new System.Drawing.Size(142, 22);
            this.txtNumeroDeCasa.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(244, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 18);
            this.label17.TabIndex = 10;
            this.label17.Text = "Numero de Casa";
            // 
            // txtColonia
            // 
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(247, 55);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(142, 22);
            this.txtColonia.TabIndex = 15;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(9, 126);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(165, 24);
            this.cbMunicipio.TabIndex = 44;
            this.cbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbMunicipio_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(244, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 8;
            this.label16.Text = "Colonia";
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(247, 124);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(142, 22);
            this.txtCalle.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Calle";
            // 
            // cbDistrito
            // 
            this.cbDistrito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(9, 56);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(165, 24);
            this.cbDistrito.TabIndex = 43;
            this.cbDistrito.SelectedIndexChanged += new System.EventHandler(this.cbDistrito_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Localidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Municipio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Distrito";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblIdDireccion);
            this.groupBox1.Controls.Add(this.LBLRFC);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 432);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // lblIdDireccion
            // 
            this.lblIdDireccion.AutoSize = true;
            this.lblIdDireccion.Location = new System.Drawing.Point(322, 380);
            this.lblIdDireccion.Name = "lblIdDireccion";
            this.lblIdDireccion.Size = new System.Drawing.Size(58, 18);
            this.lblIdDireccion.TabIndex = 43;
            this.lblIdDireccion.Text = "label21";
            // 
            // LBLRFC
            // 
            this.LBLRFC.AutoSize = true;
            this.LBLRFC.Location = new System.Drawing.Point(395, 380);
            this.LBLRFC.Name = "LBLRFC";
            this.LBLRFC.Size = new System.Drawing.Size(58, 18);
            this.LBLRFC.TabIndex = 42;
            this.LBLRFC.Text = "label21";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(20, 404);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(185, 25);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 377);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 16);
            this.label19.TabIndex = 24;
            this.label19.Text = "Fecha De Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(263, 128);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(193, 25);
            this.txtCelular.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(20, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbEstado.Size = new System.Drawing.Size(185, 26);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sexo";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(20, 199);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(193, 25);
            this.txtApellidoMaterno.TabIndex = 3;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbSexo.Location = new System.Drawing.Point(260, 59);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 26);
            this.cbSexo.TabIndex = 7;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Materno";
            // 
            // txtCurp
            // 
            this.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurp.Location = new System.Drawing.Point(260, 339);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(188, 25);
            this.txtCurp.TabIndex = 11;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(20, 130);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(193, 25);
            this.txtApellidoPaterno.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "CURP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtNss.Size = new System.Drawing.Size(185, 25);
            this.txtNss.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(260, 199);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(193, 25);
            this.txtTelefono.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Numero De Seguro Social";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(260, 265);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(193, 25);
            this.txtCorreo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo Electronico";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ControlEscolar.Properties.Resources.document_search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(277, 462);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 61);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Silver;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::ControlEscolar.Properties.Resources.notification_done;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(167, 462);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 61);
            this.btnActualizar.TabIndex = 41;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // profesionesTableAdapter
            // 
            this.profesionesTableAdapter.ClearBeforeFill = true;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Silver;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = global::ControlEscolar.Properties.Resources.document_delete;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(384, 462);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 61);
            this.btneliminar.TabIndex = 42;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // frmAltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlEscolar.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 537);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAltaDocente";
            this.Text = "Control Escolar - Formulario Alta de Docentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAltaDocente_FormClosed);
            this.Load += new System.EventHandler(this.frmAltaDocente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNombreProfesion)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbIdProfesion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbFotografia;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNss;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private dsNombreProfesion dsNombreProfesion;
        private System.Windows.Forms.BindingSource profesionesBindingSource;
        private dsNombreProfesionTableAdapters.profesionesTableAdapter profesionesTableAdapter;
        private System.Windows.Forms.Label LBLRFC;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblIdDireccion;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.Button btnAgregarMunicipio;
        private System.Windows.Forms.Button btnAgregarDistrito;
    }
}