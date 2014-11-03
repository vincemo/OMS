using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSM.DBClass
{
    class HW
    {
        private int ID;
        private string OFFERSHEET_CODE;
        private int PRODUCT_ID;
        //private string HW_TYPE;
        //private string HW_NAME;
        //private string HW_CODE;
        private int HW_NUMBER;
        private double HW_PRICE;
        private double HW_TOTALPRICE;
        private string COMMENT;

        public int getID()
        {
            return ID;
        }

        public void setID(int id)
        {
            ID = id;
        }

        public string getOFFERSHEET_CODE()
        {
            return OFFERSHEET_CODE;
        }

        public void setOFFERSHEET_CODE(string offersheet_code)
        {
            OFFERSHEET_CODE = offersheet_code;
        }

        public int getPRODUCT_ID()
        {
            return PRODUCT_ID;
        }

        public void setPRODUCT_ID(int product_id)
        {
            PRODUCT_ID = product_id;
        }

        /*public string getHW_TYPE()
        {
            return HW_TYPE;
        }

        public void setHW_TYPE(string hw_type)
        {
            HW_TYPE = hw_type;
        }

        public string getHW_NAME()
        {
            return HW_NAME;
        }

        public void setHW_NAME(string hw_name)
        {
            HW_NAME = hw_name;
        }

        public string getHW_CODE()
        {
            return HW_CODE;
        }

        public void setHW_CODE(string hw_code)
        {
            HW_CODE = hw_code;
        }*/

        public int getHW_NUMBER()
        {
            return HW_NUMBER;
        }

        public void setHW_NUMBER(int hw_number)
        {
            HW_NUMBER = hw_number;
        }

        public double getHW_PRICE()
        {
            return HW_PRICE;
        }

        public void setHW_PRICE(double hw_price)
        {
            HW_PRICE = hw_price;
        }

        public double getHW_TOTALPRICE()
        {
            return HW_TOTALPRICE;
        }

        public void setHW_TOTALPRICE(double hw_totalprice)
        {
            HW_TOTALPRICE = hw_totalprice;
        }

        public string getCOMMENT()
        {
            return COMMENT;
        }

        public void setCOMMENT(string comment)
        {
            COMMENT = comment;
        }
    }
}
