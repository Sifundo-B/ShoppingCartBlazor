using Microsoft.AspNetCore.Components;
using ShoppingCart.Models.Dtos;

namespace ShoppingCart.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }

    }
}
