using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGL.WebApp.Data;
using TGL.WebApp.Models;

namespace TGL.WebApp.Pages.Computers
{
    public class indexModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        public List<Computer> Computers { get; set; }
        public indexModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
            Computers = computerStore.GetComputer();
        }
        public ActionResult OnPostDelete(Guid id)
        {
            ComputerStore.DeleteComputer(id);
            return RedirectToPage();
        }
        public void OnGet()
        {

        }
    }
}