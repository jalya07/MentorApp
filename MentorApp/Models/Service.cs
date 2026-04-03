namespace MentorApp.Models;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<PricingService> PricingServices { get; set; }= new List<PricingService>();
    
}