using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

public class Movie
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Movie name is required.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Movie genre is required.")]
    [MaxLength(50, ErrorMessage = "Movie genre can't have more than 50 characters.")]
    public string Genre { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "Movie duration must be between 70 and 600 minutes.")]
    public int RunningTime { get; set; }  
}
