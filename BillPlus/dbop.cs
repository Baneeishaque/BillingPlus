using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

public class dbop
{

    public MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    public string connectionString;


    public dbop()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "billingplusdb";
        uid = "root";
        password = "root";

        connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }


    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {

            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }


    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    //Insert statement
    public void insert(MySqlCommand cmd)
    {
        //open connection
        if (this.OpenConnection() == true)
        {
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }


    public int maxid(MySqlCommand cmd)
    {

        cmd.Connection = connection;
        //  cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        int id;
        try
        {
            id = int.Parse(cmd.ExecuteNonQuery().ToString()) + 1;
        }
        catch
        {
            id = 1;

        }
        finally
        {
            con.Close();
        }
        return id;
    }

    SqlConnection con = new SqlConnection(@"");
    public void insert(SqlCommand cmd)
    {
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public int maxid(SqlCommand cmd)
    {
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        int id;
        try
        {
            id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
        }
        catch
        {
            id = 1;

        }
        finally
        {
            con.Close();
        }
        return id;
    }
    public DataTable select(MySqlCommand cmd)
    {
        cmd.Connection = connection;
        // cmd.CommandType = CommandType.StoredProcedure;
        MySqlDataAdapter sq = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        sq.SelectCommand = cmd;
        sq.Fill(dt);
        return dt;
    }

    public DataTable select(SqlCommand cmd)
    {
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter sq = new SqlDataAdapter();
        DataTable dt = new DataTable();
        sq.SelectCommand = cmd;
        sq.Fill(dt);
        return dt;
    }

}