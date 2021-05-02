using System;
using System.Collections.Generic;
using System.Text;

namespace DMR_Contact_List_Generator
{
    public class Model
    {
        public class DMRFile
        {
            public int count;
            public DMRContact[] results;
        }
        public class DMRContact
        {
            public String callsign;
            public String city;
            public String country;
            public String state;
            public String fname;
            public String surname;
            public int id;
            public String remarks;
        }
        public class RadioClass
        {
            public class DM1701
            {
                public int RadioID;
                public String Callsign;
                public String Name;
                public String NickName;
                public String City;
                public String State;
                public String Country;
            }
        }
    }
}
