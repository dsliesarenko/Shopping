﻿namespace Shopping.Client.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string? Description { get; set; }

        public string? ImageFile { get; set; }

        public decimal? Price { get; set; }
    }
}
