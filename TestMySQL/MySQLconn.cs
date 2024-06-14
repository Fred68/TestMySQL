using System;
using System.Collections.Generic;
using System.Data;					// Per DataTable
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;		// Per MySqlConnection

//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace TestMySQL
{

	public class ConnectionString
	{
		public string srv;
		public string prt;
		public string usr;
		public string pwd;
		public string db;

		public ConnectionString(string server, string port, string user, string password, string database)
		{
			srv = server;
			prt = port;
			usr = user;
			pwd = password;
			db = database;
		}

		override public string ToString()
		{
			return $"server={srv};port={prt};uid={usr};pwd={pwd};database={db}";
		}
	}

	public enum SQLqueryType
	{
		Reader,
		NoQuery,
		Scalar
	}

	internal class MySQLconn
	{
		MySqlConnection conn;
		ConnectionString cstr;
		DataTable dtConn;

		public MySqlConnection Connection { get {return conn;} }

		public MySQLconn(ConnectionString cs)
		{
			cstr = cs;
			conn = null;
		}
		
		public void Connect()
		{
			try
			{
				if(conn == null)
				{
					conn = new MySqlConnection(cstr.ToString());
					conn.Open();
					MessageBox.Show(GetStatus(true,false));

					dtConn = conn.GetSchema();
				}
				else
				{
					MessageBox.Show($"Already connected: {conn.State.ToString()}");
				}
			}
			catch(MySql.Data.MySqlClient.MySqlException ex)
			{
				MessageBox.Show($"{ex.Number}:{ex.Message}" + $"\nConnection string: {cstr.ToString()}");
				Disconnect();

			}
		}

		public ConnectionState Status
		{
			get
			{
			ConnectionState cst;
			if(conn != null)
				cst = conn.State;
			else
				cst = ConnectionState.Broken;
			return cst;
			}
		}
		public string GetStatus(bool bShowConnString = false, bool bShowExtraInfo = false)
		{
			StringBuilder sb = new StringBuilder();
			if(bShowConnString)
			{
				sb.AppendLine($"Connection string: {cstr.ToString()}");
			}
			if( conn != null )
			{
				sb.AppendLine($"Connection: {conn.State.ToString()}");
				if(bShowExtraInfo)
				{
					sb.Append(DisplayDataTable(dtConn));
				}
			}
			else
			{
				sb.AppendLine($"Non connected");
			}
			
			return sb.ToString();
		}

		public void Disconnect()
		{
			if(conn != null)
			{
				conn.Close();
				conn = null;
				MessageBox.Show($"Disconnected");
			}
		}

		public string DisplayDataTable(DataTable dt)
		{
			StringBuilder sb = new StringBuilder();
			foreach(DataRow dr in dt.Rows)
			{
				foreach(DataColumn dc in dt.Columns)
				{
					sb.Append($"{dc.ColumnName}={dr[dc]}\t");
				}
				sb.AppendLine("-----");
			}
			return sb.ToString();
		}

		public string ExecuteSQLCommand(string sql, SQLqueryType type)
		{
			StringBuilder sb = new StringBuilder();
			MySqlDataReader rdr = null;
			if(conn != null)
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(sql, conn);
					switch(type)
					{
						case SQLqueryType.NoQuery:
						{
							int lines = cmd.ExecuteNonQuery();
							sb.AppendLine($"NonQuery():{lines} linee.");
						}
						break;
						case SQLqueryType.Scalar:
						{
							string s = string.Empty;
							object obj = cmd.ExecuteScalar();
							if(obj != null)
							{
								s = Convert.ToString(obj);
							}
							
							sb.AppendLine($"Scalar():{s}.");
						}
						break;
						case SQLqueryType.Reader:
						{
							sb.AppendLine($"Reader():");
							rdr = cmd.ExecuteReader();
							while(rdr.Read())
							{
								for(int i=0; i<rdr.FieldCount; i++)
								{
									sb.Append(rdr[i].ToString());
									if(i != rdr.FieldCount-1)	sb.Append(", ");
									
								}
								sb.Append(System.Environment.NewLine);
							}
							rdr.Close();
							rdr = null;
						}
						break;
					}
				}
				catch(Exception ex)
				{
					if(rdr != null)
					{
						rdr.Close();
						rdr = null;
					}
					sb.AppendLine(ex.ToString());
				}

			}

			return sb.ToString();
		}


	}
}
