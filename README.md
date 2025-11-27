# CloudQA Automation Tests (C# + Selenium)

Automated UI tests for the CloudQA Developer Internship Task using **C#**, **Selenium WebDriver**, **NUnit**, and the **Page Object Model (POM)**.  
All test locators are designed to stay stable even if HTML structure or element positions change.

---

## ✨ Task Requirements (Completed)

✔ Visit CloudQA AutomationPracticeForm  
✔ Write automated tests for **any three fields**  
✔ Use stable locators that survive HTML/position changes  
✔ Implement using C# + Selenium  
✔ Provide clean project structure (POM + NUnit)

Automated fields:
1. **First Name**
2. **Email**
3. **Gender**

---

## 🔧 Tech Stack

- C# (.NET 8)
- Selenium WebDriver 4.x
- NUnit Framework
- ChromeDriver (via Selenium Manager)
- Visual Studio 2022
- Page Object Model (POM)

---

## 📁 Project Structure
CloudQA.AutomationTests/
│
├── Drivers/
│ └── WebDriverFactory.cs
│
├── Pages/
│ └── AutomationPracticeFormPage.cs
│
├── Tests/
│ └── FormTests.cs
│
└── CloudQA.AutomationTests.csproj

---

## 🧪 How to Run the Tests (Step-by-Step)

### 1️⃣ Clone the Repository
```sh
git clone https://github.com/<your-username>/CloudQA-Automation-Tests.git
cd CloudQA-Automation-Tests
```
###2️⃣ Open in Visual Studio 2022

Restore NuGet packages

Build → Rebuild Solution

Open Test Explorer → Run All

###3️⃣ Run Using Command Line
dotnet restore
dotnet build
dotnet test

Selenium will automatically:

Launch Chrome

Fill the form fields

Select the Gender radio option

Close browser

🛡 Why The Locators Are Stable

✔ Uses text-based selectors instead of IDs
✔ Avoids fragile attributes (id, class, name)
✔ Avoids absolute or index-based XPaths
✔ Uses semantic selectors (label text, relative input, radio value)
✔ Works even if positions or HTML markup change

This ensures long-term test reliability.

🧑‍💻 Author

Ayushman Rout
CloudQA Developer Internship Applicant


---


