using MongoDB.AspNet.Identity;

namespace Chess.UI.WebUI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}