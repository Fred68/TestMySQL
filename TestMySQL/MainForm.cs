using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMySQL
{
	public partial class MainForm:Form
	{

	public enum Tables
		{
			citta,
			utenti
		}

		MySQLconn conn;
		Tables table;
		List<QueryViewForm> lstQVF;

		MySQLconn Connection { get { return conn; } }
		

		public MainForm()
		{
			InitializeComponent();

		}
		private void Form1_Load(object sender,EventArgs e)
		{
			conn = new MySQLconn(new ConnectionString("localhost","3306","pippo","pippo123","prova"));
			lstQVF = new List<QueryViewForm>();
			
			table = Tables.utenti;
			UpdateContent();
		}
		private void Form1_FormClosing(object sender,FormClosingEventArgs e)
		{
			conn.Disconnect();
			UpdateContent();
		}

		public void UpdateContent()
		{
			tsslTable.Text = table.ToString();
			tsslStat.Text = conn.Status.ToString();
			tsslForms.Text = lstQVF.Count.ToString();
		}

		public bool RemoveQvfFromList(QueryViewForm f)
		{
			return lstQVF.Remove(f);
		}

		private void btConnect_Click(object sender,EventArgs e)
		{
			conn.Connect();
			UpdateContent();
		}
		private void btDisconnect_Click(object sender,EventArgs e)
		{
			conn.Disconnect();
			UpdateContent();
		}
		private void btStat_Click(object sender,EventArgs e)
		{
			MessageBox.Show(conn.GetStatus(true, false) + System.Environment.NewLine + $"Table:{table}");
			//MessageBox.Show(conn.Status.ToString());
		}


		private void btTab1_Click(object sender,EventArgs e)
		{
			table = Tables.citta;
			UpdateContent();
		}
		private void btTab2_Click(object sender,EventArgs e)
		{
			table = Tables.utenti;
			UpdateContent();
		}


		private void btSqlInsert_Click(object sender,EventArgs e)
		{
			string sql = string.Empty;
			switch(table)
			{
				case Tables.citta:
				{
					sql = $"INSERT INTO {table.ToString()} (nome, CAP) VALUES ('Trieste','34100')";
				}
				break;
				case Tables.utenti:
				{
					sql = $"INSERT INTO {table.ToString()} (nome, cognome) VALUES ('Qui','De Paperis')";	

				}
				break;
			}
			if(sql.Length > 1)
			{
				string s = conn.ExecuteSQLCommand(sql, SQLqueryType.NoQuery);
				MessageBox.Show(s);
			}
			UpdateContent();
		}
		private void btSqlDelete_Click(object sender,EventArgs e)
		{
			string sql = string.Empty;
			switch(table)
			{
				case Tables.citta:
				{
					sql = $"DELETE FROM {table.ToString()} WHERE nome='Trieste'";
				}
				break;
				case Tables.utenti:
				{
					sql = $"DELETE FROM {table.ToString()} WHERE nome='Qui'";	

				}
				break;
			}
			if(sql.Length > 1)
			{
				string s = conn.ExecuteSQLCommand(sql, SQLqueryType.NoQuery);
				MessageBox.Show(s);
			}
			UpdateContent();
		}
		private void btSqlCount_Click(object sender,EventArgs e)
		{
			string sql = $"SELECT COUNT(*) FROM {table.ToString()}";
			string s = conn.ExecuteSQLCommand(sql, SQLqueryType.Scalar);
			MessageBox.Show(s);
			UpdateContent();
		}
		private void btSqlQuery_Click(object sender,EventArgs e)
		{
			string sql = string.Empty;
			switch(table)
			{
				case Tables.citta:
				{
					sql = $"SELECT * FROM {table.ToString()}";
				}
				break;
				case Tables.utenti:
				{
					sql = $"SELECT * FROM {table.ToString()}";

				}
				break;
			}
			if(sql.Length > 1)
			{
				string s = conn.ExecuteSQLCommand(sql, SQLqueryType.Reader);
				MessageBox.Show(s);
			}
			UpdateContent();	
		}


		private void btOpenQ_Click(object sender,EventArgs e)
		{
			conn.Disconnect();
			QueryViewForm qvf = new QueryViewForm(this, table.ToString());
			lstQVF.Add(qvf);
			qvf.Show();
			UpdateContent();
		}
	}
}
