// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUITest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        //private void myButton_Click(object sender, RoutedEventArgs e)
        //{
        //    myButton.Content = "Clicked";
        //}

        private async void EnterBtnClick(object sender, RoutedEventArgs e)
        {
            string name = Txt1.Text.ToString();
            var showDialog = new Windows.UI.Popups.MessageDialog("Hello " + name);
            WinRT.Interop.InitializeWithWindow.Initialize(showDialog,
                WinRT.Interop.WindowNative.GetWindowHandle(this));
            await showDialog.ShowAsync();
        }

        private void CloseBtnClick(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
    }
}
