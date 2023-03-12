using Microsoft.AspNetCore.Mvc.RazorPages;
using SignalRChat.Hubs;

namespace SignalRChat.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string Patient_JS { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            var JSItem = new ChatHub();
            if (JSItem == null) { Patient_JS = "EMPTY String"; }
            else { Patient_JS = JSItem.Patient; }


        }

        public void OnPost()
        {
            var JSItem = new ChatHub();
            if (JSItem == null) { Patient_JS = "EMPTY String"; }
            else { Patient_JS = JSItem.Patient; }
        }
    }
}