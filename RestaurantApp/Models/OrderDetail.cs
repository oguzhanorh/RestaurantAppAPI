using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class OrderDetail
    {
        [Key]
        public long OrderDetailId { get; set; }
        public long OrderMasterId { get; set; }
        public OrderMaster OrderMaster { get; set; }
        public int FoodItemId { get; set; }
        public FoodItem FoodItem { get; set; } //Bu özellik aynı zamanda foreign key olarak da işlev görüyor.
        public decimal FoodItemPrice { get; set; }
        public int Quantity { get; set; }

    }
}
