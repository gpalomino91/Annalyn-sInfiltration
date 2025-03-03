# 🏹 Quest Logic - C# Solution

This repository contains the solution for the **Quest Logic** exercise in C#. The exercise involves implementing game logic to determine whether different actions are possible based on the state of characters in the game.

## 📜 Description
Annalyn, the main character, is on a mission to rescue her best friend, who has been kidnapped and is being held in a camp guarded by a knight and an archer. She also has a pet dog that can assist in the mission. The goal is to determine whether Annalyn can take certain actions based on the conditions of the game.

## 🛠️ Implementation
The `QuestLogic` class includes the following methods:

### 1️⃣ `CanFastAttack(bool knightIsAwake)`
Returns `true` if a fast attack can be made, which is only possible if the knight is sleeping.

### 2️⃣ `CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)`
Returns `true` if Annalyn can spy on the group, which is possible if at least one character is awake.

### 3️⃣ `CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)`
Returns `true` if Annalyn can signal the prisoner using bird sounds, which is only possible if the prisoner is awake and the archer is sleeping.

### 4️⃣ `CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)`
Returns `true` if Annalyn can free the prisoner. This is possible in two situations:
- If the **pet dog is present** and the **archer is asleep**, regardless of the knight’s state.
- If the **pet dog is NOT present**, Annalyn can only free the prisoner if the **prisoner is awake** and both the **knight and the archer are asleep**.

## 📂 Project Structure
```
📁 QuestLogic
│── 📄 QuestLogic.cs  // Class implementation
│── 📄 README.md      // This file
```

## 🚀 How to Run
1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/QuestLogic.git
   cd QuestLogic
   ```
2. Build the project (ensure you have .NET SDK installed):
   ```sh
   dotnet build
   ```
3. Run the program:
   ```sh
   dotnet run
   ```

## 🏆 Learning Outcomes
This exercise helps improve skills in:
- Boolean logic and conditional statements.
- Using logical operators (`&&`, `||`, `!`).
- Writing clean, efficient, and readable C# code.

---
💡 Feel free to contribute or improve the solution!
📢 Got questions? Open an issue or submit a pull request! 🚀
