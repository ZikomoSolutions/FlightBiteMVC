﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
    public interface IClientTerms
    {
        List<ClientTermsModel> SaveSelectedTerms(List<ClientTermsModel> terms);
    }
}
