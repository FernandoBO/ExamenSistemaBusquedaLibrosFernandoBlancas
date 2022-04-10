using AccesoDatos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LibreriaEntities1 ctx = new LibreriaEntities1();

        private async void Form1_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(respuesta);
            dgvLibrosAutor.DataSource = lst;
        }

        #region Events

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActivaNuevoLibro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarAutor.Text != String.Empty)
                {
                    using (LibreriaEntities1 db = new LibreriaEntities1())
                    {
                        dgvLibrosAutor.DataSource = db.sp_ConsultaXAutor(txtBuscarAutor.Text);
                    }
                }
                else
                {
                    string respuesta = await GetHttp();
                    List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(respuesta);
                    dgvLibrosAutor.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscaLibro.Text != String.Empty)
                {
                    using (LibreriaEntities1 db = new LibreriaEntities1())
                    {
                        dgvLibrosAutor.DataSource = db.sp_ConsultaXLibro(txtBuscaLibro.Text);
                    }
                }
                else
                {
                    string respuesta = await GetHttp();
                    List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(respuesta);
                    dgvLibrosAutor.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvLibrosAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Libro = String.Empty;
            try
            {
                using (LibreriaEntities1 db = new LibreriaEntities1())
                {
                    Libro = dgvLibrosAutor.CurrentRow.Cells[2].Value.ToString();
                    dgvlibros.DataSource = db.sp_ConsultaXLibro(Libro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Methods
        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create("http://localhost:57196/api/Libro");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        private async Task<string> GetHttpAutor()
        {
            WebRequest oRequest = WebRequest.Create("http://localhost:57196/api/Libro?Autor={Autor}");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpEditorial()
        {
            WebRequest oRequest = WebRequest.Create("http://localhost:57196/api/Libro?Editorial={Editorial}");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void ActivaNuevoLibro()
        {
            frmAgregaInformacion frmAgrega = new frmAgregaInformacion();
            frmAgrega.Show();
        }

        #endregion


    }
}
