
# 🤖 Sim Botic Game

**Sim Botic** is an interactive quiz game built using **C# Windows Forms** with **Guna UI 2** and an **embedded SQL Server database**. It challenges players with programming-related one-word questions under time constraints based on difficulty level. It also includes user login and sign-up features using an internal database.

---

## 🎮 Features

- Timed quiz mode with adjustable difficulty
- Randomized questions each session
- Score tracking and immediate feedback
- Progress bar to show quiz status
- Embedded database for sign-up and login
- Beautiful interface using Guna UI 2 components

---

## 🛠️ Requirements

- Visual Studio 2022
- .NET Framework 4.7.2 or later
- [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms/)
- LocalDB (comes with Visual Studio)

---

## 📦 How to Set Up the Project

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/sim-botic-game.git
   ```

2. **Open the Solution**

   Navigate to the project folder and open the `Sim Botic.sln` file in Visual Studio 2022.

3. **Install Guna UI 2**

   - Go to **Tools > NuGet Package Manager > Manage NuGet Packages for Solution**
   - Search for `Guna.UI2.WinForms`
   - Install it for the project

4. **Build and Run**

   - Press `Ctrl + F5` or click **Start** to launch the game

---

## 💾 Database Setup (Embedded)

This project uses an **embedded `.mdf` SQL Server database** for storing user credentials.

### 📁 Where to Find It

The `.mdf` file (e.g., `UserData.mdf`) should be located in the project directory (usually under `App_Data` or root folder).

### 🧩 How to Connect

1. **Open Server Explorer in Visual Studio**
   - Right-click `Data Connections > Add Connection`
   - Select `Microsoft SQL Server Database File (*.mdf)`
   - Browse and attach `UserData.mdf` from the project

2. **Verify Connection String**
   - The connection string may look like:
     ```csharp
     string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True";
     SqlConnection con = new SqlConnection(conStr);
     ```

3. **Check User Table**
   - Ensure a table exists:
     ```sql
     CREATE TABLE Users (
         Id INT PRIMARY KEY IDENTITY,
         Username NVARCHAR(50) NOT NULL,
         Password NVARCHAR(50) NOT NULL
     );
     ```

---

## 🧠 Questions Format

All questions are stored in code as `List<QA>` objects. Each game randomly selects the questions on startup.

### Example Questions:
- `What is the output of: Console.WriteLine(5 + 3 * 2);` → `11`
- `Which keyword is used to declare a method in C#?` → `void`

---

## 📁 Project Structure

```
Sim Botic Game/
├── Sim Botic.sln
├── Sim Botic/
│   ├── GameBoard.cs
│   ├── Login.cs
│   ├── Signup.cs
│   ├── ScoreBoard.cs
│   ├── Program.cs
│   └── UserData.mdf
```

---

## 🔐 Sign-Up and Login

- **Signup Form**: Accepts username and password, stores them in `UserData.mdf`.
- **Login Form**: Checks credentials before allowing access to the game.

---

## ✨ Future Improvements

- Use external question bank from the database
- Add sound and visual animations
- Add levels and achievements
- Export scores to leaderboard

---

## 🧑‍💻 Author

**Fathima Azha**

> Developed as a C# quiz game project using Windows Forms and embedded database.

---

## 📜 License

This project is open-source under the **MIT License**.

