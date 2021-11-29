using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos
{
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value.Equals(String.Empty))
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

    }
}
