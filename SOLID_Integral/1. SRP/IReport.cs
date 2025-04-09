﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Integral
{
    /// <summary>
    /// 1. Aplicamos el principio SRP serapando las responsabilidades en diferentes clases
    /// </summary>
    public interface IReport
    {
        void GenerateReport();

    }
}
