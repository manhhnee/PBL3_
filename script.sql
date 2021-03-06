USE [QuanLyQuanCaPhe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](50) NOT NULL,
	[DisplayName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[TypeID] [int] NOT NULL,
	[IDStaff] [int] NULL,
 CONSTRAINT [PK__Account__C9F284575F1DF56F] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountType]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountType](
	[ID] [int] NOT NULL,
	[TypeName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [datetime] NOT NULL,
	[DateCheckOut] [datetime] NULL,
	[IDTable] [int] NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Discount] [int] NULL,
	[TotalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfor]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDBill] [int] NOT NULL,
	[IDItem] [int] NOT NULL,
	[Amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[IDCategory] [int] NOT NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Age] [int] NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[TypeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableCoffee]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableCoffee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[BillInfor] ADD  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_AccountType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[AccountType] ([ID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_AccountType]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Staff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Staff]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([IDTable])
REFERENCES [dbo].[TableCoffee] ([ID])
GO
ALTER TABLE [dbo].[BillInfor]  WITH CHECK ADD FOREIGN KEY([IDBill])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[BillInfor]  WITH CHECK ADD FOREIGN KEY([IDItem])
REFERENCES [dbo].[Item] ([ID])
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD FOREIGN KEY([IDCategory])
REFERENCES [dbo].[ItemCategory] ([ID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_AccountType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[AccountType] ([ID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_AccountType]
GO
/****** Object:  StoredProcedure [dbo].[GetUnCheckBillIDByTableID]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetUnCheckBillIDByTableID]
@IDTable INT
AS
	SELECT * FROM dbo.Bill WHERE IDTable = @IDTable AND Status = 0

GO
/****** Object:  StoredProcedure [dbo].[USP_AuthoLogin]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_AuthoLogin]
@UserName nvarchar(50),
@PassWord nvarchar(100)
as
begin
    if exists (select * from Account where UserName = @UserName and PassWord = @PassWord and TypeID = 1)
        select 1 as code
    else if exists (select * from Account where UserName = @UserName and PassWord = @PassWord and TypeID = 0)
        select 0 as code
    else if exists(select * from Account where UserName = @UserName and PassWord != @PassWord) 
        select 2 as code
    else select 3 as code
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetAccountByUserName]
@UserName NVARCHAR(50)
as
begin
	Select * from Account where UserName = @UserName
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllAccount]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetAllAccount]
as
begin
	select *
	from dbo.Account 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListBillByDate]
@checkIn datetime, @checkOut datetime
as
begin
	select b.ID, t.Name [Tên bàn], b.TotalPrice [Tổng tiền], b.DateCheckIn [Ngày vào], b.DateCheckOut[Ngày ra], b.Discount[Giảm giá]
	from Bill as b, TableCoffee as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.Status = 1
	and t.ID = b.IDTable 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
as
begin
	Declare @pageRows int = 10
	Declare @selectRows int = @pageRows
	Declare @expectRows int = (@page - 1) * @pageRows

	;with BillShow AS (select b.ID, t.Name [Tên bàn], b.TotalPrice [Tổng tiền], b.DateCheckIn [Ngày vào], b.DateCheckOut[Ngày ra], b.Discount[Giảm giá]
	from Bill as b, TableCoffee as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.Status = 1
	and t.ID = b.IDTable )
	
	select top (@selectRows) * from BillShow where ID not in (Select TOP (@expectRows) ID from BillShow)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListTable]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListTable]
as 
select * from dbo.TableCoffee
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetNumBillByDate]
@checkIn datetime, @checkOut datetime
as
begin
	select COUNT(*)
	from Bill as b, TableCoffee as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.Status = 1
	and t.ID = b.IDTable 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBill]
@IDTable int
as
begin
	insert dbo.Bill(DateCheckIn, DateCheckOut, IDTable, Status, Discount) values (GETDATE(), NULL, @IDTable, 0, 0)
		
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfor]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBillInfor]
@IDBill int, @IDItem int, @Amount int
as
begin
	declare @isExistBillInfo int
	declare @AmountItem int = 1

	select @isExistBillInfo = ID , @AmountItem = Amount
	from dbo.BillInfor
	where IDBill = @IDBill and IDItem = @IDItem

	if (@isExistBillInfo > 0)
	begin
		declare @newAmount int = @AmountItem + @Amount
		if (@newAmount > 0)
			update dbo.BillInfor set Amount = @newAmount where IDItem = @IDItem
		ELSE IF (@newAmount <= 0)
			delete dbo.BillInfor where IDBill = @IDBill and IDItem = @IDItem
	end
	else
		IF (@Amount > 0)
			INSERT into dbo.BillInfor(IDBill, IDItem, Amount) values (@IDBill, @IDItem, @Amount)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_InsertItem]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[USP_InsertItem]
@Name NVARCHAR(100), @IDCategory INT, @Price FLOAT
AS
	INSERT dbo.Item( Name, IDCategory, Price )
	VALUES  ( @Name, @IDCategory, @Price )


GO
/****** Object:  StoredProcedure [dbo].[USP_SwapTable]    Script Date: 6/28/2022 11:00:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_SwapTable]
@TableID1 INT, @TableID2 INT
AS
BEGIN
	DECLARE @isTable1Null INT = 0
	DECLARE @isTable2Null INT = 0
	SELECT @isTable1Null = ID FROM dbo.Bill WHERE IDTable = @TableID1 AND Status = 0
	SELECT @isTable2Null = ID FROM dbo.Bill WHERE IDTable = @TableID2 AND Status = 0

	IF (@isTable1Null = 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET IDTable = @TableID1 WHERE ID = @isTable2Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID1
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID2
        END
	ELSE IF (@isTable1Null > 0 AND @isTable2Null = 0)
		BEGIN
			UPDATE dbo.Bill SET IDTable = @TableID2 WHERE Status = 0 AND ID = @isTable1Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
        END
    ELSE IF (@isTable1Null > 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET IDTable = @TableID2 WHERE ID = @isTable1Null
			UPDATE dbo.Bill SET IDTable = @TableID1 WHERE ID = @isTable2Null
        END
END
GO

GO
Create trigger UTG_UpdateBillInfor
on BillInfor for insert
as
begin
	declare @IDBill int
	select @IDBill = IDBill from inserted

	declare @IDTable int
	select @IDTable = IDTable from Bill where ID = @IDBill and status = 0

	declare @count int
	select @count = COUNT(*) from BillInfor where IDBill = @IDBill

	if (@count > 0)
		update TableCoffee set Status = N'Có người' where ID = @IDTable
	else
		update TableCoffee set Status = N'Trống' where ID = @IDTable
end
go

CREATE TRIGGER UTG_UpdateBill
on Bill for update
as
begin
	declare @IDBill int
	select @IDBill = ID from inserted
	declare @IDTable int
	select @IDTable = IDTable from Bill where ID = @IDBill
	declare @amount int = 0
	select @amount = COUNT(*) from Bill where IDTable = @IDTable and Status = 0
	if (@amount = 0)
		update TableCoffee set Status = N'Trống' where ID = @IDTable
end
GO