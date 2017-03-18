using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AVRDUDE.NET
{
    public class Avrdude
    {
        private string exe_path;

        /// <summary>
        ///     
        /// </summary>
        /// <param name="path">The path to the avrdude executable.</param>
        public Avrdude(string path)
        {
            if(!File.Exists(path))
            {
                throw new FileNotFoundException("Executable " + path + " was not found!");
            }
            exe_path = path;
        }



        public static Avrdude autodetect_path()
        {
            var path = "";
            return new Avrdude("");
        }


        private string run(string args)
        {
            var pi = new ProcessStartInfo(exe_path);
            Process.Start()
        }


    }
}
