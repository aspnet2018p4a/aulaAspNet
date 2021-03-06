﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;
using Microsoft.AspNetCore.Http;

namespace WebApplication4.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication4.Models.WebApplication4Context _context;

        public IndexModel(WebApplication4.Models.WebApplication4Context context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
            ViewData["usuarioNome"] = HttpContext.Session.GetString("usuarioNome");
        }
    }
}
