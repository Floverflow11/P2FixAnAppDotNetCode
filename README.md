# Lambazon Web App

This repository contains the source code for the Lambazon e-commerce web application. This guide explains how to set up and run the project locally for development and testing.

## Requirements

- [**.NET 9.0 SDK**](https://dotnet.microsoft.com/fr-fr/download/dotnet/9.0)
- **Git**
- An **IDE** of your choice, such as:
  - **Visual Studio 2022**
  - **JetBrains Rider**
  - **Visual Studio Code** ([with the C# Dev Kit extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit))

## Getting Started

Follow these steps to get a local copy up and running.

### 1. Clone the Repository and Switch to the Dev Branch

Open your terminal, clone the project, and then switch to the `dev` branch.

```
git clone https://github.com/Floverflow11/P2FixAnAppDotNetCode.git
cd P2FixAnAppDotNetCode
git checkout dev
```

### 2. Run the Application

You can run the project using the command line or directly from your IDE.

#### Using the Command Line

```
dotnet restore
dotnet run
```

#### Using an IDE
1. Open the solution file *P2FixAnAppDotNetCode.sln* in Visual Studio or JetBrains Rider.
2. Press F5 or click the Run button.
3. The IDE will automatically restore dependencies, build, and launch the application.