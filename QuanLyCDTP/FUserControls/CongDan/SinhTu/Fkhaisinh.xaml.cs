using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

namespace QuanLyCDTP
{
    /// <summary>
    /// Interaction logic for Fkhaisinh.xaml
    /// </summary>
    public partial class Fkhaisinh : UserControl
    {
        KhaiSinhDao ksd = new KhaiSinhDao();
        Check check = new Check();
        HonNhanDao hnd = new HonNhanDao();
        CongDanDAO cdd = new CongDanDAO();

        public Fkhaisinh()
        {
            InitializeComponent();
        }
        void TimKiemCongDan(string cccdNam, string cccdNu, string NoiDangKy)
        {


            DataRow cd;

            try
            {
                try
                {
                    cd = cdd.TimKiem(null, cccdNam, "", 1)[0];
                    cccdcha.textBox.Text = cd[0].ToString();
                    namecha.textBox.Text = cd[1].ToString();
                    dantoccha.textBox.Text = cd[7].ToString();
                    quoctichcha.textBox.Text = cd[12].ToString();
                }
                catch
                {

                }
                try
                {
                    cd = cdd.TimKiem(null, cccdNu, "", 1)[0];
                    cccdme.textBox.Text = cd[0].ToString();
                    nameme.textBox.Text = cd[1].ToString();
                    dantocme.textBox.Text = cd[7].ToString();
                    quoctichme.textBox.Text = cd[12].ToString();
                }
                catch
                {

                }
            }
            catch
            {
                MessageBox.Show("Khong tim thay trong co so du lieu");
                return;
            }
        }
        private void btnkhaisinh_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                
                KhaiSinh khaisinh = new KhaiSinh(maso.textBox.Text, name.textBox.Text, gioitinh.Text, BoTroGKS.Date(), dantoc.textBox.Text
                    , quoctich.textBox.Text, noisinh.textBox.Text, namecha.textBox.Text, dantoccha.textBox.Text,
                    quoctichcha.textBox.Text, nameme.textBox.Text, dantocme.textBox.Text, quoctichme.textBox.Text, BoTroGKS.CCCDCanBo.textBox.Text,cccdcha.textBox.Text, cccdme.textBox.Text,BoTroGKS.Date(),BoTroGKS.CCCDCanBo.textBox.Text);
                bool checkkhasinh = check.CheckNotNull(khaisinh);
                if (checkkhasinh == true)
                {
                    if(ksd.ThemKhaiSinh(khaisinh))
                        MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    else
                        MessageBox.Show("Thất Bại", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Bỏ Trống", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }

        void ThongTinNam(KhaiSinh ks,DateTime date, string noidk)
        {
            List<InfoCard> infor = new List<InfoCard>()
            {
                maso,name,dantoc,quoctich,noisinh,namecha,dantoccha, quoctichcha,
                nameme, dantocme,quoctichme,BoTroGKS.CCCDCanBo,cccdcha,cccdme
            };
            Object[] properties = new Object[] {ks.Id,ks.Hoten
            ,ks.Dantoc,ks.Quoctich,ks.Noisinh,ks.Hotencha,ks.Dantoccha,ks.Quoctichcha,ks.Hotenme,ks.Dantocme,ks.Quoctichme,ks.Nguoidangky,ks.CCCDCha,ks.CCCDMe};
            for (int i = 0; i < infor.Count; i++)
            {
                infor[i].textBox.Text = properties[i].ToString();
            }
            //Date.SelectedDate = ks.NgayThangNamSinh;
            gioitinh.Text = ks.Gioitinh.ToString();
            BoTroGKS.TimKiem();
            BoTroGKS.noidangky.textBox.Text = noidk;
            BoTroGKS.DisplayDate(date);
        }
        private void maso_KeyDown(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRow cd;
                try
                {
                    cd = ksd.TimKiem(null, maso.textBox.Text, "", 1)[0];
                }
                catch
                {
                    MessageBox.Show("Khong tim thay trong co so du lieu");
                    return;
                }
                ThongTinNam(new KhaiSinh(cd[0].ToString(), cd[1].ToString(), cd[2].ToString(),
                    Convert.ToDateTime(cd[3]).Date, cd[4].ToString(), cd[5].ToString(), cd[6].ToString(), cd[7].ToString()
                    , cd[8].ToString(), cd[9].ToString(), cd[10].ToString(), cd[11].ToString(), cd[12].ToString(), cd[13].ToString(), cd[14].ToString(), cd[15].ToString(), Convert.ToDateTime(cd[16].ToString()), cd[17].ToString())
                    ,Convert.ToDateTime(cd[16].ToString()),cd[17].ToString());//cccdcha.textBox.Text, cccdme.textBox.Text));
            }
        }
        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            KhaiSinh khaisinh = new KhaiSinh(maso.textBox.Text);
            if (ksd.XoaKS(khaisinh) == null)
            {
                MessageBox.Show("Hãy Thử Lại", "Thông Báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }
        }

        private void btnxoatext_Click(object sender, RoutedEventArgs e)
        {
           List<InfoCard> infor = new List<InfoCard>()
            {
                maso,name,dantoc, quoctich,noisinh, cccdcha,cccdme,namecha,nameme,dantoccha,dantocme,quoctichcha,quoctichme,
                namecha,dantoccha,quoctichcha,nameme,dantocme,quoctichme,BoTroGKS.TenCanBo
            };
            foreach (InfoCard card in infor)
            {
                card.textBox.Clear();
            }
            //Date.SelectedDate = null;
            BoTroGKS.Clear();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                KhaiSinh khaisinh = new KhaiSinh(maso.textBox.Text, name.textBox.Text, gioitinh.Text
                    , BoTroGKS.Date(), dantoc.textBox.Text
                   , quoctich.textBox.Text, noisinh.textBox.Text, namecha.textBox.Text, dantoccha.textBox.Text,
                   quoctichcha.textBox.Text, nameme.textBox.Text, dantocme.textBox.Text, quoctichme.textBox.Text, BoTroGKS.CCCDCanBo.textBox.Text, cccdcha.textBox.Text, cccdme.textBox.Text, BoTroGKS.Date(), BoTroGKS.CCCDCanBo.textBox.Text);
                bool checkks = check.CheckNotNull(khaisinh);
                if (checkks == true)
                {
                    if(ksd.SuaKhaiSinh(khaisinh))
                        MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    else
                        MessageBox.Show("Thất Bại", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("That Bai", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }
        void ThongTinKhaiSinh(KhaiSinh ks)
        {
            List<InfoCard> infor = new List<InfoCard>()
            {
               namecha,dantoccha,quoctichcha,nameme, dantocme,quoctichme
            };
            Object[] properties = new Object[] { ks.Hotencha, ks.Dantoccha, ks.Quoctichcha, ks.Hotenme, ks.Dantocme, ks.Quoctichme };
            for (int i = 0; i < infor.Count; i++)
            {
                infor[i].textBox.Text = properties[i].ToString();
            }
        }

        private void btntimkiem_Click(object sender, RoutedEventArgs e)
        {
            HonNhan hn = new HonNhan(cccdcha.textBox.Text, cccdme.textBox.Text);
            DataRow cd;
            try
            {
                cd = hnd.TimKiemThongTinKS(hn, "", "", 1)[0];
            }
            catch
            {
                MessageBox.Show("Khong tim thay trong co so du lieu");
                return;
            }
            ThongTinKhaiSinh(new KhaiSinh(cd[0].ToString(), cd[1].ToString(), cd[2].ToString(),
                      (cd[3]).ToString(), cd[4].ToString(), cd[5].ToString()));
            
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRowCollection dbc = hnd.TimKiemThongTinKS(null, cccdcha.textBox.Text, cccdme.textBox.Text, 2);
                if (dbc.Count != 0)
                {
                    try
                    {
                        TimKiemCongDan(dbc[0][0].ToString(), dbc[0][1].ToString(), dbc[0][3].ToString());
                    }
                    catch
                    {

                    }
                }
            }
        }

        
        private void Enter2(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRowCollection dbc = hnd.TimKiemThongTinKS(null, cccdcha.textBox.Text, cccdme.textBox.Text, 2);
                if (dbc.Count != 0)
                {
                    try
                    {
                        TimKiemCongDan(dbc[0][0].ToString(), dbc[0][1].ToString(), dbc[0][3].ToString());
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
