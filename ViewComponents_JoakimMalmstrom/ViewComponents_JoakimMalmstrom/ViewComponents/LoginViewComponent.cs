using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents_JoakimMalmstrom.Data;

namespace ViewComponents_JoakimMalmstrom.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
        private readonly ViewComponents_JoakimMalmstromContext db;

        public LoginViewComponent(ViewComponents_JoakimMalmstromContext db)
        {
            this.db = db;
        }


    }
}
