-- ANSII standartları, case insensitive
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

Select * from Products order by ProductName

Select * from Products order by CategoryID,ProductName

Select * from Products order by UnitPrice ASC --ascending

Select * from Products where CategoryID = 1 order by UnitPrice DESC --descending

Select count(*) from Products

Select CategoryID from Products group by CategoryID

Select CategoryID,COUNT(*) from Products group by CategoryID

Select CategoryID,COUNT(*) from Products group by CategoryID having COUNT(*)<10

Select CategoryID,COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

-- inner join sadece iki tablodada eşleşenleri getirir, eşleşmeyen data varsa onları getirmez
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
-- DTO- Data Transformation Objecct 

-- left join solda olup sağda olmayanlar. right join ise tam tersi.
Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- birden fazlo tablo eklemek
Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID