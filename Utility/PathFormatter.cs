using System;
using System.IO;
using System.Collections.Generic;

namespace ImageShifter
{
    class PathFormatter
    {
        public static IList<String> listFilename(IList<String> aszFullPath)
        {
            IList<String> aszFilename = new List<String>();
            foreach (String szCurFullPath in aszFullPath)
            {
                aszFilename.Add(Path.GetFileName(szCurFullPath));
            }
            return aszFilename;
        }
    }
}