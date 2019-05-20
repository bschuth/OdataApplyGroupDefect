CREATE TABLE Locations (
  LocationId INT PRIMARY KEY,
  Name NVARCHAR(20) NOT NULL,
  PersonResponsible NVARCHAR(20) NULL);
GO

CREATE TABLE ExpensiveStatistic (
  LocationId INT PRIMARY KEY,
  StatisticValue INT NOT NULL);
GO

ALTER TABLE ExpensiveStatistic
ADD CONSTRAINT FK_ExpensiveStatistic_Locations
FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId)
ON DELETE CASCADE; 
GO

CREATE TABLE Operators (
  OperatorId INT PRIMARY KEY,
  OperatorName NVARCHAR(100) NOT NULL);
GO

CREATE TABLE LocationOperators (
	LocationId INT NOT NULL,
	OperatorId INT NOT NULL
)
GO

ALTER TABLE LocationOperators
ADD CONSTRAINT PK_LocationOperators
PRIMARY KEY (LocationId, OperatorId);
GO

ALTER TABLE LocationOperators
ADD CONSTRAINT FK_LocationOperators_Location
FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);
GO

ALTER TABLE LocationOperators
ADD CONSTRAINT FK_LocationOperators_Operators
FOREIGN KEY (OperatorId)
REFERENCES Operators(OperatorId);
GO