using System.ComponentModel.DataAnnotations;

namespace CRUDWithWebAPI.Models
{
    public class Product
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        [Required]
        public string ProductName { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [Required]
        public float Price { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>
        /// The qty.
        /// </value>
        [Required]
        public int Qty { get; set; }
    }
}
