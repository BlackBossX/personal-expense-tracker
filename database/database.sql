CREATE DATABASE IF NOT EXISTS pocketledgerDB;
USE pocketledgerDB;

-- Users Table
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    ProfilePicture VARCHAR(255),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Categories Table
CREATE TABLE Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL,
    Type ENUM('Income', 'Expense') NOT NULL
);

-- Transactions Table
CREATE TABLE Transactions (
    TransactionID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    Type ENUM('Income', 'Expense') NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    CategoryID INT,
    Description TEXT,
    Date DATE NOT NULL,

    CONSTRAINT fk_transaction_user
        FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
        ON DELETE CASCADE,

    CONSTRAINT fk_transaction_category
        FOREIGN KEY (CategoryID)
        REFERENCES Categories(CategoryID)
        ON DELETE SET NULL
);

-- Budgets Table
CREATE TABLE Budgets (
    BudgetID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    CategoryID INT NOT NULL,
    MonthYear VARCHAR(20) NOT NULL,
    BudgetAmount DECIMAL(10,2) NOT NULL,

    CONSTRAINT fk_budget_user
        FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
        ON DELETE CASCADE,

    CONSTRAINT fk_budget_category
        FOREIGN KEY (CategoryID)
        REFERENCES Categories(CategoryID)
        ON DELETE CASCADE
);