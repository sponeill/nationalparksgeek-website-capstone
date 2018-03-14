﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NPGeek.Web.Models;

namespace NPGeek.Web.DAL
{
    public interface IForecastDAL
    {
        List<ForecastModel> GetForecasts(string parkCode);
        //bool SaveSurvey();

    }
}