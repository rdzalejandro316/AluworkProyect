﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DataRow = System.Data.DataRow;


//Sia.PublicarPnt(9669,"Cosaldos");
//dynamic ww = ((Inicio)Application.Current.MainWindow).WindowExt(9669,"Cosaldos");
//ww.ShowInTaskbar = false;
//ww.Owner = Application.Current.MainWindow;
//ww.WindowStartupLocation = WindowStartupLocation.CenterScreen;        
//ww.ShowDialog();

 

namespace SiasoftAppExt
{
    
    /// <summary>
    /// Ló  gica de interacción para SiasoftAppExt.xaml
    /// </summary>
    public partial class Cosaldos : Window
    {
        dynamic SiaWin;
        public string cod_empresa;
        public int idemp = 0;
        string cnEmp = "";
        public Cosaldos()
        {

          
            InitializeComponent();
            SiaWin = Application.Current.MainWindow;
            idemp = SiaWin._BusinessId;
            LoadConfig();
            cargarAño();

            SiaWin.seguridad.Auditor(0, SiaWin._ProyectId, SiaWin._UserId, SiaWin._UserGroup, idemp, 0, 0, 0, "Entro a traslado de saldos", "");

        }

        public void cargarAño()
        {
            if (comboYear.SelectedIndex < 0)
            {
                DateTime fecha = DateTime.Today;
                comboYear.Items.Add(fecha.Year - 2);
                comboYear.Items.Add(fecha.Year - 1);
                comboYear.Items.Add(fecha.Year);
                comboYear.Items.Add(fecha.Year + 1);
                
            }

        }
        private void LoadConfig()
        {
            try
            {
                SiaWin = Application.Current.MainWindow;
                if (idemp <= 0) idemp = SiaWin._BusinessId;

                System.Data.DataRow foundRow = SiaWin.Empresas.Rows.Find(idemp);
                idemp = Convert.ToInt32(foundRow["BusinessId"].ToString().Trim());
                cnEmp = foundRow[SiaWin.CmpBusinessCn].ToString().Trim();
                cod_empresa = foundRow["BusinessCode"].ToString().Trim();
                string nomempresa = foundRow["BusinessName"].ToString().Trim();
                //this.Title = "Devolcion de facturas" + cod_empresa + "-" + nomempresa;

                DataTable dt = SiaWin.Func.SqlDT("select businesscode,businessname  from Business", "tabla", 0);
                comboEmpresa.ItemsSource = dt.DefaultView;
                comboEmpresa.DisplayMemberPath = "businessname";
                comboEmpresa.SelectedValuePath = "businesscode";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el load" + e.Message);
            }
        }

        public int guardar(string codemp, string Ano, CancellationToken cancellationToken)
        {
            int val_ret = 0;
            SqlCommand cmd;
            try
            {
                //cnn = new SqlConnection(@"Data Source=KOPERNICO\SQLEXPRESS;Initial Catalog=Costos2020GrupoSaavedra_SiaApp;User ID=sa;Password=Cristian654321*");

                SqlConnection cnn = new SqlConnection(SiaWin._cn);
                cmd = new SqlCommand("_EmpCoSaldo_ini", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ano", Ano);
                cmd.Parameters.AddWithValue("@codemp", codemp);


                val_ret = cmd.ExecuteNonQuery();
                //    MessageBox.Show("Se realizo el descuento a la empresa" + "" + comboEmpresa.Text.Trim() + "Exitosamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show("aaaa:" + ex, "Error Interno al guardar", MessageBoxButton.OK, MessageBoxImage.Stop);
            }

            return val_ret;
        }
        private DataSet LoadData(string Ano, string codemp, CancellationToken cancellationToken)
        {
            try
            {
                SqlConnection con = new SqlConnection(SiaWin._cn);
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                cmd = new SqlCommand("_EmpCoSaldo_ini", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ano", Ano);
                cmd.Parameters.AddWithValue("@codemp", codemp);


                da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("error");
                return null;
            }
        }
        public Boolean CamposLlenos()
        {
            Boolean b = false;
            if (comboEmpresa.Text == "" || string.IsNullOrEmpty(comboEmpresa.Text))
            {
                b = true;
            }
            return b;
        }

        private void Btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void BtnRealizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CancellationTokenSource source = new CancellationTokenSource();
                CancellationToken token = source.Token;

                btnRealizar.IsEnabled = false;

                string Ano = comboYear.SelectedIndex.ToString();
                string emp = comboEmpresa.SelectedValue.ToString();



                var slowTask = Task<DataSet>.Factory.StartNew(() => LoadData(Ano, emp, source.Token), source.Token);
                await slowTask;

                    btnRealizar.IsEnabled = false;
                    MessageBox.Show("Traslado realizado");
                //SiaWin.seguridad.Auditor(0, SiaWin._proyectId, SiaWin._UserId, SiaWin._UserGroup, idemp, "GENERO TRASLADO DE SALDO:" + comboEmpresa + "/" + comboYear, "");
                //    MessageBox.Show("no hay nada");

                //    if (Ano != string.Empty)
                //    {
                //        string name = ((ComboBoxItem)comboEmpresa.SelectedItem).Content.ToString();
                //      
                //    }
                //    else
                //    {
                //        return;
                //    }
            }
            catch (Exception w)
            {

                MessageBox.Show("Error: " + w);
            }
        }
    }
}
