using BlazorFilmy.Components.Pages;
using System;
using System.ComponentModel.DataAnnotations;
namespace BlazorFilmy.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? ReleaseDate { get; set; }
        public double? Rate { get; set; }
        public List<double>? Ratings { get; set; }  // Lista do ocen, żeby łatwiej liczyć ich ilość i średnią
        public string? ImageUrl { get; set; } // Dodajemy właściwość ImageUrl do przechowywania adresu URL obrazka

        public Movie()
        {
            Ratings = new List<double>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}\t, Description: {Description}, ReleaseDate: {ReleaseDate}, Rate: {Rate}, ImageUrl: {ImageUrl}";
        }
    }
}
