﻿namespace SignalR.WebUI.Dtos.DiscountDto
{
    public class CreateDiscountDto
    {
        public int Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}