using System.IO;

namespace WindowsFormsApplication3
{
    public static class GetPaths
    {
        public static ProcessInfor getPathByProcessName(string name)
        {
            ProcessInfor pxi;
            System.Diagnostics.Process[] p;
            p = System.Diagnostics.Process.GetProcessesByName(name);
            if (p.Length < 1)
            {
                pxi.processPath = "Program not open";
                pxi.bsucc = false;
            }
            else
            {
                pxi.processPath = Path.GetDirectoryName(p[0].MainModule.FileName);
                pxi.bsucc = true;
            }

            return pxi;
        }
    }

    public struct ProcessInfor
    {
        public string processPath;
        public bool bsucc;
    }
}
