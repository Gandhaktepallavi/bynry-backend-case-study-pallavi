# Part 1 - Code Review & Debugging

## Issues Found

1. No input validation
2. Duplicate SKU possible
3. Two separate commits (partial failure risk)
4. No transaction rollback
5. Product wrongly tied to one warehouse
6. No error handling
7. Price precision issue

## Impact

- Server crashes
- Duplicate products
- Inconsistent inventory
- Bad financial values

## Fix

Use validation, single transaction, unique SKU, decimal price type, rollback handling.
