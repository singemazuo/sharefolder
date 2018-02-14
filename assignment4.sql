USE MyGuitarShop;
GO

SELECT 'question #1'
SELECT COUNT(*),SUM(TaxAmount)
FROM Orders;

SELECT 'question #2'
SELECT CategoryName, COUNT(*), MAX(ListPrice)
FROM Categories INNER JOIN Products
ON Categories.CategoryID = Products.ProductID
GROUP BY CategoryName
ORDER BY MAX(ListPrice) DESC;

SELECT 'question #3'
SELECT EmailAddress, SUM(ItemPrice*Quantity), SUM(DiscountAmount*Quantity)
FROM Customers INNER JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
INNER JOIN OrderItems
ON Orders.OrderID = OrderItems.OrderID
GROUP BY EmailAddress
ORDER BY SUM(ItemPrice*Quantity) DESC;

SELECT 'question #4'
SELECT EmailAddress, COUNT(*), SUM((ItemPrice - DiscountAmount) * Quantity)
FROM Customers INNER JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
INNER JOIN OrderItems
ON Orders.OrderID = OrderItems.OrderID
GROUP BY EmailAddress
ORDER BY SUM((ItemPrice - DiscountAmount) * Quantity) DESC;

SELECT 'question #5'
SELECT EmailAddress, COUNT(*), SUM((ItemPrice - DiscountAmount) * Quantity)
FROM Customers INNER JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
INNER JOIN OrderItems
ON Orders.OrderID = OrderItems.OrderID
GROUP BY EmailAddress
HAVING SUM((ItemPrice - DiscountAmount) * Quantity) > 400
ORDER BY SUM((ItemPrice - DiscountAmount) * Quantity) DESC;

SELECT 'question #6'
SELECT EmailAddress, COUNT(DISTINCT [OrderItems].[Quantity])
FROM Customers INNER JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
INNER JOIN OrderItems
ON Orders.OrderID = OrderItems.OrderID
INNER JOIN Products
ON OrderItems.ProductID = Products.ProductID
GROUP BY EmailAddress;
