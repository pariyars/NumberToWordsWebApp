# Number to Words Web Application - Documentation

## Approach and Reasoning

- **C# Extension Method**: Used `NumberToWord.ToWords` for clean, reusable logic.
- **ASP.NET MVC**: Server-side conversion for consistency and maintainability.
- **Bootstrap**: Responsive UI for desktop and mobile devices.

## Alternatives Considered

- **Pure client-side JavaScript**: Rejected because server-side ensures uniform conversion logic.
- **Third-party libraries**: Rejected because the task requires your own implementation.

## Notes

- Handles typical numbers, edge cases, and zero.
- Output format: "ONE HUNDRED TWENTY THREE DOLLARS AND FORTY FIVE CENTS".
