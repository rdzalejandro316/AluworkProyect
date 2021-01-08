using Microsoft.Win32;
using PDFview;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiasoftAppExt
{
    //Sia.PublicarPnt(9537, "PDFview");
    //dynamic ww = ((Inicio)Application.Current.MainWindow).WindowExt(9537, "PDFview");
    //ww.ShowInTaskbar = false;
    //ww.Owner = Application.Current.MainWindow;
    //ww.WindowStartupLocation = WindowStartupLocation.CenterScreen;
    //ww.ShowDialog();

    public partial class PDFview : Window
    {
        dynamic SiaWin;
        public int idemp = 0;
        string cnEmp = "";
        string cod_empresa = "";

        public string num_trn = "";
        public string cod_trn = "";
        bool flag = false;
        public PDFview()
        {
            InitializeComponent();
        }
        private void LoadConfig()
        {
            try
            {
                System.Data.DataRow foundRow = SiaWin.Empresas.Rows.Find(idemp);
                cnEmp = foundRow[SiaWin.CmpBusinessCn].ToString().Trim();
                cod_empresa = foundRow["BusinessCode"].ToString().Trim();
                string nomempresa = foundRow["BusinessName"].ToString().Trim();
                this.Title = "PDF VIEW :" + cod_empresa + "-" + nomempresa;
            }
            catch (Exception e)
            {
                MessageBox.Show("error en el load" + e.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                SiaWin = Application.Current.MainWindow;
                idemp = SiaWin._BusinessId;
                LoadConfig();

                if (!string.IsNullOrWhiteSpace(num_trn) && !string.IsNullOrWhiteSpace(cod_trn))
                {
                    TxDoc.Text = num_trn;

                    DataTable dt = SiaWin.Func.SqlDT("select cod_trn,num_trn From IMG_PdfDoc where  cod_trn='" + cod_trn + "' and num_trn='" + num_trn + "' ", "Clientes", idemp);

                    if (dt.Rows.Count > 0) flag = true;

                    TxContentPdf.Text = flag == true ? "SI" : "NO";
                }
            }
            catch (Exception w)
            {
                MessageBox.Show("error al cargar:" + w);
            }
        }

        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string ruta = "";
                OpenFileDialog dlg = new OpenFileDialog
                {
                    DefaultExt = ".pdf",
                    Filter = "Pdf Files|*.pdf"
                };

                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    string filename = dlg.FileName;
                    ruta = filename;
                }

                if (!string.IsNullOrEmpty(ruta))
                {
                    byte[] bytearr = File.ReadAllBytes(ruta);
                    string name_archive = System.IO.Path.GetFileName(ruta);
                    string extencion = System.IO.Path.GetExtension(ruta);

                    using (SqlConnection connection = new SqlConnection(cnEmp))
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        string query = "insert into IMG_PdfDoc (cod_trn,num_trn,name_archive,extencion,archive) values (@cod_trn,@num_trn,@name_archive,@extencion,@archive)";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@cod_trn", cod_trn);
                        cmd.Parameters.AddWithValue("@num_trn", num_trn);
                        cmd.Parameters.AddWithValue("@name_archive", name_archive);
                        cmd.Parameters.AddWithValue("@extencion", extencion);
                        cmd.Parameters.AddWithValue("@archive", bytearr);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("guardo");
                    }



                }



            }
            catch (Exception w)
            {
                MessageBox.Show("error al subir:" + w);
            }
        }

        private void BtnDownload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListArchive x = new ListArchive();
                x.cod_trn = cod_trn;
                x.num_trn = num_trn;
                x.ShowInTaskbar = false;
                x.Owner = Application.Current.MainWindow;
                x.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                x.ShowDialog();

                if (x.idrow > 0)
                {
                    byte[] bytepdf = null;
                    string name = "";
                    string query = "select * From IMG_PdfDoc where  idrow=" + x.idrow + " ";

                    DataTable dt = SiaWin.Func.SqlDT(query, "Clientes", idemp);
                    if (dt.Rows.Count > 0)
                    {
                        bytepdf = dt.Rows[0]["archive"] != DBNull.Value ? (byte[])dt.Rows[0]["archive"] : null;
                        name = dt.Rows[0]["name_archive"] != DBNull.Value ? dt.Rows[0]["name_archive"].ToString() : "";
                    }

                    if (bytepdf != null)
                    {
                        string path = AppDomain.CurrentDomain.BaseDirectory + name;
                        if (File.Exists(path)) File.Delete(path);                        
                        File.WriteAllBytes(path, bytepdf);
                        MessageBox.Show("se guardo el archivo en :" + path, "alerta", MessageBoxButton.OK, MessageBoxImage.Information);

                        pdfViewer.Load(path);
                    }
                }

            }
            catch (Exception w)
            {
                MessageBox.Show("error al descargar:" + w);
            }
        }


    }
}
