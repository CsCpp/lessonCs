﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonCs
{
    public class MyParser
    {
        public int TryCathParse(string str)
        {
            int result;
            try
            {
                result = int.Parse(str);
            }
            catch(Exception ex)
            {
                result = 0;
            }
            return result;
        }
        public int TryParse(string str)
        {

            int result;
            if (!int.TryParse(str, out result))
            {
                result = 0;
            }
            return result;
        }
    }
}
