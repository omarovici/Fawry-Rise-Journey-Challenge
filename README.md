# Fawry Rise Journey Challenge

This is a C# console application simulating a shopping cart system with product shipping and checkout features. It demonstrates object-oriented programming, interfaces, and basic business logic for e-commerce scenarios.

## Features

- Add products to a cart (including shippable and non-shippable items)
- Calculate shipping costs and total package weight
- Handle product expiration and stock
- Print checkout receipts and shipment notices

## Project Structure

- `Models/` — Contains all product, cart, and shipping-related classes
- `Interfaces/` — Contains the `IShipping` interface
- `Program.cs` — Entry point for the application

## Requirements

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later
- JetBrains Rider or any C#-compatible IDE (optional)

## How to Run

1. **Clone the repository**  
   ```
   git clone "https://github.com/omarovici/Fawry-Rise-Journey-Challenge.git"
   cd Fawry-Rise-Journey-Challenge/Fawry\ Rise\ Journey\ Challenge
   ```

2. **Restore dependencies**  
   ```
   dotnet restore
   ```

3. **Build the project**  
   ```
   dotnet build
   ```

4. **Run the application**  
   ```
   dotnet run
   ```

## Usage

- The application will execute the logic in `Program.cs`, adding products to the cart and performing checkout.
- Output will be displayed in the terminal, including shipment notices and receipts.

## License

This project is for educational purposes. See the repository for license details.
