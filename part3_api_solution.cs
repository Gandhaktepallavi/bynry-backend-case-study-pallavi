using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/companies/{companyId}/alerts")]
public class AlertsController : ControllerBase
{
    [HttpGet("low-stock")]
    public IActionResult GetLowStockAlerts(int companyId)
    {
        var alerts = new List<object>
        {
            new
            {
                product_id = 123,
                product_name = "Widget A",
                sku = "WID-001",
                warehouse_id = 456,
                warehouse_name = "Main Warehouse",
                current_stock = 5,
                threshold = 20,
                days_until_stockout = 12,
                supplier = new
                {
                    id = 789,
                    name = "Supplier Corp",
                    contact_email = "orders@supplier.com"
                }
            }
        };

        return Ok(new
        {
            alerts,
            total_alerts = alerts.Count
        });
    }
}
