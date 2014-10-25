using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSM.DBClass
{
    class OrderSheet
    {
        private int ID;
        private int OFFERSHEET_ID;
        private string ORDER_STATE;
        private string PAY_MODE;
        private string PAY_STATE;
        private double ALREADY_PAYMENT;
        private double PRE_PAYMENT;
        private double REQUIRE_PAYMENT;

        public double getREQUIRE_PAYMENT()
        {
            return REQUIRE_PAYMENT;
        }

        public void setREQUIRE_PAYMENT(double require_payment)
        {
            REQUIRE_PAYMENT = require_payment;
        }

        public double getPRE_PAYMENT()
        {
            return PRE_PAYMENT;
        }

        public void setPRE_PAYMENT(double pre_payment)
        {
            PRE_PAYMENT = pre_payment;
        }

        public double getALREADY_PAYMENT()
        {
            return ALREADY_PAYMENT;
        }

        public void setALREADY_PAYMENT(double already_payment)
        {
            ALREADY_PAYMENT = already_payment;
        }

        public string getPAY_STATE()
        {
            return PAY_STATE;
        }

        public void setPAY_STATE(string pay_state)
        {
            PAY_STATE = pay_state;
        }

        public string getPAY_MODE()
        {
            return PAY_MODE;
        }

        public void setPAY_MODE(string pay_mode)
        {
            PAY_MODE = pay_mode;
        }

        public string getORDER_STATE()
        {
            return ORDER_STATE;
        }

        public void setORDER_STATE(string order_state)
        {
            ORDER_STATE = order_state;
        }

        public int getOFFERSHEET_ID()
        {
            return OFFERSHEET_ID;
        }

        public void setOFFERSHEET_ID(int offersheet_id)
        {
            OFFERSHEET_ID = offersheet_id;
        }

        public int getID()
        {
            return ID;
        }

        public void setID(int id)
        {
            ID = id;
        }
    }
}
