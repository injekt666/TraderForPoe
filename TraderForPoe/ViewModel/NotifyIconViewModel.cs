﻿using System.ComponentModel;
using System.Windows;
using TraderForPoe.Classes;
using TraderForPoe.Windows;

namespace TraderForPoe.ViewModel
{
    public class NotifyIconViewModel : INotifyPropertyChanged
    {
        public NotifyIconViewModel()
        {
            CmdLog = new RelayCommand(() => new LogMonitor(MainWindow.lmvm).Show());
            CmdHistory = new RelayCommand(() => new TradeHistory().Show());
            CmdSettings = new RelayCommand(() => new UserSettings().Show());
            CmdRestart = new RelayCommand(() => RestartApp());
            CmdUpdate = new RelayCommand(() => Updater.CheckForUpdate());
            CmdAbout = new RelayCommand(() => new About().Show());
            CmdQuit = new RelayCommand(() => Application.Current.Shutdown());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand CmdAbout { get; private set; }
        public RelayCommand CmdHistory { get; private set; }
        public RelayCommand CmdLog { get; private set; }
        public RelayCommand CmdMonitor { get; private set; }
        public RelayCommand CmdQuit { get; private set; }
        public RelayCommand CmdRestart { get; private set; }
        public RelayCommand CmdSettings { get; private set; }
        public RelayCommand CmdUpdate { get; private set; }

        public void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private void RestartApp()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            System.Windows.Application.Current.Shutdown();
        }
    }
}