using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMerkData
{
    public class MasterMerk
    {
        private int id;
        private string merk_code;
        private string merk_desc;

        public int Id
        {
            get
            {
                return  id;
            }
            set
            {
                id = value;
            }
        }

        public string Merk_code
        {
            get
            {
                return merk_code;
            }
            set
            {
                merk_code = value;
            }
        }

        public string Merk_desc
        {
            get
            {
                return merk_desc;
            }
            set
            {
                merk_desc = value;
            }
        }
    }
}
