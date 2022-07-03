Select Products.ProductName AS [Urun Adi], SUM([Order Details].UnitPrice * [Order Details].Quantity) AS [Kazanilan Toplam Miktar] From Products 
INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
INNER JOIN Orders ON [Order Details].OrderID = Orders.OrderID
GROUP BY Products.ProductName