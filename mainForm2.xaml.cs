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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Diagnostics;
using CSS_Palette.ViewModels;

namespace CSS_Palette
{
    /// <summary>
    /// Interaction logic for mainForm2.xaml
    /// </summary>
    public partial class mainForm2 : UserControl
    {
        public mainForm2()
        {
            InitializeComponent();
            RadST.IsChecked = true;
            //Creat data for Anchor Diameter
            string b = "''";
            Anchor_Dia Dong_1A = new Anchor_Dia();
            Dong_1A.Anchorid = "CSS-CA25";
            Dong_1A.Diaid = "1/4" + b;

            Anchor_Dia Dong_2A = new Anchor_Dia();
            Dong_2A.Anchorid = "CSS-CA37";
            Dong_2A.Diaid = "3/8" + b;

            Anchor_Dia Dong_3A = new Anchor_Dia();
            Dong_3A.Anchorid = "CSS-CA50";
            Dong_3A.Diaid = "1/2" + b;

            Anchor_Dia Dong_4A = new Anchor_Dia();
            Dong_4A.Anchorid = "CSS-CA62";
            Dong_4A.Diaid = "5/8" + b;

            Anchor_Dia Dong_5A = new Anchor_Dia();
            Dong_5A.Anchorid = "CSS-CA75";
            Dong_5A.Diaid = "3/4" + b;

            Anchor_Dia Dong_6A = new Anchor_Dia();
            Dong_6A.Anchorid = "CSS-CA87";
            Dong_6A.Diaid = "7/8" + b;

            Anchor_Dia Dong_7A = new Anchor_Dia();
            Dong_7A.Anchorid = "CSS-CA100";
            Dong_7A.Diaid = "1" + b;

            Anchor_Dia Dong_8A = new Anchor_Dia();
            Dong_8A.Anchorid = "CSS-CA112";
            Dong_8A.Diaid = "1-1/8" + b;

            Anchor_Dia Dong_9A = new Anchor_Dia();
            Dong_9A.Anchorid = "CSS-CA125";
            Dong_9A.Diaid = "1-1/4" + b;

            Anchor_Dia Dong_10A = new Anchor_Dia();
            Dong_10A.Anchorid = "CSS-CA137";
            Dong_10A.Diaid = "1-3/8" + b;

            Anchor_Dia Dong_11A = new Anchor_Dia();
            Dong_11A.Anchorid = "CSS-CA150";
            Dong_11A.Diaid = "1-1/2" + b;

            DatagridACXAML.Items.Add(Dong_1A);
            DatagridACXAML.Items.Add(Dong_2A);
            DatagridACXAML.Items.Add(Dong_3A);
            DatagridACXAML.Items.Add(Dong_4A);
            DatagridACXAML.Items.Add(Dong_5A);
            DatagridACXAML.Items.Add(Dong_6A);
            DatagridACXAML.Items.Add(Dong_7A);
            DatagridACXAML.Items.Add(Dong_8A);
            DatagridACXAML.Items.Add(Dong_9A);
            DatagridACXAML.Items.Add(Dong_10A);
            DatagridACXAML.Items.Add(Dong_11A);

            //FPS Coating
            String c = "''";
            Element_FPS_Coating Dong1B = new Element_FPS_Coating();
            Dong1B.Elementid = "SLAB";
            Dong1B.THKid = "1" + c;
            Dong1B.Extendid = "5" + c;

            Element_FPS_Coating Dong2B = new Element_FPS_Coating();
            Dong2B.Elementid = "JOIST";
            Dong2B.THKid = "1" + c;
            Dong2B.Extendid = "6" + c;

            Element_FPS_Coating Dong3B = new Element_FPS_Coating();
            Dong3B.Elementid = "BEAM";
            Dong3B.THKid = "3/4" + c;
            Dong3B.Extendid = "6" + c;

            Element_FPS_Coating Dong4B = new Element_FPS_Coating();
            Dong4B.Elementid = "COLUMN";
            Dong4B.THKid = "3/4" + c;
            Dong4B.Extendid = " ";

            DatagridCoatingXAML.Items.Add(Dong1B);
            DatagridCoatingXAML.Items.Add(Dong2B);
            DatagridCoatingXAML.Items.Add(Dong3B);
            DatagridCoatingXAML.Items.Add(Dong4B);
        }
        public class Style_Scale
        {
            public string Scaleid { get; set; }
            public string Styleid { get; set; }

        }
        public class Anchor_Dia
        {
            public string Anchorid { get; set; }
            public string Diaid { get; set; }
        }
        public class Element_FPS_Coating
        {
            public string Elementid { get; set; }
            public string THKid { get; set; }
            public string Extendid { get; set; }

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+.");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void RadST_Checked_1(object sender, RoutedEventArgs e)
        {
            SST_image.Visibility = Visibility.Collapsed;

            string a = "''";
            Style_Scale Dong_1 = new Style_Scale();
            Dong_1.Styleid = "4";
            Dong_1.Scaleid = "3" + a;

            Style_Scale Dong_2 = new Style_Scale();
            Dong_2.Styleid = "8";
            Dong_2.Scaleid = "1-1/2" + a;

            Style_Scale Dong_2a = new Style_Scale();
            Dong_2a.Styleid = "12";
            Dong_2a.Scaleid = "1" + a;

            Style_Scale Dong_3 = new Style_Scale();
            Dong_3.Styleid = "16";
            Dong_3.Scaleid = "3/4" + a;

            Style_Scale Dong_4 = new Style_Scale();
            Dong_4.Styleid = "24";
            Dong_4.Scaleid = "1/2" + a;

            Style_Scale Dong_5 = new Style_Scale();
            Dong_5.Styleid = "32";
            Dong_5.Scaleid = "3/8" + a;

            Style_Scale Dong_6 = new Style_Scale();
            Dong_6.Styleid = "48";
            Dong_6.Scaleid = "1/4" + a;

            Style_Scale Dong_7 = new Style_Scale();
            Dong_7.Styleid = "64";
            Dong_7.Scaleid = "3/16" + a;

            Style_Scale Dong_8 = new Style_Scale();
            Dong_8.Styleid = "96";
            Dong_8.Scaleid = "1/8" + a;

            Style_Scale Dong_9 = new Style_Scale();
            Dong_9.Styleid = "128";
            Dong_9.Scaleid = "3/32" + a;

            Style_Scale Dong_10 = new Style_Scale();
            Dong_10.Styleid = "192";
            Dong_10.Scaleid = "1/16" + a;

            Style_Scale Dong_11 = new Style_Scale();
            Dong_11.Styleid = "240";
            Dong_11.Scaleid = "1/20" + a;
            Style_Scale Dong_12 = new Style_Scale();
            Dong_12.Styleid = "480";
            Dong_12.Scaleid = "1/40" + a;
            Style_Scale Dong_13 = new Style_Scale();
            Dong_13.Styleid = "720";
            Dong_13.Scaleid = "1/60" + a;
            Style_Scale Dong_14 = new Style_Scale();
            Dong_14.Styleid = "1200";
            Dong_14.Scaleid = "1/100" + a;

            DatagridXAML.Items.Add(Dong_1);
            DatagridXAML.Items.Add(Dong_2);
            DatagridXAML.Items.Add(Dong_2a);
            DatagridXAML.Items.Add(Dong_3);
            DatagridXAML.Items.Add(Dong_4);
            DatagridXAML.Items.Add(Dong_5);
            DatagridXAML.Items.Add(Dong_6);
            DatagridXAML.Items.Add(Dong_7);
            DatagridXAML.Items.Add(Dong_8);
            DatagridXAML.Items.Add(Dong_9);
            DatagridXAML.Items.Add(Dong_10);
            DatagridXAML.Items.Add(Dong_11);
            DatagridXAML.Items.Add(Dong_12);
            DatagridXAML.Items.Add(Dong_13);
            DatagridXAML.Items.Add(Dong_14);
        }
        private void RadST_Unchecked(object sender, RoutedEventArgs e)
        {
            //ST_image.Visibility = Visibility.Collapsed;
            SST_image.Visibility = Visibility.Visible;
            DatagridXAML.Items.Clear();
        }
        private void RadSST_Checked_1(object sender, RoutedEventArgs e)
        {
            ST_image.Visibility = Visibility.Collapsed;
            string a = "''";
            Style_Scale Dong_1 = new Style_Scale();
            Dong_1.Styleid = "16";
            Dong_1.Scaleid = "1-1/2" + a;

            Style_Scale Dong_2 = new Style_Scale();
            Dong_2.Styleid = "24";
            Dong_2.Scaleid = "1" + a;

            Style_Scale Dong_3 = new Style_Scale();
            Dong_3.Styleid = "32";
            Dong_3.Scaleid = "3/4" + a;

            Style_Scale Dong_4 = new Style_Scale();
            Dong_4.Styleid = "48";
            Dong_4.Scaleid = "1/2" + a;

            Style_Scale Dong_5 = new Style_Scale();
            Dong_5.Styleid = "64";
            Dong_5.Scaleid = "3/8" + a;

            Style_Scale Dong_6 = new Style_Scale();
            Dong_6.Styleid = "96";
            Dong_6.Scaleid = "1/4" + a;

            Style_Scale Dong_7 = new Style_Scale();
            Dong_7.Styleid = "128";
            Dong_7.Scaleid = "3/16" + a;

            Style_Scale Dong_8 = new Style_Scale();
            Dong_8.Styleid = "192";
            Dong_8.Scaleid = "1/8" + a;

            Style_Scale Dong_9 = new Style_Scale();
            Dong_9.Styleid = "240";
            Dong_9.Scaleid = "3/32" + a;

            DatagridXAML.Items.Add(Dong_1);
            DatagridXAML.Items.Add(Dong_2);
            DatagridXAML.Items.Add(Dong_3);
            DatagridXAML.Items.Add(Dong_4);
            DatagridXAML.Items.Add(Dong_5);
            DatagridXAML.Items.Add(Dong_6);
            DatagridXAML.Items.Add(Dong_7);
            DatagridXAML.Items.Add(Dong_8);
            DatagridXAML.Items.Add(Dong_9);
        }

        private void RadSST_Unchecked_1(object sender, RoutedEventArgs e)
        {
            //SST_image.Visibility = Visibility.Collapsed;
            ST_image.Visibility = Visibility.Visible;
            DatagridXAML.Items.Clear();
        }

        private void txtFeet_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtInch.Text != "")
                {
                    double varfeet, varin;
                    varfeet = Double.Parse(txtFeet.Text);
                    varin = Double.Parse(txtInch.Text);
                    lblFeet.Content = Math.Round(varfeet + varin / 12, 2).ToString();
                    //LbFeetRsult.Text = "Your result of: " + varfeet + "'" + "-" + varin + "''";             
                    lblInch.Content = Math.Round(varfeet * 12 + varin, 2).ToString() + "''";
                    txtFeet.Clear();
                    txtInch.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill INCH value = 0 if it has not value");
                }
            }
        }
        private void txtInch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtFeet.Text != "")
                {
                    double varfeet, varin;
                    varfeet = Double.Parse(txtFeet.Text);
                    varin = Double.Parse(txtInch.Text);
                    lblFeet.Content = Math.Round((varfeet + varin / 12), 2).ToString();
                    //LbFeetRsult.Text = "Your result of: " + varfeet + "'" + "-" + varin + "''";             
                    lblInch.Content = Math.Round((varfeet * 12 + varin), 2).ToString() + "''";
                    txtFeet.Clear();
                    txtInch.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill FEET value = 0 if it has not value");
                }
            }
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}