SELECT Max(Salary)
FROM Employee
Where Salary NOT IN (
  Select MAX(Salary)
    FROM Employee
    );
