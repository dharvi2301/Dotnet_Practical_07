# 🧩 Employee Management System — SOLID Principles in C#

This project demonstrates the **SOLID principles** in object-oriented design using a modular **Employee Management System** implemented in C#. Each SOLID principle is represented by clear and realistic examples following good software design practices.

---

## 📁 Project Structure
```
EmployeeManagement/ │ ├── Models/ # SRP: Core data structure (Employee) │ └── Employee.cs │ ├── Services/ # SRP & DIP: Business logic services │ ├── SalaryCalculator.cs │ ├── ReportGenerator.cs │ └── HRService.cs │ ├── Types/ # OCP: Abstract and base employee types │ ├── EmployeeBase.cs │ ├── FullTimeEmployee.cs │ └── ContractEmployee.cs │ ├── Liskov/ # LSP: Derived employee types │ ├── Manager.cs │ └── Intern.cs │ ├── Interfaces/ # ISP: Small, focused interfaces │ ├── IWork.cs │ └── IManage.cs │ ├── Workers/ # ISP: Role-specific implementations │ ├── Developer.cs │ └── TeamLead.cs │ ├── Notifications/ # DIP: Notification abstraction and implementations │ ├── INotifier.cs │ └── EmailNotifier.cs │ ├── Program.cs # Entry point demonstrating all principles └── EmployeeManagement.csproj
```
![image](https://github.com/user-attachments/assets/f58d5930-a98a-4293-b150-565867be10f5)

---

## ✅ SOLID Principles Breakdown

### 1. 🔹 Single Responsibility Principle (SRP)

> *A class should have only one reason to change.*

- `Employee.cs`: defines employee data only.
- `SalaryCalculator.cs`: handles salary calculations.
- `ReportGenerator.cs`: formats employee reports.
- `HRService.cs`: manages employee notifications.

Each class has one focused responsibility.

---

### 2. 🔸 Open/Closed Principle (OCP)

> *Software should be open for extension, but closed for modification.*

- `EmployeeBase.cs`: abstract base class for all employee types.
- `FullTimeEmployee.cs`, `ContractEmployee.cs`: extend functionality without changing base class.
- New types like `RemoteEmployee` or `PartTimeEmployee` can be added without touching existing logic.

---

### 3. 🟪 Liskov Substitution Principle (LSP)

> *Objects of a superclass should be replaceable with objects of a subclass without altering behavior.*

- `Manager.cs` and `Intern.cs` inherit `EmployeeBase` and can be used interchangeably.
- Their overridden `GetSalary()` methods work seamlessly where `EmployeeBase` is expected.

---

### 4. 🟨 Interface Segregation Principle (ISP)

> *Clients should not be forced to depend on interfaces they don’t use.*

- `IWork.cs`: only contains `Work()`.
- `IManage.cs`: only contains `Manage()`.
- `Developer.cs`: implements only `IWork`.
- `TeamLead.cs`: implements both `IWork` and `IManage`.

This ensures clean and minimal contracts.

---

### 5. 🟩 Dependency Inversion Principle (DIP)

> *High-level modules should not depend on low-level modules. Both should depend on abstractions.*

- `INotifier.cs`: defines `Notify()` abstraction.
- `EmailNotifier.cs`: implements the interface.
- `HRService.cs`: depends only on `INotifier`, not the concrete implementation.
- Allows easy switching to other notifiers (e.g., SMS, Slack).

---

## ▶️ How to Run

1. Clone the repository.
2. Open the solution in **Visual Studio** or **VS Code**.
3. Build the project.
4. Run `Program.cs`.

**Expected Output:**
![image](https://github.com/user-attachments/assets/c110a524-9656-4031-9ed6-fc1ff7f323d6)

