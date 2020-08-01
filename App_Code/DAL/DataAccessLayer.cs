using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for DataLogicLayer
/// </summary>
public class DataAccessLayer
{

    Getconnection con = new Getconnection();
    SqlConnection c;
    SqlCommand cmd;
    //industry type start
    public string SaveMyTablebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertindustryname1", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IndustryName", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getallIndustrygroupfroadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("indutrynamedisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable checkdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkindustryname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@IndustryName", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getIndustrygroupdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showindustryname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deletedata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteindustryname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string tbl_update(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updateindustryname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@IndustryName", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checklogindata(string uname, string password)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checklogindetails", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = uname;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    // Industry type end

    //Businesstype start
    public string Savebusinesstypebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertbusinesstype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BusinessType", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallbusinesstypeDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("businesstypedisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkbusinesstypedata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkbusinesstypename", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@BusinessTypeName", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getBusinesstypedatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showbusinesstype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deletebusinesstypedata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletebusinesstype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_businesstypeupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatebusinesstype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@BusinessTypeName", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //Businesstype End

    // Role Start 

    public string Saverolebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertrole", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Role", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallroleDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("roledisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkroledata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkrole", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Role", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getroledatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showrole", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deleteroledata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleterole", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_roleupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updaterole", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Role", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    // Role End

    //Source Start

    public string Savesourcebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertsource", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallsourceDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("sourcedisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checksourcedata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checksource", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getsourcedatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showsource", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deletesourcedata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletesource", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_sourceupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatesource", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //Source End

    //Status Start

    public string Savestatusbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertstatus", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallstatusDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("statusdisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkstatusdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkstatus", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getstatusdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showstatus", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deletestatusdata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletestatus", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_statusupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatestatus", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //Status End

    //Department Start

    public string Savedepartmentbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertdepartment", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Department", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getalldepartmentDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("depaartmentdisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkdepartmentdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkdepartment", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Department", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getdepartmentdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showdepartment", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deletedepartmentdata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletedepartment", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_departmentupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatedepartment", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Department", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //Department end

    //Designation Start

    public string Savedesignationbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertdesignation", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Designation", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getalldesignationDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("designationdisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkdesignationdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkdesignation", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Designation", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getdesignationdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showdesignation", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deletedesignationdata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletedesignation", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_designationupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatedesignation", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Designation", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //Designation END

    // Unit of measurement start

    public string Saveunitofmeasurementbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertunitofmeasurement", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UnitofMeasurement", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallunitofmeasurementDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("unitofmeasurementdisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkunitofmeasurementdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkunitofmeasurement", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@UnitofMeasurement", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getunitofmeasurementdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showunitofmeasurement", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deleteunitofmeasurementdata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteunitofmeasurement", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_unitofmeasurementupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updateunitofmeasurement", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@UnitofMeasurement", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //Unit of Measurement End
       //FollowUpType start

    public string Savefollowuptypebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertfollowuptype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FollowUpType", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallfollowuptypeDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("followuptypedisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkfollowuptypedata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkfollowuptype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@FollowUpType", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getfollowuptypedatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showfollowuptable", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deletefollowuptypedata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletefollowuptype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_followuptypeupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatefollowuptype", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@FollowUpType", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    //FollowUpType End

    //ItemGroup start

    public string Saveitemgroupbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertitemgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ItemGroup", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public DataTable getallitemgroupDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("itemgroupdisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable checkitemgroupdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkitemgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@ItemGroup", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public DataTable getitemgroupdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showitemgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string deleteitemgroupdata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteitemgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_itemgroupupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updateitemgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@ItemGroup", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done


    //ItemGroup Done

    //ItemSubgroup Start

    public DataTable getallItemsubgroup(int id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallItemsubgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getallItemsubgroupforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallItemsubgroupforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable checkItemsubgroupnameDAL(string GroupName)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkItemsubgroupname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@GroupName", SqlDbType.VarChar).Value = GroupName;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Itemsubgroup_Master_InsertDAL(string ItemSubGroupName, int ItemGroupId, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertitemsubgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubGroupName", SqlDbType.VarChar).Value = ItemSubGroupName;
            cmd.Parameters.Add("@ItemGroupId", SqlDbType.Int).Value = ItemGroupId;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public DataTable getItemsubgroupdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getItemsubgroupdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteItemsubgroupdatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteItemsubgroupdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string tbl_Itemsubgroup_Master_UpdateDAL(string Id, int ItemGroupId, string ItemSubGroupName)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updateitemsubgroup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@ItemGroupid", SqlDbType.Int).Value = ItemGroupId;
            cmd.Parameters.Add("@SubGroupName", SqlDbType.VarChar).Value = ItemSubGroupName;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    // Item master start
    public string tbl_ItemDocument_Master_InsertDAL(string no, string DocuName, string Filename, string DocumentPath, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_ItemDocument_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = no;
            cmd.Parameters.Add("@DocuName", SqlDbType.VarChar).Value = DocuName;
            cmd.Parameters.Add("@Filename", SqlDbType.VarChar).Value = Filename;
            cmd.Parameters.Add("@DocumentPath", SqlDbType.VarChar).Value = DocumentPath;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getItemdocumentadataDAL(string Createby, int no)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getitemdocumentdata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            cmd.Parameters.Add("@no", SqlDbType.BigInt).Value = no;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deletitemimgdatabyidDAL(string id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteitemimgdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string tbl_ItemImage_Master_InsertDAL(string no, string DocuName, string Filename, string DocumentPath, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_ItemImage_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = no;
            cmd.Parameters.Add("@DocuName", SqlDbType.VarChar).Value = DocuName;
            cmd.Parameters.Add("@Filename", SqlDbType.VarChar).Value = Filename;
            cmd.Parameters.Add("@DocumentPath", SqlDbType.VarChar).Value = DocumentPath;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public DataTable getItemimageadataDAL(string Createby, int no)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getitemimagedata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
          
            cmd.Parameters.Add("@no", SqlDbType.BigInt).Value = no;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deletitemdocumentdatabyidDAL(string id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteitemdocumentdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checkItemnameDAL(string Itemname)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkItemname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Itemname", SqlDbType.VarChar).Value = Itemname;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Item_Master_InsertDAL(int no, int itemgroup, int itemsubgroup, string Modelno, string Itemname, string ItemFinalname, string Itemalis, string Itemcategoryno, int ItemUOM, decimal Itemrate, int Itemgst, string ItemHsn, string ItemDesc, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Item_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@no", SqlDbType.Int).Value = no;
            cmd.Parameters.Add("@itemgroup", SqlDbType.Int).Value = itemgroup;
            cmd.Parameters.Add("@itemsubgroup", SqlDbType.Int).Value = itemsubgroup;
            cmd.Parameters.Add("@Modelno", SqlDbType.VarChar).Value = Modelno;
            cmd.Parameters.Add("@Itemname", SqlDbType.VarChar).Value = Itemname;
            cmd.Parameters.Add("ItemFinalname", SqlDbType.VarChar).Value = ItemFinalname;
            cmd.Parameters.Add("@Itemalis", SqlDbType.VarChar).Value = Itemalis;
            cmd.Parameters.Add("@Itemcategoryno", SqlDbType.VarChar).Value = Itemcategoryno;
            cmd.Parameters.Add("@ItemUOM", SqlDbType.Int).Value = ItemUOM;
            cmd.Parameters.Add("@Itemrate", SqlDbType.Decimal).Value = Itemrate;
            cmd.Parameters.Add("@Itemgst", SqlDbType.Int).Value = Itemgst;
            cmd.Parameters.Add("@ItemHsn", SqlDbType.VarChar).Value = ItemHsn;
            cmd.Parameters.Add("@ItemDesc", SqlDbType.VarChar).Value = @ItemDesc;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
 
    public DataTable getallItemdataDAL(string Createby)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallItemdata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getallItemdataforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallItemdataforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getallitemdatabynoDAL(string no)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallitemdatabyno", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = no;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Item_Master_updateDAL(int no, int itemgroup, int itemsubgroup, string Modelno, string Itemname, string ItemFinalname, string Itemalis, string Itemcategoryno, int ItemUOM, decimal Itemrate, int Itemgst, string ItemHsn, string ItemDesc, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Item_Master_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@no", SqlDbType.Int).Value = no;
            cmd.Parameters.Add("@itemgroup", SqlDbType.Int).Value = itemgroup;
            cmd.Parameters.Add("@itemsubgroup", SqlDbType.Int).Value = itemsubgroup;
            cmd.Parameters.Add("@Modelno", SqlDbType.VarChar).Value = Modelno;
            cmd.Parameters.Add("@Itemname", SqlDbType.VarChar).Value = Itemname;
            cmd.Parameters.Add("ItemFinalname", SqlDbType.VarChar).Value = ItemFinalname;
            cmd.Parameters.Add("@Itemalis", SqlDbType.VarChar).Value = Itemalis;
            cmd.Parameters.Add("@Itemcategoryno", SqlDbType.VarChar).Value = Itemcategoryno;
            cmd.Parameters.Add("@ItemUOM", SqlDbType.Int).Value = ItemUOM;
            cmd.Parameters.Add("@Itemrate", SqlDbType.Decimal).Value = Itemrate;
            cmd.Parameters.Add("@Itemgst", SqlDbType.Int).Value = Itemgst;
            cmd.Parameters.Add("@ItemHsn", SqlDbType.VarChar).Value = ItemHsn;
            cmd.Parameters.Add("@ItemDesc", SqlDbType.VarChar).Value = @ItemDesc;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string deleteitematanoDAL(string no)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteitematano", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = no;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }


    //NO SERIES

    public string tbl_Item_NoSeries_InsertDAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Item_NoSeries_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@No", SqlDbType.BigInt).Value = No;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string tbl_Company_NoSeries_InsertDAL(string CompanyNo, string Extra1, string Extra2)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Company_NoSeries_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CompanyNo", SqlDbType.BigInt).Value = CompanyNo;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string tbl_Customer_Noseries_InsertDAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Customer_Noseries_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@No", SqlDbType.BigInt).Value = No;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    //No series end

    // Company Master

    public DataTable checkcompanycontactnameDAL(string companyno, string ContactName, string ContactEmail)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkcompanycontactname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@companyno", SqlDbType.VarChar).Value = companyno;
            cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = ContactName;
            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Company_Contact_Master_InsertDAL(string Companyno, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Company_Contact_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Companyno", SqlDbType.VarChar).Value = Companyno;
            cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = ContactName;
            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            cmd.Parameters.Add("@ContactPhone", SqlDbType.VarChar).Value = ContactPhone;
            cmd.Parameters.Add("@ContactMobileno1", SqlDbType.VarChar).Value = ContactMobileno1;
            cmd.Parameters.Add("@ContactMobileno2", SqlDbType.VarChar).Value = ContactMobileno2;
            cmd.Parameters.Add("@Dept", SqlDbType.Int).Value = Dept;
            cmd.Parameters.Add("@Design", SqlDbType.Int).Value = Design;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public DataTable getcompanycontactdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getcompanycontactdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deletecompanycontactdatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletecompanycontactdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string tbl_Company_Contact_Master_updateDAL(int Id, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Company_Contact_Master_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = ContactName;
            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            cmd.Parameters.Add("@ContactPhone", SqlDbType.VarChar).Value = ContactPhone;
            cmd.Parameters.Add("@ContactMobileno1", SqlDbType.VarChar).Value = ContactMobileno1;
            cmd.Parameters.Add("@ContactMobileno2", SqlDbType.VarChar).Value = ContactMobileno2;
            cmd.Parameters.Add("@Dept", SqlDbType.Int).Value = Dept;
            cmd.Parameters.Add("@Design", SqlDbType.Int).Value = Design;

            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getcompanycontactdataDAL(string Createby, int companyno)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getcompanycontactdata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            cmd.Parameters.Add("@companyno", SqlDbType.BigInt).Value = companyno;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Company_Master_InsertDAL(string Companyno, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string ComCountry, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Company_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Companyno", SqlDbType.VarChar).Value = Companyno;
            cmd.Parameters.Add("@Comname", SqlDbType.VarChar).Value = Comname;
            cmd.Parameters.Add("@Comarea", SqlDbType.VarChar).Value = Comarea;
            cmd.Parameters.Add("@Comaddress", SqlDbType.VarChar).Value = Comaddress;
            cmd.Parameters.Add("@Comcity", SqlDbType.VarChar).Value = Comcity;
            cmd.Parameters.Add("@Comstate", SqlDbType.VarChar).Value = Comstate;
            cmd.Parameters.Add("@ComDistrict", SqlDbType.VarChar).Value = ComDistrict;
            cmd.Parameters.Add("@ComCountry", SqlDbType.VarChar).Value = ComCountry;
            cmd.Parameters.Add("@ComPincode", SqlDbType.VarChar).Value = ComPincode;
            cmd.Parameters.Add("@ComPhoneNo", SqlDbType.VarChar).Value = ComPhoneNo;
            cmd.Parameters.Add("@ComEmail", SqlDbType.VarChar).Value = ComEmail;
            cmd.Parameters.Add("@BussinessType", SqlDbType.Int).Value = BussinessType;
            cmd.Parameters.Add("@Industrygroup", SqlDbType.Int).Value = Industrygroup;
            cmd.Parameters.Add("@URL", SqlDbType.VarChar).Value = URL;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
            cmd.Parameters.Add("@GSTno", SqlDbType.VarChar).Value = GSTno;
            cmd.Parameters.Add("@Bankname", SqlDbType.VarChar).Value = Bankname;
            cmd.Parameters.Add("@Accountno", SqlDbType.VarChar).Value = Accountno;
            cmd.Parameters.Add("@IFSCcode", SqlDbType.VarChar).Value = IFSCcode;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public DataTable getallcompanydataDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallcompanydata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
         //   cmd.Parameters.Add("@createby", SqlDbType.VarChar).Value = Createby;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }



    public DataTable getallcompanydataforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallcompanydataforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getallcompanydatabycomnoDAL(string comno)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallcompanydatabycomno", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@comno", SqlDbType.VarChar).Value = comno;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Company_Master_updateDAL(string Companyno, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string ComCountry, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Company_Master_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Companyno", SqlDbType.VarChar).Value = Companyno;
            cmd.Parameters.Add("@Comname", SqlDbType.VarChar).Value = Comname;
            cmd.Parameters.Add("@Comarea", SqlDbType.VarChar).Value = Comarea;
            cmd.Parameters.Add("@Comaddress", SqlDbType.VarChar).Value = Comaddress;
            cmd.Parameters.Add("@Comcity", SqlDbType.VarChar).Value = Comcity;
            cmd.Parameters.Add("@Comstate", SqlDbType.VarChar).Value = Comstate;
            cmd.Parameters.Add("@ComDistrict", SqlDbType.VarChar).Value = ComDistrict;
            cmd.Parameters.Add("@ComCountry", SqlDbType.VarChar).Value = ComCountry;
            cmd.Parameters.Add("@ComPincode", SqlDbType.VarChar).Value = ComPincode;
            cmd.Parameters.Add("@ComPhoneNo", SqlDbType.VarChar).Value = ComPhoneNo;
            cmd.Parameters.Add("@ComEmail", SqlDbType.VarChar).Value = ComEmail;
            cmd.Parameters.Add("@BussinessType", SqlDbType.Int).Value = BussinessType;
            cmd.Parameters.Add("@Industrygroup", SqlDbType.Int).Value = Industrygroup;
            cmd.Parameters.Add("@URL", SqlDbType.VarChar).Value = URL;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
            cmd.Parameters.Add("@GSTno", SqlDbType.VarChar).Value = GSTno;
            cmd.Parameters.Add("@Bankname", SqlDbType.VarChar).Value = Bankname;
            cmd.Parameters.Add("@Accountno", SqlDbType.VarChar).Value = Accountno;
            cmd.Parameters.Add("@IFSCcode", SqlDbType.VarChar).Value = IFSCcode;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string deletecompanydatabyCompanynoDAL(string companyno)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletecompanydatabyCompanyno", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@companyno", SqlDbType.VarChar).Value = companyno;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    //company master ended

    //Country master
    public DataTable getallcountryDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("countrydisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable checkcountrydata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkcountryname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string Savecountrybll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertcountry", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    public DataTable getcountrydatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        { 
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showcountry", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletecountrydata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletecountry", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    public string tbl_countryupdate(string Id, string name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatecountry", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = name;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done


    //End
    //State start

    //public DataTable getallstate(int id)
    //{
    //    DataTable dt = null;
    //    try
    //    {
    //        c = con.getconnection();
    //        SqlCommand cmd = new SqlCommand("getallstate", c);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);
    //        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

    //        dt = new DataTable();
    //        da.Fill(dt);
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //    return dt;
    //}
    public DataTable getallstateforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallstateforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
       {

        }
        return dt;
    }
    public DataTable getstatedatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getstatedatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deletestatedatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletestatedatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checkstatenameDAL(string GroupName)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkstatename", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = GroupName;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_state_Master_InsertDAL(string StateName, int CountryId, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertstate", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = StateName;
            cmd.Parameters.Add("@Country", SqlDbType.Int).Value = CountryId;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string tbl_state_Master_UpdateDAL(string Id, int ItemGroupId, string ItemSubGroupName)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatestate", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Country", SqlDbType.Int).Value = ItemGroupId;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = ItemSubGroupName;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }


    // state end
    //city start

    public DataTable getallcityforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallcityforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getcitydatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getscitydatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deletecitydatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletecitydatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checkcitynameDAL(string GroupName)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkcityname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = GroupName;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_city_Master_InsertDAL(string StateName, int CountryId, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("insertcity", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = StateName;
            cmd.Parameters.Add("@State", SqlDbType.Int).Value = CountryId;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    public string tbl_city_Master_UpdateDAL(string Id, int ItemGroupId, string ItemSubGroupName)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatecity", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@State", SqlDbType.Int).Value = ItemGroupId;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = ItemSubGroupName;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getstatedataDAL(int state)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getstatedata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = state;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getcitydataDAL(int city)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getcitydata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = city;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    //city end
    //inqiury

    public string tbl_Inquiry_No_Series_InsertDAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inquiry_No_Series_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@No", SqlDbType.BigInt).Value = No;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getInqiuryDetailsdataDAL( int Noseries)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getInqiuryDetailsdata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = Createby;
            cmd.Parameters.Add("@Noseries", SqlDbType.BigInt).Value = Noseries;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getFollowupdataDAL( int Noseries)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getFollowupdata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = Createby;
            cmd.Parameters.Add("@Noseries", SqlDbType.BigInt).Value = Noseries;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable checkProductNameDAL(string Noseries, int Item)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkProductName", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Noseries", SqlDbType.VarChar).Value = Noseries;
            cmd.Parameters.Add("@Item", SqlDbType.Int).Value = Item;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;

    }
    public string tbl_Inqiury_Details_InsertDAL(int Noseries, int Item, int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inqiury_Details_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Noseries", SqlDbType.Int).Value = Noseries;
            cmd.Parameters.Add("@Item", SqlDbType.Int).Value = Item;
//cmd.Parameters.Add("@Supplier", SqlDbType.Int).Value = Supplier;
//cmd.Parameters.Add("@Principal", SqlDbType.Int).Value = Principal;
            cmd.Parameters.Add("@UOM", SqlDbType.Int).Value = UOM;
            cmd.Parameters.Add("@Qty", SqlDbType.Decimal).Value = Qty;
            cmd.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Rate;
            cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = Amount;

            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getInqiuryDetailsdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getInqiuryDetailsdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteinquirydetailsdatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteinquirydetailsdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string tbl_Inqiury_Details_updateDAL(int Id, int Item, int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inqiury_Details_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@Item", SqlDbType.Int).Value = Item;
//cmd.Parameters.Add("@Supplier", SqlDbType.Int).Value = Supplier;
         //   cmd.Parameters.Add("@Principal", SqlDbType.Int).Value = Principal;
            cmd.Parameters.Add("@UOM", SqlDbType.Int).Value = UOM;
            cmd.Parameters.Add("@Qty", SqlDbType.Decimal).Value = Qty;
            cmd.Parameters.Add("@Rate", SqlDbType.Int).Value = Rate;
            cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = Amount;

            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checkFollowupDAL(string Noseries, string NextFolldate, int Follotype)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkFollowup", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Noseries", SqlDbType.VarChar).Value = Noseries;
            cmd.Parameters.Add("@NextFolldate", SqlDbType.VarChar).Value = NextFolldate;
            cmd.Parameters.Add("@Follotype", SqlDbType.Int).Value = Follotype;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Inqiury_Followup_InsertDAL(int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inqiury_Followup_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Noseries", SqlDbType.Int).Value = Noseries;
            cmd.Parameters.Add("@NextFolldate", SqlDbType.VarChar).Value = NextFolldate;
            cmd.Parameters.Add("@Follotype", SqlDbType.Int).Value = Follotype;
            cmd.Parameters.Add("@Assignto", SqlDbType.Int).Value = Assignto;
            cmd.Parameters.Add("@FolloStatus", SqlDbType.Int).Value = FolloStatus;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = Remarks;
            cmd.Parameters.Add("@Comdate", SqlDbType.VarChar).Value = Comdate;
            cmd.Parameters.Add("@Comremarks", SqlDbType.VarChar).Value = Comremarks;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string tbl_Inqiury_Followup_updateDAL(int Id, int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inqiury_Followup_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@Noseries", SqlDbType.Int).Value = Noseries;
            cmd.Parameters.Add("@NextFolldate", SqlDbType.VarChar).Value = NextFolldate;
            cmd.Parameters.Add("@Follotype", SqlDbType.Int).Value = Follotype;
            cmd.Parameters.Add("@Assignto", SqlDbType.Int).Value = Assignto;
            cmd.Parameters.Add("@FolloStatus", SqlDbType.Int).Value = FolloStatus;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = Remarks;
            cmd.Parameters.Add("@Comdate", SqlDbType.VarChar).Value = Comdate;
            cmd.Parameters.Add("@Comremarks", SqlDbType.VarChar).Value = Comremarks;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getFollowupDetailsdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getFollowupDetailsdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteinquiryfollowupdatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteinquiryfollowupdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string getCustomerIdbynameDAL(string Name)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("getCustomerIdbyname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = @Name;


            res = cmd.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checkInqiuryalreadyDAL(string InqiuryNo, string Inquirydate, int Custname)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkInqiuryalready", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@InqiuryNo", SqlDbType.VarChar).Value = InqiuryNo;
            cmd.Parameters.Add("@Inquirydate", SqlDbType.VarChar).Value = Inquirydate;
       //     cmd.Parameters.Add("@Custgroup", SqlDbType.Int).Value = Custgroup;
            cmd.Parameters.Add("@Custname", SqlDbType.Int).Value = Custname;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Inqiury_Master_InsertDAL(int InqiuryNo, int Noseries, string Inquirydate, int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inqiury_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@InqiuryNo", SqlDbType.Int).Value = InqiuryNo;
            cmd.Parameters.Add("@Noseries", SqlDbType.Int).Value = Noseries;
            cmd.Parameters.Add("@Inquirydate", SqlDbType.VarChar).Value = Inquirydate;
          //  cmd.Parameters.Add("@Custgroup", SqlDbType.Int).Value = Custgroup;
            cmd.Parameters.Add("@Custname", SqlDbType.Int).Value = Custname;
            cmd.Parameters.Add("@Custcontact", SqlDbType.Int).Value = Custcontact;
            cmd.Parameters.Add("@Custcontactno", SqlDbType.VarChar).Value = Custcontactno;
            cmd.Parameters.Add("@Dept", SqlDbType.Int).Value = Dept;
            cmd.Parameters.Add("@Design", SqlDbType.Int).Value = Design;


            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            cmd.Parameters.Add("@ContactMno1", SqlDbType.VarChar).Value = ContactMno1;
            cmd.Parameters.Add("@ContactMno2", SqlDbType.VarChar).Value = ContactMno2;
            cmd.Parameters.Add("@InqiuryStatus", SqlDbType.Int).Value = InqiuryStatus;
            cmd.Parameters.Add("@InquirySource", SqlDbType.Int).Value = InquirySource;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = Remarks;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getallInqiurydataforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallInqiurydataforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getallInqiurydataDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallInqiurydataforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
       //     cmd.Parameters.Add("@createby", SqlDbType.VarChar).Value = Createby;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getCustomerConatctPersonDAL(int Custno)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getCustomerConatctPerson", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = Createby;
            cmd.Parameters.Add("@Custno", SqlDbType.Int).Value = Custno;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getallInqiurydatabynoDAL(string Noseries)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallInqiurydatabyno", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Noseries", SqlDbType.VarChar).Value = Noseries;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getCustomerNameDAL(string Createby, string GroupNo)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getCustomerName", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = Createby;
            cmd.Parameters.Add("@GroupNo", SqlDbType.VarChar).Value = GroupNo;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Inqiury_Master_UpdateDAL(int InqiuryNo, int Noseries, string Inquirydate,  int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Inqiury_Master_Update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@InqiuryNo", SqlDbType.Int).Value = InqiuryNo;
            cmd.Parameters.Add("@Noseries", SqlDbType.Int).Value = Noseries;
            cmd.Parameters.Add("@Inquirydate", SqlDbType.VarChar).Value = Inquirydate;
         //   cmd.Parameters.Add("@Custgroup", SqlDbType.Int).Value = Custgroup;
            cmd.Parameters.Add("@Custname", SqlDbType.Int).Value = Custname;
            cmd.Parameters.Add("@Custcontact", SqlDbType.Int).Value = Custcontact;
            cmd.Parameters.Add("@Custcontactno", SqlDbType.VarChar).Value = Custcontactno;
            cmd.Parameters.Add("@Dept", SqlDbType.Int).Value = Dept;
            cmd.Parameters.Add("@Design", SqlDbType.Int).Value = Design;


            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            cmd.Parameters.Add("@ContactMno1", SqlDbType.VarChar).Value = ContactMno1;
            cmd.Parameters.Add("@ContactMno2", SqlDbType.VarChar).Value = ContactMno2;
            cmd.Parameters.Add("@InqiuryStatus", SqlDbType.Int).Value = InqiuryStatus;
            cmd.Parameters.Add("@InquirySource", SqlDbType.Int).Value = InquirySource;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = Remarks;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getallitemDAL(int no)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallitem", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = no;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    //customer
    public string tbl_Customer_Master_InsertDAL(string No, string GroupNo, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string Country, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Customer_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@No", SqlDbType.VarChar).Value = No;
            cmd.Parameters.Add("@GroupNo", SqlDbType.VarChar).Value = GroupNo;
            cmd.Parameters.Add("@Comname", SqlDbType.VarChar).Value = Comname;
            cmd.Parameters.Add("@Comarea", SqlDbType.VarChar).Value = Comarea;
            cmd.Parameters.Add("@Comaddress", SqlDbType.VarChar).Value = Comaddress;
            cmd.Parameters.Add("@Comcity", SqlDbType.VarChar).Value = Comcity;
            cmd.Parameters.Add("@Comstate", SqlDbType.VarChar).Value = Comstate;
            cmd.Parameters.Add("@ComDistrict", SqlDbType.VarChar).Value = ComDistrict;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
            cmd.Parameters.Add("@ComPincode", SqlDbType.VarChar).Value = ComPincode;
            cmd.Parameters.Add("@ComPhoneNo", SqlDbType.VarChar).Value = ComPhoneNo;
            cmd.Parameters.Add("@ComEmail", SqlDbType.VarChar).Value = ComEmail;
            cmd.Parameters.Add("@BussinessType", SqlDbType.Int).Value = BussinessType;
            cmd.Parameters.Add("@Industrygroup", SqlDbType.Int).Value = Industrygroup;
            cmd.Parameters.Add("@URL", SqlDbType.VarChar).Value = URL;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
            cmd.Parameters.Add("@GSTno", SqlDbType.VarChar).Value = GSTno;
            cmd.Parameters.Add("@Bankname", SqlDbType.VarChar).Value = Bankname;
            cmd.Parameters.Add("@Accountno", SqlDbType.VarChar).Value = Accountno;
            cmd.Parameters.Add("@IFSCcode", SqlDbType.VarChar).Value = IFSCcode;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getCustomercontactdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getCustomercontactdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deleteCustomercontactdatabyidDAL(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteCustomercontactdatabyid", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable getallCustomerMasterataforadminDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallCustomerMasterataforadmin", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getallCustomerMasterataDAL(string Createby)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallCustomerMasterata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           // cmd.Parameters.Add("@createby", SqlDbType.VarChar).Value = Createby;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Customer_Master_updateDAL(string No, string GroupNo, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string Country, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Customer_Master_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@No", SqlDbType.VarChar).Value = No;
            cmd.Parameters.Add("@GroupNo", SqlDbType.VarChar).Value = GroupNo;
            cmd.Parameters.Add("@Comname", SqlDbType.VarChar).Value = Comname;
            cmd.Parameters.Add("@Comarea", SqlDbType.VarChar).Value = Comarea;
            cmd.Parameters.Add("@Comaddress", SqlDbType.VarChar).Value = Comaddress;
            cmd.Parameters.Add("@Comcity", SqlDbType.VarChar).Value = Comcity;
            cmd.Parameters.Add("@Comstate", SqlDbType.VarChar).Value = Comstate;
            cmd.Parameters.Add("@ComDistrict", SqlDbType.VarChar).Value = ComDistrict;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
            cmd.Parameters.Add("@ComPincode", SqlDbType.VarChar).Value = ComPincode;
            cmd.Parameters.Add("@ComPhoneNo", SqlDbType.VarChar).Value = ComPhoneNo;
            cmd.Parameters.Add("@ComEmail", SqlDbType.VarChar).Value = ComEmail;
            cmd.Parameters.Add("@BussinessType", SqlDbType.Int).Value = BussinessType;
            cmd.Parameters.Add("@Industrygroup", SqlDbType.Int).Value = Industrygroup;
            cmd.Parameters.Add("@URL", SqlDbType.VarChar).Value = URL;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
            cmd.Parameters.Add("@GSTno", SqlDbType.VarChar).Value = GSTno;
            cmd.Parameters.Add("@Bankname", SqlDbType.VarChar).Value = Bankname;
            cmd.Parameters.Add("@Accountno", SqlDbType.VarChar).Value = Accountno;
            cmd.Parameters.Add("@IFSCcode", SqlDbType.VarChar).Value = IFSCcode;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public string deleteCustomerdatabynoDAL(string No)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deleteCustomerdatabyno", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@No", SqlDbType.VarChar).Value = No;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;

    }

    public DataTable getallCustomerdatabynoDAL(string No)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getallCustomerdatabyno", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@No", SqlDbType.VarChar).Value = No;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getCustomercontactdataDAL( int Custno)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("getCustomercontactdata", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
         //   cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = Createby;
            cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = Custno;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;

    }
    public string tbl_Customer_Contact_Master_updateDAL(int Id, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Customer_Contact_Master_update", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = ContactName;
            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            cmd.Parameters.Add("@ContactPhone", SqlDbType.VarChar).Value = ContactPhone;
            cmd.Parameters.Add("@ContactMobileno1", SqlDbType.VarChar).Value = ContactMobileno1;
            cmd.Parameters.Add("@ContactMobileno2", SqlDbType.VarChar).Value = ContactMobileno2;
            cmd.Parameters.Add("@Dept", SqlDbType.Int).Value = Dept;
            cmd.Parameters.Add("@Design", SqlDbType.Int).Value = Design;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }
    public DataTable checkcustomercontactnameDAL(string Custno, string ContactName, string ContactEmail)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checkcustomercontactname", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Custno", SqlDbType.VarChar).Value = Custno;
            cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = ContactName;
            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Customer_Contact_Master_InsertDAL(string Custno, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("tbl_Customer_Contact_Master_Insert", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Custno", SqlDbType.VarChar).Value = Custno;
            cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = ContactName;
            cmd.Parameters.Add("@ContactEmail", SqlDbType.VarChar).Value = ContactEmail;
            cmd.Parameters.Add("@ContactPhone", SqlDbType.VarChar).Value = ContactPhone;
            cmd.Parameters.Add("@ContactMobileno1", SqlDbType.VarChar).Value = ContactMobileno1;
            cmd.Parameters.Add("@ContactMobileno2", SqlDbType.VarChar).Value = ContactMobileno2;
            cmd.Parameters.Add("@Dept", SqlDbType.Int).Value = Dept;
            cmd.Parameters.Add("@Design", SqlDbType.Int).Value = Design;
            cmd.Parameters.Add("@CreateBy", SqlDbType.VarChar).Value = CreateBy;
            cmd.Parameters.Add("@CreateDatetime", SqlDbType.DateTime).Value = CreateDatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = Extra1;
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = Extra2;
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = Extra3;
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = Extra4;
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = Extra5;
            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    }

    //
    //Terms and Conditions

    public DataTable checktermsandconditionsdata(string name)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("checktermsandconditions", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = name;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string Savetermsandconditionsbll(string name,string termsandconditions, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("inserttermsandconditions", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Termsandconditions", SqlDbType.VarChar).Value = termsandconditions;

            cmd.Parameters.Add("@Createby", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CreateDateTime", SqlDbType.DateTime).Value = Createddatetime;
            cmd.Parameters.Add("@Extra1", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra2", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra3", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra4", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Extra5", SqlDbType.VarChar).Value = "";


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

    public DataTable getalltermsandconditionsDAL()
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("termsandconditionsdisp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable gettermsandconditionsdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            c = con.getconnection();
            SqlCommand cmd = new SqlCommand("showtermsandconditions", c);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletetermsandconditionsdata(string Id)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("deletetermsandconditions", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;

            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done
    public string tbl_termsandconditionsupdate(string Id, string name,string tandc)
    {
        string res = "";
        try
        {
            c = con.getconnection();
            cmd = new SqlCommand("updatedesignation", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@TandC", SqlDbType.VarChar).Value = tandc;


            res = cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }
        return res;
    } //done

}