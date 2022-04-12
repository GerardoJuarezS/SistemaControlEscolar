namespace ControlEscolar.presentacion
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioSocialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasdocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasPorImpartirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altamateriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasPorSemestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasCFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altausuarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedausuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosAcademicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salubridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alergiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.restaurarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.semestreToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.documentosAcademicosToolStripMenuItem,
            this.salubridadToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(80, 46);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(209, 48);
            this.salirToolStripMenuItem.Text = "&Cerrar Sesion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = global::ControlEscolar.Properties.Resources.Error;
            this.salirToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(209, 48);
            this.salirToolStripMenuItem1.Text = "&Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionToolStripMenuItem,
            this.reinscripcionToolStripMenuItem,
            this.calificacionesToolStripMenuItem,
            this.servicioSocialToolStripMenuItem1,
            this.consultarCalificacionesToolStripMenuItem});
            this.alumnosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnosToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.alumnosToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.URBAN;
            this.alumnosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(131, 46);
            this.alumnosToolStripMenuItem.Text = "&Alumnos";
            // 
            // inscripcionToolStripMenuItem
            // 
            this.inscripcionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.inscripcionToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscripcionToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.inscripcion1;
            this.inscripcionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inscripcionToolStripMenuItem.Name = "inscripcionToolStripMenuItem";
            this.inscripcionToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.inscripcionToolStripMenuItem.Text = "&Inscripcion";
            this.inscripcionToolStripMenuItem.Click += new System.EventHandler(this.inscripcionToolStripMenuItem_Click);
            // 
            // reinscripcionToolStripMenuItem
            // 
            this.reinscripcionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.reinscripcionToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reinscripcionToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.document_edit;
            this.reinscripcionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reinscripcionToolStripMenuItem.Name = "reinscripcionToolStripMenuItem";
            this.reinscripcionToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.reinscripcionToolStripMenuItem.Text = "&Reinscripcion";
            this.reinscripcionToolStripMenuItem.Click += new System.EventHandler(this.reinscripcionToolStripMenuItem_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.calificacionesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificacionesToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.calculator;
            this.calificacionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.calificacionesToolStripMenuItem.Text = "&Calificaciones";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // servicioSocialToolStripMenuItem1
            // 
            this.servicioSocialToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.servicioSocialToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem});
            this.servicioSocialToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicioSocialToolStripMenuItem1.Image = global::ControlEscolar.Properties.Resources.home;
            this.servicioSocialToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.servicioSocialToolStripMenuItem1.Name = "servicioSocialToolStripMenuItem1";
            this.servicioSocialToolStripMenuItem1.Size = new System.Drawing.Size(230, 38);
            this.servicioSocialToolStripMenuItem1.Text = "&Servicio Social";
            this.servicioSocialToolStripMenuItem1.Click += new System.EventHandler(this.servicioSocialToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.informesToolStripMenuItem.Text = "&Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // consultarCalificacionesToolStripMenuItem
            // 
            this.consultarCalificacionesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarCalificacionesToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Signature;
            this.consultarCalificacionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultarCalificacionesToolStripMenuItem.Name = "consultarCalificacionesToolStripMenuItem";
            this.consultarCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.consultarCalificacionesToolStripMenuItem.Text = "Consultar Calificaciones";
            this.consultarCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarCalificacionesToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.docentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasdocentesToolStripMenuItem,
            this.materiasPorImpartirToolStripMenuItem});
            this.docentesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docentesToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.docentesToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.URBANMSN2;
            this.docentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(136, 46);
            this.docentesToolStripMenuItem.Text = "&Docentes";
            // 
            // altasdocentesToolStripMenuItem
            // 
            this.altasdocentesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altasdocentesToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Users;
            this.altasdocentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altasdocentesToolStripMenuItem.Name = "altasdocentesToolStripMenuItem";
            this.altasdocentesToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.altasdocentesToolStripMenuItem.Text = "&Altas";
            this.altasdocentesToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // materiasPorImpartirToolStripMenuItem
            // 
            this.materiasPorImpartirToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasPorImpartirToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Spell;
            this.materiasPorImpartirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.materiasPorImpartirToolStripMenuItem.Name = "materiasPorImpartirToolStripMenuItem";
            this.materiasPorImpartirToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.materiasPorImpartirToolStripMenuItem.Text = "Materias por impartir";
            this.materiasPorImpartirToolStripMenuItem.Click += new System.EventHandler(this.materiasPorImpartirToolStripMenuItem_Click);
            // 
            // semestreToolStripMenuItem
            // 
            this.semestreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.semestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altamateriasToolStripMenuItem1,
            this.materiasPorSemestreToolStripMenuItem,
            this.cFTToolStripMenuItem,
            this.materiasCFTToolStripMenuItem});
            this.semestreToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestreToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.semestreToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Dictionary;
            this.semestreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.semestreToolStripMenuItem.Name = "semestreToolStripMenuItem";
            this.semestreToolStripMenuItem.Size = new System.Drawing.Size(148, 46);
            this.semestreToolStripMenuItem.Text = "A&cademico";
            // 
            // altamateriasToolStripMenuItem1
            // 
            this.altamateriasToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altamateriasToolStripMenuItem1.Image = global::ControlEscolar.Properties.Resources.Signature;
            this.altamateriasToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altamateriasToolStripMenuItem1.Name = "altamateriasToolStripMenuItem1";
            this.altamateriasToolStripMenuItem1.Size = new System.Drawing.Size(233, 38);
            this.altamateriasToolStripMenuItem1.Text = "&Altas Materias";
            this.altamateriasToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // materiasPorSemestreToolStripMenuItem
            // 
            this.materiasPorSemestreToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasPorSemestreToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Index;
            this.materiasPorSemestreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.materiasPorSemestreToolStripMenuItem.Name = "materiasPorSemestreToolStripMenuItem";
            this.materiasPorSemestreToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.materiasPorSemestreToolStripMenuItem.Text = "&Materias por semestre";
            this.materiasPorSemestreToolStripMenuItem.Click += new System.EventHandler(this.materiasPorSemestreToolStripMenuItem_Click);
            // 
            // cFTToolStripMenuItem
            // 
            this.cFTToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFTToolStripMenuItem.Name = "cFTToolStripMenuItem";
            this.cFTToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.cFTToolStripMenuItem.Text = "CFT";
            this.cFTToolStripMenuItem.Click += new System.EventHandler(this.cFTToolStripMenuItem_Click);
            // 
            // materiasCFTToolStripMenuItem
            // 
            this.materiasCFTToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasCFTToolStripMenuItem.Name = "materiasCFTToolStripMenuItem";
            this.materiasCFTToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.materiasCFTToolStripMenuItem.Text = "Materias CFT";
            this.materiasCFTToolStripMenuItem.Click += new System.EventHandler(this.materiasCFTToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altausuarioToolStripMenuItem2,
            this.busquedausuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.usuariosToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.usuarios;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(132, 46);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // altausuarioToolStripMenuItem2
            // 
            this.altausuarioToolStripMenuItem2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altausuarioToolStripMenuItem2.Image = global::ControlEscolar.Properties.Resources.user_add;
            this.altausuarioToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altausuarioToolStripMenuItem2.Name = "altausuarioToolStripMenuItem2";
            this.altausuarioToolStripMenuItem2.Size = new System.Drawing.Size(156, 38);
            this.altausuarioToolStripMenuItem2.Text = "&alta";
            this.altausuarioToolStripMenuItem2.Click += new System.EventHandler(this.altaToolStripMenuItem2_Click);
            // 
            // busquedausuarioToolStripMenuItem
            // 
            this.busquedausuarioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedausuarioToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.search;
            this.busquedausuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.busquedausuarioToolStripMenuItem.Name = "busquedausuarioToolStripMenuItem";
            this.busquedausuarioToolStripMenuItem.Size = new System.Drawing.Size(156, 38);
            this.busquedausuarioToolStripMenuItem.Text = "&Busqueda";
            this.busquedausuarioToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // documentosAcademicosToolStripMenuItem
            // 
            this.documentosAcademicosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.documentosAcademicosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentosAcademicosToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.documentosAcademicosToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Documents;
            this.documentosAcademicosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.documentosAcademicosToolStripMenuItem.Name = "documentosAcademicosToolStripMenuItem";
            this.documentosAcademicosToolStripMenuItem.Size = new System.Drawing.Size(258, 46);
            this.documentosAcademicosToolStripMenuItem.Text = "&Documentos Academicos";
            this.documentosAcademicosToolStripMenuItem.Click += new System.EventHandler(this.documentosAcademicosToolStripMenuItem_Click);
            // 
            // salubridadToolStripMenuItem
            // 
            this.salubridadToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salubridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enfermedadesToolStripMenuItem,
            this.alergiasToolStripMenuItem});
            this.salubridadToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salubridadToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.salubridadToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.salud;
            this.salubridadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salubridadToolStripMenuItem.Name = "salubridadToolStripMenuItem";
            this.salubridadToolStripMenuItem.Size = new System.Drawing.Size(146, 46);
            this.salubridadToolStripMenuItem.Text = "&Salubridad";
            // 
            // enfermedadesToolStripMenuItem
            // 
            this.enfermedadesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Medic;
            this.enfermedadesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.enfermedadesToolStripMenuItem.Name = "enfermedadesToolStripMenuItem";
            this.enfermedadesToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.enfermedadesToolStripMenuItem.Text = "&Enfermedades";
            this.enfermedadesToolStripMenuItem.Click += new System.EventHandler(this.enfermedadesToolStripMenuItem_Click_1);
            // 
            // alergiasToolStripMenuItem
            // 
            this.alergiasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alergiasToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.Vista;
            this.alergiasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alergiasToolStripMenuItem.Name = "alergiasToolStripMenuItem";
            this.alergiasToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.alergiasToolStripMenuItem.Text = "&Alergias";
            this.alergiasToolStripMenuItem.Click += new System.EventHandler(this.alergiasToolStripMenuItem_Click_1);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarBDToolStripMenuItem,
            this.restaurarBDToolStripMenuItem});
            this.seguridadToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(100, 46);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // respaldarBDToolStripMenuItem
            // 
            this.respaldarBDToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respaldarBDToolStripMenuItem.Name = "respaldarBDToolStripMenuItem";
            this.respaldarBDToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.respaldarBDToolStripMenuItem.Text = "&RespaldarBD";
            this.respaldarBDToolStripMenuItem.Click += new System.EventHandler(this.respaldarBDToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlEscolar.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(269, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1065, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colegio De Bachilleres Del Estado De Oaxaca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(326, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(846, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plantel 49. San Pedro y San Pablo Teposcolula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(631, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bienvenido";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblTipoUsuario.Location = new System.Drawing.Point(326, 333);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(237, 44);
            this.lblTipoUsuario.TabIndex = 5;
            this.lblTipoUsuario.Text = "TipoUsuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblNombreUsuario.Location = new System.Drawing.Point(640, 333);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(300, 44);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Red;
            this.lblfecha.Location = new System.Drawing.Point(509, 650);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(83, 44);
            this.lblfecha.TabIndex = 7;
            this.lblfecha.Text = "aaa";
            // 
            // restaurarBDToolStripMenuItem
            // 
            this.restaurarBDToolStripMenuItem.Name = "restaurarBDToolStripMenuItem";
            this.restaurarBDToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.restaurarBDToolStripMenuItem.Text = "&RestaurarBD";
            this.restaurarBDToolStripMenuItem.Click += new System.EventHandler(this.restaurarBDToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ControlEscolar.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 697);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasdocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasPorImpartirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altamateriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altausuarioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem documentosAcademicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salubridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedausuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasPorSemestreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioSocialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enfermedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alergiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTipoUsuario;
        public System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem consultarCalificacionesToolStripMenuItem;
        public System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasCFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBDToolStripMenuItem;
    }
}