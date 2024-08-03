using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDwithRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentDate { get; set; }
        public string CurrentTime { get; set; }

        public void OnGet()
        {
            CurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
            CurrentTime = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
