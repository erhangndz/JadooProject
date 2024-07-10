﻿namespace JadooProject.Features.CQRS.Commands
{
    public class CreateDestinationCommand
    {
        public string ImageUrl { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }

    }
}