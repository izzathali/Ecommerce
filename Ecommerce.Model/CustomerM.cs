using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecommerce.Model
{
    public class CustomerM : BaseEntity
    {
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(250)")]
        public string Email { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(250)")]
        public string Password { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(15)")]
        [Display(Name = "Phone No")]
        public string PhoneNo1 { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(15)")]
        [Display(Name = "Phone No")]
        public string PhoneNo2 { get; set; } = string.Empty;
    }
}
