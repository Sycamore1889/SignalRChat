using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System.Runtime.CompilerServices;

namespace SignalRChat.Pages
{
    
    public class PatientModel : PageModel
    {
        private const string _fireServer = "https://launch.smarthealthit.org";

        public string patA { get; set; }
        public void OnGet()
        {

            FhirClient fhirClient = new FhirClient(_fireServer);
            fhirClient.Settings.PreferredFormat = ResourceFormat.Json;
            var pat_A = fhirClient.Read<Patient>("Patient/");
            
        }
    }
}
