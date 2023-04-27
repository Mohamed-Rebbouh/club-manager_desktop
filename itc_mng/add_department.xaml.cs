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
    /// Logique d'interaction pour add_department.xaml
    /// </summary>
    public partial class add_department : Window
    {
        public int kdor;
        public add_department()
        {
            InitializeComponent();
        }

        private void add_closebtndepartment_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void save_btnevent_Click(object sender, RoutedEventArgs e)
        {
            department drp = new department()
            {
                
                name = add_namedepartment.Text,
                leader = add_leadrdepartment.Text,
                num_mmbr = 1

            };
            string cn = Properties.Settings.Default.con;
            SqlConnection conect = new SqlConnection(cn);

            if (kdor == 0)
            {
                try
                {
                    conect.Open();
                    string cmd = "insert into department (name,leader,num_mmbr) values('" + drp.name + "','" + drp.leader + "','" + drp.num_mmbr + "')";
                    SqlCommand cm = new SqlCommand(cmd, conect);
                    cm.ExecuteNonQuery();
                    conect.Close();
                    this.Close();
                    MessageBox.Show("add succefuly");
                }catch(Exception ex) { MessageBox.Show(ex.Message); }   

            }
            else if(kdor==1)
            {
                try
                {
                    conect.Open();
                    string cmd = "update department set name='" + drp.name + "',leader='" + drp.leader + "',num_mmbr='" + drp.num_mmbr + "'where name='" + drp.name + "'";
                    SqlCommand cm = new SqlCommand(cmd, conect);
                    cm.ExecuteNonQuery();
                    conect.Close();
                    this.Close();
                    MessageBox.Show("edit succefuly");

                }catch(Exception ex) { MessageBox.Show(ex.Message); }


            }









        }
    }
}
