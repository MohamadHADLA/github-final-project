
-- database.sql
CREATE TABLE Users (
    UserID INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(100),
    Email VARCHAR(100),
    HashedPassword VARCHAR(255),
    Role VARCHAR(50)
);
