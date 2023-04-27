
using itc_mng.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Logique d'interaction pour addmmbr.xaml
    /// </summary>
    public partial class addmmbr : Window
    {

        public int Moh;
        public addmmbr()
        {
            InitializeComponent();
            
        }

        private void add_closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mmbr mm = new mmbr
            {
                matricul = Convert.ToInt32(add_mat.Text),
                name = add_name.Text,
                feliar = add_fel.Text,
                year = add_year.Text,
                team = add_dep.Text
            };
            if (Moh == 0)
            {

                try
                {

                    string cn = Properties.Settings.Default.con;
                    SqlConnection conect = new SqlConnection(cn);


                    if (conect.State != ConnectionState.Open) { conect.Open(); }
                    string com = "insert into members (matricule,name,feliare,year,department) values('" + mm.matricul + "','" + mm.name + "','" + mm.feliar + "','" + mm.year + "','" + mm.team + "')";
                    SqlCommand cmd = new SqlCommand(com, conect);
                    cmd.ExecuteNonQuery();
                    conect.Close();
                    this.Close();
                    MessageBox.Show("add succefuly");



                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            else if(Moh == 1) 
            {
              
                try
                {
                    string cn = Properties.Settings.Default.con;
                    SqlConnection conect = new SqlConnection(cn);
                    conect.Open();
                    string com = "update members set matricule ='" + mm.matricul + "',name ='" + mm.name + "',feliare ='" + mm.feliar + "',year ='" + mm.year + "',department ='" + mm.team + "' where matricule ='" + mm.matricul + "'";
                    SqlCommand cm = new SqlCommand(com, conect);
                    cm.ExecuteNonQuery();
                    this.Close();
                    MessageBox.Show("edit succefly");
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }

               Moh= 0;
            }




        }
    }
}
