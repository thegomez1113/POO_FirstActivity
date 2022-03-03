﻿namespace POO_FirstActivity
{
    public abstract class Product
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tPrice......:{$"{Price:C2}",13}" +
                $"\n\tTax........:{$"{Tax:P2}",15}";
        }

    }
}
