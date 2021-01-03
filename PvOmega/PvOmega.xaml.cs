using System;
using System.Collections.Generic;
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
    /// Sia.PublicarPnt(10718,"PvOmega");
    /// Sia.TabU(10718);
    public partial class PvOmega : UserControl
    {

        dynamic SiaWin;
        dynamic tabitem;
        int idemp = 0;
        int moduloid = 0;        
        string cnEmp = "";
        string cod_empresa = "";

        public PvOmega(dynamic tabitem1)
        {
            InitializeComponent();
            SiaWin = Application.Current.MainWindow;
            tabitem = tabitem1;
            tabitem.MultiTab = true;            
            if (tabitem.idemp > 0) idemp = tabitem.idemp;
            if (tabitem.idemp <= 0) idemp = SiaWin._BusinessId;        
        }





    }
}
