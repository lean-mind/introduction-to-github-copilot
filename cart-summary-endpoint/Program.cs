using System.Globalization;
using System.Text.Json;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        // Configure localization
        var supportedCultures = new[] { "en", "es" };
        var localizationOptions = new RequestLocalizationOptions()
            .SetDefaultCulture(supportedCultures[0])
            .AddSupportedCultures(supportedCultures)
            .AddSupportedUICultures(supportedCultures);

        app.UseRequestLocalization(localizationOptions);

        app.MapGet("/{lang}/cart-summary", (string lang) =>
        {
            // Cargar el archivo JSON manualmente basado en el idioma
            var localizedStrings = LoadLocalizedStrings(lang);

            if (localizedStrings == null)
            {
                return Results.NotFound($"Language file not found for culture '{lang}'.");
            }

            var productName = "Laptop";
            var quantity = 2;
            var totalPrice = 1500.00;
            var discount = 100.00;
            var tax = 120.00;
            var shippingCost = 20.00;
            var estimatedDelivery = "3-5 business days";
            var customerName = "John Doe";
            var customerEmail = "john.doe@example.com";
            var billingAddress = "123 Main St, Anytown, USA";
            var shippingAddress = "123 Main St, Anytown, USA";
            var orderDate = "2023-10-01";
            var orderNumber = "ORD123456";
            var paymentMethod = "Credit Card";

            var cartSummary =
                $"{localizedStrings["cartSummary"]}: {localizedStrings["productName"]} - {productName}, " +
                $"{localizedStrings["quantity"]} - {quantity}, {localizedStrings["totalPrice"]} - ${totalPrice}, " +
                $"{localizedStrings["discount"]} - ${discount}, {localizedStrings["tax"]} - ${tax}, " +
                $"{localizedStrings["shippingCost"]} - ${shippingCost}, {localizedStrings["estimatedDelivery"]} - {estimatedDelivery}, " +
                $"{localizedStrings["customerName"]} - {customerName}, {localizedStrings["customerEmail"]} - {customerEmail}, " +
                $"{localizedStrings["billingAddress"]} - {billingAddress}, {localizedStrings["shippingAddress"]} - {shippingAddress}, " +
                $"{localizedStrings["orderDate"]} - {orderDate}, {localizedStrings["orderNumber"]} - {orderNumber}, " +
                $"{localizedStrings["paymentMethod"]} - {paymentMethod}, {localizedStrings["checkout"]}";

            return Results.Ok(new { CartSummary = cartSummary });
        });

        app.Run();
    }

    // Método para cargar manualmente los archivos JSON desde el disco
    private static Dictionary<string, string> LoadLocalizedStrings(string lang)
    {
        var filePath = $"Resources/lang.{lang}.json";
        if (!System.IO.File.Exists(filePath))
        {
            return null;
        }

        var jsonString = System.IO.File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
    }
}