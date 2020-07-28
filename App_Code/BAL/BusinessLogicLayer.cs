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

}