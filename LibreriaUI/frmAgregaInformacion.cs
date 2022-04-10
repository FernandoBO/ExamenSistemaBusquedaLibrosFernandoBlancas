using AccesoDatos;
using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace LibreriaUI
{
    public partial class frmAgregaInformacion : Form
    {
        public frmAgregaInformacion()
        {
            InitializeComponent();
        }

        private LibreriaEntities1 ctx = new LibreriaEntities1();
        private void frmAgregaInformacion_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Events

        private void btnGuardaNuevoLibro_Click(object sender, EventArgs e)
        {
            string Autor = string.Empty, TituloLibro = string.Empty, Editorial = string.Empty, Anio = string.Empty;

            Autor = txtNuevoAutor.Text;
            TituloLibro = txtNuevoNombreLibro.Text;
            Anio = txtNuevoAnio.Text;
            Editorial = txtNuevaEditorial.Text;

            try
            {
                if (Autor != string.Empty)
                {
                    if (TituloLibro != string.Empty)
                    {
                        if (Anio != string.Empty)
                        {
                            if (Editorial != string.Empty)
                            {
                                using (LibreriaEntities1 db = new LibreriaEntities1())
                                {
                                    //db.sp_AgregaLibro("Fernando", "Libro", 2022, "Editorial");
                                    db.sp_AgregaLibro(Autor, TituloLibro, Int32.Parse(Anio), Editorial);
                                    //db.SaveChanges();
                                    //Send<Libro>(URL, libro, "POST");
                                    ReiniciaCampos();
                                }
                            }
                            else { MessageBox.Show("Ingrese la editorial"); }
                        }
                        else { MessageBox.Show("Ingrese el año"); }
                    }
                    else { MessageBox.Show("Ingrese el Titulo del Libro"); }
                }
                else
                { MessageBox.Show("Ingrese un autor"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Methods

        private void ReiniciaCampos()
        {
            txtNuevaEditorial.Text = string.Empty;
            txtNuevoAnio.Text = string.Empty;
            txtNuevoAutor.Text = string.Empty;
            txtNuevoNombreLibro.Text = string.Empty;
        }
        private void OcultaNuevoLibro()
        {
            frmAgregaInformacion frmAgrega = new frmAgregaInformacion();
            frmAgrega.Hide();
        }
        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = string.Empty;
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);

                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";


                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                //y aquí va nuestra respuesta, la cual es lo que nos regrese el sitio solicitado

            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        #endregion


    }
}
