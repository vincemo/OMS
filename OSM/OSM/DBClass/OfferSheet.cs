using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSM.DBClass
{
    class OfferSheet
    {
        private int ID;
        private string OFFERSHEET_CODE;
        private int GMF_ID;
        private int BJF_ID;
        private string OFFERSHEET_TYPE;
        private string OFFERSHEET_STATE;
        private string OFFERSHEET_DATE;
        private string OFFERSHEET_REGION;
        private string CONFIRM_DATE;

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

        public int getGMF_ID()
        {
            return GMF_ID;
        }

        public void setGMF_ID(int gmf_id)
        {
            GMF_ID = gmf_id;
        }

        public int getBJF_ID()
        {
            return BJF_ID;
        }

        public void setBJF_ID(int bjf_id)
        {
            BJF_ID = bjf_id;
        }

        public string getOFFERSHEET_TYPE()
        {
            return OFFERSHEET_TYPE;
        }

        public void setOFFERSHEET_TYPE(string offersheet_type)
        {
            OFFERSHEET_TYPE = offersheet_type;
        }

        public string getOFFERSHEET_STATE()
        {
            return OFFERSHEET_STATE;
        }

        public void setOFFERSHEET_STATE(string offersheet_state)
        {
            OFFERSHEET_STATE = offersheet_state;
        }

        public string getOFFERSHEET_DATE()
        {
            return OFFERSHEET_DATE;
        }

        public void setOFFERSHEET_DATE(string offersheet_date)
        {
            OFFERSHEET_DATE = offersheet_date;
        }

        public string getOFFERSHEET_REGION()
        {
            return OFFERSHEET_REGION;
        }

        public void setOFFERSHEET_REGION(string offersheet_region)
        {
            OFFERSHEET_REGION = offersheet_region;
        }

        public string getCONFIRM_DATE()
        {
            return CONFIRM_DATE;
        }

        public void setCONFIRM_DATE(string confirm_date)
        {
            CONFIRM_DATE = confirm_date;
        }
    }
}
