select emp.name as Employee from employee as emp join employee as manager on emp.managerId = manager.id
where emp.salary > manager.salary;