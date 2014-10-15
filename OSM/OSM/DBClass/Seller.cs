using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSM.DBClass
{
    class Seller
    {
        private int ID;
        private string COM_NAME;
        private string ADDR;
        private string CONTACT;
        private string PHONE;
        private string ZIP_CODE;
        private string EMAIL;
        private string FAX;
        private string COMMENT;

        public void setID(int id) 
        {
            ID = id;
        }

        public int getID()
        {
            return ID;
        }

        public void setCOM_NAME(string com_name)
        {
            COM_NAME = com_name;
        }

        public string getCOM_NAME()
        {
            return COM_NAME;
        }

        public void setADDR(string addr)
        {
            ADDR = addr;
        }

        public string getADDR()
        {
            return ADDR;
        }

        public void setCONTACT(string contact)
        {
            CONTACT = contact;
        }

        public string getCONTACT()
        {
            return CONTACT;
        }

        public void setPHONE(string phone)
        {
            PHONE = phone;
        }

        public string getPHONE()
        {
            return PHONE;
        }

        public void setZIP_CODE(string zip_code)
        {
            ZIP_CODE = zip_code;
        }

        public string getZIP_CODE()
        {
            return ZIP_CODE;
        }

        public void setEMAIL(string email)
        {
            EMAIL = email;
        }

        public string getEMAIL()
        {
            return EMAIL;
        }

        public void setFAX(string fax)
        {
            FAX = fax;
        }

        public string getFAX()
        {
            return FAX;
        }

        public void setCOMMENT(string comment)
        {
            COMMENT = comment;
        }

        public string getCOMMENT()
        {
            return COMMENT;
        }
    }
}
