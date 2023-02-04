SELECT p.Name AS 'Product Name',
       c.Name AS 'Category Name'
FROM Products AS p WITH(NOLOCK)
LEFT JOIN ProductsCategories AS pc WITH(NOLOCK)
    ON p.Id = pc.ProductId
LEFT JOIN Categories AS c WITH(NOLOCK)
    ON c.Id = pc.CategoryId;