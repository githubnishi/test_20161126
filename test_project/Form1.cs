using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this, DateTime.Now.AddHours(10).ToString());

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(textBox1.text);


            database.database.Instance.ExecuteSqlNonQuery("CREATE TABLE IF NOT EXISTS TEST(TITLE TEXT)");

            var sql = new StringBuilder();
            DataTable load = database.database.Instance.ExecuteSql("SELECT * FROM TEST");

            if (load.Rows.Count != 0)
            {
                sql.AppendFormat("UPDATE TEST SET TITLE = '{0}'", textBox1.Text);
            }else
            {
                sql.AppendFormat("INSERT INTO TEST VALUES('{0}')", textBox1.Text);
            }
            
            database.database.Instance.ExecuteSqlNonQuery(sql.ToString());

            //database.database.Instance.ExecuteSqlNonQuery("UPDATE TESTtbl SET TEST = " + textBox1.Text + "WHERE TEST = 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable x = database.database.Instance.ExecuteSql("SELECT * FROM TEST");

            textBox1.Text = x.Rows[0].ItemArray[0].ToString();
        }
    }
} 
