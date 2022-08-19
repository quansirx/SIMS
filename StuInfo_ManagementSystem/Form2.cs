using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfo_ManagementSystem
{
    public partial class Form2 : Form
    {
        MySqlConnection sqlConn; //连接数据库对象
        MySqlDataAdapter mda; //适配器变量
        DataSet ds;  //临时数据集

        public static MySqlConnection GetSqlConnection(String SqlConnCMD)
        {
            MySqlConnection c = null;
            c=new MySqlConnection(SqlConnCMD);
            try
            {
                //c.Open();
                //MessageBox.Show("数据库连接成功");
                //c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            return c;
        }
        public static MySqlDataAdapter GetSqlQueryMDA(String sqlQueryCMD,MySqlConnection c)
        {
            MySqlDataAdapter MDA = null;
            MDA=new MySqlDataAdapter(sqlQueryCMD, c);
            return MDA;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn = new MySqlConnection("server=localhost;user id=root;password=123456;database=qjm01");
            sqlConn.Open();
            if (sqlConn!=null){
                mda=GetSqlQueryMDA("select * from qjm_table",sqlConn);
                if (mda != null)
                {          
                    try
                    {
                        ds = new DataSet();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);    
                    }
                    mda.Fill(ds, "qjm_table");
                    dataGridView1.DataSource = ds.Tables["qjm_table"];
                    sqlConn.Close();
                }
            }
            else
            {
                MessageBox.Show("数据库连接失败!");
            }
        }

        private void 菜单1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 菜单11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 菜单22ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
