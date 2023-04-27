
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Collections.Generic;
using itc_mng.classes;
using System.Data;
using System;
using System.Collections.Specialized;
using System.Security.Cryptography.Xml;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.Entity;
using System.Security.Policy;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace itc_mng
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) { this.DragMove(); }

        }
        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pnl_home.Visibility = Visibility.Visible;
            pnl_mmbr.Visibility = Visibility.Hidden;
            addbtn.Visibility = Visibility.Hidden;
            titl_page.Text = "Home";

            string cn = Properties.Settings.Default.con;
            SqlConnection conect = new SqlConnection(cn);
            conect.Open();
            string a, b, c;
            a = "select * from members";
            b = "select * from events";
            c = "select * from department";
            DataTable A= new DataTable("members");
            DataTable B = new DataTable("events");
            DataTable C = new DataTable("department");
            
            SqlDataAdapter AA= new SqlDataAdapter(a,conect);
            SqlDataAdapter BB=new SqlDataAdapter(b,conect);
            SqlDataAdapter CC=new SqlDataAdapter(c,conect);

            AA.Fill(A);
            BB.Fill(B); 
            CC.Fill(C);

            this.textblokmmbrnum.Text = A.Rows.Count.ToString();
            this.textnum_dep.Text=C.Rows.Count.ToString();
            this.textblokeventnum.Text=B.Rows.Count.ToString();


        }

        public void homebtn_Click(object sender, RoutedEventArgs e)
        {            
            pnl_home.Visibility = Visibility.Visible;
            pnl_mmbr.Visibility = Visibility.Hidden;
            addbtn.Visibility = Visibility.Hidden;
            titl_page.Text = "Home";

            string cn = Properties.Settings.Default.con;
            SqlConnection conect = new SqlConnection(cn);
            conect.Open();
            string a, b, c;
            a = "select * from members";
            b = "select * from events";
            c = "select * from department";
            DataTable A = new DataTable("members");
            DataTable B = new DataTable("events");
            DataTable C = new DataTable("department");

            SqlDataAdapter AA = new SqlDataAdapter(a, conect);
            SqlDataAdapter BB = new SqlDataAdapter(b, conect);
            SqlDataAdapter CC = new SqlDataAdapter(c, conect);

            AA.Fill(A);
            BB.Fill(B);
            CC.Fill(C);

            this.textblokmmbrnum.Text = A.Rows.Count.ToString();
            this.textnum_dep.Text = C.Rows.Count.ToString();
            this.textblokeventnum.Text = B.Rows.Count.ToString();

        }

        private void memberbtn_Click(object sender, RoutedEventArgs e)
        {
            pnl_home.Visibility = Visibility.Hidden;
            pnl_mmbr.Visibility = Visibility.Visible;
            addbtn.Visibility = Visibility.Visible;
            titl_page.Text = "Members";

             string cn = Properties.Settings.Default.con;
              SqlConnection conect = new SqlConnection(cn);
           

            if (conect.State != ConnectionState.Open) { conect.Open(); }
            string com = "SELECT * FROM members ";

            DataTable tbmmbr = new DataTable("members");
            SqlDataAdapter adapter = new SqlDataAdapter(com, conect);
            adapter.Fill(tbmmbr);
            gridmmbr.ItemsSource = tbmmbr.DefaultView;

            adapter.Update(tbmmbr);
            conect.Close();             
        }
        private void eventbtn_Click(object sender, RoutedEventArgs e)
        {
            pnl_home.Visibility = Visibility.Hidden;        
            pnl_mmbr.Visibility = Visibility.Visible;
            addbtn.Visibility = Visibility.Visible;                     
            titl_page.Text = "Events";

            string cn = Properties.Settings.Default.con;
            SqlConnection conect = new SqlConnection(cn);


            if (conect.State != ConnectionState.Open) { conect.Open(); }
            string com = "SELECT * FROM events ";
            try
            {

                DataTable tbdpr = new DataTable("events");
                SqlDataAdapter adapter = new SqlDataAdapter(com, conect);
                adapter.Fill(tbdpr);
                gridmmbr.ItemsSource = tbdpr.DefaultView;

                adapter.Update(tbdpr);
                conect.Close();
            }
            catch (Exception) { }






        }

        private void departemtbtn_Click(object sender, RoutedEventArgs e)
        {
            pnl_home.Visibility = Visibility.Hidden;
            pnl_mmbr.Visibility = Visibility.Visible;
            addbtn.Visibility = Visibility.Visible;
            titl_page.Text = "department";

            string cn = Properties.Settings.Default.con;
            SqlConnection conect = new SqlConnection(cn);


            if (conect.State != ConnectionState.Open) { conect.Open(); }
            string com = "SELECT * FROM department ";
            try
            {

                DataTable tbdpr = new DataTable("department");
                SqlDataAdapter adapter = new SqlDataAdapter(com, conect);
                adapter.Fill(tbdpr);
                gridmmbr.ItemsSource = tbdpr.DefaultView;
            
                adapter.Update(tbdpr);
                conect.Close();
            }
            catch (Exception) { }
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (titl_page.Text == "Members") 
            {
                addmmbr wdn_add_mmbr = new addmmbr();
                wdn_add_mmbr.ShowDialog();
                wdn_add_mmbr.Moh = 0;
            }
            else if(titl_page.Text== "Events")
            {
                addevent wnd_add_event = new addevent();
                wnd_add_event.ShowDialog();
                wnd_add_event.ayoub = 0;

            }
            else
            {
                add_department wnd_add_department = new add_department();
                wnd_add_department.ShowDialog();
                wnd_add_department.kdor= 0;
            }
        }
     

        private void gridmmbreditbtn_Click(object sender, RoutedEventArgs e)
        {

            
            if (titl_page.Text == "Members")
            {                       
                DataRowView ri = gridmmbr.SelectedItem as DataRowView;
                addmmbr wdn = new addmmbr();
                if (ri != null)
                {
                    wdn.add_mat.Text = ri[0].ToString();
                    wdn.add_name.Text = ri[1].ToString();
                    wdn.add_fel.Text = ri[2].ToString();
                    wdn.add_year.Text = ri[3].ToString();
                    wdn.add_dep.Text = ri[4].ToString();
                    wdn.Moh = 1;
                    wdn.ShowDialog();
                }





            }
            else if (titl_page.Text == "Events")
            {
                DataRowView ri = gridmmbr.SelectedItem as DataRowView;
                addevent wdn= new addevent();
                if (ri != null)
                {
                    wdn.add_Idevent.Text = ri[0].ToString();
                    wdn.add_nameevent.Text = ri[1].ToString();
                    wdn.add_depevent.Text = ri[2].ToString();
                    wdn.add_dateevent.Text = ri[3].ToString();
                    wdn.ayoub = 1;
                    wdn.ShowDialog();
                }

            }
            else
            {
                DataRowView ri = gridmmbr.SelectedItem as DataRowView;
                add_department wdn= new add_department();
                if (ri != null)
                {
                    wdn.add_namedepartment.Text = ri[1].ToString();
                    wdn.add_leadrdepartment.Text = ri[2].ToString();
                    wdn.kdor = 1;
                    wdn.ShowDialog();
                }

            }


        }

        private void gridmmbrsuppbtn_Click(object sender, RoutedEventArgs e)
        {
            
                DataRowView ri = gridmmbr.SelectedItem as DataRowView;
                int id = Convert.ToInt32(ri[0].ToString());
            
           
            switch (titl_page.Text)
            {
                case "Members":
                    string cn = Properties.Settings.Default.con;
                    SqlConnection conect = new SqlConnection(cn);
                    conect.Open();
                    string cm = "delete members where matricule='" + id + "'";
                    SqlCommand com = new SqlCommand(cm,conect);
                    com.ExecuteNonQuery();
                    conect.Close();
                    MessageBox.Show("delete succefuly");
                    break;
                case "Events":
                    string con = Properties.Settings.Default.con;
                    SqlConnection conecte = new SqlConnection(con);
                    conecte.Open();
                    string cme = "delete events where Id='" + id + "'";
                    SqlCommand coma = new SqlCommand(cme, conecte);
                    coma.ExecuteNonQuery();
                    conecte.Close();
                    MessageBox.Show("delete succefuly");
                    break;
                default:
                    string c = Properties.Settings.Default.con;
                    SqlConnection conec = new SqlConnection(c);
                    conec.Open();
                    string q = "delete departmrnt where Id='" + id + "'";
                    SqlCommand qe = new SqlCommand(q, conec);
                    qe.ExecuteNonQuery();
                    conec.Close();
                    MessageBox.Show("delete succefuly");
                    break;
              
            }

        }

        private bool ismaxmazed = false;
        private void max_btn_Click(object sender, RoutedEventArgs e)
        {
            if(ismaxmazed==false)
            {
                this.WindowState=WindowState.Maximized;
                ismaxmazed = true;

            }
            else
            {
                this.WindowState=WindowState.Normal;
                Width = 1080;
                Height = 720;
                ismaxmazed = false;


            }

        }

        private void refrech_btn_Click(object sender, RoutedEventArgs e)
        {
            switch (titl_page.Text)
            {
                
                case "Members":
                    string cn = Properties.Settings.Default.con;
                    SqlConnection conect = new SqlConnection(cn);


                    if (conect.State != ConnectionState.Open) { conect.Open(); }
                    string com = "SELECT * FROM members ";
                    try
                    {

                        DataTable tbdpr = new DataTable("members");
                        SqlDataAdapter adapter = new SqlDataAdapter(com, conect);
                        adapter.Fill(tbdpr);
                        gridmmbr.ItemsSource = tbdpr.DefaultView;

                        adapter.Update(tbdpr);
                        conect.Close();
                    }
                    catch (Exception) { }

                    break;
                case "Events":
                    string cna = Properties.Settings.Default.con;
                    SqlConnection conecta = new SqlConnection(cna);


                    if (conecta.State != ConnectionState.Open) { conecta.Open(); }
                    string coma = "SELECT * FROM events ";
                    try
                    {

                        DataTable tbdpr = new DataTable("events");
                        SqlDataAdapter adapter = new SqlDataAdapter(coma, conecta);
                        adapter.Fill(tbdpr);
                        gridmmbr.ItemsSource = tbdpr.DefaultView;

                        adapter.Update(tbdpr);
                        conecta.Close();
                    }
                    catch (Exception) { }

                    break;
                default:
                    string cne = Properties.Settings.Default.con;
                    SqlConnection conecte = new SqlConnection(cne);


                    if (conecte.State != ConnectionState.Open) { conecte.Open(); }
                    string come = "SELECT * FROM department ";
                    try
                    {

                        DataTable tbdpr = new DataTable("department");
                        SqlDataAdapter adapter = new SqlDataAdapter(come, conecte);
                        adapter.Fill(tbdpr);
                        gridmmbr.ItemsSource = tbdpr.DefaultView;

                        adapter.Update(tbdpr);
                        conecte.Close();
                    }
                    catch (Exception) { }
                    break;






            }

        }

        private void serch_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(serch.Text)==false)
            {
                switch(titl_page.Text)               
                {
                    case "Members":
                        string cn = Properties.Settings.Default.con;
                        SqlConnection conect = new SqlConnection(cn);


                        if (conect.State != ConnectionState.Open) { conect.Open(); }
                        string com = "SELECT * FROM members where name='"+serch.Text+"'";

                        DataTable tbmmbr = new DataTable("members");
                        SqlDataAdapter adapter = new SqlDataAdapter(com, conect);
                        adapter.Fill(tbmmbr);
                        gridmmbr.ItemsSource = tbmmbr.DefaultView;

                        adapter.Update(tbmmbr);
                        conect.Close();
                        break;

                    case "Events":
                        string cne = Properties.Settings.Default.con;
                        SqlConnection conecte = new SqlConnection(cne);


                        if (conecte.State != ConnectionState.Open) { conecte.Open(); }
                        string come = "SELECT * FROM events where name='" + serch.Text + "'";

                        DataTable tbmmbre = new DataTable("events");
                        SqlDataAdapter adaptere = new SqlDataAdapter(come, conecte);
                        adaptere.Fill(tbmmbre);
                        gridmmbr.ItemsSource = tbmmbre.DefaultView;

                        adaptere.Update(tbmmbre);
                        conecte.Close();
                        break;
                    default:
                        string cna = Properties.Settings.Default.con;
                        SqlConnection conecta = new SqlConnection(cna);


                        if (conecta.State != ConnectionState.Open) { conecta.Open(); }
                        string coma = "SELECT * FROM department where name='" + serch.Text + "'";

                        DataTable tbmmbra = new DataTable("department");
                        SqlDataAdapter adaptera = new SqlDataAdapter(coma, conecta);
                        adaptera.Fill(tbmmbra);
                        gridmmbr.ItemsSource = tbmmbra.DefaultView;

                        adaptera.Update(tbmmbra);
                        conecta.Close();
                        break;
                }
            }
        }

        private void info_btn_Click(object sender, RoutedEventArgs e)
        {
            info ww=new info();
            ww.ShowDialog();
        }
    }

  }

