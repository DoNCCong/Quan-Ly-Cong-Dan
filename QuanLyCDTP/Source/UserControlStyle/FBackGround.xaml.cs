﻿using System;
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

namespace QuanLyCDTP { 
    /// <summary>
    /// Interaction logic for FBackGround.xaml
    /// </summary>
    public partial class FBackGround : UserControl
    {
        public FBackGround()
        {
            InitializeComponent();
        }
        public void NhapUserControl(UIElement ui)
        {
            thongtin.Children.Clear();
            thongtin.Children.Add(ui);
        }
    }
}
