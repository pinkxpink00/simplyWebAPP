using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class PlaceHolderItem
{
    [Required]
    public string? Description { get; set; }
    
    [Required]
    public string? ImageUrl { get; set; }
    
    [Required]
    public DateTime Date {get;set;}
}