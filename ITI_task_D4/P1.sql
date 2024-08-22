use Company_SD
select * from Employee
select * from Dependent
select * from Departments 
select * from Works_for
select * from Project
----Display (Using Union Function)
 ----The name and the gender of the dependence that's gender is Female and depending on Female Employee.
 ----And the male dependence that depends on Male Employee
select D.Dependent_name,D.Sex
from Dependent D inner join Employee E
on  D.ESSN=E.SSN  and D.Sex=E.Sex and E.Sex ='F'
union 
select D.Dependent_name,D.Sex
from Dependent D inner join Employee E
on  D.ESSN=E.SSN  and D.Sex=E.Sex and E.Sex ='M'
----For each project, list the project name and the total hours per week (for all employees) spent on that project.
select P.Pname,sum(W.Hours)[Total work hours]
from Project p inner join Works_for W
on p.Pnumber=W.Pno
group by P.Pname
----Display the data of the department which has the smallest employee ID over all employees' ID.



----For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select D.Dname ,max(e.Salary)Maximum_salary,min(E.Salary)minimum_salary, avg(E.Salary)Averge_salary 
from Departments D inner join Employee E 
on D.Dnum = E.Dno 
group by D.Dname
----List the full name of all managers who have no dependents
select E.Fname+' '+E.Lname full_name
from Employee E
where not exists (select * from Dependent D where D.ESSN =E.SSN)
----For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
select D.Dnum,D.Dname,count(E.SSN)
from Departments D inner join Employee E
on D.Dnum = E.Dno
group by D.Dnum,D.Dname
having avg(isnull(E.Salary,0))<(select avg(isnull(E.Salary,0)) from Employee)
