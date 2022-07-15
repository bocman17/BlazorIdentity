using BlazorIdentity.Shared;
using Microsoft.AspNetCore.Identity;

namespace BlazorIdentity.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Superhero> Superheroes { get; set; } = new List<Superhero>();
    }
}