using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ResourceOrder = P2FixAnAppDotNetCode.Resources.Models.ViewModels.Order;

namespace P2FixAnAppDotNetCode.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessageResourceName = "ErrorMissingName", ErrorMessageResourceType = typeof(ResourceOrder))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "ErrorMissingAddress", ErrorMessageResourceType = typeof(ResourceOrder))]
        public string Address { get; set; }

        [Required(ErrorMessageResourceName = "ErrorMissingCity", ErrorMessageResourceType = typeof(ResourceOrder))]
        public string City { get; set; }
        
        [Required(ErrorMessageResourceName = "ErrorMissingZip", ErrorMessageResourceType = typeof(ResourceOrder))]
        public string Zip { get; set; }

        [Required(ErrorMessageResourceName = "ErrorMissingCountry", ErrorMessageResourceType = typeof(ResourceOrder))]
        public string Country { get; set; }

        [BindNever]
        public DateTime Date { get; set; }
    }
}
