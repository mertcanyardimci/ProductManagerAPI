# Dotnet Project - Product Management

This project is a product management application that allows for listing, filtering, and sorting products.

## Getting Started

These instructions will help you to run and develop the project on your local machine.

### Requirements

- .NET Core SDK
- An IDE (Visual Studio, Visual Studio Code, etc.)
- A SQL Server database

### Installation

1. Clone the project:

```
git clone https://github.com/mertcanyardimci/ProductManagerAPI.git
```

2. Navigate to the project folder:

```
cd project-folder
```

3. Create the database:

Update the connection string defined in the ProductContext class to create your database, and then run the following commands:

```
dotnet ef database update
```
4. Run the application:

```
dotnet run
```

- The application will run by default at https://localhost:5001.

## Usage

This application can be utilized through API calls.

To list the products:

```
GET /api/products
```
To search and sort:

```
GET /api/products?search=searchTerm&sort=asc|desc&page=pageNumber
```
## Contributing

1. Fork this repository.
2. Create a new branch: git checkout -b new-branch
3. Make your changes and validate them: git commit -am 'Add new feature'
4. Push to your branch: git push origin new-branch
5. Submit a Pull Request.
