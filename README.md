# Vehicle Selling Portal

A modern Blazor Server application for listing, browsing, and managing vehicle sales, repossessed auctions, and damaged vehicle inventory.

---

## Project Structure

This solution follows a clean **onion architecture** with four main layers:

Presentation → Blazor UI (Razor components, pages)
Application → Interfaces, service contracts
Domain → Core business models/entities
Infrastructure → EF Core DbContext, service implementations

## Features

-  Filtered vehicle inventory with sorting & pagination  
-  Sell your vehicle form (data entry with validation)  
-  Current offers section with promotional highlights  
-  Browse vehicles grouped by location  
-  Services & Support module for user help  
---

##  Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/VehicleSellingPortal.git
cd VehicleSellingPortal
