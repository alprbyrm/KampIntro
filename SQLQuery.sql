--SELECT
select ContactName Adi,CompanyName ŞirketAdi,city Şehir from Customers 


Select * from Customers where City='Berlin'

--case insensitive (büyük küçük harf duyaarsız)
SELECT *from Products where CategoryID=1 or CategoryID=3

select *from Products where CategoryID=1 and UnitPrice>=10

--ascendıng artan   --descending düşen
Select *from Products where CategoryID=1 order by UnitPrice desc

Select count(*) from Products where CategoryID = 1

--hangi kategoriden kaç ürün var
-- groupby olduğundan her bir ıd için ayrı ayrı hesaplanıyor
select categoryId,count(*) from Products group by CategoryID

--10 DAN AZ ürün çeşidi olan kategorileri ver
select categoryId,count(*) from Products group by CategoryID having count (*)<10

select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count (*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select *from Products p inner join [Order Details] od 
on p.ProductID=od.ProductID
--SOLDA OLUP SAĞDA OLMAYANLARIDA GETİR
--Ürünler tablosunda var ama Satış yapılmamış ürünleri getirir
Select *from Products p left join [Order Details] od 
on p.ProductID=od.ProductID

Select *from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null
