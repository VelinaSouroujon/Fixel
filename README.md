# Fixel

## About the project

A repair shop deals with many small pieces of information at once: who brought a device in, what is wrong with it, what condition it arrived in, and when the customer expects it back. When this information lives on paper or in spreadsheets, it is easily lost, duplicated, or out of date.

Fixel replaces those notes with a single shared system. Staff register customers, associate them with their devices, and open a repair ticket for every job. Each ticket preserves the problem as the customer described it, the condition of the device at intake, its priority, and the date by which the repair is expected to be finished.

The application is intended for one repair business with several employees working in the same shop.

## Features

### Customers
* View all customers in one list, together with the number of devices each customer owns and the number of repairs currently in progress.
* Add a new customer with first name, last name, phone number, an optional email address, and a preferred contact method (phone, email, or SMS).
* Open a customer's page to see their contact details, their devices, and their complete repair history.
* Edit a customer's details.
* Delete a customer. Their devices and repair tickets remain in the system without an owner so that the shop's repair records stay intact.
* Duplicate email addresses are detected and reported with a clear message.

### Repair tickets
* View all repair tickets in one list, newest first. The list shows the reference number, customer, device, status, priority, and expected completion date.
* Overdue tickets are highlighted so they are noticed immediately.
* Open a ticket to see the reported problem, the condition of the device at intake, the priority, the intake date, the expected completion date, and the device and customer concerned. The customer's name links to their page.
* Create a ticket for any registered device by entering a reference number, choosing a priority, describing the condition of the device, describing the reported problem, and optionally setting an expected completion date.
* Every ticket carries a status that is displayed as a coloured badge, identical on every page. The statuses follow a real repair: *Received*, *Diagnosing*, *Awaiting approval*, *Approved*, *Waiting for parts*, *In repair*, *Testing*, *Ready for collection*, *Collected*, *Declined*, *Unrepairable*, and *Cancelled*.
* Duplicate reference numbers are detected and reported with a clear message.

### General
* Every page is reachable from the main navigation or from a related page.
* Forms validate input as the user types and again on submission. Messages are written in plain language and explain how to correct the problem.
* The application starts with realistic demo data, so every page can be explored immediately.

## Technologies

* C# and ASP.NET Core MVC (.NET 9)
* Entity Framework Core 9 with SQL Server
* Razor views
* Bootstrap 5
* jQuery Validation

## Solution structure

The solution is divided into five projects:

| Project | Responsibility |
| :--- | :--- |
| `Fixel.Web` | The ASP.NET Core MVC application: controllers, Razor views, layout, and static files. Startup project. |
| `Fixel.Core` | Business logic, implemented as services behind interfaces. |
| `Fixel.Data` | Entity models, the database context, entity configurations, seed data, and migrations. |
| `Fixel.ViewModels` | View models used to pass data between the services and the views. |
| `Fixel.Common` | Constants shared across the projects, such as validation limits. |

## Setup

### Prerequisites
* [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
* SQL Server Express with an instance named `SQLEXPRESS` on the local machine
* The Entity Framework Core command-line tool:
  ```bash
  dotnet tool install --global dotnet-ef
  ```

### Installation

1. Clone the repository and open its root folder:
   ```bash
   git clone <repository-url>
   cd Fixel
   ```
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
3. Create the database and load the sample data:
   ```bash
   dotnet ef database update --project Fixel.Data --startup-project Fixel.Web
   ```
4. Start the application:
   ```bash
   dotnet run --project Fixel.Web --launch-profile https
   ```
5. Open `https://localhost:7091` in a browser. The address `http://localhost:5274` is also available.

## Configuration

The only setting the application requires is the database connection string, stored in `Fixel.Web/appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.\\SQLEXPRESS;Database=Fixel;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

| Setting | Value |
| :--- | :--- |
| SQL Server instance | `.\SQLEXPRESS` |
| Database name | `Fixel` (created by the migration) |
| Authentication | Windows authentication; no username or password is needed |

No environment variables or other credentials are required. If your SQL Server instance has a different name, or you use SQL Server authentication, change the connection string before running the migration. The same value can also be supplied through the `ConnectionStrings__DefaultConnection` environment variable.