using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Xml;

namespace ComicsTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Comic> comics { get; set; }


        public MainWindow()
        {   
            InitializeComponent();


            comics = new List<Comic>();
            comics = LoadComics();
            this.DataContext = this;
            Mylist.ItemsSource = comics;

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        public List<Comic> LoadComics()
        {
            List<Comic> coms = new List<Comic>();

            Comic com1 = new Comic("Batman", true);
            Comic com2 = new Comic("Flash", true);
            Comic com3 = new Comic("Booster", false);
            coms.Add(com1);
            coms.Add(com2);
            coms.Add(com3);
            XmlTextWriter xmlTextWriter = new XmlTextWriter("D:/cs/ComicsTracker/ComicsTracker/data.xml", System.Text.Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("comics");
            for(int i = 0; i < coms.Count; i++)
            {
                xmlTextWriter.WriteElementString("name",coms[i].Name);
                xmlTextWriter.WriteElementString("status", coms[i].Finished.ToString());
            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
            return coms;
        }
    }
}
