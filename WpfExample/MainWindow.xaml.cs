﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InfoCommand _infoCommand = new InfoCommand();

        public MainWindow()
        {
            InitializeComponent();

            // Свържете DataContext с текущия MainWindow
            this.DataContext = this;
        }

        // Свойство за публичен достъп до командата
        public InfoCommand InformationCommand
        {
            get { return _infoCommand; }
        }
    }
}
