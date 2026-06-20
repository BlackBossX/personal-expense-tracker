CREATE DATABASE IF NOT EXISTS pocketledgerDB;
USE pocketledgerDB;


CREATE TABLE IF NOT EXISTS Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    ProfilePicture VARCHAR(255),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE IF NOT EXISTS Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL,
    Type ENUM('Income', 'Expense') NOT NULL
);


CREATE TABLE IF NOT EXISTS Transactions (
    TransactionID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    Type ENUM('Income', 'Expense') NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    CategoryID INT,
    PaymentMethod VARCHAR(50) DEFAULT 'Cash',
    Description TEXT,
    Notes TEXT,
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







CREATE TABLE IF NOT EXISTS Budgets (
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





INSERT IGNORE INTO Categories (CategoryID, CategoryName, Type) VALUES
  (1,  'Salary',            'Income'),
  (2,  'Business',          'Income'),
  (3,  'Investment',        'Income'),
  (4,  'Freelance',         'Income'),
  (5,  'Other Income',      'Income'),
  (6,  'Food & Dining',     'Expense'),
  (7,  'Transport',         'Expense'),
  (8,  'Bills & Utilities', 'Expense'),
  (9,  'Shopping',          'Expense'),
  (10, 'Healthcare',        'Expense'),
  (11, 'Entertainment',     'Expense'),
  (12, 'Education',         'Expense'),
  (13, 'Other Expense',     'Expense');






CREATE OR REPLACE VIEW BudgetSummaryView AS
SELECT
    b.BudgetID,
    u.Email,
    c.CategoryName,
    b.MonthYear,
    b.BudgetAmount,
    COALESCE(SUM(t.Amount), 0)                          AS SpentAmount,
    b.BudgetAmount - COALESCE(SUM(t.Amount), 0)         AS RemainingAmount,
    CASE
        WHEN b.BudgetAmount = 0 THEN 'No Budget'
        WHEN COALESCE(SUM(t.Amount), 0) >= b.BudgetAmount THEN 'Over Budget'
        WHEN COALESCE(SUM(t.Amount), 0) >= b.BudgetAmount * 0.70 THEN 'Warning'
        ELSE 'Safe'
    END AS Status
FROM Budgets b
INNER JOIN Users u   ON b.UserID   = u.UserID
INNER JOIN Categories c ON b.CategoryID = c.CategoryID
LEFT  JOIN Transactions t
    ON  t.UserID     = b.UserID
    AND t.CategoryID = b.CategoryID
    AND t.Type       = 'Expense'
    AND DATE_FORMAT(t.Date, '%M') = b.MonthYear
GROUP BY
    b.BudgetID, u.Email, c.CategoryName, b.MonthYear, b.BudgetAmount;