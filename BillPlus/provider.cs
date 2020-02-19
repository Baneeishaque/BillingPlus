using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BillPlus
{
    class provider
    {
        dbop db = new dbop();

        // insert institution details



        public int insertintocompanysettings(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblcompany(companyid,companyname,address,state,pincode,email,logo,financialyear,currency,password,phone,financialyearfrom,financialyearto) values (@companyid,@companyname,@address,@state,@pincode,@email,@logo,@financialyear,@currency,@password,@phone,@financialyearfrom,@financialyearto)";
            cmd.Parameters.AddWithValue("@companyid", c.Companyid);
            cmd.Parameters.AddWithValue("@companyname", c.Companyname);
            cmd.Parameters.AddWithValue("@address", c.Address);


            cmd.Parameters.AddWithValue("@state", c.State);
            cmd.Parameters.AddWithValue("@pincode", c.Pincode);
            cmd.Parameters.AddWithValue("@email", c.Email);


            cmd.Parameters.AddWithValue("@logo", c.Logo);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@currency", c.Currency);
            cmd.Parameters.AddWithValue("@password", c.Password);
            cmd.Parameters.AddWithValue("@phone", c.Phone);


            cmd.Parameters.AddWithValue("@financialyearfrom", c.Financialyearfrom);
            cmd.Parameters.AddWithValue("@financialyearto", c.Financialyearto);

            db.insert(cmd);
            return (int)cmd.LastInsertedId;
        }
        public DataTable selectcompany()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblcompany";
            return db.select(cmd);
        }

        public void updatecompanysettings(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblcompany set companyname=@companyname,address=@address,state=@state,pincode=@pincode,email=@email,logo=@logo,financialyear=@financialyear,currency=@currency,password=@password,phone=@phone,financialyearfrom=@financialyearfrom,financialyearto=@financialyearto where companyid=@companyid";
            cmd.Parameters.AddWithValue("@companyid", c.Companyid);
            cmd.Parameters.AddWithValue("@companyname", c.Companyname);
            cmd.Parameters.AddWithValue("@address", c.Address);


            cmd.Parameters.AddWithValue("@state", c.State);
            cmd.Parameters.AddWithValue("@pincode", c.Pincode);
            cmd.Parameters.AddWithValue("@email", c.Email);


            cmd.Parameters.AddWithValue("@logo", c.Logo);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@currency", c.Currency);
            cmd.Parameters.AddWithValue("@password", c.Password);
            cmd.Parameters.AddWithValue("@phone", c.Phone);


            cmd.Parameters.AddWithValue("@financialyearfrom", c.Financialyearfrom);
            cmd.Parameters.AddWithValue("@financialyearto", c.Financialyearto);
            db.insert(cmd);
        }

        public void updatecompanypaassword(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblcompany set password=@password where companyid=@companyid";
            cmd.Parameters.AddWithValue("@companyid", c.Companyid);
            cmd.Parameters.AddWithValue("@password", c.Password);
            db.insert(cmd);
        }
        public void inerttblMaster(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblmaster (id,username,address,contactno,accounttype,financialyear,startingamount,status,closingamount,statusclosing,adhar,remarks) values(@id,@username,@address,@contactno,@accounttype,@financialyear,@startingamount,@status,@closingamount,@statusclosing,@adhar,@remarks)";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@username", c.Username);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@contactno", c.Contactno);
            cmd.Parameters.AddWithValue("@accounttype", c.Accounttype);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);
            cmd.Parameters.AddWithValue("@status", c.Status);
            //Closingamount,Statusclosing

            cmd.Parameters.AddWithValue("@closingamount", c.Closingamount);
            cmd.Parameters.AddWithValue("@statusclosing", c.Statusclosing);



            cmd.Parameters.AddWithValue("@adhar", c.Adhars);
            cmd.Parameters.AddWithValue("@remarks", c.Remarks);
         
            db.insert(cmd);
        }

        public DataTable selectcompanycustomerdetails()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblmaster ORDER BY id DESC ";
           
            return db.select(cmd);
        }
       

   

        public void insertintotlcategory(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblcategory(id,categoryname) values(@id,@categoryname)";
            cmd.Parameters.AddWithValue("@id", c.Id);

            cmd.Parameters.AddWithValue("@categoryname", c.Username);
           

            db.insert(cmd);
        }


        public DataTable selectHeadNames(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblaccounthead where accounttype=@accounttype ";
            cmd.Parameters.AddWithValue("@accounttype", c.Accounttype);
            return db.select(cmd);
        }



        public DataTable Mastersmaxid()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(id) from tblmaster";
          
            return db.select(cmd);
        }

        public void insrtintoProductCreation(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblproduct(id,productname,productcode,catogery,sellingprice,unit,gst,cgst,sgst,startingstock,financialyear,gstamount,barcodeno,closingstock) values(@id,@productname,@productcode,@catogery,@sellingprice,@unit,@gst,@cgst,@sgst,@startingstock,@financialyear,@gstamount,@barcodeno,@closingstock)";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@productname", c.Productname);
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);

            cmd.Parameters.AddWithValue("@sellingprice", c.Sellingprice);
            cmd.Parameters.AddWithValue("@catogery", c.Category);
            cmd.Parameters.AddWithValue("@unit", c.Unit);
            cmd.Parameters.AddWithValue("@gst", c.Gst);
            cmd.Parameters.AddWithValue("@cgst", c.Cgst);
            cmd.Parameters.AddWithValue("@sgst", c.Sgst);
            cmd.Parameters.AddWithValue("@startingstock", c.Stockstrt);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@gstamount", c.Gstamount);
            cmd.Parameters.AddWithValue("@barcodeno", c.Purchasedprice);

            cmd.Parameters.AddWithValue("@closingstock", c.Closingstock);
            db.insert(cmd);
        }

        public DataTable SelectProductdetails()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblproduct";

            return db.select(cmd);
        }
        public DataTable productsmaxid()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(id) from tblproduct";

            return db.select(cmd);
        }

        public DataTable selectfromcategory()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblcategory ";
          
            return db.select(cmd);
        }

        public void deletefromcategory(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblcategory where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);
           
            db.insert(cmd);
        }
        public DataTable selectmaxidcategory()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(id) from tblcategory ";

            return db.select(cmd);
        }



     


        public DataTable selectproductdetailsfromtblmaster(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblproduct where productname=@productname and productcode=@productcode";
            cmd.Parameters.AddWithValue("@productname", c.Productname);
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);
           
            return db.select(cmd);
        }

     
        public DataTable selectMaxofPurchase()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(id) from tblpurchase";

            return db.select(cmd);
        }

    

        public DataTable selectcustomerbyid(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblmaster where id=@id ";
            cmd.Parameters.AddWithValue("@id", c.Id);
            return db.select(cmd);
        }



        public DataTable selectcustomerbynamesvalidaion(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblmaster where username=@username ";
            cmd.Parameters.AddWithValue("@username", c.Username);
            return db.select(cmd);
        }

      



        public DataTable selectcustomerbyname(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblmaster where username=@username ";
            cmd.Parameters.AddWithValue("@username", c.Username);
            return db.select(cmd);
        }

        public void updteMaster(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblmaster set username=@username,address=@address,contactno=@contactno,accounttype=@accounttype,financialyear=@financialyear,startingamount=@startingamount,status=@status,closingamount=@closingamount,statusclosing=@statusclosing,adhar=@adhar,remarks=@remarks where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@username", c.Username);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@contactno", c.Contactno);
            cmd.Parameters.AddWithValue("@accounttype", c.Accounttype);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);
            cmd.Parameters.AddWithValue("@status", c.Status);
            //Closingamount,Statusclosing

            cmd.Parameters.AddWithValue("@closingamount", c.Closingamount);
            cmd.Parameters.AddWithValue("@statusclosing", c.Statusclosing);
       

                  cmd.Parameters.AddWithValue("@adhar", c.Adhars);
            cmd.Parameters.AddWithValue("@remarks", c.Remarks);
            db.insert(cmd);
        }

        public void insrtintoinstallmentcollection(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblinstallmentcollection(id,customername,mobile,collectiondate,amountcollectingnow,balanceamount,status,collectionid,financialyear,remarks,branch) values(@id,@customername,@mobile,@collectiondate,@amountcollectingnow,@balanceamount,@status,@collectionid,@financialyear,@remarks,@branch)";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@customername", c.Customername);
            cmd.Parameters.AddWithValue("@mobile", c.Phone);
      
                 cmd.Parameters.AddWithValue("@remarks", c.Remarks);
                cmd.Parameters.AddWithValue("@branch", c.Branch);
            cmd.Parameters.AddWithValue("@collectiondate", c.Collctiondate);
            cmd.Parameters.AddWithValue("@amountcollectingnow", c.Amountcollectingnow);
            cmd.Parameters.AddWithValue("@balanceamount", c.Balanceamount);
            cmd.Parameters.AddWithValue("@status", c.Status);
            cmd.Parameters.AddWithValue("@collectionid", c.Collctionid);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            db.insert(cmd);
        }



        public void updteBalance(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblmaster set startingamount=@startingamount where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);
               cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);
  
            //Closingamount,Statusclosing

            db.insert(cmd);
        }


        public void updteBalancebyname(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblmaster set startingamount=@startingamount where username=@username";
            cmd.Parameters.AddWithValue("@username", c.Username);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }





        public DataTable selectinstallmentdetails(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblinstallmentcollection where financialyear=@financialyear ORDER BY id DESC ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            return db.select(cmd);
        }

        public DataTable maxofcollection()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(collectionid) from tblinstallmentcollection";

            return db.select(cmd);
        }

        public void Deletecollection(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblinstallmentcollection where collectionid=@collectionid";
            cmd.Parameters.AddWithValue("@collectionid", c.Collctionid);
 
            //Closingamount,Statusclosing

            db.insert(cmd);
        }

        public DataTable SelectProductdetailsbyid(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblproduct where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            return db.select(cmd);
        }



        public void Deleteproduct(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblproduct where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }



        public void Deletemaster(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblmaster where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }


        public DataTable salesmaxid()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(salesno) from tblsalesvoucher";

            return db.select(cmd);
        }


        public DataTable Selectproductdetailsbyproductcode(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblproduct where productcode=@productcode";
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);
           
            return db.select(cmd);
        }



        public void insrtintosalesvoucher(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblsalesvoucher(salesno,id,customer,salesdate,productcode,productname,quantity,unit,price,discount,total,paymentmode,financialyear,narration,balance,status,grandtotal,discounttotal,nettotal,paid) values(@salesno,@id,@customer,@salesdate,@productcode,@productname,@quantity,@unit,@price,@discount,@total,@paymentmode,@financialyear,@narration,@balance,@status,@grandtotal,@discounttotal,@nettotal,@paid)";
            

            
            
                cmd.Parameters.AddWithValue("@salesno", c.Salesno);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@customer", c.Customer);

                cmd.Parameters.AddWithValue("@salesdate", c.Salesdate);
                cmd.Parameters.AddWithValue("@productcode", c.Productcode);
                cmd.Parameters.AddWithValue("@productname", c.Productname);
                cmd.Parameters.AddWithValue("@quantity", c.Quantity);
                cmd.Parameters.AddWithValue("@unit", c.Unit);

                cmd.Parameters.AddWithValue("@price", c.Price);
                cmd.Parameters.AddWithValue("@discount", c.Discount);
                cmd.Parameters.AddWithValue("@total", c.Total);
                cmd.Parameters.AddWithValue("@paymentmode", c.Paymentmode);
                cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
                cmd.Parameters.AddWithValue("@narration", c.Narration);
                cmd.Parameters.AddWithValue("@balance", c.Balance);
                cmd.Parameters.AddWithValue("@status", c.Status);
                cmd.Parameters.AddWithValue("@grandtotal", c.Grandtotal);
                cmd.Parameters.AddWithValue("@discounttotal", c.Discounttotal);
               cmd.Parameters.AddWithValue("@nettotal", c.Nettotal);
               cmd.Parameters.AddWithValue("@paid", c.Paid);
            db.insert(cmd);
        }






        public DataTable Selectsalesdetails(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select DISTINCT salesno,customer,salesdate,balance,grandtotal,discounttotal,nettotal,paid from tblsalesvoucher where financialyear=@financialyear ORDER BY salesno DESC";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            return db.select(cmd);
        }

        public void insrtintoincomeexpese(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblincomeandexpenses(id,incomeorexpense,financialyear,dateof,typeof,description,amount) values(@id,@incomeorexpense,@financialyear,@dateof,@typeof,@description,@amount)";
          
            
            
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@incomeorexpense", c.Incomeorexpence);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);

            cmd.Parameters.AddWithValue("@dateof", c.Collctiondate);
            cmd.Parameters.AddWithValue("@typeof", c.Typrofepnce);
            cmd.Parameters.AddWithValue("@description", c.Descrption);
            cmd.Parameters.AddWithValue("@amount", c.Amount);
  
            db.insert(cmd);
        }

        public DataTable incomemaxid()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(id) from tblincomeandexpenses";

            return db.select(cmd);
        }
        public DataTable Selecincomeexpense(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense ORDER BY id DESC ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@incomeorexpense", c.Typrofepnce);

            return db.select(cmd);
        }

        public void deleteintoincomeexpese(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblincomeandexpenses where id=@id";



            cmd.Parameters.AddWithValue("@id", c.Id);
          

            db.insert(cmd);
        }

      //  select sum(fee_collecting_now) from tbl_fee_collection where acadamic_year='" + acadamic_year + "'
        public DataTable selectsumincome(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@incomeorexpense", c.Typrofepnce);

            return db.select(cmd);
        }

        public DataTable selectsumexpense(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@incomeorexpense", c.Typrofepnce);


            return db.select(cmd);
        }
        public DataTable selectsumsale(containerclass c)
        {

      

            MySqlCommand cmd = new MySqlCommand();
           
            cmd.CommandText = " select sum(paid) from (select salesno,paid from tblsalesvoucher where financialyear=@financialyear  GROUP BY salesno) tbl";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);

            

            return db.select(cmd);
        }

        public DataTable selectsuminstallment(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amountcollectingnow) from  tblinstallmentcollection where financialyear=@financialyear";
          
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
          
            //cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";
       

            return db.select(cmd);
        }




        public DataTable Selecsaledetailforupdation(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsalesvoucher where financialyear=@financialyear and salesno=@salesno ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@salesno", c.Salesno);

            return db.select(cmd);
        }

        public void deleteisales(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblsalesvoucher where salesno=@salesno";


            cmd.Parameters.AddWithValue("@salesno", c.Salesno);


            db.insert(cmd);
        }




        public DataTable selectinstallmentbyname(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblinstallmentcollection where financialyear=@financialyear and branch=@branch ORDER BY id DESC ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@branch", c.Branch);
            return db.select(cmd);
        }

        public DataTable selectinstallmentbynameselct(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblinstallmentcollection where financialyear=@financialyear and customername=@customername ORDER BY id DESC ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@customername", c.Username);
            return db.select(cmd);
        }


        // profit and loss by date





        public DataTable selectsumincomedate(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and dateof>=@collectiondatefrom and dateof<=@collectiondateto";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@incomeorexpense", c.Typrofepnce);
            cmd.Parameters.AddWithValue("@collectiondatefrom", c.Collcndatefrom);
            cmd.Parameters.AddWithValue("@collectiondateto", c.Collcndateto);
         
            return db.select(cmd);
        }



        public DataTable selectexpensewisedate(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and dateof>=@collectiondatefrom and dateof<=@collectiondateto";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@incomeorexpense", c.Typrofepnce);
            cmd.Parameters.AddWithValue("@collectiondatefrom", c.Collcndatefrom);
            cmd.Parameters.AddWithValue("@collectiondateto", c.Collcndateto);
  
            return db.select(cmd);
        }
        
        public DataTable selectsuminstallmentsearch(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amountcollectingnow) from  tblinstallmentcollection where financialyear=@financialyear and collectiondate>=@collectiondatefrom and collectiondate<=@collectiondateto";
          
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@collectiondatefrom", c.Collcndatefrom);
            cmd.Parameters.AddWithValue("@collectiondateto", c.Collcndateto);
            //cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            return db.select(cmd);
        }

        public DataTable selectsupplierbynamesvalidaion(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier where username=@username ";
            cmd.Parameters.AddWithValue("@username", c.Username);
            return db.select(cmd);
        }


        public DataTable suppliersmaxid()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(id) from tblsupplier";

            return db.select(cmd);
        }


        public void inerttblsupplier(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblsupplier (id,username,address,contactno,accounttype,financialyear,startingamount,status,closingamount,statusclosing,adhar,remarks) values(@id,@username,@address,@contactno,@accounttype,@financialyear,@startingamount,@status,@closingamount,@statusclosing,@adhar,@remarks)";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@username", c.Username);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@contactno", c.Contactno);
            cmd.Parameters.AddWithValue("@accounttype", c.Accounttype);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);
            cmd.Parameters.AddWithValue("@status", c.Status);
            //Closingamount,Statusclosing

            cmd.Parameters.AddWithValue("@closingamount", c.Closingamount);
            cmd.Parameters.AddWithValue("@statusclosing", c.Statusclosing);



            cmd.Parameters.AddWithValue("@adhar", c.Adhars);
            cmd.Parameters.AddWithValue("@remarks", c.Remarks);

            db.insert(cmd);
        }


        public DataTable selectsupplierdetails()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier ORDER BY id DESC ";

            return db.select(cmd);
        }
        public void updtesupplierdetails(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblsupplier set username=@username,address=@address,contactno=@contactno,accounttype=@accounttype,financialyear=@financialyear,startingamount=@startingamount,status=@status,closingamount=@closingamount,statusclosing=@statusclosing,adhar=@adhar,remarks=@remarks where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@username", c.Username);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@contactno", c.Contactno);
            cmd.Parameters.AddWithValue("@accounttype", c.Accounttype);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);
            cmd.Parameters.AddWithValue("@status", c.Status);
            //Closingamount,Statusclosing

            cmd.Parameters.AddWithValue("@closingamount", c.Closingamount);
            cmd.Parameters.AddWithValue("@statusclosing", c.Statusclosing);


            cmd.Parameters.AddWithValue("@adhar", c.Adhars);
            cmd.Parameters.AddWithValue("@remarks", c.Remarks);
            db.insert(cmd);
        }

        public DataTable selectsupplierbyid(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier where id=@id ";
            cmd.Parameters.AddWithValue("@id", c.Id);
            return db.select(cmd);
        }
        public void Deletsupplier(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblsupplier where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }


        public DataTable selecttblinstallmentsupplierdetails()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier ORDER BY id DESC ";

            return db.select(cmd);
        }


        public DataTable selectsupplierrbyid(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier where id=@id ";
            cmd.Parameters.AddWithValue("@id", c.Id);
            return db.select(cmd);
        }
        public DataTable maxofsuppliercollection()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(collectionid) from tblinstallmentsupplier";

            return db.select(cmd);
        }


        public void insrtintoinstallmentcollectionsuppplier(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblinstallmentsupplier(id,customername,mobile,collectiondate,amountcollectingnow,balanceamount,status,collectionid,financialyear,remarks,branch) values(@id,@customername,@mobile,@collectiondate,@amountcollectingnow,@balanceamount,@status,@collectionid,@financialyear,@remarks,@branch)";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@customername", c.Customername);
            cmd.Parameters.AddWithValue("@mobile", c.Phone);

            cmd.Parameters.AddWithValue("@remarks", c.Remarks);
            cmd.Parameters.AddWithValue("@branch", c.Branch);
            cmd.Parameters.AddWithValue("@collectiondate", c.Collctiondate);
            cmd.Parameters.AddWithValue("@amountcollectingnow", c.Amountcollectingnow);
            cmd.Parameters.AddWithValue("@balanceamount", c.Balanceamount);
            cmd.Parameters.AddWithValue("@status", c.Status);
            cmd.Parameters.AddWithValue("@collectionid", c.Collctionid);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            db.insert(cmd);
        }

        public void updteBalancesuplier(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblsupplier set startingamount=@startingamount where id=@id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }



        public DataTable selectinstallmentdetailssupplier(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblinstallmentsupplier where financialyear=@financialyear ORDER BY id DESC ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            return db.select(cmd);
        }


        public DataTable selectinstallmentbysuppliernameselct(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblinstallmentsupplier where financialyear=@financialyear and customername=@customername ORDER BY id DESC ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@customername", c.Username);
            return db.select(cmd);
        }
        public DataTable selectsupplrbybynamesvalidaion(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier where username=@username ";
            cmd.Parameters.AddWithValue("@username", c.Username);
            return db.select(cmd);
        }


        public void updteBalancebysupliername(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblsupplier set startingamount=@startingamount where username=@username";
            cmd.Parameters.AddWithValue("@username", c.Username);
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }

        public void Deletecollectionsupplier(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblinstallmentsupplier where collectionid=@collectionid";
            cmd.Parameters.AddWithValue("@collectionid", c.Collctionid);

            //Closingamount,Statusclosing

            db.insert(cmd);
        }

        public void updateProductCreation(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
           // cmd.CommandText = "insert into tblproduct(id,productname,productcode,catogery,sellingprice,unit,gst,cgst,sgst,startingstock,financialyear,gstamount,barcodeno,closingstock) values(@id,@productname,@productcode,@catogery,@sellingprice,@unit,@gst,@cgst,@sgst,@startingstock,@financialyear,@gstamount,@barcodeno,@closingstock)";

            cmd.CommandText = "update tblproduct set productname=@productname,productcode=@productcode,catogery=@catogery,sellingprice=@sellingprice,unit=@unit,gst=@gst,cgst=@cgst,sgst=@sgst,startingstock=@startingstock,financialyear=@financialyear,gstamount=@gstamount,barcodeno=@barcodeno,closingstock=@closingstock where id=@id";
         
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@productname", c.Productname);
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);

            cmd.Parameters.AddWithValue("@sellingprice", c.Sellingprice);
            cmd.Parameters.AddWithValue("@catogery", c.Category);
            cmd.Parameters.AddWithValue("@unit", c.Unit);
            cmd.Parameters.AddWithValue("@gst", c.Gst);
            cmd.Parameters.AddWithValue("@cgst", c.Cgst);
            cmd.Parameters.AddWithValue("@sgst", c.Sgst);
            cmd.Parameters.AddWithValue("@startingstock", c.Stockstrt);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@gstamount", c.Gstamount);
            cmd.Parameters.AddWithValue("@barcodeno", c.Purchasedprice);

            cmd.Parameters.AddWithValue("@closingstock", c.Closingstock);
            db.insert(cmd);
        }


        public void updatestockonsale(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            // cmd.CommandText = "insert into tblproduct(id,productname,productcode,catogery,sellingprice,unit,gst,cgst,sgst,startingstock,financialyear,gstamount,barcodeno,closingstock) values(@id,@productname,@productcode,@catogery,@sellingprice,@unit,@gst,@cgst,@sgst,@startingstock,@financialyear,@gstamount,@barcodeno,@closingstock)";

            cmd.CommandText = "update tblproduct set startingstock=@startingstock where productname=@productname and productcode=@productcode";

     
            cmd.Parameters.AddWithValue("@productname", c.Productname);
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);

         
            cmd.Parameters.AddWithValue("@startingstock", c.Stockstrt);
           
            db.insert(cmd);
        }



        public void updteMasteronsales(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblmaster set startingamount=@startingamount where username=@username";
        
            cmd.Parameters.AddWithValue("@username", c.Username);
         
            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);
         
          
            db.insert(cmd);
        }


        public DataTable Selectsalesdetailsvustomerwise(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select DISTINCT salesno,customer,salesdate,balance,grandtotal,discounttotal,nettotal,paid from tblsalesvoucher where financialyear=@financialyear and customer=@customer ORDER BY salesno DESC";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@customer", c.Customer);
            return db.select(cmd);
        }
        public DataTable Selectsalesdetailsdatewise(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select DISTINCT salesno,customer,salesdate,balance,grandtotal,discounttotal,nettotal,paid from tblsalesvoucher where financialyear=@financialyear and salesdate=@salesdate ORDER BY salesno DESC";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@salesdate", c.Salesdate);
            return db.select(cmd);
        }


        public DataTable purchasemaxid()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select max(salesno) from tblpurchasevoucher";

            return db.select(cmd);
        }

        public DataTable selectsuplierdetails()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier ORDER BY id DESC ";

            return db.select(cmd);
        }


        public DataTable selectsupplierbynamesforpurchasevalidaion(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblsupplier where username=@username ";
            cmd.Parameters.AddWithValue("@username", c.Username);
            return db.select(cmd);
        }
        public void insrtintopurchasevoucher(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tblpurchasevoucher(salesno,id,customer,salesdate,productcode,productname,quantity,unit,price,discount,total,paymentmode,financialyear,narration,balance,status,grandtotal,discounttotal,nettotal,paid) values(@salesno,@id,@customer,@salesdate,@productcode,@productname,@quantity,@unit,@price,@discount,@total,@paymentmode,@financialyear,@narration,@balance,@status,@grandtotal,@discounttotal,@nettotal,@paid)";




            cmd.Parameters.AddWithValue("@salesno", c.Salesno);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@customer", c.Customer);

            cmd.Parameters.AddWithValue("@salesdate", c.Salesdate);
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);
            cmd.Parameters.AddWithValue("@productname", c.Productname);
            cmd.Parameters.AddWithValue("@quantity", c.Quantity);
            cmd.Parameters.AddWithValue("@unit", c.Unit);

            cmd.Parameters.AddWithValue("@price", c.Price);
            cmd.Parameters.AddWithValue("@discount", c.Discount);
            cmd.Parameters.AddWithValue("@total", c.Total);
            cmd.Parameters.AddWithValue("@paymentmode", c.Paymentmode);
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@narration", c.Narration);
            cmd.Parameters.AddWithValue("@balance", c.Balance);
            cmd.Parameters.AddWithValue("@status", c.Status);
            cmd.Parameters.AddWithValue("@grandtotal", c.Grandtotal);
            cmd.Parameters.AddWithValue("@discounttotal", c.Discounttotal);
            cmd.Parameters.AddWithValue("@nettotal", c.Nettotal);
            cmd.Parameters.AddWithValue("@paid", c.Paid);
            db.insert(cmd);
        }

        public void updatestockonpurchase(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            // cmd.CommandText = "insert into tblproduct(id,productname,productcode,catogery,sellingprice,unit,gst,cgst,sgst,startingstock,financialyear,gstamount,barcodeno,closingstock) values(@id,@productname,@productcode,@catogery,@sellingprice,@unit,@gst,@cgst,@sgst,@startingstock,@financialyear,@gstamount,@barcodeno,@closingstock)";

            cmd.CommandText = "update tblproduct set startingstock=@startingstock where productname=@productname and productcode=@productcode";


            cmd.Parameters.AddWithValue("@productname", c.Productname);
            cmd.Parameters.AddWithValue("@productcode", c.Productcode);


            cmd.Parameters.AddWithValue("@startingstock", c.Stockstrt);

            db.insert(cmd);
        }

        public void updtesupplierdetailsronpurchase(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblsupplier set startingamount=@startingamount where username=@username";

            cmd.Parameters.AddWithValue("@username", c.Username);

            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);


            db.insert(cmd);
        }
        public DataTable SelectPurchasedetailsall(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select DISTINCT salesno,customer,salesdate,balance,grandtotal,discounttotal,nettotal,paid from tblpurchasevoucher where financialyear=@financialyear ORDER BY salesno DESC";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            return db.select(cmd);
        }

        public DataTable Selectpurchasedetailssupplierwise(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select DISTINCT salesno,customer,salesdate,balance,grandtotal,discounttotal,nettotal,paid from tblpurchasevoucher where financialyear=@financialyear and customer=@customer ORDER BY salesno DESC";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@customer", c.Customer);
            return db.select(cmd);
        }


        public DataTable Selectpurchasedetailsdatewise(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select DISTINCT salesno,customer,salesdate,balance,grandtotal,discounttotal,nettotal,paid from tblpurchasevoucher where financialyear=@financialyear and salesdate=@salesdate ORDER BY salesno DESC";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@salesdate", c.Salesdate);
            return db.select(cmd);
        }

        public DataTable Selecspurchaseetailforupdation(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblpurchasevoucher where financialyear=@financialyear and salesno=@salesno ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@salesno", c.Salesno);

            return db.select(cmd);
        }

        public DataTable Selecpurchaseetailforupdation(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from tblpurchasevoucher where financialyear=@financialyear and salesno=@salesno ";
            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@salesno", c.Salesno);

            return db.select(cmd);
        }

        public void updtesupplierinpurchase(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tblsupplier set startingamount=@startingamount where username=@username";

            cmd.Parameters.AddWithValue("@username", c.Username);

            cmd.Parameters.AddWithValue("@startingamount", c.Startingamount);


            db.insert(cmd);
        }

        public void deletetblpurchasevouchers(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tblpurchasevoucher where salesno=@salesno";


            cmd.Parameters.AddWithValue("@salesno", c.Salesno);


            db.insert(cmd);
        }

        public DataTable selectsumpurchase(containerclass c)
        {



            MySqlCommand cmd = new MySqlCommand();
           // cmd.CommandText = "select sum(DISTINCT(paid)) as sumpaid from  tblpurchasevoucher where financialyear=@financialyear ";

            cmd.CommandText = "select sum(paid) from (select salesno,paid from tblpurchasevoucher where financialyear=@financialyear GROUP BY salesno) tbl";
      




            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);

            return db.select(cmd);
        }

        public DataTable selectsuminstallmentpurchase(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(amountcollectingnow) from  tblinstallmentsupplier where financialyear=@financialyear";

            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);

            //cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            return db.select(cmd);
        }


        public DataTable selectsumofcreditsales(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(startingamount) from  tblmaster where financialyear=@financialyear";

            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);

            //cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            return db.select(cmd);
        }



        public DataTable selectsumofcreditpurchase(containerclass c)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select sum(startingamount) from  tblsupplier where financialyear=@financialyear";

            cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);

            //cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            return db.select(cmd);
        }

         public DataTable selectsumsaleinbetweendates(containerclass c)
        {

      

            MySqlCommand cmd = new MySqlCommand();
            //cmd.CommandText = "select sum(DISTINCT(paid)) as sumpaid from  tblsalesvoucher where financialyear=@financialyear and salesdate>=@salesdatedatefrom and salesdate<=@salesdateteto  ";
            cmd.CommandText = "select sum(paid) from (select salesno,paid from tblsalesvoucher where financialyear=@financialyear and salesdate>=@salesdatedatefrom and salesdate<=@salesdateteto  GROUP BY salesno) tbl";
           
             
             cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
            cmd.Parameters.AddWithValue("@salesdatedatefrom", c.Collcndatefrom);
            cmd.Parameters.AddWithValue("@salesdateteto", c.Collcndateto);
            return db.select(cmd);




        }


         public DataTable selectsuminstallmentsearchsupplier(containerclass c)
         {
             MySqlCommand cmd = new MySqlCommand();
             cmd.CommandText = "select sum(amountcollectingnow) from  tblinstallmentsupplier where financialyear=@financialyear and collectiondate>=@collectiondatefrom and collectiondate<=@collectiondateto";

             cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
             cmd.Parameters.AddWithValue("@collectiondatefrom", c.Collcndatefrom);
             cmd.Parameters.AddWithValue("@collectiondateto", c.Collcndateto);
             //cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


             return db.select(cmd);
         }

         public DataTable selectsumpurchaseinbetweendates(containerclass c)
         {



             MySqlCommand cmd = new MySqlCommand();
           
             cmd.CommandText = "select sum(paid) from (select salesno,paid from tblpurchasevoucher where financialyear=@financialyear and salesdate>=@salesdatedatefrom and salesdate<=@salesdateteto GROUP BY salesno) tbl";

             
             cmd.Parameters.AddWithValue("@financialyear", c.Financialyear);
             cmd.Parameters.AddWithValue("@salesdatedatefrom", c.Collcndatefrom);
             cmd.Parameters.AddWithValue("@salesdateteto", c.Collcndateto);
             return db.select(cmd);
         }



         public DataTable Selectproductdetailsbyproductnameandcode(containerclass c)
         {
             MySqlCommand cmd = new MySqlCommand();
             cmd.CommandText = "select * from tblproduct where productname=@productname OR productcode=@productcode";
             cmd.Parameters.AddWithValue("@productname", c.Productname);
             cmd.Parameters.AddWithValue("@productcode", c.Productcode);
             return db.select(cmd);
         }

    }
}
