USE Microseguros
GO
DELETE FROM Models
GO
DELETE FROM Devices
GO
DELETE FROM Brands
GO
DELETE FROM Ends
GO
DELETE FROM Cards
GO
DELETE FROM Documents
GO

GO
INSERT INTO Documents([id], [name]) VALUES(1, 'CI')
GO
INSERT INTO Documents([id], [name]) VALUES(2, 'DNI')
GO
INSERT INTO Documents([id], [name]) VALUES(3, 'LC')
GO
INSERT INTO Documents([id], [name]) VALUES(4, 'LE')
GO

INSERT INTO Cards([id], [name]) VALUES(1, 'Diners')
GO
INSERT INTO Cards([id], [name]) VALUES(2, 'MasterCard')
GO
INSERT INTO Cards([id], [name]) VALUES(3, 'VISA')
GO

INSERT INTO Ends([id], [name]) VALUES(1, 'Half')
GO
INSERT INTO Ends([id], [name]) VALUES(2, 'Low')
GO
INSERT INTO Ends([id], [name]) VALUES(3, 'High')
GO

INSERT INTO Brands([id], [name]) VALUES(1, 'Samsung')
GO
INSERT INTO Brands([id], [name]) VALUES(2, 'Motorola')
GO
INSERT INTO Brands([id], [name]) VALUES(3, 'Nokia')
GO
INSERT INTO Brands([id], [name]) VALUES(4, 'Alcatel')
GO
INSERT INTO Brands([id], [name]) VALUES(5, 'Apple')
GO
INSERT INTO Brands([id], [name]) VALUES(6, 'Lenovo')
GO
INSERT INTO Brands([id], [name]) VALUES(7, 'Acer')
GO
INSERT INTO Brands([id], [name]) VALUES(8, 'Asus')
GO
INSERT INTO Brands([id], [name]) VALUES(9, 'HP')
GO
INSERT INTO Brands([id], [name]) VALUES(10, 'DELL')
GO
INSERT INTO Brands([id], [name]) VALUES(11, 'PHILIPS')
GO
INSERT INTO Brands([id], [name]) VALUES(12, 'Google')
GO
INSERT INTO Brands([id], [name]) VALUES(13, 'Toshiba')
GO
INSERT INTO Brands([id], [name]) VALUES(14, 'Sony')
GO

INSERT INTO Devices([id], [name], [icon]) VALUES (1, 'Smartphone', 'phone-portrait')
GO
INSERT INTO Devices([id], [name], [icon]) VALUES (2, 'Tablet', 'tablet-portrait')
GO
INSERT INTO Devices([id], [name], [icon]) VALUES (3, 'Laptop', 'laptop')
GO



INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (1, 'Samsung Galaxy M20', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (2, 'Samsung Galaxy M10', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (3, 'Samsung Galaxy A8s', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (4, 'Samsung Galaxy A6s', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (5, 'Samsung Galaxy J4 Core', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (6, 'Samsung Galaxy A9 (2018)', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (7, 'Samsung Galaxy A7 (2018)', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (8, 'Samsung Galaxy J6+', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (9, 'Samsung Galaxy J4+', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (10, 'Samsung Galaxy Tab A 10.5', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (11, 'Samsung Galaxy Note 9', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (12, 'Samsung Galaxy On6', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (13, 'Samsung Galaxy J7 (2018)', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (14, 'Samsung Galaxy J3 (2018)', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (15, 'Samsung Galaxy A8 Star', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (16, 'Samsung Galaxy A9 Star Lite', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (17, 'Samsung Galaxy A9 Star', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (18, 'Samsung Galaxy S Lite Luxury', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (19, 'Samsung Galaxy J8', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (20, 'Samsung Galaxy J6', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (21, 'Samsung Galaxy J4', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (22, 'Samsung Galaxy A6+', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (23, 'Samsung Galaxy A6', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (24, 'Samsung Galaxy J2 (2018)', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (25, 'Samsung Galaxy J7 Duo', 1, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (26, 'Samsung Galaxy J7 Prime (2018)', 1, 1)
GO


INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (27, 'Motorola Moto E5 Plus (USA)', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (28, 'Motorola One', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (29, 'Motorola P30', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (30, 'Motorola Moto Z3', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (31, 'Motorola Moto E5 Play (Go Edition)', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (32, 'Motorola One Power', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (33, 'Motorola Moto Z3 Play', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (34, 'Motorola Moto E5 Play', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (35, 'Motorola Moto E5 Plus', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (36, 'Motorola Moto E5', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (37, 'Motorola Moto G6 Play', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (38, 'Motorola Moto G6 Plus', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (39, 'Motorola Moto G6', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (40, 'Motorola Moto E4 Plus (USA)', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (41, 'Motorola Moto G5S Plus', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (42, 'Motorola Moto G5S', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (43, 'Motorola Moto Z2 Force', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (44, 'Motorola Moto Z2 Play', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (45, 'Motorola Moto E4 Plus', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (46, 'Motorola Moto E4', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (47, 'Motorola Moto C', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (48, 'Motorola Moto C Plus', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (49, 'Motorola Moto X4', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (50, 'Motorola Moto G5 Plus', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (51, 'Motorola Moto G5', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (52, 'Motorola Moto M', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (53, 'Motorola Moto E3', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (54, 'Motorola Moto E3 Power', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (55, 'Motorola Moto Z Play', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (56, 'Motorola Moto Z Force', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (57, 'Motorola Moto Z', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (58, 'Motorola Moto G4 Play', 2, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (60, 'Nokia 8.1', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (61, 'Nokia 106 (2018)', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (62, 'Nokia 7.1 Plus', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (63, 'Nokia X7 (2018)', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (64, 'Nokia 3.1 Plus', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (65, 'Nokia 7.1', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (66, 'Nokia 5.1 Plus', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (67, 'Nokia 6.1 Plus', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (68, 'Nokia X5', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (69, 'Nokia 5.1', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (70, 'Nokia 3.1', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (71, 'Nokia 2.1', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (72, 'Nokia X6 (2018)', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (73, 'Nokia 8110 4G', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (74, 'Nokia 8 Sirocco', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (75, 'Nokia 7 Plus', 3, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (76, 'Nokia 1', 3, 1)
GO

INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (77, 'Google Pixel 3 XL', 12, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (78, 'Google Pixel 3', 12, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (79, 'Google Pixel 2', 12, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (80, 'Google Pixel 2 XL', 12, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (81, 'Google Pixel XL', 12, 1)
GO
INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (82, 'Google Pixel', 12, 1)
GO


INSERT INTO Models([id], [name], [brandId], [deviceId]) 
VALUES (83, 'Sony D2306', 14, 1)
GO


INSERT INTO ModelEnds(modelId, endId, quoted, insuredValue)
VALUES(79, 1, 300, 700)
GO
INSERT INTO ModelEnds(modelId, endId, quoted, insuredValue)
VALUES(79, 2, 450, 1000)
GO
INSERT INTO ModelEnds(modelId, endId, quoted, insuredValue)
VALUES(79, 3, 1000, 5000)
GO
INSERT INTO ModelEnds(modelId, endId, quoted, insuredValue)
VALUES(83, 1, 250, 500)
GO
INSERT INTO ModelEnds(modelId, endId, quoted, insuredValue)
VALUES(83, 2, 400, 800)
GO
INSERT INTO ModelEnds(modelId, endId, quoted, insuredValue)
VALUES(83, 3, 700, 1000)
GO