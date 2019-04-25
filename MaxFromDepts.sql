-- Query to find Max Salary from each department
SELECT DeptID, MAX(Salary)
  FROM Employee 
    GROUP BY DeptID
