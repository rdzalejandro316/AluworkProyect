using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Data;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace SiasoftAppExt
{

    //Sia.PublicarPnt(10713, "PvFormaPago");
    //dynamic ww = ((Inicio)Application.Current.MainWindow).WindowExt(10713, "PvFormaPago");  
    //ww.ShowInTaskbar = false;
    //ww.Owner = Application.Current.MainWindow;
    //ww.WindowStartupLocation = WindowStartupLocation.CenterScreen;    
    //ww.ShowDialog();

    public partial class PvFormaPago : Window
    {
        dynamic SiaWin;
        int idemp = 0;
        string cnEmp = string.Empty;

        public DataTable dtCue = new DataTable();
        DataTable dtFpag = new DataTable();
        public double totalPagar = 0;
        public string predeterminarfpag = "";
        public bool flag = false;


        //consulta
        public string idreg = "";
        public bool consulta = true;


        public PvFormaPago()
        {
            try
            {
                InitializeComponent();
                SiaWin = Application.Current.MainWindow;
                idemp = SiaWin._BusinessId;
                cnEmp = SiaWin.Func.DatosEmp(idemp);

                loadInfo();
            }
            catch (Exception w)
            {
                MessageBox.Show("erro FormasDePago():" + w, "alerta", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                loadColumns();

                if (string.IsNullOrEmpty(idreg))
                {

                    TxtTotalRecaudo.Text = totalPagar.ToString("C2");

                    if (!string.IsNullOrWhiteSpace(predeterminarfpag))
                    {
                        DataTable dt = SiaWin.Func.SqlDT("select * from inmae_fpag where cod_pag='01'; ", "formapago", idemp);
                        if (dt.Rows.Count > 0)
                        {
                            string codpag = dt.Rows[0]["cod_pag"].ToString().Trim();
                            string nompag = dt.Rows[0]["nom_pag"].ToString().Trim();
                            string codcta = dt.Rows[0]["cod_cta"].ToString().Trim();
                            insertGrid(codpag, nompag, codcta, totalPagar);
                            TxtTotalRecaudo.Text = "0";
                        }
                    }

                }
                else
                {
                    string query = "select t1.cod_pag,t2.nom_pag,t1.vlr_pagado,t1.cod_cta,t1.doc_ref,t1.cod_ban  ";
                    query += "from indet_fpag as t1 ";
                    query += "inner join inmae_fpag t2 on t1.cod_pag = t2.cod_pag ";
                    query += "where t1.idregcab='" + idreg + "' ";

                    double val = 0;
                    DataTable dt = SiaWin.Func.SqlDT(query, "formapago", idemp);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (System.Data.DataRow item in dt.Rows)
                        {
                            string codpag = item["cod_pag"].ToString().Trim();
                            string nom_pag = item["nom_pag"].ToString().Trim();
                            string cod_cta = item["cod_cta"].ToString().Trim();
                            double valor = Convert.ToDouble(item["vlr_pagado"]);
                            val += valor;
                            string doc_ref = item["doc_ref"].ToString().Trim();
                            string cod_ban = item["cod_ban"].ToString().Trim();
                            dtCue.Rows.Add(codpag, nom_pag, valor, cod_cta, doc_ref, cod_ban);
                        }

                    }
                    if (consulta) GridMain.IsEnabled = false;
                    else TxtTotalRecaudo.Text = (totalPagar - val).ToString("C2");
                }
            }
            catch (Exception w)
            {
                MessageBox.Show("errro al cargar formas de pago:" + w);
            }
        }

        private void loadInfo()
        {
            try
            {
                dtFpag = SiaWin.Func.SqlDT("select cod_pag,nom_pag,cod_cta from inmae_fpag", "formapago", idemp);
                CBpagos.ItemsSource = dtFpag.DefaultView;
                CBpagos.DisplayMemberPath = "nom_pag";
                CBpagos.SelectedValuePath = "cod_pag";
            }
            catch (Exception w)
            {
                MessageBox.Show("error en loadInfo:" + w);
            }

        }


        public void loadColumns()
        {
            try
            {
                dtCue.Columns.Add("cod_pag");
                dtCue.Columns.Add("nom_pag");
                dtCue.Columns.Add("valor", typeof(decimal));
                dtCue.Columns.Add("cod_cta");
                dtCue.Columns.Add("doc_ref");
                dtCue.Columns.Add("cod_ban");
                dataGrid.ItemsSource = dtCue.DefaultView;
            }
            catch (Exception w)
            {
                MessageBox.Show("error en loadColums:" + w);
            }

        }


        private void dataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            try
            {
                GridColumn colum = ((SfDataGrid)sender).CurrentColumn as GridColumn;
                if (colum.MappingName == "valor")
                {
                    double totalabono = 0;

                    double.TryParse(dtCue.Compute("Sum(valor)", "").ToString(), out totalabono);
                    System.Data.DataRow dr = dtCue.Rows[dataGrid.SelectedIndex];
                    if (totalabono > totalPagar)
                    {
                        MessageBox.Show("El valor pagado es mayor al saldo...");
                        dr.BeginEdit();
                        dr["valor"] = 0;
                        dr.EndEdit();
                    }
                    dataGrid.UpdateLayout();
                    sumaAbonos();
                    //SiaWin.Browse(dtCue);
                }
            }
            catch (Exception w)
            {
                MessageBox.Show("error en dataGrid_CurrentCellEndEdit:" + w);
            }
        }

        private void dataGrid_PreviewKeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (dataGrid.SelectedIndex >= 0)
                {
                    DataRowView row = (DataRowView)dataGrid.SelectedItems[0];
                    GridColumn colum = ((SfDataGrid)sender).CurrentColumn as GridColumn;

                    if (e.Key == Key.F6)
                    {
                        if (colum.MappingName == "cod_ban")
                        {
                            int idr = 0; string code = ""; string nombre = "";
                            dynamic xx = SiaWin.WindowBuscar("Cobancos", "banco", "nombre", "banco", "banco", "Bancos", cnEmp, true, "", idEmp: idemp);
                            xx.ShowInTaskbar = false;
                            xx.Owner = Application.Current.MainWindow;
                            xx.Height = 400;
                            xx.Width = 500;
                            xx.ShowDialog();
                            idr = xx.IdRowReturn;
                            code = xx.Codigo;
                            nombre = xx.Nombre;
                            xx = null;
                            if (!string.IsNullOrEmpty(code))
                            {
                                System.Data.DataRow dr = dtCue.Rows[dataGrid.SelectedIndex];
                                dr.BeginEdit();
                                dr["cod_ban"] = code;
                                dr.EndEdit();
                            }
                        }
                    }

                    if (e.Key == Key.F8)
                    {
                        GridColumn Colum = ((SfDataGrid)sender).CurrentColumn as GridColumn;
                        if (Colum.MappingName == "valor")
                        {
                            double totalabono = 0;
                            double.TryParse(dtCue.Compute("Sum(valor)", "").ToString(), out totalabono);
                            System.Data.DataRow dr = dtCue.Rows[dataGrid.SelectedIndex];
                            dr.BeginEdit();
                            dr["valor"] = (totalPagar - totalabono);
                            dr.EndEdit();
                            e.Handled = true;
                        }
                        dataGrid.UpdateLayout();
                        sumaAbonos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en dataGrid_PreviewKeyDown_1" + ex.Message.ToString());
            }
        }

        private void sumaAbonos()
        {
            try
            {
                double totalabono = 0;
                double.TryParse(dtCue.Compute("Sum(valor)", "").ToString(), out totalabono);
                TxtTotalPagado.Text = totalabono.ToString("C2");
                TxtTotalRecaudo.Text = Convert.ToDecimal(totalPagar - totalabono).ToString("C2"); ;
            }
            catch (Exception w)
            {
                MessageBox.Show("error en sumaAbonos():" + w);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var valor = TxtTotalRecaudo.Text;
                double value = double.Parse(valor, NumberStyles.Currency);

                if (value == 0)
                {
                    double abono = 0;
                    double.TryParse(dtCue.Compute("Sum(valor)", "").ToString(), out abono);
                    if (abono <= 0 || abono != totalPagar)
                    {
                        MessageBox.Show("Digita Valor a pagar o valor a abono es diferente al valor a pagar");
                        dataGrid.SelectedIndex = 0;
                        dataGrid.Focus();
                        return;
                    }

                    flag = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tiene un saldo por pagar de:" + TxtTotalRecaudo.Text);
                }

            }
            catch (Exception w)
            {
                MessageBox.Show("error en Button_Click:" + w);
            }
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            flag = false;
            this.Close();
        }


        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.F5)
                {
                    if (e.Key == System.Windows.Input.Key.F5)
                    {
                        BtnGrabar.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                        return;
                    }
                }
            }
            catch (Exception w)
            {
                MessageBox.Show("error Window_PreviewKeyDown:" + w);
            }

        }

        private void Btnadd_Click(object sender, RoutedEventArgs e)
        {
            if (CBpagos.SelectedIndex >= 0)
            {
                System.Data.DataRow selectedDataRow = ((DataRowView)CBpagos.SelectedItem).Row;
                string name = selectedDataRow["nom_pag"].ToString();
                string codigo = selectedDataRow["cod_pag"].ToString();
                string cod_cta = selectedDataRow["cod_cta"].ToString();

                insertGrid(codigo, name, cod_cta);
            }
            else
            {
                MessageBox.Show("Selecione una forma de pago");
            }
        }

        void insertGrid(string cod_pag, string nom_pag, string cod_cta, double val = 0)
        {

            dtCue.Rows.Add(cod_pag, nom_pag, val, cod_cta, "", "");
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataGrid.SelectedIndex >= 0)
                {
                    DataRowView row = (DataRowView)dataGrid.SelectedItems[0];
                    row.Delete();
                    sumaAbonos();
                }
            }
            catch (Exception w)
            {
                MessageBox.Show("errro en la eliminacio:" + w);
            }

        }







    }
}
