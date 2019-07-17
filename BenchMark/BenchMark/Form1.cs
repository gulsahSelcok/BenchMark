using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenchMark
{
    public partial class FormBenchWork : Form
    {
        public FormBenchWork()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=.;Database=Northwind;UID=Section1;PWD=123456"); // GLOBAL OLARAK TANIMLADIK. DİĞER CLASSLARDA DA GÖRÜNSÜN DİYE
        NorthwindEntities db = new NorthwindEntities();
        Stopwatch watch = new Stopwatch();
        private void btnConnected_Click(object sender, EventArgs e)
        {
            watch.Start();
            // DateTime baslangic = DateTime.Now;
            conn.Open();
            string SqlStmt = "SELECT OrderID FROM Orders";
            SqlCommand cmd = new SqlCommand(SqlStmt,conn);
            SqlDataReader dr = cmd.ExecuteReader(); //Gei dönüş seti SqlDataReader tipinde bir alana atılır.
            if (dr.HasRows)//İçi dolu mu diye control ediyoruz.
            {
                while (dr.Read())
                {
                    lbConnected.Items.Add(dr["OrderID"]);
                    //lbConnected.Items.Add(dr.GetInt32(0)); //Dönüş değeri tipinde tanımlamada yapılabilir
                }
            }
            
            conn.Close();
            watch.Stop();
            lblConnected.Text = watch.Elapsed.Milliseconds.ToString();
           // DateTime bitis = DateTime.Now;
           // TimeSpan timeSpan = bitis-baslangic;   
            watch.Reset();
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            watch.Start();
            string SqlStmt = "SELECT OrderID FROM Orders";
            SqlDataAdapter da = new SqlDataAdapter(SqlStmt,conn); //burada alınan vveriler ya datatable ya da datasete atmamız gerekiyor.
            DataSet ds = new DataSet();
            da.Fill(ds,"Order");
            ////DATA TABLE KULLANIMI
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //lbDisconnected.DataSource = dt;
            //lbDisconnected.DisplayMember = "OrderID"; //GÖSTERMEK İSTEDİĞİMİZ ALANI DİSPLAY MEMBERA ATIYORUZ.
        
            foreach (DataRow item in ds.Tables["Order"].Rows)
            {
                lbDisconnected.Items.Add(item[0].ToString());
            }
            watch.Stop();
            lblDisconnected.Text = watch.Elapsed.Milliseconds.ToString();
            watch.Reset();
        }

        private void btnEntityFramework_Click(object sender, EventArgs e)
        {
            watch.Start();
            var order = db.Orders.Select(x=>x.OrderID).ToList();
            foreach (var item in order)
            {
                lbEntityFramework.Items.Add(item);
            }
            watch.Stop();
            lblEntity.Text = watch.Elapsed.Milliseconds.ToString();
            watch.Reset();
        }

        //Disconnected bir kez verileri alıp sonraki çalışmaları için RAMe kaydeder. Bu yüzden ilk çalışmasından sonra hep daha hızlı çalışır Connected bağlanıya göre RAM üstünde çalıştığı için.
        //Entity de connectede göre daha hızlı çalışır. Program içinde çalıştığından daha hızlı çalışır.
    }
}
