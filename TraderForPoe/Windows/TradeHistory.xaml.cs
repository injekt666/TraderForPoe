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
using System.Windows.Shapes;
using TraderForPoe.ViewModel;

namespace TraderForPoe.Windows
{
    /// <summary>
    /// Interaktionslogik für TradeHistory.xaml
    /// </summary>
    public partial class TradeHistory : Window
    {
        public TradeHistory()
        {
            InitializeComponent();
            this.DataContext = new TradeHistoryViewModel();
        }
    }
}
