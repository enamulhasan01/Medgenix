# MedGenix: Healthcare Recommendation & Research Data Platform

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-239120.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-MS%20SQL%20Server-CC292B.svg)](https://www.microsoft.com/en-us/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

MedGenix is a desktop healthcare management system built using C# Windows Forms and Microsoft SQL Server. It connects patients, medical contributors, researchers, and institutional clients by offering disease recommendations, rewarding verified health submissions, and distributing validated medical datasets.

---

## 📌 Roles & Capabilities
- **Admin**: Manages user account statuses (activate/deactivate), moderates disease records, and oversees supervisor/moderator roles.
- **Supervisor**: Reviews and verifies incoming hospital reports from contributors and moderators.
- **Moderator & Contributor**: Inputs localized disease data; contributors earn reward points upon verification.
- **Patient**: Submits symptoms to receive localized hospital and care recommendations.
- **Researcher & Institutional Client**: Searches verified datasets, manages cart orders, and processes purchases.

---

## 🚀 Setup & Installation

### Prerequisites
- Visual Studio 2022 with **.NET Desktop Development** workload.
- Microsoft SQL Server (e.g., Express) and **SQL Server Management Studio (SSMS)**.

### 1. Database Setup (Import .bacpac)
1. Launch **SQL Server Management Studio (SSMS)** and connect to your server (`.\SQLEXPRESS`).
2. Right-click the **Databases** folder in Object Explorer and select **Import Data-tier Application...**.
3. Choose **Import from local disk**, click **Browse...**, and select `Database/Medgenix.bacpac` from this repository.
4. Set the database name to `Medgenix` and complete the wizard.

### 2. Configure Connection String
Verify `App.config` matches your local SQL Server instance:
```xml
<connectionStrings>
  <add name="MedGenixDB" 
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;TrustServerCertificate=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>