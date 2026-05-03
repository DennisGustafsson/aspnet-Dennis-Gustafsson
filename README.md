# 🏋️‍♂️ GymFitness – ASP.NET Core MVC  
Ett webbaserat gym‑system byggt med ASP.NET Core MVC, Entity Framework Core och ASP.NET Identity.

## 📌 Beskrivning  
Detta projekt är ett gym‑system där användare kan skapa konto, logga in och hantera sin profil.  
Systemet använder ASP.NET Identity för autentisering och lagrar all data i en SQL Server‑databas.

Funktioner för inloggade användare:
- Uppdatera personuppgifter  
- Ladda upp profilbild  
- Ta bort sitt konto och all tillhörande data  
- (Kommande) Välja och ändra medlemskap  
- (Kommande) Boka träningspass  

Även användare som inte är inloggade kan skicka meddelanden via kontaktformuläret. Dessa sparas i databasen.

Projektet följer principerna för Clean Architecture, där affärslogik, datalager och presentation är tydligt separerade.

---

## 🚀 Starta projektet lokalt

### 1. Klona repository  

git clone https://github.com/dennisgustafsson/aspnet-Dennis-Gustafsson.git

### 2. Konfigurera databas

"ConnectionStrings": {
  "SqlConnection": "Server=localhost;Database=GymFitnessDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

### 3. Updatera databasen

Update-Database

### 4. Starta applikationen

dotnet run
