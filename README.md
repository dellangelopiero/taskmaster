# TaskMaster – Full-Stack Productivity App

**TaskMaster** is a full-stack task management application built with **React** (frontend) and **C#/.NET Core** (backend). Users can create, update, delete, and track tasks in real-time through a responsive, intuitive interface. This project demonstrates full-stack development, UX/UI principles, and problem-solving skills.

---

## Key Features

- Add, edit, delete, and complete tasks  
- Dashboard displays tasks by priority and status  
- Responsive UI based on **wireframes**  
- Real-time updates through backend API  
- Full CRUD functionality with React frontend + C# backend  
- Demonstrates **collaboration, code review, and problem-solving**

---

## Technologies Used

- **Frontend:** React, JavaScript (ES6), CSS3  
- **Backend:** C# (.NET Core), ASP.NET Web API  
- **Database:** SQLite (or SQL Server Express)  
- **Tools:** Git, VS Code, Postman  
- **Design:** Figma (for wireframes and UX/UI design)

---

## Project Structure
taskmaster/
├── backend/ # C# .NET API
│ ├── Controllers/ # API endpoints
│ ├── Models/ # Task models
│ ├── Services/ # Business logic
│ └── Program.cs # App entry point
├── frontend/ # React App
│ ├── src/
│ │ ├── components/ # UI components
│ │ ├── pages/ # App pages
│ │ ├── services/ # API calls
│ │ └── App.js # Root component
│ └── package.json # Frontend dependencies
└── README.md

---

## Installation & Running

### Backend (C#/.NET Core)
1. Navigate to `/backend`  
2. Restore packages:  
```bash
dotnet restore
