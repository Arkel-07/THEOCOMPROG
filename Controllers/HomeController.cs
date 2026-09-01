using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using THEOCOMPROG.Models;

namespace THEOCOMPROG.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Members = new List<MemberModel>
                {
                    new MemberModel { Name = "Antonio, Miles Ivan", ShortName = "Miles", ImageFileName = "Milesresume.png" },
                    new MemberModel { Name = "Cruz, Glenard", ShortName = "Glenard", ImageFileName = "Glenardresume.png" },
                    new MemberModel { Name = "Cadilig, Paul Mckaizzer", ShortName = "Paul", ImageFileName = "Paulresume.png" },
                    new MemberModel { Name = "Delos Santos, Patrick Jace", ShortName = "Jace", ImageFileName = "Jaceresume.png" },
                    new MemberModel { Name = "Itchon, Antonio Lorenzo", ShortName = "Al", ImageFileName = "Alresume.png" },
                    new MemberModel { Name = "Pelobello, Travis", ShortName = "Travis", ImageFileName = "Travisresume.png" },
                    new MemberModel { Name = "Mendoza Jr., Ronnelio", ShortName = "JJ", ImageFileName = "JJresume.png" },
                    new MemberModel { Name = "Maclang, Josiah", ShortName = "Josiah", ImageFileName = "Josiahresume.png" },
                    new MemberModel { Name = "Polintan, Zandher", ShortName = "Zandher", ImageFileName = "Zandherresume.png" },
                    new MemberModel { Name = "Reyes, Angela", ShortName = "Angela", ImageFileName = "Angelaresume.png" },
                    new MemberModel { Name = "Ramos, Arquel", ShortName = "Arquel", ImageFileName = "Arquelresume.png" },
                    new MemberModel { Name = "Rubiano, Prince Niño", ShortName = "Prince", ImageFileName = "Princeresume.png" },
                    new MemberModel { Name = "Tarol, Timothy John", ShortName = "TeeJay", ImageFileName = "TeeJayresume.png" }
                }
            };

            return View(viewModel);
        }
    }
}