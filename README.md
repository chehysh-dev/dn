# .NET Practicals

A curated laboratory collection of **23 complete .NET and C# programming practicals and sub-practicals** extracted, structured, modernized, and thoroughly documented from the laboratory curriculum.

Each practical is housed in its own dedicated folder containing **three primary deliverables** along with all essential supporting files:
1. **Primary Code File** (`Practical-XX-Code.<ext>`)
2. **Comprehensive Word Document** (`Practical-XX-Documentation.docx`) containing all 10 standard academic journal sections
3. **Standalone Plain-Text Notes** (`Practical-XX-Notes.txt`) for immediate terminal or text editor reference
4. **Essential Supporting Files** (Models, Controllers, Razor Views, Web.config, appsettings.json, Manifests, HTML/XML files) required for complete execution.

---

## Table of Contents

| # | Practical Title / Topic | Primary Deliverables | Supporting Files | Folder Link |
|---|---|---|---|---|
| **01A** | **Floyd's Triangle till N Rows**<br>Console application generating right-angled triangular number sequence | • `Practical-01A-Code.cs`<br>• `Practical-01A-Documentation.docx`<br>• `Practical-01A-Notes.txt` | — | [Practical-01A-Floyds-Triangle](./Practical-01A-Floyds-Triangle) |
| **01B** | **Arrange Names of Cities in Sorted Order**<br>Accepts 10 city names and sorts them alphabetically using `Array.Sort()` | • `Practical-01B-Code.cs`<br>• `Practical-01B-Documentation.docx`<br>• `Practical-01B-Notes.txt` | — | [Practical-01B-Sort-Cities](./Practical-01B-Sort-Cities) |
| **02A** | **Function Overloading**<br>Compile-time polymorphism computing areas of square, rectangle, and circle | • `Practical-02A-Code.cs`<br>• `Practical-02A-Documentation.docx`<br>• `Practical-02A-Notes.txt` | — | [Practical-02A-Function-Overloading](./Practical-02A-Function-Overloading) |
| **02B** | **Inheritance**<br>Multilevel and hierarchical inheritance across vehicle, car, sportscar, and bike | • `Practical-02B-Code.cs`<br>• `Practical-02B-Documentation.docx`<br>• `Practical-02B-Notes.txt` | — | [Practical-02B-Inheritance](./Practical-02B-Inheritance) |
| **02C** | **Interface Implementation**<br>Polymorphic contract dispatch across Square and Circle implementing Area interface | • `Practical-02C-Code.cs`<br>• `Practical-02C-Documentation.docx`<br>• `Practical-02C-Notes.txt` | — | [Practical-02C-Interface](./Practical-02C-Interface) |
| **02D** | **Exception Handling & Custom Exceptions**<br>Try-catch-finally error handling with user-defined `invalidage` exception | • `Practical-02D-Code.cs`<br>• `Practical-02D-Documentation.docx`<br>• `Practical-02D-Notes.txt` | — | [Practical-02D-Exception-Handling](./Practical-02D-Exception-Handling) |
| **03A** | **Arithmetic Methods via C# Delegates**<br>Single-cast delegates dynamically referencing arithmetic functions | • `Practical-03A-Code.cs`<br>• `Practical-03A-Documentation.docx`<br>• `Practical-03A-Notes.txt` | — | [Practical-03A-Delegates](./Practical-03A-Delegates) |
| **03B** | **Multicast Delegate Chaining**<br>Invocation list manipulation using `+` (chaining) and `-` (removal) operators | • `Practical-03B-Code.cs`<br>• `Practical-03B-Documentation.docx`<br>• `Practical-03B-Notes.txt` | — | [Practical-03B-Multicast-Delegate](./Practical-03B-Multicast-Delegate) |
| **03C** | **BankAccount Property Validation**<br>Data encapsulation with getter/setter validation preventing negative balances | • `Practical-03C-Code.cs`<br>• `Practical-03C-Documentation.docx`<br>• `Practical-03C-Notes.txt` | — | [Practical-03C-BankAccount-Validation](./Practical-03C-BankAccount-Validation) |
| **04A** | **Student Registration Form**<br>ASP.NET Web Forms server controls (TextBox, Radio, DropDown, Calendar, CheckBox) | • `Practical-04A-Code.aspx`<br>• `Practical-04A-Documentation.docx`<br>• `Practical-04A-Notes.txt` | `WebForm1.aspx.cs` | [Practical-04A-Student-Registration](./Practical-04A-Student-Registration) |
| **04B** | **Registration Form with Validation Controls**<br>RequiredField, Range, RegularExpression, Compare, and ValidationSummary | • `Practical-04B-Code.aspx`<br>• `Practical-04B-Documentation.docx`<br>• `Practical-04B-Notes.txt` | `WebForm1.aspx.cs`<br>`Web.config` | [Practical-04B-Registration-Validation](./Practical-04B-Registration-Validation) |
| **04C** | **AdRotator Server Control**<br>Dynamic advertisement banner rotation driven by an XML advertisement configuration | • `Practical-04C-Code.aspx`<br>• `Practical-04C-Documentation.docx`<br>• `Practical-04C-Notes.txt` | `XMLFile.xml` | [Practical-04C-AdRotator-Control](./Practical-04C-AdRotator-Control) |
| **05A** | **MVC Basic Arithmetic Operations**<br>ASP.NET Core MVC strongly typed calculator with Model, Controller, and Razor View | • `Practical-05A-Code.cs`<br>• `Practical-05A-Documentation.docx`<br>• `Practical-05A-Notes.txt` | `Calculator.cs`<br>`Index.cshtml` | [Practical-05A-MVC-Arithmetic](./Practical-05A-MVC-Arithmetic) |
| **05B** | **Different Types of Cookies**<br>Session Cookies (RAM-only) and Persistent Cookies (stored on disk with expiration) | • `Practical-05B-Code.aspx.cs`<br>• `Practical-05B-Documentation.docx`<br>• `Practical-05B-Notes.txt` | `CookieDemo.aspx` | [Practical-05B-Cookies](./Practical-05B-Cookies) |
| **05C** | **Authentication & Authorization in ASP.NET Core**<br>ASP.NET Core Identity user registration, login, and `[Authorize]` endpoint protection | • `Practical-05C-Code.cs`<br>• `Practical-05C-Documentation.docx`<br>• `Practical-05C-Notes.txt` | `Secret.cshtml` | [Practical-05C-Authentication-Authorization](./Practical-05C-Authentication-Authorization) |
| **05D** | **Employee CRUD Using EF Core & SQL Server**<br>Full Code-First database operations (Create, Read, Update, Delete) with DbContext | • `Practical-05D-Code.cs`<br>• `Practical-05D-Documentation.docx`<br>• `Practical-05D-Notes.txt` | `Employee.cs`<br>`Program.cs`<br>`appsettings.json` | [Practical-05D-Employee-CRUD-EFCore](./Practical-05D-Employee-CRUD-EFCore) |
| **06A** | **College Information Portal as a PWA**<br>PWA conversion with `manifest.json`, Service Worker registration, and static file serving | • `Practical-06A-Code.js`<br>• `Practical-06A-Documentation.docx`<br>• `Practical-06A-Notes.txt` | `manifest.json`<br>`Index.cshtml`<br>`_Layout.cshtml` | [Practical-06A-College-Portal-PWA](./Practical-06A-College-Portal-PWA) |
| **06B** | **PWA with Custom Offline Fallback Page**<br>Service Worker precaching `offline.html` and intercepting fetch errors when offline | • `Practical-06B-Code.js`<br>• `Practical-06B-Documentation.docx`<br>• `Practical-06B-Notes.txt` | `offline.html`<br>`manifest.json`<br>`Index.cshtml` | [Practical-06B-Offline-Page-PWA](./Practical-06B-Offline-Page-PWA) |
| **07A** | **PWA Offline Mode Using Service Worker**<br>Cache-first strategy caching MVC application routes for seamless offline execution | • `Practical-07A-Code.js`<br>• `Practical-07A-Documentation.docx`<br>• `Practical-07A-Notes.txt` | `manifest.json`<br>`Index.cshtml` | [Practical-07A-Offline-Mode-Service-Worker](./Practical-07A-Offline-Mode-Service-Worker) |
| **08A** | **HTML PWA Starting Page with Manifest Link**<br>Minimal ASP.NET Core static file server with responsive viewport and manifest link | • `Practical-08A-Code.html`<br>• `Practical-08A-Documentation.docx`<br>• `Practical-08A-Notes.txt` | `manifest.json`<br>`Program.cs` | [Practical-08A-HTML-PWA-Manifest](./Practical-08A-HTML-PWA-Manifest) |
| **08B** | **Student Web API Returning JSON Format**<br>ASP.NET Core Web API controller with `[ApiController]` and `[HttpGet]` returning JSON array | • `Practical-08B-Code.cs`<br>• `Practical-08B-Documentation.docx`<br>• `Practical-08B-Notes.txt` | `Student.cs`<br>`Program.cs` | [Practical-08B-Student-WebAPI](./Practical-08B-Student-WebAPI) |
| **09A** | **Factorial Web API Tested with Postman**<br>Route parameterized API endpoint calculating factorial with negative input 400 Bad Request | • `Practical-09A-Code.cs`<br>• `Practical-09A-Documentation.docx`<br>• `Practical-09A-Notes.txt` | `Program.cs` | [Practical-09A-Factorial-WebAPI-Postman](./Practical-09A-Factorial-WebAPI-Postman) |
| **10A** | **PWA with Manifest and Push Notifications**<br>Browser Notification API permissions and Service Worker notifications | • `Practical-10A-Code.js`<br>• `Practical-10A-Documentation.docx`<br>• `Practical-10A-Notes.txt` | `service-worker.js`<br>`index.html`<br>`manifest.json`<br>`Program.cs` | [Practical-10A-Push-Notifications-PWA](./Practical-10A-Push-Notifications-PWA) |

---

## Required Development Environment

* **C# / .NET Console Practicals (01A – 03C)**:
  * .NET SDK 6.0, 7.0, 8.0, 9.0, or 10.0
  * Executable cross-platform on Windows, macOS, and Linux using `dotnet run`
* **ASP.NET Web Forms Practicals (04A – 04C, 05B)**:
  * Visual Studio 2019 / 2022 / 2026 on Windows
  * .NET Framework 4.7.2 or 4.8
  * IIS Express web server
* **ASP.NET Core MVC & Web API Practicals (05A, 05C, 05D, 08B, 09A)**:
  * .NET SDK 6.0+ (or Visual Studio 2022 / 2026)
  * SQL Server LocalDB or SQL Server Express (for Practical 05D CRUD and 05C Identity)
  * Postman or cURL CLI for Web API testing
* **Progressive Web Application (PWA) Practicals (06A, 06B, 07A, 08A, 10A)**:
  * Modern Chromium browser (Google Chrome, Microsoft Edge, Brave) with Service Worker and PWA install support
  * Served over HTTPS or `localhost`

---

## How to Open and Run the Projects

### Running Console Applications (01A – 03C)
```bash
cd Practical-01A-Floyds-Triangle
dotnet new console -o . --force
# Replace Program.cs with Practical-01A-Code.cs
dotnet run
```

### Running ASP.NET Core MVC and Web API Projects (05A, 05C, 05D, 08B, 09A)
```bash
# Example for Factorial Web API:
cd Practical-09A-Factorial-WebAPI-Postman
dotnet new webapi -o . --force
# Place MathController.cs and Program.cs
dotnet run
# Open browser at: https://localhost:<port>/api/math/factorial/5
```

### Running ASP.NET Web Forms Projects (04A – 04C, 05B)
1. Open Visual Studio.
2. Select **File &rarr; New &rarr; Project &rarr; ASP.NET Web Application (.NET Framework)**.
3. Choose the **Empty** template and check **Web Forms**.
4. Add the provided `.aspx` markup and `.aspx.cs` code-behind files.
5. Press **F5** to launch IIS Express in your web browser.

---

## Source PDFs
The complete collection of original source laboratory PDF documents is preserved in this repository:
* Merged Master Document: [Source-Practicals.pdf](./Source-Practicals.pdf) (47 total pages)
* Individual Topic PDFs: [Source-PDFs/](./Source-PDFs/)
