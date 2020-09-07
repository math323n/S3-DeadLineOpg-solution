﻿
using S3_DeadLineOpg.GUI.UserControls;

using System;
using System.Windows;
using System.Windows.Controls;

namespace S3_DeadLineOpg.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {

 
        readonly LoginControl loginControl;
   

        public MainWindow()
        {
            InitializeComponent();
            loginControl = new LoginControl();
            Display(loginControl);
        }


        private void Display(UserControl userControl)
        {
            displayedUserControl.Content = userControl;
        }
    }
}