using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json.Linq;

public class CartSummaryTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public CartSummaryTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Theory]
    [InlineData("en", "Cart Summary: Product Name - Laptop, Quantity - 2, Total Price - $1500, Discount - $100, Tax - $120, Shipping Cost - $20, Estimated Delivery - 3-5 business days, Customer Name - John Doe, Customer Email - john.doe@example.com, Billing Address - 123 Main St, Anytown, USA, Shipping Address - 123 Main St, Anytown, USA, Order Date - 2023-10-01, Order Number - ORD123456, Payment Method - Credit Card, Checkout")]
    [InlineData("es", "Carrito de compras: Nombre del producto - Laptop, Cantidad - 2, Precio total - $1500, Descuento - $100, Impuestos - $120, Costo de envío - $20, Entrega estimada - 3-5 días hábiles, Nombre del cliente - John Doe, Correo electrónico del cliente - john.doe@example.com, Dirección de facturación - 123 Main St, Anytown, USA, Dirección de envío - 123 Main St, Anytown, USA, Fecha del pedido - 2023-10-01, Número de pedido - ORD123456, Método de pago - Tarjeta de crédito, Pagar")]
    public async Task GetCartSummary_ReturnsCorrectSummary(string lang, string expectedSummary)
    {
        var response = await _client.GetAsync($"/{lang}/cart-summary");
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var responseJson = JObject.Parse(responseString);

        Assert.Equal(expectedSummary, responseJson.GetValue("cartSummary")?.ToString());
    }
}