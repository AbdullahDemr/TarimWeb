﻿using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext c = new AgricultureContext();
            var values = c.TopAnnouncements.ToList();
            return View(values);
        }
    }
}