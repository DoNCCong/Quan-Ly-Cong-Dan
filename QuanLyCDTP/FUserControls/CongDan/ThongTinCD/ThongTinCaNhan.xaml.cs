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
using System.Data;
namespace QuanLyCDTP
{
    /// <summary>
    /// Interaction logic for ThongTinCaNhan.xaml
    /// </summary>
    public partial class ThongTinCaNhan : UserControl
    {
        
        thongtincn thc = new thongtincn();
        FBackGround fbg = new FBackGround();
        Fsohokhau hokhau = new Fsohokhau();
        int sl=1;//Bien lua chon de lam Lam Sach UserControl
        public ThongTinCaNhan()
        {
            InitializeComponent();
            fbg.NhapUserControl(thc);
            ThongTin.Children.Add(fbg);
        }
        void LamSachUS()
        {
            switch (sl)
            {
                case 1:
                    {
                        thc.LamSachUS();
                        break;
                    }
                case 2:
                    {
                        hokhau.LamSachUS();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        
        private void btnHoKhau_Click(object sender, RoutedEventArgs e)
        {
            sl = 2;
            boHienthi.Visibility = Visibility.Hidden;
            gridhienthi.Visibility = Visibility.Visible;
            gridhienthi.Children.Clear();
            gridhienthi.Children.Add(hokhau);
        }
        private void btn_cmnd_Click(object sender, RoutedEventArgs e)
        {
            sl = 1;
            boHienthi.Visibility = Visibility.Visible;
            gridhienthi.Visibility = Visibility.Hidden;
        }
        private void btn_ks_Click(object sender, RoutedEventArgs e)
        {

            boHienthi.Visibility = Visibility.Hidden;
            gridhienthi.Visibility = Visibility.Visible;
            gridhienthi.Children.Clear();
        }

        private void LamSach(object sender, RoutedEventArgs e)
        {
            LamSachUS();
        }
    }
}
