namespace ControlEscolar.presentacion
{
    partial class frmCalificaciones
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt4P = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt5P = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt6P = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSegundoPromedio = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt1P = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt2P = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt3P = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimerPromedio = new System.Windows.Forms.TextBox();
            this.txtPromedioGeneral = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblvacio = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.rbADMON = new System.Windows.Forms.RadioButton();
            this.rbTICS = new System.Windows.Forms.RadioButton();
            this.rbHSC = new System.Windows.Forms.RadioButton();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMatricula = new System.Windows.Forms.ComboBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMatricula = new ControlEscolar.dsMatricula();
            this.alumnoTableAdapter = new ControlEscolar.dsMatriculaTableAdapters.alumnoTableAdapter();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.txtPromedioGeneral);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(81, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calificaciones";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel3.Controls.Add(this.btnActualizar);
            this.flowLayoutPanel3.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel3.Controls.Add(this.btnBusqueda);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(402, 139);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(334, 66);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::ControlEscolar.Properties.Resources.diskette;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 63);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::ControlEscolar.Properties.Resources.notification_done;
            this.btnActualizar.Location = new System.Drawing.Point(90, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 61);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ControlEscolar.Properties.Resources.document_delete;
            this.btnEliminar.Location = new System.Drawing.Point(177, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 61);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Gray;
            this.btnBusqueda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Image = global::ControlEscolar.Properties.Resources.document_search;
            this.btnBusqueda.Location = new System.Drawing.Point(256, 3);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(72, 61);
            this.btnBusqueda.TabIndex = 10;
            this.btnBusqueda.Text = "&Buscar";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.txt4P);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.txt5P);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.txt6P);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.txtSegundoPromedio);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(212, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(166, 198);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cuarto Parcial";
            // 
            // txt4P
            // 
            this.txt4P.Location = new System.Drawing.Point(3, 19);
            this.txt4P.MaxLength = 3;
            this.txt4P.Name = "txt4P";
            this.txt4P.Size = new System.Drawing.Size(100, 22);
            this.txt4P.TabIndex = 14;
            this.txt4P.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Quinto Parcial";
            // 
            // txt5P
            // 
            this.txt5P.Location = new System.Drawing.Point(3, 63);
            this.txt5P.MaxLength = 3;
            this.txt5P.Name = "txt5P";
            this.txt5P.Size = new System.Drawing.Size(100, 22);
            this.txt5P.TabIndex = 15;
            this.txt5P.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Sexto Parcial";
            // 
            // txt6P
            // 
            this.txt6P.Location = new System.Drawing.Point(3, 107);
            this.txt6P.MaxLength = 3;
            this.txt6P.Name = "txt6P";
            this.txt6P.Size = new System.Drawing.Size(100, 22);
            this.txt6P.TabIndex = 16;
            this.txt6P.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Promedio Trimestral";
            // 
            // txtSegundoPromedio
            // 
            this.txtSegundoPromedio.Location = new System.Drawing.Point(3, 151);
            this.txtSegundoPromedio.MaxLength = 3;
            this.txtSegundoPromedio.Name = "txtSegundoPromedio";
            this.txtSegundoPromedio.Size = new System.Drawing.Size(100, 22);
            this.txtSegundoPromedio.TabIndex = 22;
            this.txtSegundoPromedio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSegundoPromedio_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.txt1P);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.txt2P);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.txt3P);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txtPrimerPromedio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 189);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Primer Parcial";
            // 
            // txt1P
            // 
            this.txt1P.Location = new System.Drawing.Point(3, 19);
            this.txt1P.MaxLength = 3;
            this.txt1P.Name = "txt1P";
            this.txt1P.Size = new System.Drawing.Size(100, 22);
            this.txt1P.TabIndex = 11;
            this.txt1P.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Segundo Parcial";
            // 
            // txt2P
            // 
            this.txt2P.Location = new System.Drawing.Point(3, 63);
            this.txt2P.MaxLength = 3;
            this.txt2P.Name = "txt2P";
            this.txt2P.Size = new System.Drawing.Size(100, 22);
            this.txt2P.TabIndex = 12;
            this.txt2P.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tercer Parcial";
            // 
            // txt3P
            // 
            this.txt3P.Location = new System.Drawing.Point(3, 107);
            this.txt3P.MaxLength = 3;
            this.txt3P.Name = "txt3P";
            this.txt3P.Size = new System.Drawing.Size(100, 22);
            this.txt3P.TabIndex = 13;
            this.txt3P.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Promedio Trimestral";
            // 
            // txtPrimerPromedio
            // 
            this.txtPrimerPromedio.Location = new System.Drawing.Point(3, 151);
            this.txtPrimerPromedio.MaxLength = 3;
            this.txtPrimerPromedio.Name = "txtPrimerPromedio";
            this.txtPrimerPromedio.Size = new System.Drawing.Size(100, 22);
            this.txtPrimerPromedio.TabIndex = 20;
            this.txtPrimerPromedio.Click += new System.EventHandler(this.txtPrimerPromedio_Click);
            // 
            // txtPromedioGeneral
            // 
            this.txtPromedioGeneral.Location = new System.Drawing.Point(404, 93);
            this.txtPromedioGeneral.MaxLength = 3;
            this.txtPromedioGeneral.Name = "txtPromedioGeneral";
            this.txtPromedioGeneral.Size = new System.Drawing.Size(100, 22);
            this.txtPromedioGeneral.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Promedio General";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblvacio);
            this.groupBox1.Controls.Add(this.cbMateria);
            this.groupBox1.Controls.Add(this.rbADMON);
            this.groupBox1.Controls.Add(this.rbTICS);
            this.groupBox1.Controls.Add(this.rbHSC);
            this.groupBox1.Controls.Add(this.lblSemestre);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.lblAM);
            this.groupBox1.Controls.Add(this.lblAP);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMatricula);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Alumno";
            // 
            // lblvacio
            // 
            this.lblvacio.AutoSize = true;
            this.lblvacio.Location = new System.Drawing.Point(338, 119);
            this.lblvacio.Name = "lblvacio";
            this.lblvacio.Size = new System.Drawing.Size(47, 16);
            this.lblvacio.TabIndex = 36;
            this.lblvacio.Text = "label9";
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(6, 114);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(260, 24);
            this.cbMateria.TabIndex = 35;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // rbADMON
            // 
            this.rbADMON.AutoSize = true;
            this.rbADMON.Location = new System.Drawing.Point(138, 74);
            this.rbADMON.Name = "rbADMON";
            this.rbADMON.Size = new System.Drawing.Size(121, 20);
            this.rbADMON.TabIndex = 34;
            this.rbADMON.TabStop = true;
            this.rbADMON.Text = "Administracion";
            this.rbADMON.UseVisualStyleBackColor = true;
            // 
            // rbTICS
            // 
            this.rbTICS.AutoSize = true;
            this.rbTICS.Location = new System.Drawing.Point(138, 47);
            this.rbTICS.Name = "rbTICS";
            this.rbTICS.Size = new System.Drawing.Size(223, 20);
            this.rbTICS.TabIndex = 33;
            this.rbTICS.TabStop = true;
            this.rbTICS.Text = "Tecnologias De La Informacion";
            this.rbTICS.UseVisualStyleBackColor = true;
            // 
            // rbHSC
            // 
            this.rbHSC.AutoSize = true;
            this.rbHSC.Location = new System.Drawing.Point(138, 16);
            this.rbHSC.Name = "rbHSC";
            this.rbHSC.Size = new System.Drawing.Size(209, 20);
            this.rbHSC.TabIndex = 32;
            this.rbHSC.TabStop = true;
            this.rbHSC.Text = "Higiene y Salud Comunitaria";
            this.rbHSC.UseVisualStyleBackColor = true;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(683, 106);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(66, 16);
            this.lblSemestre.TabIndex = 13;
            this.lblSemestre.Text = "Semestre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(683, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "Semestre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Materia";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(493, 109);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(45, 16);
            this.lblGrupo.TabIndex = 9;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAM.Location = new System.Drawing.Point(724, 46);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(110, 16);
            this.lblAM.TabIndex = 8;
            this.lblAM.Text = "Apellido Materno";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(525, 46);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(108, 16);
            this.lblAP.TabIndex = 7;
            this.lblAP.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(398, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // cbMatricula
            // 
            this.cbMatricula.DataSource = this.alumnoBindingSource;
            this.cbMatricula.DisplayMember = "Matricula";
            this.cbMatricula.FormattingEnabled = true;
            this.cbMatricula.Location = new System.Drawing.Point(6, 46);
            this.cbMatricula.Name = "cbMatricula";
            this.cbMatricula.Size = new System.Drawing.Size(121, 24);
            this.cbMatricula.TabIndex = 2;
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
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlEscolar.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCalificaciones";
            this.Text = "Control Escolar - Calificaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalificaciones_FormClosed);
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt4P;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt5P;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt6P;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSegundoPromedio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt1P;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt2P;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt3P;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimerPromedio;
        private System.Windows.Forms.TextBox txtPromedioGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbADMON;
        private System.Windows.Forms.RadioButton rbTICS;
        private System.Windows.Forms.RadioButton rbHSC;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMatricula;
        private dsMatricula dsMatricula;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private dsMatriculaTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label lblvacio;
    }
}