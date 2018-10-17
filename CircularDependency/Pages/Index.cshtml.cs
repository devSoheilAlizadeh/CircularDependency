using CircularDependency.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CircularDependency.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IAService aservice)
        {

        }

        public void OnGet()
        {

        }
    }
}
