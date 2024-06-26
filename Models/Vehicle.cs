using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using team_stranger_strings_backend.Models;

namespace team_stranger_strings_backend.Models;

public class Vehicle 
{
    public int VehicleId { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Colour { get; set; }
    public string? Photo { get; set; }
    public int Price { get; set; }

    public User? User { get; set; }

    public int? UserId { get; set; }
    public string? UserEmail { get; set; }
}