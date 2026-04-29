# Part 1 - Code Review & Debugging

## Issues Found

1. No request validation for required fields.
2. SKU uniqueness not checked.
3. Product commit and inventory commit are separate.
4. If second insert fails, product remains without inventory.
5. Product tied to one warehouse though products can exist in multiple warehouses.
6. No transaction rollback.
7. Price precision issues if float used.
8. No exception handling.

## Production Impact

- Duplicate products
- Broken inventory data
- Server errors
- Financial inaccuracies
- Hard-to-maintain data model

## Recommended Fixes

- Validate request body
- Add unique constraint on SKU
- Use one transaction
- Use decimal for price
- Keep warehouse relation in Inventory table
- Add try/catch + rollback
