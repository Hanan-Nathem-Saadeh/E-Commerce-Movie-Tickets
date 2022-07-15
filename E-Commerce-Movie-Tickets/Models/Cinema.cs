﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Movie_Tickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Relationships
        public List<Movie> Movies { get; set; }

    }
}
