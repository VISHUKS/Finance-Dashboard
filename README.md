# 📊 Finance Dashboard System - ASP.NET Core Web API

## 📌 Project Overview

The **Finance Dashboard System** is a robust backend application built using ASP.NET Core Web API. It manages financial data, employees, and user roles with secure authentication and structured API architecture.

This project demonstrates real-world backend development with modular design, role-based access, and efficient data handling.

---

## 🚀 Key Features

* 🔐 JWT Authentication & Authorization
* 👥 Role-Based Access Control (Admin/User)
* 🧑‍💼 Employee Management
* 💰 Financial Records & Transactions
* 📊 Dashboard APIs for insights
* ⚡ RESTful API design
* 🛡️ Validation & Exception Handling

---

## 🛠️ Tech Stack

* Backend: ASP.NET Core Web API
* Language: C#
* Database: SQL Server
* ORM: Entity Framework Core
* Authentication: JWT
* Tools: Postman, Visual Studio

---

## 📂 Project Structure

```bash
Finance Dashboard System/
│
├── Controllers/
│   ├── AuthController.cs
│   ├── AdminRolesController.cs
│   ├── EmployeesController.cs
│   ├── FinancialRecordsController.cs
│   ├── DashboardController.cs
│
├── Models/
│   ├── User.cs
│   ├── Employee.cs
│   ├── FinancialRecord.cs
│   ├── Role.cs
│   ├── Department.cs
│   ├── Designation.cs
│   ├── Transaction.cs
│   ├── (Other supporting models...)
│
├── DTOs/
│   ├── LoginDto.cs
│   ├── RegisterDto.cs
│   ├── EmployeeDto.cs
│   ├── FinancialRecordDto.cs
│
├── Services/
│   ├── AuthService.cs
│   ├── EmployeeService.cs
│   ├── FinancialService.cs
│
├── Context/
│   ├── ApplicationDbContext.cs
│
├── Middleware/
│   ├── ExceptionMiddleware.cs
│
└── Migrations/
```

---

## 🔐 Authentication Flow

1. User registers or logs in
2. JWT token is generated
3. Token is passed in headers:

```
Authorization: Bearer <your_token>
```

---

## 🧪 API Modules

### 🔑 Authentication

* Login / Register users
* Generate JWT tokens

### 👥 Role Management

* Assign roles (Admin/User)
* Control access permissions

### 🧑‍💼 Employee Management

* Add, update, delete employees
* Manage departments & designations

### 💰 Financial Records

* Track income/expenses
* Manage transactions

### 📊 Dashboard

* Aggregate financial insights
* Summary APIs

---

## ⚙️ Setup Instructions

```bash
git clone https://github.com/vishu-singh/finance-dashboard-system.git
cd finance-dashboard-system
```

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=FinanceDashboardDB;Trusted_Connection=True;Encrypt=False;"
}
```

Run:

```bash
dotnet ef database update
dotnet run
```

---

## 🧩 Key Concepts Used

* RESTful API Design
* JWT Authentication
* Role-Based Authorization
* Entity Framework Core
* DTO Pattern
* Dependency Injection
* Middleware (Exception Handling)

---

## 📈 Future Enhancements

* 📊 Advanced analytics (charts & reports)
* 📤 Export to Excel/PDF
* 🌐 Frontend (React / Angular)
* 🔔 Notifications system

---

## 👨‍💻 Author

**Vishu Singh**
ASP.NET Backend Developer

---

## ⭐ Support

If you like this project, give it a ⭐ on GitHub!
