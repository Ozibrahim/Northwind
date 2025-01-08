using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Utility
{
    public static class RandomValueGenerator
    {
        public static string RandomFileGenerator(string extension) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Guid.NewGuid().ToString().Replace("-",""));
            sb.Append("_");
            sb.Append(DateTime.Now.Ticks);
            sb.Append(extension);
           
            return sb.ToString();
        }
    }
}
