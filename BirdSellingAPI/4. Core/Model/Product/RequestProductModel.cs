﻿namespace BirdSellingAPI._4._Core.Model.Product
{
    public class RequestProductModel
    {
        public string category_id { get; set; }

        public string image { get; set; }

        public decimal price { get; set; }

        public string name { get; set; }

        public bool sex { get; set; }

        public string description { get; set; }

        public string bird_mother_id { get; set; }

        public string bird_father_id { get; set; }

        public bool is_egg { get; set; }
        public DateTimeOffset day_of_birth { get; set; }
    }
}