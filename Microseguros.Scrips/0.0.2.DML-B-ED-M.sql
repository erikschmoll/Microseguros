
DELETE FROM Models
GO


DELETE FROM Brands
GO
INSERT INTO Brands
values(1, 'Google')
GO
INSERT INTO Brands
values(2, 'Asus')
GO
INSERT INTO Brands
values(3, 'SONY')
GO

DELETE FROM Devices
GO
INSERT INTO Devices
values(1, 'Smartphone')
GO
INSERT INTO Devices
values(2, 'Tablet')
GO
INSERT INTO Devices
values(3, 'Laptop')
GO

INSERT INTO Models
values(1, 'D2306', 3, 1, 5800.97)
GO
INSERT INTO Models
values(2, 'X556UQ-NH71', 2, 3, 15000)
GO

