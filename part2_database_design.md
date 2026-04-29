# Part 2 - Database Design

## Tables

- companies
- warehouses
- products
- inventory
- suppliers
- product_suppliers
- inventory_movements
- product_bundles

## Key Decisions

- Products stored in multiple warehouses
- Inventory separated from products
- SKU unique
- Quantity tracked historically

## Questions

1. SKU global or company-wise?
2. Multiple suppliers allowed?
3. Can stock go negative?
4. Bundle auto deduction needed?
