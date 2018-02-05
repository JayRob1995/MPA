using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace ProjectDataLayer
{
    public class DataConnector
    {
        protected OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter();

        public DataConnector(string Filename)
        {
	        string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='"+Filename+"'; Persist Security Info=false;";
            OleDbConnection Connection1 = new OleDbConnection(ConnectionString);
            this.DataAdapter1.SelectCommand = new OleDbCommand("", Connection1);
            this.DataAdapter1.InsertCommand = new OleDbCommand("", Connection1);
            this.DataAdapter1.UpdateCommand = new OleDbCommand("", Connection1);
            this.DataAdapter1.DeleteCommand = new OleDbCommand("", Connection1);
        }
	
        public DataTable DataSelect(string Query)
        {
            DataTable dt = new DataTable();
            TraceListener X = new TextWriterTraceListener("debug.log");
            Debug.Listeners.Add(X);
            try
            {
                DataAdapter1.SelectCommand.CommandText = Query;
                DataAdapter1.SelectCommand.Connection.Open();
                DataAdapter1.Fill(dt);
                DataAdapter1.SelectCommand.Connection.Close();
            }
            catch(Exception err)
            {
                DataAdapter1.SelectCommand.Connection.Close();
                Debug.WriteLine(System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")+
                    ": Error in DataConnector DataSelect Query: " + Query + " - Error Message was: "+err.Message);
            }
            Debug.Close();
            return dt;
        }
        
        public int DataInsert(string Query)
        {
            TraceListener X = new TextWriterTraceListener("debug.log");
            Debug.Listeners.Add(X);
            try
            {
                DataAdapter1.InsertCommand.CommandText = Query;
                DataAdapter1.InsertCommand.Connection.Open();
                int Result = DataAdapter1.InsertCommand.ExecuteNonQuery();
                DataAdapter1.InsertCommand.Connection.Close();
                Debug.Close();
                return Result;
            }
            catch
            {
                DataAdapter1.InsertCommand.Connection.Close();
                Debug.WriteLine("Error in DataConnector DataInsert Query: <b>" + Query + "</b><br />");
                Debug.Close();
                return 0;
            }
        }

        public void DataDelete(string Query)
        {
            TraceListener X = new TextWriterTraceListener("debug.log");
            Debug.Listeners.Add(X);
            try
            {
                DataAdapter1.DeleteCommand.CommandText = Query;
                DataAdapter1.DeleteCommand.Connection.Open();
                DataAdapter1.DeleteCommand.ExecuteNonQuery();
                DataAdapter1.DeleteCommand.Connection.Close();
            }
            catch
            {
                DataAdapter1.DeleteCommand.Connection.Close();
                Debug.WriteLine("Error in DataConnector DataDelete Query: <b>" + Query + "</b><br />");
            }
            Debug.Close();
        }

        public void DataUpdate(string Query)
        {
            TraceListener X = new TextWriterTraceListener("debug.log");
            Debug.Listeners.Add(X);
            try
            {
                DataAdapter1.UpdateCommand.CommandText = Query;
                DataAdapter1.UpdateCommand.Connection.Open();
                DataAdapter1.UpdateCommand.ExecuteNonQuery();
                DataAdapter1.UpdateCommand.Connection.Close();
            }
            catch
            {
                DataAdapter1.UpdateCommand.Connection.Close();
                Debug.WriteLine("Error in DataConnector DataUpdate Query: <b>" + Query + "</b><br />");
            }
            Debug.Close();
        }
        
    }
}
