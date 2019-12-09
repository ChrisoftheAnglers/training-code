use AdventureWorks2017;
go

-- select
select 1 + 1;

select *
from Person.Person;

select firstname, lastname, middlename
from Person.Person;

select firstname, lastname, middlename
from Person.Person
where FirstName = 'robert' or FirstName = 'john';

select firstname, lastname, middlename
from Person.Person
where FirstName = 'robert' and FirstName = 'john';

select firstname, lastname, middlename
from Person.Person
where FirstName <> 'robert' and FirstName <> 'john';

select firstname, lastname, middlename
from Person.Person
where FirstName = 'robert' and not FirstName = 'john';

select firstname, LastName
from Person.Person
where FirstName like '%robert%';

select firstname, lastname, middlename
from Person.Person
where FirstName like '%r%e' and FirstName like 'r___';

select firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by firstname, lastname;

select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1;

select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1
ORDER BY lastname asc, FirstName desc;

select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1
ORDER BY "amount of"

SELECT * FROM Person.Address
WHERE AddressLine1 = 'UT' or AddressLine2 = 'ut';

-- INSERT into Person.Address(AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, SpatialLocation, rowguid, ModifiedDate)
-- values ('UT', NULL, 'Arlington', 79, 76010, 0xE6100000010CAE8BFC28BCE4474067A89189898A5EC0, '9aadcb0d-36cf-483f-84d8-585c2d4ec6fg', '2019-11-08');

-- INSERT into Person.Address
-- SELECT AddressLine2, AddressLine1, City, StateProvinceID, PostalCode, SpatialLocation, rowguid, ModifiedDate
-- from Person.Address
-- WHERE AddressLine1 = 'UT';

-- bulk insert Person.Address from 'data.csv' with (rowterminator = '\n', fieldterminator = ',');

-- update (always mentally process these sorts of operations before you run them, and always use WHERE to minimize accidental damage)

update Person.Person
set firstname = 'john'
where FirstName = 'robert';

update pp
set firstname = 'robert'
from Person.Person as pp
WHERE pp.LastName = 'jones';

-- delete
-- delete
-- from Person.Person
-- where MiddleName is null and FirstName = 'xavier';

-- join

-- CTE using 'with' keyword
with OrderHeader as 
(
    select salesorderid, customerid
    from Sales.SalesOrderHeader
    where month(OrderDate) = 7
),
Product AS
(
    select productid, name
    from Production.Product
    where Name like '%tire%'
)

select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join Person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join Person.Address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityID
inner join OrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
inner join Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';

select distinct pp1.firstname, pp2.lastname
from Person.Person as pp1
inner join Person.Person as pp2 on pp2.LastName = pp1.FirstName;

select firstname
from Person.Person
UNION
select lastname
from Person.Person;