using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class VehicleSaleModel
    {
        [Required(ErrorMessage = "Please enter a Year!")]
        public string? VehYear { get; set; }

        [Required(ErrorMessage = "Please enter a Make!")]
        public string? VehMake { get; set; }

        [Required(ErrorMessage = "Please enter a Model!")]
        public string? VehModel { get; set; }

        [Required(ErrorMessage = "Please enter select a Type!")]
        public string? VehType { get; set; }

        [Required(ErrorMessage = "Please enter a Sale Price!")]
        [Range(0, 10000000000, ErrorMessage = "The Sale Price amount must be greater than or equal to 0.")]
        public decimal? VehPrice { get; set; }

        public decimal? VehDiscount { get; set; }

        public decimal? SaleTax { get; set; }

        public decimal? VehicleSaleCal()
        {
            decimal? price = VehPrice;
            decimal? discount = VehDiscount / 100;
            decimal? salesTax = 1 + (SaleTax / 100);
            decimal? finalPrice = 0;
      
            
            if (discount > 0 && salesTax > 0)
            {
                finalPrice = (price - (price * discount))*salesTax;
            }
            else if (discount == 0 && salesTax > 0)
            {
                finalPrice = price * salesTax;
            }
            else
            {
                finalPrice = price; 
            }
            return finalPrice;
        }

        public string? VehicleDisc()
        {
            string? year = VehYear;
            string? make = VehMake;
            string? model = VehModel;
            string? type = VehType;

            string? finalDisc = year + " " + make + " " + model + " " + type;

            return finalDisc;
        }
    }
}
