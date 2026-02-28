using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplicationAPP.Models;
using WebApplicationAPP.Servicios;

namespace WebApplicationAPP.Views.Laboratorios
{
    public class IndexModel : PageModel
    {

        private readonly InMemoryRepository _repository;

        public List<Laboratorio> Laboratorios { get; set; }

        public IndexModel()
        {
            _repository = new InMemoryRepository();
        }

        public void OnGet()
        {
            Laboratorios = _repository.GetLaboratorios();
        }

        public IActionResult OnPost(string Name, int Capacity, string Responsible)
        {
            var lab = new Laboratorio
            {
                Name = Name,
                Capacity = Capacity,
                Responsible = Responsible
            };

            _repository.AddLaboratorio(lab);

            return RedirectToPage();

        }

        public IActionResult OnPostDelete(int id)
        {
            _repository.DeleteLaboratorio(id);

            return RedirectToPage();
        }


    }
}