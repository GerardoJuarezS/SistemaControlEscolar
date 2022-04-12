using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ControlEscolar.bd;

namespace ControlEscolar
{
    public class ConexImg
    {


        public void Insertar(Image imagen,
            Image imagen2,
            Image imagen3,
            Image imagenFinal,
            string matricula,
            int idservicio)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, ImageFormat.Png);
                    Byte[] imgArr = ms.ToArray();
                    imagen2.Save(ms, ImageFormat.Png);
                    Byte[] imgArr2 = ms.ToArray();
                    imagen3.Save(ms, ImageFormat.Png);
                    Byte[] imgArr3 = ms.ToArray();
                    imagenFinal.Save(ms, ImageFormat.Png);
                    Byte[] imgArrf = ms.ToArray();
                    using (MySqlConnection conn = clsConexion.BaseDeDatos())
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO alumnoserviciosocial VALUES(null,@PRIMER,@SEGUNDO,@TERCERO,@FINAL,@matricula,@idservicio)";
                            cmd.Parameters.AddWithValue("@PRIMER", imgArr);
                            cmd.Parameters.AddWithValue("@SEGUNDO", imgArr2);
                            cmd.Parameters.AddWithValue("@TERCERO", imgArr3);
                            cmd.Parameters.AddWithValue("@FINAL", imgArrf);
                            cmd.Parameters.AddWithValue("@matricula", matricula);
                            cmd.Parameters.AddWithValue("@idservicio", idservicio);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" Insertado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message + "Error al Ingresar los Datos ");
            }
        }


        public void Modificar(Image imagen,
            Image imagen2,
            Image imagen3,
            Image imagenFinal,
            string matricula
           )
        {

            try
            {
                using (MemoryStream ms = new MemoryStream())
                using (MemoryStream ms2 = new MemoryStream())
                using (MemoryStream ms3 = new MemoryStream())
                using (MemoryStream msf = new MemoryStream())
                {
                    imagen.Save(ms, ImageFormat.Png);
                    Byte[] imgArr = ms.ToArray();

                    imagen2.Save(ms2, ImageFormat.Png);
                    Byte[] imgArr2 = ms2.ToArray();

                    imagen3.Save(ms3, ImageFormat.Png);
                    Byte[] imgArr3 = ms3.ToArray();

                    imagenFinal.Save(msf, ImageFormat.Png);
                    Byte[] imgArrf = msf.ToArray();
                    using (MySqlConnection conn = clsConexion.BaseDeDatos())
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            string SqlDetenido = "UPDATE alumnoserviciosocial SET PrimerInforme=@UNO,SegundoInforme=@DOS,TercerInforme=@TERCER,InformeFinal=@Final  where Matricula=@matri";

                            cmd.Connection = conn;
                            cmd.CommandText = SqlDetenido;
                            cmd.Parameters.AddWithValue("@UNO", imgArr);
                            cmd.Parameters.AddWithValue("@DOS", imgArr2);
                            cmd.Parameters.AddWithValue("@TERCER", imgArr3);
                            cmd.Parameters.AddWithValue("@Final", imgArrf);
                            cmd.Parameters.AddWithValue("@matri", matricula);
                          


                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" Modificado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message + "Error al Modificar Datos");

            }
        }



    } }

