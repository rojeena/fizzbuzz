# FizzBuzz Game

This is a web-based **FizzBuzz-like** game with an **Admin Portal** for managing game rules dynamically. Built using **React (TypeScript) with Material UI** for the frontend and **.NET 8** for the backend, the game allows players to apply custom rules while ensuring real-time validation.

## Features

### 🕹️ Game Features
- Users play by selecting the correct response for numbers based on predefined rules.
- Rules define text replacements for numbers divisible by specific values (e.g., "Fizz" for 3, "Buzz" for 5).
- Displays correct and incorrect attempts dynamically.

### ⚙️ Admin Portal Features
- **Add New Rules** – Admins can define a new rule (e.g., replace numbers divisible by 7 with "Boo").
- **Update Rules** – Modify existing rules (change divisor or text).
- **Enable/Disable Rules** – Toggle rules on/off without deleting them.
- **Delete Rules** – Remove unwanted rules.

## 🛠️ Tech Stack

- **Frontend**: React (TypeScript), Material UI, Axios  
- **Backend**: .NET 8 (C#) with an in-memory database  
- **API Communication**: RESTful API  

---

## 🚀 Setup Instructions  

### 1️⃣ Clone the Repository  
```sh
git clone https://github.com/rojeena/fizzbuzz.git

### 2️⃣ Backend Setup  
Navigate to the backend folder:  
```sh
cd FizzBuzzGameAPI

### Run the .NET server:

dotnet run

The backend will start at http://localhost:5000.


cd fizzbuzz-frontend
npm install
npm start
The frontend will be available at http://localhost:3000.

### 🔌 API Endpoints
Game API

GET /rules        # Fetch all enabled rules.
POST /rules       # Add a new rule.
PUT /rules/:id    # Update a rule (divisor, text, or enable/disable state).
DELETE /rules/:id # Delete a rule.