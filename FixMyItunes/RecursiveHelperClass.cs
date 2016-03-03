using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FixMyItunes
{
    class RecursiveHelperClass
    {

        private void InitialList(string fp)
        {
            string p = fp;

            foreach(string f in Directory.GetFiles(fp))
            {
                
            }
        }
    }
}
