// Query to find second highest salary of Employee using subquery
SELECT Max(Salary) FROM Employee
Where Salary NOT IN (
  Select MAX(Salary)
    FROM Employee
    );
