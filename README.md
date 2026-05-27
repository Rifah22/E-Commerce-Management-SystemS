# 🛒 E-Commerce Management System

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white"/>
  <img src="https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
  <img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white"/>
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white"/>
  <img src="https://img.shields.io/badge/MetroFramework-00ADB5?style=for-the-badge"/>
</p>

> A **C# Windows Forms** desktop e-commerce application with two panels — a **User Panel** for customers to browse products, manage cart, and pay via Bkash/Nagad/Rocket, and an **Admin Panel** for managing sellers, customers, products, and orders.

---

## 📌 Table of Contents
- [About](#about)
- [Two Panels](#two-panels)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Database Setup](#database-setup)
- [Getting Started](#getting-started)
- [Screenshots](#screenshots)
- [Author](#author)

---

## 📖 About

This **E-Commerce Management System** is a desktop application built with **C# Windows Forms** and **SQL Server (LocalDB)**. It simulates a real-world e-commerce platform with two separate panels:

- **User Panel** — customers can register, log in, browse products, add to cart, and pay using Bangladeshi mobile payment methods (Bkash, Nagad, Rocket)
- **Admin Panel** — admins manage seller registrations (approve/reject), customers, products, and orders via a dashboard

The UI uses the **MetroFramework** library for a modern, flat design on Windows Forms.

---

## 🖥️ Two Panels

### 👤 User Panel (`UserPanel` namespace)
Customer-facing interface for browsing and purchasing products.

### 🛠️ Admin Panel (`E_Commerce_Management_System_Project` namespace)
Backend management interface for the store administrator.

---

## ✨ Features

### 👤 User Panel
| Feature | Details |
|---------|---------|
| **Registration** | Full name, username, phone, email, gender, password + confirm password validation |
| **Login** | Username + password, authenticated against SQL Server `Registration` table |
| **Forgot Password** | Reset password by verifying username + registered phone number |
| **Product Listing** | Browse all products in a DataGridView with product ID, name, type, price |
| **Product Details** | Click a product to view its image and details in `AddCart` form |
| **Add to Cart** | Select quantity using +/− buttons; total price calculated automatically |
| **View Cart** | Summary of ordered items with total cost |
| **Order Placement** | Order saved to `[Order]` table with product IDs, user ID, and total cost |
| **Order History** | View previous orders filtered by user ID |
| **Payment** | Choose from 3 mobile payment options: **Bkash**, **Nagad (Nogod)**, **Rocket** |

### 🛠️ Admin Panel
| Feature | Details |
|---------|---------|
| **Admin Login** | Secure admin authentication |
| **Seller Management** | View all seller registrations, filter by approval status, approve or delete sellers |
| **Customer Management** | View registered customers |
| **Product Management** | View and manage product listings |
| **Order Management** | View all placed orders |

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Language | C# |
| Framework | .NET Framework (Windows Forms) |
| UI Library | MetroFramework (Modern UI for WinForms) |
| Database | SQL Server LocalDB (`.mdf` files) |
| Data Access | `SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `DataTable` |
| IDE | Visual Studio |

---

## 📂 Project Structure

```
E-Commerce-Management-SystemS-C-/
│
├── 👤 USER PANEL (UserPanel.csproj / namespace: UserPanel)
│   ├── Program.cs                  # Entry point
│   ├── DataAccess.cs               # Central DB helper (getData, setData using SqlConnection)
│   ├── LogINForm.cs                # Customer login form
│   ├── SignUpForm.cs               # Customer registration (name, username, phone, email, gender, password)
│   ├── ResetPassForm1.cs           # Forgot password (verify username + phone → reset password)
│   ├── ProductsList.cs             # Product listing with DataGridView (MetroForm)
│   ├── AddCart.cs                  # Product detail view + quantity selector (+/−) (MetroForm)
│   ├── ViewCartForm.cs             # Cart summary + payment options (Bkash/Nagad/Rocket) (MetroForm)
│   ├── OrderHistory.cs             # Past orders by user (MetroForm)
│   ├── BkashForm.cs                # Bkash payment form (account + PIN)
│   ├── NogodForm.cs                # Nagad payment form (account + PIN)
│   ├── RoketForm.cs                # Rocket payment form (account + PIN)
│   └── LogInfoDB.mdf               # SQL Server LocalDB database file
│
├── 🛠️ ADMIN PANEL (E-Commerce Management System Project.csproj)
│   ├── Login.cs                    # Admin login
│   ├── DashB.cs                    # Admin dashboard (navigate to Seller/Customer/Product/Order)
│   ├── saller.cs                   # Seller management (view all, filter pending, approve, delete)
│   ├── customer.cs                 # Customer management
│   ├── product.cs                  # Product management
│   ├── order.cs                    # Order management
│   └── SellerDB.mdf                # Admin SQL Server LocalDB database file
│
├── Interface/                      # UI background images
│   ├── Login.jpg
│   ├── Seller Dashboard.jpg
│   ├── Seller registration.jpg
│   └── ...
│
├── SQLQuery1.sql                   # SQL schema (Seller_Reg, Product, Cart, Customer_Reg tables)
├── SellerDB/SQLQuery1.sql          # Additional SQL scripts
├── MetroFramework.txt              # MetroFramework license
└── E-Commerce Management SystemS.sln  # Visual Studio solution file
```

---

## 🗄️ Database Setup

The project uses **two SQL Server LocalDB** (`.mdf`) databases:

### User Panel Database — `LogInfoDB.mdf`
| Table | Columns |
|-------|---------|
| `Registration` | `UserId`, `FullName`, `UserName`, `PhoneNum`, `Email`, `Gender`, `Password` |
| `Product` | `Product_Id`, `Product_Name`, `Product_Type`, `Product_Price`, `Product_Image` |
| `Cart` | `Cart_Id`, `Product_Id`, `Product_Name`, `Total_Cost`, `Quantity` |
| `Order` | `Order_Id`, `Product_Id`, `UserId`, `Total_Cost` |

### Admin Panel Database — `SellerDB.mdf` / `Admin database.mdf`
| Table | Columns |
|-------|---------|
| `Seller_Registration` | `Seller_id`, `Seller_name`, `Seller_address`, `Seller_phone_no`, `Approve_status` |
| `Customer_Reg` | `Customer_id`, `Customer_name`, `Customer_pass`, `Customer_address`, `Customer_phn_no` |

> ⚠️ **Important:** The database connection strings in `DataAccess.cs` and `saller.cs` contain absolute local paths (e.g. `C:\Users\HP\...`). You must update these paths to match your machine before running.

---

## ⚙️ Getting Started

### Prerequisites
- **Visual Studio 2019 / 2022** with `.NET Desktop Development` workload
- **SQL Server LocalDB** (included with Visual Studio)
- **MetroFramework NuGet package** (see `packages.config`)

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/Rifah22/E-Commerce-Management-SystemS.git
   ```

2. **Open in Visual Studio**
   - Open `E-Commerce Management SystemS.sln`

3. **Restore NuGet packages**
   - Right-click solution → **Restore NuGet Packages**
   - This installs MetroFramework

4. **Set up the databases**
   - Place `LogInfoDB.mdf` in your desired folder
   - Update the connection string in `DataAccess.cs`:
     ```csharp
     public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;
     AttachDbFilename=YOUR_PATH\LogInfoDB.mdf;
     Integrated Security=True;Connect Timeout=30";
     ```
   - Update the connection string in `saller.cs` similarly for `Admin database.mdf`

5. **Set startup project**
   - For User Panel: set `UserPanel` as startup project
   - For Admin Panel: set `E-Commerce Management System Project` as startup project

6. **Run** with `F5` or `Ctrl+F5`

---

## 📸 Screenshots

Interface design previews are available in the `Interface/` folder:

| Screen | File |
|--------|------|
| Login Screen | `Interface/Login.jpg` |
| Seller Dashboard | `Interface/Seller Dashboard.jpg` |
| Seller Registration | `Interface/Seller registration.jpg` |
| Product Background | `Interface/Product Background.jpg` |

> _Add runtime screenshots of the running application in a `screenshots/` folder for a better portfolio presentation_

---

## 💳 Payment Methods Supported

| Method | Description |
|--------|-------------|
| 🟣 **Bkash** | Enter Bkash account number + PIN |
| 🔴 **Nagad (Nogod)** | Enter Nagad account number + PIN |
| 🟠 **Rocket** | Enter Rocket account number + PIN |

These are Bangladeshi mobile financial services (MFS), making this project contextually relevant for the local market.

---

## 👩‍💻 Author

**Rifah Sanzida**
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat&logo=linkedin)](https://www.linkedin.com/in/rifah-sanzida-b58141290/)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github)](https://github.com/Rifah22)
