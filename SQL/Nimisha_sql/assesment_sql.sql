create database exam
use exam

Create Table departments (
    dept_id INT PRIMARY KEY,
    dept_name VARCHAR(100)
);

CREATE TABLE employees (
    emp_id INT PRIMARY KEY,
    emp_name VARCHAR(100),
    salary DECIMAL(10, 2),
    dept_id INT,
    FOREIGN KEY (dept_id) REFERENCES departments(dept_id)
);

INSERT INTO departments VALUES (1, 'HR'), (2, 'IT'), (3, 'Sales'), (4, 'Marketing');

INSERT INTO employees VALUES
(101, 'Nimmi', 60000, 1),
(102, 'Nisha', 45000, 2),
(103, 'RIthu', 70000, 1),
(104, 'Apsara', 30000, 3),
(105, 'Naushad', 80000, 2),
(106, 'sreelaskshmi', 52000, 2),
(107, 'Lismy', 48000, 4),
(108, 'saritha',30000,3)



select * from departments
select * from employees

select * from employees where salary>50000

select * from departments
select * from employees
Select d.dept_name, COUNT(e.emp_id) AS total_employees
FROM departments d
LEFT JOIN employees e ON d.dept_id = e.dept_id
GROUP BY d.dept_name;


select top 5 * from employees order by salary desc 

Select e.emp_name, e.salary, d.dept_name
From employees e
LEFT JOIN departments d ON e.dept_id = d.dept_id;

select avg(salary)  FROM employees 
Select * FROM employees
Where salary > (SELECT AVG(salary) FROM employees);


