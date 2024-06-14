using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace TestMySQL
{
	public partial class QueryViewForm:Form
	{

		MainForm mf;
		MySqlConnection myConn;
		string sql = "";
		MySqlDataAdapter da;
		MySqlCommandBuilder cb;
		DataSet ds;


		public QueryViewForm(MainForm mf, string table)
		{
			InitializeComponent();
			this.mf = mf;
			myConn = null;
			sql = $"SELECT * FROM {table}";
		}
		private void QueryViewForm_Load(object sender,EventArgs e)
		{
			try
			{
				myConn = new MySqlConnection(new ConnectionString("localhost","3306","pippo","pippo123","prova").ToString());
				da = new MySqlDataAdapter(sql,myConn);
				cb = new MySqlCommandBuilder(da);
				ds = new DataSet();
				da.Fill(ds,"AAA");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "AAA";
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error: {ex.ToString()}");
			}
		}
		
		private void QueryViewForm_FormClosing(object sender,FormClosingEventArgs e)
		{
			if(MessageBox.Show("Close ?","Closing",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
			{
			e.Cancel = true;
			}
		}
		private void QueryViewForm_FormClosed(object sender,FormClosedEventArgs e)
		{
			mf.RemoveQvfFromList(this);
			mf.UpdateContent();
		}

		

		private void btClose_Click(object sender,EventArgs e)
		{
			Close();
		}
		private void btUpdate_Click(object sender,EventArgs e)
		{
			da.Update(ds, "AAA");
			dataGridView1.Update();
		}
	}
}
