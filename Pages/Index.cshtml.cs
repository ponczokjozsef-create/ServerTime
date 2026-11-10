using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerTime.Pages
{
    public class IndexModel : PageModel
    {
        public string ServerTime { get; set; } = "";

        // Runs when the page loads
        public void OnGet()
        {
            ServerTime = DateTime.Now.ToString();
        }

        // Runs when the "Refresh Time" button is clicked
        public void OnPost()
        {
            ServerTime = DateTime.Now.ToString();
        }
    }
}