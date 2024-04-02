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
    /// Interaction logic for thongtincn.xaml
    /// </summary>
    public partial class thongtincn : UserControl
    {
        CongDanDAO cdD = new CongDanDAO();
        TruyVanChungDao tvc = new TruyVanChungDao();
        KhaiTuDAO shk = new KhaiTuDAO();
        LamSach ls = new LamSach();
        public thongtincn()
        {
            InitializeComponent();
        }
        public void LamSachUS()
        {
            ls.LamSachGiaTri(thongtincanhan, null, 1);
            HoTen.Text = "Họ Và Tên";
            CCCD.Text = "CCCD";
            ThuongTru.Text = "Quê Quán";
            Nam.Background = Brushes.White;
            Nu.Background = Brushes.White;
            infocard.Text = "";
        }


        string name(string cccd)
        {
            try
            {

                return tvc.GetValue("CongDan", "hoten", "cccd", cccd, 2)[0][0].ToString();
            }
            catch
            {

            }
            return "";
        }
        void ThongTin(CongDan cd)
        {
            HoTen.Text = cd.HoTen;
            CCCD.Text = cd.CCCD;
            ThuongTru.Text = cd.ThuongTru;
            cccdCha.textBox.Text = cd.CccdCha;
            cccdMe.textBox.Text = cd.CccdMe;
            HonNhan.textBox.Text = cd.HonNhan;
            TamTru.textBox.Text = cd.TamTru;
            NgaySinh.textBox.Text = cd.NgaySinh;
            nameCha.textBox.Text = name(cd.CccdCha);
            nameMe.textBox.Text = name(cd.CccdMe);
            if (cd.GioiTinh == "Nam")
            {
                Nam.Background = Brushes.Red;
            }
            else
            {
                Nu.Background = Brushes.Pink ;
            }
            NgayMat.textBox.Text = "";
            try
            {
                NgayMat.textBox.Text = shk.TimKiem(null, infocard.Text, 1)[0][1].ToString();
            }
            catch
            {

            }
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRow cd;
                CongDan congdan = new CongDan(infocard.Text);
                try
                {
                    cd = cdD.TimKiem(congdan, "", "", 2)[0];

                    CongDan cdn = new CongDan(cd[0].ToString(), cd[1].ToString(), cd[2].ToString(), cd[3].ToString(), cd[4].ToString(), cd[5].ToString(), cd[6].ToString(), cd[7].ToString()
                            , cd[8].ToString(), cd[9].ToString(), cd[10].ToString(), float.Parse(cd[11].ToString()), cd[12].ToString());
                    ThongTin(cdn);
                }
                catch
                {
                    MessageBox.Show("Khong tim thay trong co so du lieu");
                    return;
                }
            }
        }
    }
}
