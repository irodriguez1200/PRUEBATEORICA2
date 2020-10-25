using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRUEBATEORICA2.Data;
using PRUEBATEORICA2.Models;

namespace PRUEBATEORICA2.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly PRUEBATEORICA2.Data.PRUEBATEORICA2Context _context;

        public IndexModel(PRUEBATEORICA2.Data.PRUEBATEORICA2Context context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Name { get; set; }
             
        public async Task OnGetAsync()
        {
            var employees = from m in _context.Employee
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                employees = employees.Where(s => s.Name.Contains(SearchString));                
            }
            IQueryable<string> nameQuery = from m in _context.Employee
                                            orderby m.Name
                                            select m.Name;
            Name = new SelectList(await nameQuery.Distinct().ToListAsync());
            Employee = await employees.ToListAsync();
            //Employee = await _context.Employee.ToListAsync();
        }
    }
}
