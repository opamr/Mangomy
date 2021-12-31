using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public static class GlobalVar
    {
        /// <summary>
        /// Global variable that is constant.
        /// </summary>
        public const string GlobalString = "Important Text";

        //public const string MyAllPath = "D:\\";
        //public const string MyEmptyImagePath = "D:\\EmptyMan.jpg";

        public const string MyAllPath = "D:\\FCSS Program\\";
        public const string MyEmptyImagePath = "D:\\FCSS Program\\EmptyMan.jpg";


        /// <summary>
        /// Static value protected by access routine.
        /// </summary>
        static int _bill_id;
        static int _order_id;
        static int _Customer_bill;
        static int _Vendor_ID;
        static int _user_Id;
        static int _Customer_Id;
        static int _title_Id;
        static string _Customer_Name;
        static string _Vendor_Name;


        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int Customer_bill
        {
            get
            {
                return _Customer_bill;
            }
            set
            {
                _Customer_bill = value;
            }
        }
        //-------------------------------------------------
        public static int title_Id
        {
            get
            {
                return _title_Id;
            }
            set
            {
                _title_Id = value;
            }
        }
        //-------------------------------------------------
        public static int order_id
        {
            get
            {
                return _order_id;
            }
            set
            {
                _order_id = value;
            }
        }
        //---------------------------------------------------
        public static int bill_id
        {
            get
            {
                return _bill_id;
            }
            set
            {
                _bill_id = value;
            }
        }

        public static int user_Id
        {
            get
            {
                return _user_Id;
            }
            set
            {
                _user_Id = value;
            }
        }

        public static int Customer_Id
        {
            get
            {
                return _Customer_Id;
            }
            set
            {
                _Customer_Id = value;
            }
        }
        //--------------
        public static string Vendor_Name
        {
            get
            {
                return _Vendor_Name;
            }
            set
            {
                _Vendor_Name = value;
            }
        }

        //--------------
        public static string Customer_Name
        {
            get
            {
                return _Customer_Name;
            }
            set
            {
                _Customer_Name = value;
            }
        }

        //-------------------------
        //--------------
        public static int Vendor_ID
        {
            get
            {
                return _Vendor_ID;
            }
            set
            {
                _Vendor_ID = value;
            }
        }

    }
}
