using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace PDFview
{
    public partial class ListArchive : Window
    {
        dynamic SiaWin;
        public int idemp = 0;
        string cnEmp = "";
        string cod_empresa = "";
        public string num_trn = "";
        public string cod_trn = "";

        public int idrow = -1;
        public ListArchive()
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
                    DataTable dt = SiaWin.Func.SqlDT("select idrow,cod_trn,num_trn,name_archive,extencion From IMG_PdfDoc where  cod_trn='" + cod_trn + "' and num_trn='" + num_trn + "' ", "Clientes", idemp);

                    if (dt.Rows.Count > 0)
                    {
                        DataGridArchive.ItemsSource = dt.DefaultView;
                    }

                }

            }
            catch (Exception w)
            {
                MessageBox.Show("error al carga:" + w);
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (DataGridArchive.SelectedIndex >= 0)
                {
                    
                    DataRowView row = (DataRowView)DataGridArchive.SelectedItems[0];                                        
                    idrow = Convert.ToInt32(row["idrow"]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("seleccione un archivo", "alerta", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (Exception w)
            {
                MessageBox.Show("errorwww:" + w);
            }
        }
    }
}
