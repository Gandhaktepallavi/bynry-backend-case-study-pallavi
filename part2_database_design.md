# Part 2 - Database Design

## Tables

### Companies
- Id (PK)
- Name

### Warehouses
- Id (PK)
- CompanyId (FK)
- Name
- Location

### Products
- Id (PK)
- CompanyId (FK)
- Name
- SKU (Unique)
- Price DECIMAL(10,2)
- ProductType

### Inventory
- Id (PK)
- ProductId (FK)
- WarehouseId (FK)
- Quantity
- UpdatedAt

### Suppliers
- Id (PK)
- CompanyId (FK)
- Name
- ContactEmail

### ProductSuppliers
- ProductId (FK)
- SupplierId (FK)

### InventoryMovements
- Id (PK)
- ProductId
- WarehouseId
- ChangeQty
- Reason
- CreatedAt

### ProductBundles
- BundleProductId
- ChildProductId
- QuantityRequired

## Questions for Product Team

1. Is SKU unique globally or per company?
2. Can one product have many suppliers?
3. Can inventory go negative?
4. Should bundles auto-deduct child items?
5. Need audit history retention policy?
