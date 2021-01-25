using sb_admin_2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sb_admin_2.Web.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> navbarItems()
        {
            var menu = new List<Navbar>();
            menu.Add(new Navbar { Id = 1, nameOption = "Dashboard", controller = "Home", action = "Index", imageClass = "fa fa-dashboard fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 2, nameOption = "General Information", imageClass = "fa fa-bar-chart-o fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 3, nameOption = "Mission & Vission", controller = "Home", action = "MissionandVission", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 4, nameOption = "Core Values", controller = "Home", action = "CoreValues", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 5, nameOption = "University Calendar ", controller = "Home", action = "UniversityCalendar", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 6, nameOption = "University Hymn ", controller = "Home", action = "UniversityHymn", status = true, isParent = false, parentId = 2 });

            menu.Add(new Navbar { Id = 7, nameOption = "Campuses", controller = "Home", action = "Campuses", imageClass = "fa fa-table fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 8, nameOption = "San Bartolome ", controller = "Home", action = "SanBartolome", status = true, isParent = false, parentId = 7 });
            menu.Add(new Navbar { Id = 9, nameOption = "Batasan ", controller = "Home", action = "Batasan", status = true, isParent = false, parentId = 7 });
            menu.Add(new Navbar { Id = 10, nameOption = "San Francisco ", controller = "Home", action = "SanFrancisco", status = false, isParent = false, parentId = 7 });

            menu.Add(new Navbar { Id = 11, nameOption = "Records", controller = "Home", action = "Forms", imageClass = "fa fa-edit fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 12, nameOption = "List of Students", controller = "Home", action = "TranscriptOfRecord", status = false, isParent = false, parentId = 11 });
            menu.Add(new Navbar { Id = 13, nameOption = "Downloadable forms ", controller = "Home", action = "DownloadableForms", status = false, isParent = false, parentId = 11 });

            menu.Add(new Navbar { Id = 14, nameOption = "Pages", imageClass = "fa fa-wrench fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 15, nameOption = "Login", controller = "Home", action = "Login", status = true, isParent = false, parentId = 14 });
            menu.Add(new Navbar { Id = 16, nameOption = "Register", controller = "Home", action = "Register", status = true, isParent = false, parentId = 14 });
            menu.Add(new Navbar { Id = 17, nameOption = "Forgot Password", controller = "Home", action = "ForgotPassword", status = true, isParent = false, parentId = 14 });

            menu.Add(new Navbar { Id = 18, nameOption = "Grades", imageClass = "fa fa-sitemap fa-fw", status = true, isParent = true, parentId = 0 });
           

            return menu.ToList();
        }
    }
}