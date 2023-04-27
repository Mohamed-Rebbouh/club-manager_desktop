using itc_mng.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace itc_mng
{
    /// <summary>
    /// Logique d'interaction pour addevent.xaml
    /// </summary>
    public partial class addevent : Window
    {
        public int ayoub;
        public addevent()
        {
            InitializeComponent();
        }

        private void add_closebtnevent_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void save_btnevent_Click(object sender, RoutedEventArgs e)
        {
            string cn = Properties.Settings.Default.con;
            SqlConnection conect = new SqlConnection(cn);
            even ev = new even()
            {
                ID = Convert.ToInt32(add_Idevent.Text),
                name=add_nameevent.Text,
                date=add_dateevent.Text,
                team=add_depevent.Text
            };

            if(ayoub == 0 )
            {
                try
                {
                    conect.Open();
                    string cm = "insert into events (id,name,department,date) values('"+ev.ID+"','" + ev.name + "','" + ev.team + "','" + ev.date + "')";
                    SqlCommand com = new SqlCommand(cm,conect);
                    com.ExecuteNonQuery();
                    conect.Close();
                    this.Close();
                    MessageBox.Show("add succefuly");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if(ayoub == 1)
            {
                try
                {
                    conect.Open();
                    string cmm = "update events set id='" + ev.ID + "',name='" + ev.name + "',department='" + ev.team + "',date='" + ev.date+ "'where id='"+ev.ID+"'";
                    SqlCommand ce=new SqlCommand(cmm,conect);
                    ce.ExecuteNonQuery();
                    conect.Close();
                    this.Close();
                    MessageBox.Show("edit succefuly");
                }catch(Exception ex) { MessageBox.Show(ex.Message); }




            }



        }
    }
}
