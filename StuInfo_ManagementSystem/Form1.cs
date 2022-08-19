using MySql.Data.MySqlClient;

namespace StuInfo_ManagementSystem
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn; //连接数据库对象
        MySqlCommand msc;
        public static MySqlConnection GetSqlConnection(String SqlConnCMD)
        {
            //
            MySqlConnection c = null;
            c = new MySqlConnection(SqlConnCMD);
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
        public static MySqlDataAdapter GetSqlQueryMDA(String sqlQueryCMD, MySqlConnection c)
        {
            MySqlDataAdapter MDA = null;
            MDA = new MySqlDataAdapter(sqlQueryCMD, c);
            return MDA;
        }
        public static MySqlCommand GetSqlQueryResult(String sqlQueryCMD, MySqlConnection c)
        {
            MySqlCommand cmdResult = new MySqlCommand(sqlQueryCMD, c);
            return cmdResult;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String str1,str2;
            str1 = textBox1.Text;
            str2 = textBox2.Text;
            sqlConn = GetSqlConnection("server=localhost;user id=root;password=123456;database=qjm01");
            sqlConn.Open();
            if(sqlConn != null)
            {
                msc = GetSqlQueryResult("select * from admin_table where admin_id="+str1+" and "+"admin_pwd="+str2,sqlConn);
                //sqlConn.Close();
                if(msc != null)
                {
                    MySqlDataReader reader = msc.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("账户或密码错误！");
                    }
                }
            }

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}