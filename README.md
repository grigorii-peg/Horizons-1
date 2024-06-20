```
USE [HorizonsDb]
GO
SET IDENTITY_INSERT [dbo].[Excursions] ON 

INSERT [dbo].[Excursions] ([Id], [Title], [Cost]) VALUES (1, N'Обзорная экскурсия по Минску', 3000)
INSERT [dbo].[Excursions] ([Id], [Title], [Cost]) VALUES (2, N'Путешествие по замкам Беларуси', 8000)
INSERT [dbo].[Excursions] ([Id], [Title], [Cost]) VALUES (3, N'Брестская крепость', 6000)
INSERT [dbo].[Excursions] ([Id], [Title], [Cost]) VALUES (4, N'Летописный Гродно', 5000)
INSERT [dbo].[Excursions] ([Id], [Title], [Cost]) VALUES (5, N'Путешествие в Беловежскую пущу', 9000)
SET IDENTITY_INSERT [dbo].[Excursions] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Title]) VALUES (1, N'Клиент')
INSERT [dbo].[Roles] ([Id], [Title]) VALUES (2, N'Менеджер')
INSERT [dbo].[Roles] ([Id], [Title]) VALUES (3, N'Администратор')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [Salt], [RoleId]) VALUES (2, N'Пегушин Григорий Алексеевич', N'admin', N'admin', N'', 3)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [Salt], [RoleId]) VALUES (3, N'Фёдоров Антон Павлович', N'manager', N'manager', N'', 2)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [Salt], [RoleId]) VALUES (4, N'Петров Виктор Сергеевич', N'client', N'client', N'', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomTypes] ON 

INSERT [dbo].[RoomTypes] ([Id], [Title], [MaxPersonCount], [NightCost]) VALUES (1, N'Эконом', 3, 2000)
INSERT [dbo].[RoomTypes] ([Id], [Title], [MaxPersonCount], [NightCost]) VALUES (2, N'Комфорт', 4, 4000)
INSERT [dbo].[RoomTypes] ([Id], [Title], [MaxPersonCount], [NightCost]) VALUES (3, N'Люкс', 6, 6000)
INSERT [dbo].[RoomTypes] ([Id], [Title], [MaxPersonCount], [NightCost]) VALUES (4, N'Президентский', 8, 10000)
SET IDENTITY_INSERT [dbo].[RoomTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Transfers] ON 

INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (2, N'Трансфер до отеля (эконом)', 3000)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (3, N'Трансфер до аэропорта (эконом)', 3000)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (4, N'Трансфер в обе стороны (эконом)', 6000)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (5, N'Трансфер до отеля (комфорт)', 4500)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (6, N'Трансфер до аэропорта (комфорт)', 4500)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (7, N'Трансфер в обе стороны (комфорт)', 9000)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (8, N'Трансфер до отеля (премиум)', 6000)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (9, N'Трансфер до аэропорта (премиум)', 6000)
INSERT [dbo].[Transfers] ([Id], [Title], [Cost]) VALUES (10, N'Трансфер в обе стороны (премиум)', 12000)
SET IDENTITY_INSERT [dbo].[Transfers] OFF
GO
SET IDENTITY_INSERT [dbo].[TourOrders] ON 

INSERT [dbo].[TourOrders] ([Id], [StartDate], [EndDate], [ClientId], [PersonCount], [RoomTypeId], [TransferId], [ManagerId]) VALUES (3, CAST(N'2024-06-11T00:00:00.000' AS DateTime), CAST(N'2024-06-12T00:00:00.000' AS DateTime), 4, 1, 1, 2, 3)
INSERT [dbo].[TourOrders] ([Id], [StartDate], [EndDate], [ClientId], [PersonCount], [RoomTypeId], [TransferId], [ManagerId]) VALUES (4, CAST(N'2024-06-14T00:00:00.000' AS DateTime), CAST(N'2024-06-21T00:00:00.000' AS DateTime), 4, 3, 2, 9, 3)

INSERT [dbo].[TourOrders] ([Id], [StartDate], [EndDate], [ClientId], [PersonCount], [RoomTypeId], [TransferId], [ManagerId], [ExcursionsId]) VALUES (17, CAST(N'2024-06-20T00:00:00.000' AS DateTime), CAST(N'2024-06-21T00:00:00.000' AS DateTime), 4, 2, 1, 2, 2, 1)
INSERT [dbo].[TourOrders] ([Id], [StartDate], [EndDate], [ClientId], [PersonCount], [RoomTypeId], [TransferId], [ManagerId], [ExcursionsId]) VALUES (18, CAST(N'2024-06-21T00:00:00.000' AS DateTime), CAST(N'2024-06-22T00:00:00.000' AS DateTime), 4, 1, 2, 5, 2, 3)
SET IDENTITY_INSERT [dbo].[TourOrders] OFF
GO

```
