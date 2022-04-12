using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.bd;
using MySql.Data.MySqlClient;
using System.IO;
namespace ControlEscolar.presentacion
{
    public partial class frmInformesServicioSocial : Form
    {
        public frmInformesServicioSocial()
        {
            InitializeComponent();
        }
        const string MySqlConnecionString = "Server=localhost; Database=cobao; Username=root; Password=1990-2014;";
        int ImgInser = 0;
        String Ubicacion;
        String Id;
        OpenFileDialog Open = new OpenFileDialog();
        void mostrarnombre(string matricula)
        {
            string nombre;
            string consultanombre = "SELECT datospersonales.Nombre FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnnombre = clsConexion.BaseDeDatos();
            MySqlCommand Cmdnombre = new MySqlCommand(String.Format(consultanombre), Cnnnombre);
            MySqlDataReader Drnombre = Cmdnombre.ExecuteReader();
            while (Drnombre.Read())
            {
                nombre = Drnombre.GetString(0);
                lblNombre.Text = nombre;
            }
        }

        void mostrarapellidopaterno(string matricula)
        {
            string ApellidoPaterno;
            string consultaAP = "SELECT datospersonales.ApellidoPaterno FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnap = clsConexion.BaseDeDatos();
            MySqlCommand Cmdap = new MySqlCommand(String.Format(consultaAP), Cnnap);
            MySqlDataReader Drap = Cmdap.ExecuteReader();
            while (Drap.Read())
            {
                ApellidoPaterno = Drap.GetString(0);
                lblApellidop.Text = ApellidoPaterno;
            }
        }

        void mostrarapellidomaterno(string matricula)
        {
            string ApellidoMaterno;
            string consultaAM = "SELECT datospersonales.ApellidoMaterno FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnam = clsConexion.BaseDeDatos();
            MySqlCommand Cmdam = new MySqlCommand(String.Format(consultaAM), Cnnam);
            MySqlDataReader Dram = Cmdam.ExecuteReader();
            while (Dram.Read())
            {
                ApellidoMaterno = Dram.GetString(0);
                lblApellidom.Text = ApellidoMaterno;
            }
        }

        void mostrargrupo(string matricula)
        {

            string Grupo;
            string consultaG = "SELECT IdGrupo from alumnogrupo where Matricula='" + matricula + "'";

            MySqlConnection CnnG = clsConexion.BaseDeDatos();
            MySqlCommand CmdG = new MySqlCommand(String.Format(consultaG), CnnG);
            MySqlDataReader DrG = CmdG.ExecuteReader();
            while (DrG.Read())
            {
                Grupo = DrG.GetString(0);
                lblGrupo.Text = Grupo;
            }
        }

        void mostrarsemestre(string matricula)
        {
            string semestreanterior;
            string consultasemestreanterior = "select idsemestre from alumnosemestre where Matricula = '" + matricula + "'";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lblSemestre.Text = semestreanterior;
            }
        }

        void mostrardependencia(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.Dependencia from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '"+matricula+"' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lbldependencia.Text = dependencia;
            }
        }

        void mostrarnombredelprograma(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.NombreDelPrograma from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblnombredelprograma.Text = dependencia;
            }
        }

        void subprograma(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.Subprograma from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblsubprograma.Text = dependencia;
            }
        }

        void actividadbasica(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.ActividadBasica from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblactividadbasica.Text = dependencia;
            }
        }

        void modalidad(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.Modalidad from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblmodalidad.Text = dependencia;
            }
        }

        void area(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.Areas from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblarea.Text = dependencia;
            }
        }

        void fechainicio(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.Fecha_Inicio from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblfechainicio.Text = dependencia;
            }
        }

        void fechafinal(string matricula)
        {
            string dependencia;
            string consultadependencia = "select serviciosocial.Fecha_Final from serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '" + matricula + "' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial";
            MySqlConnection Cnndependencia = clsConexion.BaseDeDatos();
            MySqlCommand Cmddependencia = new MySqlCommand(String.Format(consultadependencia), Cnndependencia);
            MySqlDataReader Drdependencia = Cmddependencia.ExecuteReader();
            while (Drdependencia.Read())
            {
                dependencia = Drdependencia.GetString(0);
                lblfechafin.Text = dependencia;
            }
        }
        static MySqlConnection GetNewConnection()
        {
            var conn = new MySqlConnection(MySqlConnecionString);
            conn.Open();
            return conn;
        }

        static void GuardarImagen1(Image p1, string matricula)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                p1.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr1 = ms.ToArray();
                using (MySqlConnection conn = GetNewConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "update alumnoserviciosocial set PrimerInforme =@imgArr1 where Matricula = @matricula)";
                        cmd.Parameters.AddWithValue("@imgArr1",imgArr1);
                        cmd.Parameters.AddWithValue("@matricula",matricula);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        static void GuardarImagen2(Image p1, Image p2, Image p3, Image inf, string matricula)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                p1.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr1 = ms.ToArray();
                p2.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr2 = ms.ToArray();
                p3.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr3 = ms.ToArray();
                inf.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr4 = ms.ToArray();
                using (MySqlConnection conn = GetNewConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "update alumnoserviciosocial set PrimerInforme = @P1, SegundoInforme = @P2, TercerInforme = @P3, InformeFinal = @IF where Matricula = @Matri)";
                        cmd.Parameters.AddWithValue("@P1", p1);
                        cmd.Parameters.AddWithValue("@P2", p2);
                        cmd.Parameters.AddWithValue("@P3", p3);
                        cmd.Parameters.AddWithValue("@IF", inf);
                        cmd.Parameters.AddWithValue("@Matri", matricula);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        static void GuardarImagen3(Image p1, Image p2, Image p3, Image inf, string matricula)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                p1.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr1 = ms.ToArray();
                p2.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr2 = ms.ToArray();
                p3.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr3 = ms.ToArray();
                inf.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr4 = ms.ToArray();
                using (MySqlConnection conn = GetNewConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "update alumnoserviciosocial set PrimerInforme = @P1, SegundoInforme = @P2, TercerInforme = @P3, InformeFinal = @IF where Matricula = @Matri)";
                        cmd.Parameters.AddWithValue("@P1", p1);
                        cmd.Parameters.AddWithValue("@P2", p2);
                        cmd.Parameters.AddWithValue("@P3", p3);
                        cmd.Parameters.AddWithValue("@IF", inf);
                        cmd.Parameters.AddWithValue("@Matri", matricula);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        static void GuardarImagen4(Image p1, Image p2, Image p3, Image inf, string matricula)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                p1.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr1 = ms.ToArray();
                p2.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr2 = ms.ToArray();
                p3.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr3 = ms.ToArray();
                inf.Save(ms, ImageFormat.Jpeg);
                byte[] imgArr4 = ms.ToArray();
                using (MySqlConnection conn = GetNewConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "update alumnoserviciosocial set PrimerInforme = @P1, SegundoInforme = @P2, TercerInforme = @P3, InformeFinal = @IF where Matricula = @Matri)";
                        cmd.Parameters.AddWithValue("@P1", p1);
                        cmd.Parameters.AddWithValue("@P2", p2);
                        cmd.Parameters.AddWithValue("@P3", p3);
                        cmd.Parameters.AddWithValue("@IF", inf);
                        cmd.Parameters.AddWithValue("@Matri", matricula);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        static Image Cargarp1(string matricula)
        {
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select PrimerInforme, SegundoInforme, TercerInforme, InformeFinal from alumnoserviciosocial where Matricula = @Matricula";
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    byte[] imgArr1 = (byte[])cmd.ExecuteScalar();
                    imgArr1 = (byte[])cmd.ExecuteScalar();

                    using (var stream = new MemoryStream(imgArr1))
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
        }

        static Image Cargarp2(string matricula)
        {
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select SegundoInforme from alumnoserviciosocial where Matricula = @Matricula";
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    byte[] imgArr2 = (byte[])cmd.ExecuteScalar();
                    imgArr2 = (byte[])cmd.ExecuteScalar();

                    using (var stream = new MemoryStream(imgArr2))
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
        }

        static Image Cargarp3(string matricula)
        {
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select TercerInforme from alumnoserviciosocial where Matricula = @Matricula";
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    byte[] imgArr3 = (byte[])cmd.ExecuteScalar();
                    imgArr3 = (byte[])cmd.ExecuteScalar();

                    using (var stream = new MemoryStream(imgArr3))
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
        }

        static Image Cargarinf(string matricula)
        {
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select InformeFinal from alumnoserviciosocial where Matricula = @Matricula";
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    byte[] imgArr4 = (byte[])cmd.ExecuteScalar();
                    imgArr4 = (byte[])cmd.ExecuteScalar();

                    using (var stream = new MemoryStream(imgArr4))
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
        }

        private void frmInformesServicioSocial_Load(object sender, EventArgs e)
        {
            LlenarMatriculas();
          //  Foto("");
        }
        public void LlenarMatriculas()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select distinct alumnoserviciosocial.Matricula from alumnoserviciosocial", Cnn);
            Myda.Fill(dsMatricula, "alumnosemestre");
            cbMatricula.DataSource = dsMatricula.Tables[0].DefaultView;
            cbMatricula.ValueMember = "matricula";
            cbMatricula.DisplayMember = "matricula";
        }
        void Foto(string cla)
        {
            if (cla == "") { MessageBox.Show("Sin Clave"); }
            else
            {
                try
                {
                 

                    MySqlCommand coman = new MySqlCommand(("Select primerinforme, segundoinforme,tercerinforme,informefinal  from alumnoserviciosocial where matricula = '" + cla + "'"), clsConexion.BaseDeDatos());

                    MySqlDataAdapter dp = new MySqlDataAdapter(coman);

                    DataSet ds = new DataSet("alumnoserviciosocial ");
                    byte[] MisDatos = new byte[0];
                    byte[] MisDatos2 = new byte[0];
                    byte[] MisDatos3 = new byte[0];
                    byte[] MisDatos4 = new byte[0];
                    dp.Fill(ds, "alumnoserviciosocial ");
                    DataRow myRow = ds.Tables["alumnoserviciosocial "].Rows[0];
                    MisDatos = (byte[])myRow["primerinforme"];
                    MisDatos2 = (byte[])myRow["segundoinforme"];
                    MisDatos3 = (byte[])myRow["tercerinforme"];
                    MisDatos4 = (byte[])myRow["informefinal"];
                    MemoryStream ms = new MemoryStream(MisDatos);
                    MemoryStream ms2 = new MemoryStream(MisDatos2);
                    MemoryStream ms3 = new MemoryStream(MisDatos3);
                    MemoryStream ms4 = new MemoryStream(MisDatos4);
                  
                    
                        pb1.Image = Image.FromStream(ms);
                        pb2.Image = Image.FromStream(ms2);
                        pb3.Image = Image.FromStream(ms3);
                        pb4.Image = Image.FromStream(ms4);
                    
                }
                catch (Exception e)
                {
                    
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //GuardarImagen1(pb1.Image,cbMatricula.Text);

            ConexImg inse = new ConexImg();
            inse.Modificar(
                  pb1.Image,
                   pb2.Image,
                    pb3.Image,
                     pb4.Image,
                    cbMatricula.Text
                  
                  );
        }

        private void btnp4_Click(object sender, EventArgs e)
        {

            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files(*.jpg)|*jpg|Gif files(*.gif)|*gif|Bitmap  files(*.Bmp)|*.bmp|PNG files(*.png)|*.png|All files(*.*)|*.*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Ubicacion = Open.FileName;
                Bitmap Picture = new Bitmap(Ubicacion);
                pb4.Image = (Image)Picture;
                ImgInser = 1;
                Id = Open.SafeFileName;
            }
        }

        private void btnp2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files(*.jpg)|*jpg|Gif files(*.gif)|*gif|Bitmap  files(*.Bmp)|*.bmp|PNG files(*.png)|*.png|All files(*.*)|*.*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Ubicacion = Open.FileName;
                Bitmap Picture = new Bitmap(Ubicacion);
                pb2.Image = (Image)Picture;
                ImgInser = 1;
                Id = Open.SafeFileName;
            }
        }

        private void btnp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files(*.jpg)|*jpg|Gif files(*.gif)|*gif|Bitmap  files(*.Bmp)|*.bmp|PNG files(*.png)|*.png|All files(*.*)|*.*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Ubicacion = Open.FileName;
                Bitmap Picture = new Bitmap(Ubicacion);
                pb3.Image = (Image)Picture;
                ImgInser = 1;
                Id = Open.SafeFileName;
            }
        }

        private void btnp1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files(*.jpg)|*jpg|Gif files(*.gif)|*gif|Bitmap  files(*.Bmp)|*.bmp|PNG files(*.png)|*.png|All files(*.*)|*.*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Ubicacion = Open.FileName;
                Bitmap Picture = new Bitmap(Ubicacion);
                pb1.Image = (Image)Picture;
                ImgInser = 1;
                Id = Open.SafeFileName;
            }
        }

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            mostrarnombre(cbMatricula.Text);
                mostrarapellidopaterno(cbMatricula.Text);
                mostrarapellidomaterno(cbMatricula.Text);
                mostrargrupo(cbMatricula.Text);
                mostrarsemestre(cbMatricula.Text);
            mostrardependencia(cbMatricula.Text);
            mostrarnombredelprograma(cbMatricula.Text);
            subprograma(cbMatricula.Text);
            actividadbasica(cbMatricula.Text);
            modalidad(cbMatricula.Text);
            area(cbMatricula.Text);
            fechainicio(cbMatricula.Text);
            fechafinal(cbMatricula.Text);
         
            Foto(cbMatricula.Text);
        }

        private void frmInformesServicioSocial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
