use master;
go

--create
If(db_id(N'PizzaBox') is null)
create database PizzaBox;
go

use PizzaBox;
go

create schema [Order];
go

create schema Account;
go

create table [Order].[Order]
(
    OrderId int not null IDENTITY(1,2) --primary key
    ,UserId int not null --foreign key REFERENCES Account.User.UserId
    ,StoreId int not null --foreign key
    ,TotalCost DECIMAL(3,2) not null
    ,OrderDate datetime2(7) not null --computed
    ,Active BIT not null --default
    --,CONSTRAINT PK_Order_OrderId primary key (OrderId)
    --,CONSTRAINT FK_Order_UserId foreign key (UserId) REFERENCES Account.User(UserId)
);

create table [Order].[OrderPizza]
(
    OrderPizzaId int not null IDENTITY(1,2)
    ,OrderId int not NULL
    ,PizzaId int not NULL
);

create table [Order].[Pizza]
(
    PizzaId int not null IDENTITY(1,2)
    ,SizeId int not null --foreign
    ,CrustId int not null --foreign
    ,Price decimal(2,2) not null
    ,Active bit not null
);


-- alter
alter table [Order].[Order]
    add constraint PK_Order_OrderId primary key (OrderId);

alter table [Order].[OrderPizza]
    add constraint PK_OrderPizza_OrderPizzaId primary key (OrderPizzaId);

alter table [Order].[Pizza]
    add constraint PK_Pizza_PizzaId primary key (PizzaId);

alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_OrderId foreign key (OrderId) references [Order].[Order](OrderId);

alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_PizzaId foreign key (PizzaId) references [Order].[Pizza](PizzaId);

alter table [Order].[Order]
    add constraint DF_Order_Active default (1) for Active;

alter table [Order].[Pizza]
    add constraint DF_Pizza_Active default (1) for Active;

alter table [Order].[Order]
    add constraint CK_Order_OrderDate check (OrderDate > '2019-11-11');

alter table [Order].[Order]
    drop constraint CK_Order_OrderDate;

alter table [Order].[Order]
    add TipAmount decimal(2,2) null;

alter table [Order].[Order]
    drop column TipAmount;

-- drop
-- drop TABLE [Order].[OrderPizza];

-- truncate
-- truncate table [Order].[OrderPizza];