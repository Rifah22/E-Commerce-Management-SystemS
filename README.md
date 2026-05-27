# 🛒 E-Commerce Management System

<p align="center">
  <img src="https://img.shields.io/badge/PHP-777BB4?style=for-the-badge&logo=php&logoColor=white"/>
  <img src="https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white"/>
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white"/>
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white"/>
  <img src="https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black"/>
</p>

> A complete e-commerce web platform with customer shopping, cart management, order processing, and a full admin dashboard for product and order management.

---

## 📌 Table of Contents
- [About](#about)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Screenshots](#screenshots)
- [Getting Started](#getting-started)
- [Database Setup](#database-setup)

---

## 📖 About

E-Commerce Management System is a full-stack web application that replicates the core functionality of a real online store. Customers can register, browse products, add items to a cart, and check out with order tracking. Admins have complete control over product listings, inventory, and customer orders through a dedicated dashboard.

This project showcases end-to-end web development using PHP and MySQL, covering authentication, CRUD operations, session management, and dynamic UI rendering.

---

## ✨ Features

### 🛍️ Customer Side
- User registration, login & profile management
- Product browsing with categories & search
- Shopping cart with quantity control
- Order placement and order history
- Responsive product pages

### 🛠️ Admin Panel
- Secure admin login
- Add, edit, and delete products
- Manage product categories
- View and update order statuses
- Customer management
- Sales dashboard overview

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Backend | PHP (Native) |
| Frontend | HTML5, CSS3, JavaScript |
| Database | MySQL |
| Server | Apache (XAMPP/WAMP) |

---

## 📸 Screenshots

> _Add screenshots of your storefront, product pages, cart, and admin dashboard_

<!--
![Home/Storefront](screenshots/home.png)
![Product Page](screenshots/product.png)
![Admin Dashboard](screenshots/admin.png)
-->

---

## ⚙️ Getting Started

### Prerequisites
- XAMPP or WAMP
- PHP 7.4+
- MySQL 5.7+

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Rifah22/E-Commerce-Management-SystemS.git
   ```

2. **Move to server root**
   ```bash
   # XAMPP:
   mv E-Commerce-Management-SystemS /xampp/htdocs/ecommerce
   ```

3. **Start Apache & MySQL** in XAMPP

4. **Import the database** (see below)

5. **Open in browser**
   ```
   http://localhost/ecommerce/
   ```

---

## 🗄️ Database Setup

1. Go to `http://localhost/phpmyadmin`
2. Create a new database: `ecommerce_db`
3. Import the SQL file from the repo
4. Update DB credentials in your config/connection file:
   ```php
   $host = "localhost";
   $user = "root";
   $password = "";
   $database = "ecommerce_db";
   ```

---

## 🧭 User Roles

| Role | Access |
|------|--------|
| Customer | Browse, cart, order, profile |
| Admin | Full product, order & user management |

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome. Feel free to open a pull request!

---

## 👩‍💻 Author

**Rifah Sanzida**  
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat&logo=linkedin)](https://www.linkedin.com/in/rifah-sanzida-b58141290/)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github)](https://github.com/Rifah22)
