﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;
using ihff.Models;

namespace ihff.Controllers
{
    public class AgendaBlokkenController : Controller
    {
        //
        // GET: /AgendaBlokken/

        
        private DbRepository repository = new DbRepository();

        public ActionResult Index()
        {
            IEnumerable<Activiteit> activities = repository.GetActivities();
            //IEnumerable<string> allLocations;
            Activitieswednesday activitieswednesday = new Activitieswednesday( 
                activities);
            Wishlist wishlist = repository.GetAllWishlists().First();
            Activiteit actvities = repository.GetActivities().First();
            return View(activitieswednesday);


        }

    }
}