INSERT INTO Locations (LocationId, Name, PersonResponsible)
VALUES
(1, 'Hospital', 'Brian');
GO

INSERT INTO ExpensiveStatistic (LocationId, StatisticValue)
VALUES
(1, 666);
GO

INSERT INTO Operators (OperatorId, OperatorName)
VALUES
(1, 'Fred');
GO

INSERT INTO Operators(OperatorId, OperatorName)
VALUES
(2, 'Wilma');
GO

INSERT INTO LocationOperators (LocationId, OperatorId)
VALUES 
(1, 1);
GO

INSERT INTO LocationOperators (LocationId, OperatorId)
VALUES 
(1, 2);
GO

INSERT INTO Locations (LocationId, Name, PersonResponsible)
VALUES
(2, 'Somewhere', 'Fred');
GO

INSERT INTO ExpensiveStatistic (LocationId, StatisticValue)
VALUES
(2, 7777);
GO

INSERT INTO LocationOperators (LocationId, OperatorId)
VALUES 
(2, 2);
GO

INSERT INTO Locations (LocationId, Name, PersonResponsible)
VALUES
(3, 'Elsewhere', 'Fred');
GO