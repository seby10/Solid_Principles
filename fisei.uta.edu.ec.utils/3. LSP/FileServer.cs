﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fisei.uta.edu.ec.utils.ISP;

namespace fisei.uta.edu.ec.utils.LSP
{
    public class FileServer : IFileServer
    {
        /// <summary>
        /// 3. Aplication of the LSP: For each sublass (inheritance or implementation),
        /// the principle stil works withouth breaking the expected behaviour 
        /// </summary>
        public void SaveToFile()
        {
            Console.WriteLine("Saving report in a file...");
        }
    }
}
