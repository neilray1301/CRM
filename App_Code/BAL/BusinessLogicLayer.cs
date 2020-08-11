using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for BusinessLogicLayer
/// </summary>
public class BusinessLogicLayer
{
    DataAccessLayer dal = new DataAccessLayer();
    //Industrytype Start

    public string SaveMyTablebll(string name, string Createby,DateTime Createddatetime,string Extra1, string Extra2,string Extra3, string Extra4,string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.SaveMyTablebll(name,Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4,Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallIndustrygroupfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallIndustrygroupfroadminDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable checklogindata(string uname,string password)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checklogindata(uname, password);
        }
        catch(Exception ex) {
        }
        return dt;
    }

    public DataTable checkdata(string name)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getIndustrygroupdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getIndustrygroupdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deletedata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletedata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_update(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_update(id,name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    
    //Industrytype end

    //Businesstype start

    public string Savebusinesstypebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savebusinesstypebll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallbusinesstypefroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallbusinesstypeDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }//done

    public DataTable checkbusinesstypedata(string name)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkbusinesstypedata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getbusinesstypedatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getBusinesstypedatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletebusinesstypedata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletebusinesstypedata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_businesstypeupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_businesstypeupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //BusinessType end

    //Role Start

    public string Saverolebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Saverolebll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallrolefroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallroleDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }//done

    public DataTable checkroledata(string name)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkroledata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } // done

    public DataTable getroledatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getroledatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deleteroledata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteroledata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_roleupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_roleupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //Role End

    //Source Start
    
    public string Savesourcebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savesourcebll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallsourcefroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallsourceDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checksourcedata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getsourcedatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getsourcedatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletesourcedata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletesourcedata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_sourceupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_sourceupdate(id, name);
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
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savestatusbll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallstatusfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallstatusDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkstatusdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getstatusdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getstatusdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletestatusdata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletestatusdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_statusupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_statusupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //Status end

    //Department start
    
    public string Savedepartmentbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savedepartmentbll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getalldepartmentfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getalldepartmentDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkdepartmentdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getdepartmentdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getdepartmentdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletedepartmentdata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletedepartmentdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_departmentupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_departmentupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //Department End

    //Designation start

    public string Savedesignationbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savedesignationbll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getalldesignationfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getalldesignationDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkdesignationdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getdesignationdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getdesignationdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletedesignationdata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletedesignationdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_designationupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_designationupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //Designation done

    //Unit of Measurement Start 

    public string Saveunitofmeasurementbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Saveunitofmeasurementbll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallunitofmeasurementfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallunitofmeasurementDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkunitofmeasurementdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getunitofmeasurementdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getunitofmeasurementdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deleteunitofmeasurementdata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteunitofmeasurementdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_unitofmeasurementupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_unitofmeasurementupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //Unit of Measurement Done

    //Followuptype start

    public string Savefollowuptypebll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savefollowuptypebll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallfollowuptypefroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallfollowuptypeDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkfollowuptypedata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getfollowuptypedatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getfollowuptypedatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletefollowuptypedata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletefollowuptypedata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_followuptypeupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_followuptypeupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //Followuptype done

    //ItemGroup start

    public string Saveitemgroupbll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Saveitemgroupbll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getallitemgroupfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallitemgroupDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkitemgroupdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public DataTable getitemgroupdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getitemgroupdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deleteitemgroupdata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteitemgroupdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_itemgroupupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_itemgroupupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    //ItemGroup END

    //ItemSubgroup start

    public DataTable getallItemsubgroupBAL(int id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallItemsubgroup(id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getallItemsubgroupforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallItemsubgroupforadminDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable checkItemsubgroupnameBAL(string groupname)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkItemsubgroupnameDAL(groupname);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Itemsubgroup_Master_InsertBAL(string ItemSubGroupName, int ItemGroupId, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Itemsubgroup_Master_InsertDAL(ItemSubGroupName, ItemGroupId, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getItemsubgroupdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getItemsubgroupdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteItemsubgroupdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteItemsubgroupdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Itemsubgroup_Master_UpdateBAL(string Id, int ItemGroupId, string ItemSubGroupName)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Itemsubgroup_Master_UpdateDAL(Id, ItemGroupId, ItemSubGroupName);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    // ItemSubgroup end
    //item master start

    public string tbl_ItemDocument_Master_InsertBAL(string no, string DocuName, string Filename, string DocumentPath, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_ItemDocument_Master_InsertDAL(no, DocuName, Filename, DocumentPath, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getItemdocumentadataBAL(string Createby, int no)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getItemdocumentadataDAL(Createby, no);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string deletitemimgdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletitemimgdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deletitemdocumentdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletitemdocumentdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_ItemImage_Master_InsertBAL(string no, string DocuName, string Filename, string DocumentPath, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_ItemImage_Master_InsertDAL(no, DocuName, Filename, DocumentPath, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getItemimageadataBAL(string Createby, int no)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getItemimageadataDAL(Createby, no);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable checkItemnameBAL(string Itemname)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkItemnameDAL(Itemname);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Item_Master_InsertBAL(int no, int itemgroup, int itemsubgroup, string Modelno, string Itemname, string ItemFinalname, string Itemalis, string Itemcategoryno, int ItemUOM, decimal Itemrate, int Itemgst, string ItemHsn, string ItemDesc, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Item_Master_InsertDAL(no, itemgroup, itemsubgroup, Modelno, Itemname, ItemFinalname, Itemalis, Itemcategoryno, ItemUOM, Itemrate, Itemgst, ItemHsn, ItemDesc, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallItemdataBAL(string Createby)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallItemdataDAL(Createby);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallItemdataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallItemdataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallitemdatabynoBAL(string no)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallitemdatabynoDAL(no);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Item_Master_updateBAL(int no, int itemgroup, int itemsubgroup, string Modelno, string Itemname, string ItemFinalname, string Itemalis, string Itemcategoryno, int ItemUOM, decimal Itemrate, int Itemgst, string ItemHsn, string ItemDesc, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Item_Master_updateDAL(no, itemgroup, itemsubgroup, Modelno, Itemname, ItemFinalname, Itemalis, Itemcategoryno, ItemUOM, Itemrate, Itemgst, ItemHsn, ItemDesc, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deleteitematanoBAL(string no)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteitematanoDAL(no);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    //No series

    public string tbl_Item_NoSeries_InsertBAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Item_NoSeries_InsertDAL(No, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Company_NoSeries_InsertBAL(string CompanyNo, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Company_NoSeries_InsertDAL(CompanyNo, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }


    public string tbl_Customer_Noseries_InsertBAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Customer_Noseries_InsertDAL(No, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    // NO series end

    // Company Master
    public DataTable checkcompanycontactnameBAL(string companyno, string ContactName, string ContactEmail)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkcompanycontactnameDAL(companyno, ContactName, ContactEmail);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Company_Contact_Master_InsertBAL(string Companyno, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Company_Contact_Master_InsertDAL(Companyno, ContactName, ContactEmail, ContactPhone, ContactMobileno1, ContactMobileno2, Dept, Design, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getcompanycontactdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getcompanycontactdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deletecompanycontactdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletecompanycontactdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Company_Contact_Master_updateBAL(int id, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {

        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Company_Contact_Master_updateDAL(id, ContactName, ContactEmail, ContactPhone, ContactMobileno1, ContactMobileno2, Dept, Design, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getcompanycontactdataBAL(string Createby, int companyno)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getcompanycontactdataDAL(Createby, companyno);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Company_Master_InsertBAL(string Companyno, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string ComCountry, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Company_Master_InsertDAL(Companyno, Comname, Comarea, Comaddress, Comcity, Comstate, ComDistrict, ComCountry, ComPincode, ComPhoneNo, ComEmail, BussinessType, Industrygroup, URL, Status, GSTno, Bankname, Accountno, IFSCcode, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);

        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallcompanydataBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallcompanydataDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallcompanydataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallcompanydataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallcompanydatabycomnoBAL(string comno)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallcompanydatabycomnoDAL(comno);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Company_Master_updateBAL(string Companyno, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string ComCountry, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Company_Master_updateDAL(Companyno, Comname, Comarea, Comaddress, Comcity, Comstate, ComDistrict, ComCountry, ComPincode, ComPhoneNo, ComEmail, BussinessType, Industrygroup, URL, Status, GSTno, Bankname, Accountno, IFSCcode, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);

        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deletecompanydatabyCompanynoBAL(string companyno)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletecompanydatabyCompanynoDAL(companyno);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    //Company master ended

    //Country started
    public DataTable getallcountryfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallcountryDAL();
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
            dal = new DataAccessLayer();
            dt = dal.checkcountrydata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done
    public string Savecountrybll(string name, string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savecountrybll(name, Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getcountrydatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getcountrydatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletecountrydata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletecountrydata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_countryupdate(string id, string name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_countryupdate(id, name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done
      //Country Ended

    //State Start
    public DataTable getallstateforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallstateforadminDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getstatedatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getstatedatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deletestatedatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletestatedatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public DataTable checkstatenameBAL(string groupname)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkstatenameDAL(groupname);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_state_Master_InsertBAL(string StateName, int CountryId, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_state_Master_InsertDAL(StateName, CountryId, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_state_Master_UpdateBAL(string Id, int ItemGroupId, string ItemSubGroupName)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_state_Master_UpdateDAL(Id, ItemGroupId, ItemSubGroupName);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }


    //state end
    //city start

    public DataTable getallcityforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallcityforadminDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getcitydatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getcitydatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deletecitydatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletecitydatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkcitynameBAL(string groupname)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkcitynameDAL(groupname);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_city_Master_InsertBAL(string StateName, int CountryId, string CreateBy, DateTime @CreateDatetime, string Extra1, string Extra2, string @Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_city_Master_InsertDAL(StateName, CountryId, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_city_Master_UpdateBAL(string Id, int ItemGroupId, string ItemSubGroupName)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_city_Master_UpdateDAL(Id, ItemGroupId, ItemSubGroupName);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getstatedataBAL( int state)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getstatedataDAL(state);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable getcitydataBAL(int city)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getcitydataDAL(city);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    // Inquiry 
    public DataTable getallitemBAL(int no)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallitemDAL(no);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }
    public string tbl_Inquiry_No_Series_InsertBAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Inquiry_No_Series_InsertDAL(No, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public DataTable getInqiuryDetailsdataBAL( int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getInqiuryDetailsdataDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallInqiuryDetailsdataBAL(int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallInqiuryDetailsdataDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }
    public DataTable getFollowupdatabal(int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getFollowupdataDAL(Noseries);
        }catch(Exception ex)
        {
            ex.ToString();
        }
        return dt;
    }
    public DataTable getorderFollowupdataBAL( int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getorderFollowupdataDAL( Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }
    public DataTable checkProductNameBAL(string Noseries, int Item)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkProductNameDAL(Noseries, Item);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Inqiury_Details_InsertBAL(int Noseries, int Item,  int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Inqiury_Details_InsertDAL(Noseries, Item,  UOM, Qty, Rate, Amount, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getInqiuryDetailsdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getInqiuryDetailsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deleteinquirydetailsdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteinquirydetailsdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public string tbl_Inqiury_Details_updateBAL(int Id, int Item,  int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {

        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Inqiury_Details_updateDAL(Id, Item,  UOM, Qty, Rate, Amount, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public DataTable checkFollowupBAL(string Noseries, string NextFolldate, int Follotype)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkFollowupDAL(Noseries, NextFolldate, Follotype);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Inqiury_Followup_InsertBAL(int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Inqiury_Followup_InsertDAL(Noseries, NextFolldate, Follotype, Assignto, FolloStatus, Remarks, Comdate, Comremarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Inqiury_Followup_updateBAL(int Id, int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Inqiury_Followup_updateDAL(Id, Noseries, NextFolldate, Follotype, Assignto, FolloStatus, Remarks, Comdate, Comremarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public DataTable getFollowupDetailsdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getFollowupDetailsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string deleteinquiryfollowupdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteinquiryfollowupdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public string getCustomerIdbynameBAL(string Name)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.getCustomerIdbynameDAL(Name);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkInqiuryalreadyBAL(string InqiuryNo, string Inquirydate,  int Custname)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkInqiuryalreadyDAL(InqiuryNo, Inquirydate,  Custname);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Inqiury_Master_InsertBAL(int InqiuryNo, int Noseries, string Inquirydate,  int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Inqiury_Master_InsertDAL(InqiuryNo, Noseries, Inquirydate,  Custname, Custcontact, Custcontactno, Dept, Design, ContactEmail, ContactMno1, ContactMno2, InqiuryStatus, InquirySource, Remarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
    public DataTable getallInqiurydataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallInqiurydataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }
    public DataTable getallInqiurydataBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallInqiurydataDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getCustomerConatctPersonBAL( int Custno)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getCustomerConatctPersonDAL( Custno);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getallInqiurydatabynoBAL(string Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallInqiurydatabynoDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getCustomerNameBAL(string Createby, string GroupNo)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getCustomerNameDAL(Createby, GroupNo);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public string tbl_Inqiury_Master_UpdateBAL(int InqiuryNo, int Noseries, string Inquirydate,  int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
             res = dal.tbl_Inqiury_Master_UpdateDAL(InqiuryNo, Noseries, Inquirydate,  Custname, Custcontact, Custcontactno, Dept, Design, ContactEmail, ContactMno1, ContactMno2, InqiuryStatus, InquirySource, Remarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }


    // customer
    public string tbl_Customer_Master_InsertBAL(string No, string Groupno, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string Country, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Customer_Master_InsertDAL(No, Groupno, Comname, Comarea, Comaddress, Comcity, Comstate, ComDistrict, Country, ComPincode, ComPhoneNo, ComEmail, BussinessType, Industrygroup, URL, Status, GSTno, Bankname, Accountno, IFSCcode, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);

        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getCustomercontactdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getCustomercontactdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteCustomercontactdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteCustomercontactdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallCustomerMasterataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallCustomerMasterataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallCustomerMasterataBAL(string Createby)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallCustomerMasterataDAL(Createby);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Customer_Master_updateBAL(string No, string GroupNo, string Comname, string Comarea, string Comaddress, string Comcity, string Comstate, string ComDistrict, string Country, string ComPincode, string ComPhoneNo, string ComEmail, int BussinessType, int Industrygroup, string URL, string Status, string GSTno, string Bankname, string Accountno, string IFSCcode, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Customer_Master_updateDAL(No, GroupNo, Comname, Comarea, Comaddress, Comcity, Comstate, ComDistrict, Country, ComPincode, ComPhoneNo, ComEmail, BussinessType, Industrygroup, URL, Status, GSTno, Bankname, Accountno, IFSCcode, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);

        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deleteCustomerdatabynoBAL(string No)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteCustomerdatabynoDAL(No);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallCustomerdatabynoBAL(string No)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallCustomerdatabynoDAL(No);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getCustomercontactdataBAL( int Custno)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getCustomercontactdataDAL( Custno);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Customer_Contact_Master_updateBAL(int id, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {

        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Customer_Contact_Master_updateDAL(id, ContactName, ContactEmail, ContactPhone, ContactMobileno1, ContactMobileno2, Dept, Design, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkcustomercontactnameBAL(string Custno, string ContactName, string ContactEmail)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkcustomercontactnameDAL(Custno, ContactName, ContactEmail);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Customer_Contact_Master_InsertBAL(string Custno, string ContactName, string ContactEmail, string ContactPhone, string ContactMobileno1, string ContactMobileno2, int Dept, int Design, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Customer_Contact_Master_InsertDAL(Custno, ContactName, ContactEmail, ContactPhone, ContactMobileno1, ContactMobileno2, Dept, Design, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
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
            dal = new DataAccessLayer();
            dt = dal.checktermsandconditionsdata(name);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string Savetermsandconditionsbll(string name, string termsandconditions,string Createby, DateTime Createddatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.Savetermsandconditionsbll(name,termsandconditions ,Createby, Createddatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public DataTable getalltermsandconditionsfroadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getalltermsandconditionsDAL();
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable gettermsandconditionsdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.gettermsandconditionsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    } //done

    public string deletetermsandconditionsdata(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletetermsandconditionsdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_termsandconditionsupdate(string id, string name,string tandc)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_termsandconditionsupdate(id, name,tandc);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    } //done

    public string tbl_Quotation_No_Series_InsertBAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_No_Series_InsertDAL(No, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Quotation_Details_InsertBAL(int Noseries, int Item, int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_Details_InsertDAL(Noseries, Item, UOM, Qty, Rate, Amount, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Quotation_Details_updateBAL(int Id, int Item, int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {

        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_Details_updateDAL(Id, Item, UOM, Qty, Rate, Amount, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkQuotationProductNameBAL(string Noseries, int Item)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkQuotationProductNameDAL(Noseries, Item);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Quotation_Followup_InsertBAL(int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_Followup_InsertDAL(Noseries, NextFolldate, Follotype, Assignto, FolloStatus, Remarks, Comdate, Comremarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkQuotationFollowupBAL(string Noseries, string NextFolldate, int Follotype)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkQuotationFollowupDAL(Noseries, NextFolldate, Follotype);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Quotation_Followup_updateBAL(int Id, int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_Followup_updateDAL(Id, Noseries, NextFolldate, Follotype, Assignto, FolloStatus, Remarks, Comdate, Comremarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Quotation_Master_InsertBAL(int InqiuryNo, int Noseries, string Inquirydate, int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_Master_InsertDAL(InqiuryNo, Noseries, Inquirydate, Custname, Custcontact, Custcontactno, Dept, Design, ContactEmail, ContactMno1, ContactMno2, InqiuryStatus, InquirySource, Remarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkQuotationalreadyBAL(string InqiuryNo, string Inquirydate, int Custname)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkQuotationalreadyDAL(InqiuryNo, Inquirydate, Custname);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Quotation_tandc_InsertBAL(int termsid, int noseries, string termstitle, string termsdescrip, string status, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_tandc_InsertDAL(termsid,noseries,termstitle,termsdescrip,status,CreateBy,CreateDatetime,Extra1,Extra2,Extra3,Extra4,Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallQuotationdataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallQuotationdataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }


    public DataTable getallQuotationdataBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallQuotationdataDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallQuotationdatabynoBAL(string Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallQuoationdatabynoDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallquotatationtermsandconditionsfroadminBAL(int noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallquotationtermsandconditionsDAL(noseries);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Quotation_Master_updateBAL( int Noseries,  int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Quotation_Master_updateDAL( Noseries, Custname, Custcontact, Custcontactno, Dept, Design, ContactEmail, ContactMno1, ContactMno2, InqiuryStatus, InquirySource, Remarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }


    public string deletequtationtermsandconditionsdata(int id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletequtationtermsandconditionsdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallquotationInqiurydatabynoBAL(string Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallquotationInqiurydatabynoBAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallquotationitemdatabal(string Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallquotationitemdatadal(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }


    public DataTable getquotationDetailsdataBAL(int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getquotationDetailsdataDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getQuotationDetailsdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getQuotationDetailsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deletequotationdetailsdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletequotationdetailsdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deletequotationfollowupdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deletequotationfollowupdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    // Order

    public string tbl_Order_No_Series_InsertBAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_No_Series_InsertDAL(No, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkOrderProductNameBAL(string Noseries, int Item)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkQuotationProductNameDAL(Noseries, Item);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Order_Details_InsertBAL(int Noseries, int Item, int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_Details_InsertDAL(Noseries, Item, UOM, Qty, Rate, Amount, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Order_Details_updateDAL(int Id, int Item, int UOM, decimal Qty, decimal Rate, decimal Amount, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {

        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_Details_updateDAL(Id, Item, UOM, Qty, Rate, Amount, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallorderitemdatabal(string Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallorderitemdatadal(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallOrderDetailsdataBAL(int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallOrderDetailsdataDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getOrderDetailsdatabyidDAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getorderDetailsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteorderdetailsdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteorderdetailsdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getorderFollowupDetailsdatabyidBAL(string Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getorderFollowupDetailsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string deleteorderfollowupdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteorderfollowupdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable checkOrderFollowupBAL(string Noseries, string NextFolldate, int Follotype)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.checkorderFollowupDAL(Noseries, NextFolldate, Follotype);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Order_Followup_InsertBAL(int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_Followup_InsertDAL(Noseries, NextFolldate, Follotype, Assignto, FolloStatus, Remarks, Comdate, Comremarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Order_Followup_updateBAL(int Id, int Noseries, string NextFolldate, int Follotype, int Assignto, int FolloStatus, string Remarks, string Comdate, string Comremarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_Followup_updateDAL(Id, Noseries, NextFolldate, Follotype, Assignto, FolloStatus, Remarks, Comdate, Comremarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Order_Master_InsertBAL(int InqiuryNo, int Noseries, string Inquirydate, int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_Master_InsertDAL(InqiuryNo, Noseries, Inquirydate, Custname, Custcontact, Custcontactno, Dept, Design, ContactEmail, ContactMno1, ContactMno2, InqiuryStatus, InquirySource, Remarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deleteordertermsandconditionsdata(int id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteordertermsandconditionsdata(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Order_tandc_InsertBAL(int termsid, int noseries, string termstitle, string termsdescrip, string status, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_tandc_InsertDAL(termsid, noseries, termstitle, termsdescrip, status, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getquotationDetailsdatabyidDAL(int Id)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getquotationDetailsdatabyidDAL(Id);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable getQUotationFollowupdataDAL(int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getQUotationFollowupdataDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallOrderdataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallOrderdataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallOrderdataBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallOrderdataDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    // Update ORder

    public DataTable getallOrderdatabynoBAL(string Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallOrderdatabynoDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getOrderFollowupdataDAL(int Noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getOrderFollowupdataDAL(Noseries);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public DataTable getallordertermsandconditionsfroadminBAL(int noseries)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallordertermsandconditionsDAL(noseries);
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public string tbl_Order_Master_updateBAL(int Noseries, int Custname, int Custcontact, string Custcontactno, int Dept, int Design, string ContactEmail, string ContactMno1, string ContactMno2, int InqiuryStatus, int InquirySource, string Remarks, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Order_Master_updateDAL(Noseries, Custname, Custcontact, Custcontactno, Dept, Design, ContactEmail, ContactMno1, ContactMno2, InqiuryStatus, InquirySource, Remarks, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    // Employee Master

    public string tbl_Employee_NoSeries_InsertBAL(string No, string Extra1, string Extra2)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Employee_NoSeries_InsertDAL(No, Extra1, Extra2);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string deleteemployeedocumentdatabyidBAL(string id)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteemployeedocumentdatabyidDAL(id);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public string tbl_Employee_Document_Master_InsertBAL(string no, string DocuName, string Filename, string DocumentPath, string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Employee_Document_Master_InsertDAL(no, DocuName, Filename, DocumentPath, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getdocumentadataBAL(string Createby, int no)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getdocumentadataDAL(Createby, no);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Employee_master_InsertBAL(string no, string Ename, string Efname, string Esurname, string Egender,
       string Epaddress, string Eperaddress, string ECity, string EState, string EDistrict, string ECountry, string EPincode, string EPhoneNo, string Emobilenop, string Emobileoffice, string Emobilewhatsup,
       string Erole, string Epfno, string Edoa, string Edoj, string Edol, int Edept, int Edesign,
       string Eemailid, string Epwd, string Eurgentcontactname, string Eurgentcontactno, string Eurgentcontactrelation, string Estatus, string Ebankname, string Eaccno, string Eifsccode,

       string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Employee_master_InsertDAL(no, Ename, Efname, Esurname, Egender,
        Epaddress, Eperaddress, ECity, EState, EDistrict, ECountry, EPincode, EPhoneNo, Emobilenop, Emobileoffice, Emobilewhatsup,
        Erole, Epfno, Edoa, Edoj, Edol, Edept, Edesign,
        Eemailid, Epwd, Eurgentcontactname, Eurgentcontactno, Eurgentcontactrelation, Estatus, Ebankname, Eaccno, Eifsccode,

        CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);

        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getallemployeedataforadminBAL()
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallemployeedataforadminDAL();

        }
        catch (Exception ex)
        {


        }
        return dt;
    }
    public DataTable getallemployeedataBAL(string Createby)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getallemployeedataDAL(Createby);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string tbl_Employee_master_UpdateBAL(string no, string Ename, string Efname, string Esurname, string Egender,
     string Epaddress, string Eperaddress, string ECity, string EState, string EDistrict, string ECountry, string EPincode, string EPhoneNo, string Emobilenop, string Emobileoffice, string Emobilewhatsup,
     string Erole, string Epfno, string Edoa, string Edoj, string Edol, int Edept, int Edesign,
     string Eemailid, string Epwd, string Eurgentcontactname, string Eurgentcontactno, string Eurgentcontactrelation, string Estatus, string Ebankname, string Eaccno, string Eifsccode,
        string CreateBy, DateTime CreateDatetime, string Extra1, string Extra2, string Extra3, string Extra4, string Extra5)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.tbl_Employee_master_UpdateDAL(no, Ename, Efname, Esurname, Egender,
        Epaddress, Eperaddress, ECity, EState, EDistrict, ECountry, EPincode, EPhoneNo, Emobilenop, Emobileoffice, Emobilewhatsup,
        Erole, Epfno, Edoa, Edoj, Edol, Edept, Edesign,
        Eemailid, Epwd, Eurgentcontactname, Eurgentcontactno, Eurgentcontactrelation, Estatus, Ebankname, Eaccno, Eifsccode, CreateBy, CreateDatetime, Extra1, Extra2, Extra3, Extra4, Extra5);

        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }

    public DataTable getemployeedatanoBAL(string comno)
    {
        DataTable dt = null;
        try
        {
            dal = new DataAccessLayer();
            dt = dal.getemployeedatanoDAL(comno);

        }
        catch (Exception ex)
        {


        }
        return dt;
    }

    public string deleteemployeedatabynoBAL(string no)
    {
        string res = "";
        dal = new DataAccessLayer();
        try
        {
            res = dal.deleteemployeedatabynoDAL(no);
        }
        catch (Exception ex)
        {
            res = ex.ToString();
        }

        return res;
    }
}