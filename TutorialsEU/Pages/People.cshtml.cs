using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutorialsEU.Models;

namespace TutorialsEU.Pages
{
    public class PeopleModel : PageModel
    {
     Å@private readonly MyDBcontext _context;

        public List<Person> People { get; set; }=new List<Person>();    

        [BindProperty]
        public Person NewPerson { get; set; }   

        //ctor
        public PeopleModel(MyDBcontext context)
        {
            _context= context;


        }

        public void OnGet()
        {
            People= _context.People.ToList();
        }

        public IActionResult OnPost()
        {
            _context.People.Add(NewPerson);
            _context.SaveChanges();

            return RedirectToPage();

        }



    }
}
