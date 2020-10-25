﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PRUEBATEORICA2.Data;
using PRUEBATEORICA2.Models;

namespace PRUEBATEORICA2.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly PRUEBATEORICA2.Data.PRUEBATEORICA2Context _context;

        public DetailsModel(PRUEBATEORICA2.Data.PRUEBATEORICA2Context context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.ID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
