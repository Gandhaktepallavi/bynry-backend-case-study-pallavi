using Microsoft.AspNetCore.Mvc;

namespace StockFlow.Controllers
{
    [ApiController]
    [Route("api/companies/{companyId}/alerts")]
    public class AlertsController : ControllerBase
    {
        [HttpGet("low-stock")]
        public IActionResult GetLowStockAlerts(int companyId)
        {
            // Assumptions:
            // Threshold differs by product type
            // Only recently sold items are included
            // Sample static response for case study

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
}
