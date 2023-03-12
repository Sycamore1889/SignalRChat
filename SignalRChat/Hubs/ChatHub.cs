
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub :Hub
    {
        public string? Patient { get; set; }
        public async Task SendMyVariable(string myVariable)
        {
            Console.WriteLine(myVariable);
            await Clients.All.SendAsync("MyVariableReceived");
            Console.WriteLine(myVariable);
            Patient = myVariable;
        }
    }
}
