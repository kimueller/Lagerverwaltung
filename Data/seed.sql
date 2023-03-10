use WarehouseManagment;

DELETE FROM Articles;
DELETE FROM ProcessTypes;
DELETE FROM BusinessCases;
DELETE FROM StockMovements;

SET IDENTITY_INSERT Articles ON;

INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(1, 'Ghost Pepper', 100, 'Seeds', 1.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(2, 'Carolina Reaper Red', 22, 'Seeds', 2.50);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(3, 'Long Red Cayenne Chili - Plants', 10, 'Plants', 15.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(4, 'Long Red Cayenne Chili', 500, 'Seeds', 2.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(5, 'Hungarian Wax Pepper - Plants', 29, 'Plants', 9.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(6, 'Hungarian Wax Pepper', 55, 'Seeds', 0.50);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(7, 'Ghost Pepper', 100, 'Seeds', 1.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(8, 'Shishito Chili', 263, 'Seeds', 0.20);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(9, 'Cherry Bomb Chili', 99, 'Seeds', 4.50);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(10, 'Holland Red Chili', 27, 'Seeds', 2.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(11, 'Korean Gochugaru Chili', 15, 'Seeds', 2.00);
INSERT INTO Articles(ArticleID, ArticleName, Stock, Unit, Price) VALUES(12, 'Aleppo Pepper', 200, 'Seeds', 0.50);

SET IDENTITY_INSERT Articles OFF;

--SET IDENTITY_INSERT BusinessCases ON;

--INSERT INTO BusinessCases(BusinessCaseID, CreationTime, EmployeeId) VALUES(1, GETDATE(), 'bdd762b2-a69a-4da2-8fd5-e1e3a36e3aec');
--INSERT INTO BusinessCases(BusinessCaseID, CreationTime, EmployeeId) VALUES(2, DATEADD(DAY,-2, GETDATE()), 'bdd762b2-a69a-4da2-8fd5-e1e3a36e3aec');
--INSERT INTO BusinessCases(BusinessCaseID, CreationTime, EmployeeId) VALUES(3, DATEADD(DAY,-20, GETDATE()), 'bdd762b2-a69a-4da2-8fd5-e1e3a36e3aec');

--SET IDENTITY_INSERT BusinessCases OFF;

SET IDENTITY_INSERT ProcessTypes ON;

INSERT INTO ProcessTypes(ProcessTypeID, TypeName) VALUES(1, 'incoming');
INSERT INTO ProcessTypes(ProcessTypeID, TypeName) VALUES(2, 'outgoing');

SET IDENTITY_INSERT ProcessTypes OFF;

--SET IDENTITY_INSERT StockMovements ON;

--INSERT INTO StockMovements(StockMovementID, BusinessCaseID, ProcessTypeID, ArticleID, Amount) VALUES (1, 1, 1, 1, 20);
--INSERT INTO StockMovements(StockMovementID, BusinessCaseID, ProcessTypeID, ArticleID, Amount) VALUES (2, 1, 1, 2, 150);
--INSERT INTO StockMovements(StockMovementID, BusinessCaseID, ProcessTypeID, ArticleID, Amount) VALUES (3, 2, 2, 3, 33);
--INSERT INTO StockMovements(StockMovementID, BusinessCaseID, ProcessTypeID, ArticleID, Amount) VALUES (4, 3, 2, 4, 59);

--SET IDENTITY_INSERT StockMovements OFF;


