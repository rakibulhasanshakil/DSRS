# DSRS - Dhaka Subway Reservation System

## Overview

The **Dhaka Subway Reservation System (DSRS)** is a ticket booking system developed using **C#** and **.NET** with a local database. This system provides two types of user roles: **Admin** and **Passenger**, each with different capabilities. Passengers can register, search, and book tickets, while Admins have control over ticket management and can oversee passenger information.

---

## Features

### Admin Features:
- **Add, Update, and Delete Tickets**: Admins can create, modify, or remove tickets as required.
- **View Passenger Information**: Admins can view details of passengers who have registered on the system and booked tickets.
  
### Passenger Features:
- **User Registration**: Passengers can create an account in the system.
- **Search and Buy Tickets**: Passengers can search for tickets based on:
  - **Living City**
  - **Destination City**
  - **Journey Date**
  - **Seat Type**
- **Download or Print Ticket**: After booking, passengers can download or print their tickets in PDF format.

---

## Technology Stack

- **Frontend**: C# (Windows Forms/WPF/ASP.NET)
- **Backend**: .NET Framework/Core
- **Database**: Local Database (e.g., SQL Server LocalDB)
- **PDF Generation**: iTextSharp library for generating tickets in PDF format

---

## Installation and Setup

### Prerequisites

- .NET SDK (version 5.0 or higher)
- SQL Server LocalDB or any local database supported by .NET
- Visual Studio 2019/2022 or any C# IDE
- iTextSharp library for PDF generation

### Steps to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/rakibulhasanshakil/DSRS.git
   
2. Open the project in Visual Studio.

3. Configure the connection string for your local database in appsettings.json or Web.config depending on your application type.

4. Run the migrations to set up the local database:
   ```bash
   dotnet ef database update

5. Build and run the project.

### Usage
#### For Admin:
- Log in with the admin credentials.
- Navigate to the Admin Panel to:
- Add, update, or delete tickets.
- View registered passenger details.
#### For Passengers:
- Register and log in to your account.
- Search for available tickets based on your city, destination, date, and seat type.
- Book a ticket and download or print the ticket in PDF format.
