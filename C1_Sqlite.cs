using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Platinum_ERP
{
    class C1_Sqlite
    {
        public void SqliteShow(String ConnString_Addres, String Inquiry_String, DataGrid DGV_Name)
        {
            using(SQLiteConnection SQLConnection = new SQLiteConnection("Data Source=Data_Files/" + ConnString_Addres))
            {
                SQLConnection.Open();
                SQLiteDataAdapter SQLData = new SQLiteDataAdapter(Inquiry_String, SQLConnection);
                DataTable SQLDTable = new DataTable();
                SQLData.Fill(SQLDTable);
                DGV_Name.ItemsSource = SQLDTable.DefaultView;
                SQLConnection.Close();
            }
            
            
        }

        public void SqliteWrite(String ConnString_Addres_Write,String Write_Table, String Write_Data, String Write_Place, DataGrid DGV_Name_Refresh = null, String Inquiry_String_Show = null, String Connection_Addres_Show = null)
        {
            using SQLiteConnection SQLConnection = new SQLiteConnection("Data Source=Data_Files/" + ConnString_Addres_Write);
            SQLConnection.Open();
            SQLiteCommand SqLiteCommand_Var = new SQLiteCommand();
            SqLiteCommand_Var = SQLConnection.CreateCommand();
            SqLiteCommand_Var.CommandText = "INSERT INTO " + Write_Table + " (" + Write_Place + ") VALUES (" + Write_Data + ")";
            SqLiteCommand_Var.ExecuteNonQuery();
            if(DGV_Name_Refresh != null)
            {
                C1_Sqlite c1_Sqlite = new C1_Sqlite();
                c1_Sqlite.SqliteShow(Connection_Addres_Show, Inquiry_String_Show, DGV_Name_Refresh);
            }            
            SQLConnection.Close();

        }


    }
}
