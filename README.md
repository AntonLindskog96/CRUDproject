# CRUDproject

A simple Windows Forms application to perform CRUD (Create, Read, Update, Delete) operations on a SQL Server database.

## Project Overview
This application demonstrates a basic implementation of database interactions using:
- **C# (.NET Framework/.NET Core)** for the front-end logic.
- **SQL Server** for the back-end database.
- A reusable `DbService` class to handle database operations.

The application includes the following features:
- **Create:** Add a new user to the database.
- **Read:** Display all user records in a data grid.
- **Update:** Modify existing user records.
- **Delete:** Remove a user record from the database.

## Features
1. **Create:**
   - Add new users by filling out fields for `email`, `name`, `username`, and `password`.
   - Data is saved to the `crudApp` table in the database.

2. **Read:**
   - View all users in the database displayed in a `DataGridView` control.

3. **Update:**
   - Update existing user records using their `id`.

4. **Delete:**
   - Remove user records from the database by specifying their `id`.

## Technology Stack
- **Language:** C#
- **Framework:** Windows Forms
- **Database:** SQL Server
- **Libraries:** 
  - `System.Data`
  - `System.Data.SqlClient`


