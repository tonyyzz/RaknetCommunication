using RakNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknetCommunication.SwigRaknetCS
{
    public class SwigRaknetCSPreInit
    {
        public static bool JudgeRaknetRun(out string errorMsg)
        {
            errorMsg = "";
            bool flag = false;
            if (!File.Exists("RakNet.dll"))
            {
                string str = "The SWIG build of the DLL has not been copied to the executable directory\nCopy from Swig/SwigWindowsCSharpSample/SwigTestApp/bin/X86/Debug/RakNet.dll to\nSwigWindowsCSharpSample/SwigTestApp/bin/Debug/RakNet.dll\nPress enter to quit.";
                errorMsg = str;
                //Console.WriteLine(str);
                //Debug.WriteLine(str);
                return flag;
            }
            try
            {
                RakString dllCallTest = new RakString();
            }
            catch (Exception e)
            {
                string str = "DLL issue\nAdd SwigOutput/CplusDLLIncludes/RakNetWrap.cxx to the project\nDLL_Swig/RakNet.sln and rebuild.\nPress enter to quit.";
                errorMsg = str;
                //Console.WriteLine(str);
                //Debug.WriteLine(str);
                return flag;
            }
            return true;
        }
    }
}
