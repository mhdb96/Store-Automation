﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mycon = MySql.Data.MySqlClient.MySqlConnection;
using Myad = MySql.Data.MySqlClient.MySqlDataAdapter;
using Mycom = MySql.Data.MySqlClient.MySqlCommand;


namespace VTYS_Mobilay_Magazasi

{
    class Products
    {
        public string id;
        public string name;
        public string desc;
        public string price;
        public string stock;
        public string set_id;
        public string[] attribute_id;
        public string[] attribute_name;
        public string[] att_val_id;
        public int count;

        public void setArrayslength()
        {
            attribute_id = new string[count];
            attribute_name = new string[count];
            att_val_id = new string [count];

        }

        public void setAttVal(string[] nattVa, int ct)
        {
            att_val_id = new string[ct];
            for (int i = 0; i < ct; i++)
            {
                att_val_id[i] = nattVa[i];
            }
        }

    }
}
