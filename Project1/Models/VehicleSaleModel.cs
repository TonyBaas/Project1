using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class VehicleSaleModel
    {
        [Required(ErrorMessage = "Please enter a Sale Price!")]
        [Range(0, 10000000000, ErrorMessage = "The Sale Price amount must be greater than or equal to 0.")]
        public decimal? VehPrice { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent! Input 0 if there is no discount!")]
        [Range(0, 100, ErrorMessage = "The discount percent must be between 0% and 100%")]
        public decimal? VehDiscount { get; set; }

        [Required(ErrorMessage = "Please enter the sales tax! Input 0 if there is no sales tax!")]
        [Range(1, 50, ErrorMessage = "Number of years must be between 1 and 50.")]
        public int? SaleTax { get; set; }

        public decimal? VehicleSaleCal()
        {
            decimal? discount = VehDiscount / 100;
            decimal? salesTax = SaleTax / 100;
            decimal? finalPrice = 0;
      
            
            if (discount > 0 && salesTax > 0)
            {
                finalPrice = VehPrice + ((VehPrice - (VehPrice * discount))*salesTax);
            }
            else if (discount == 0 && salesTax > 0)
            {
                finalPrice = VehPrice + (VehPrice * salesTax);
            }
            else
            {
                finalPrice = VehPrice; 
            }
            return finalPrice;
        }
    }
}
