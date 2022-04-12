namespace ControlEscolar.presentacion
{
    partial class frmBusquedaMateriaCFT
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCFT = new System.Windows.Forms.ComboBox();
            this.dsNombreCFT = new ControlEscolar.dsNombreCFT();
            this.cftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cftTableAdapter = new ControlEscolar.dsNombreCFTTableAdapters.cftTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNombreCFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbCFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(199, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 147);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dato De La Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ControlEscolar.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(164, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 54);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(343, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 48);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 173);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(801, 198);
            this.dgvResultado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Componente De Formacion Para El Trabajo";
            // 
            // cbCFT
            // 
            this.cbCFT.DataSource = this.cftBindingSource;
            this.cbCFT.DisplayMember = "Nombre";
            this.cbCFT.FormattingEnabled = true;
            this.cbCFT.Location = new System.Drawing.Point(10, 48);
            this.cbCFT.Name = "cbCFT";
            this.cbCFT.Size = new System.Drawing.Size(379, 26);
            this.cbCFT.TabIndex = 56;
            this.cbCFT.SelectedIndexChanged += new System.EventHandler(this.cbCFT_SelectedIndexChanged);
            // 
            // dsNombreCFT
            // 
            this.dsNombreCFT.DataSetName = "dsNombreCFT";
            this.dsNombreCFT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cftBindingSource
            // 
            this.cftBindingSource.DataMember = "cft";
            this.cftBindingSource.DataSource = this.dsNombreCFT;
            // 
            // cftTableAdapter
            // 
            this.cftTableAdapter.ClearBeforeFill = true;
            // 
            // frmBusquedaMateriaCFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(825, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmBusquedaMateriaCFT";
            this.Text = "frmBusquedaMateriaCFT";
            this.Load += new System.EventHandler(this.frmBusquedaMateriaCFT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNombreCFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cftBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCFT;
        private dsNombreCFT dsNombreCFT;
        private System.Windows.Forms.BindingSource cftBindingSource;
        private dsNombreCFTTableAdapters.cftTableAdapter cftTableAdapter;
    }
}