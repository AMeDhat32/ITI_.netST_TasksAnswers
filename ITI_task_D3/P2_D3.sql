use Company_SD 
select * from Departments
select * from Employee
select * from Project
select * from Dependent
select * from Works_for

----Display the Department id, name and id and the name of its manager.
select D.Dname,D.Dnum,E.Fname+' '+E.Lname as [Manager Name],SSN from Employee E inner join Departments D on D.MGRSSN =E.SSN
----Display the name of the departments and the name of the projects under its control.
select Dname,Pname from Departments D inner join Project P on D.Dnum = P.Dnum order by Dname asc
----Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select E.Fname +' '+E.Lname as [Employee name],D.*  from Employee E inner join Dependent D on E.SSN = D.ESSN
----Display the Id, name and location of the projects in Cairo or Alex city.
select P.Pname,P.Pnumber,P.Plocation from Project P where P.City in('Alex','Cairo')
----display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * from Employee E where E.Dno=30 and E.Salary>=1000 and E.Salary <=2000 order by E.Salary asc
----Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select distinct E.Fname +' '+E.Lname as [Employee name] 
from Employee E inner join Works_for W on W.Hours>=10 
inner join Project P on E.Dno=10 and P.Dnum = E.Dno and P.Pname='AL Rabwah'
----Find the names of the employees who directly supervised with Kamel Mohamed.
select emp.Fname +' '+emp.Lname as [Employee name]
from Employee emp, Employee mgr
where mgr.SSN= emp.Superssn and mgr.Fname = 'Kamel' and mgr.Lname='Mohamed'
----Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select E.Fname +' '+E.Lname as [Employee name],P.Pname
from Employee E inner join Project P
on E.Dno = P.Dnum
order by P.Pname
----For each project located in Cairo City , find the project number,
----the controlling department name ,the department manager last name ,address and birthdate.
select P.Pnumber,D.Dname,E.Lname,E.Address,E.Bdate
from Project P,Departments D,Employee E
where P.Dnum=D.Dnum and D.MGRSSN=E.SSN and P.City='Cairo'

----Display All Data of the managers
select E.*
from Employee E inner join Departments D
on D.MGRSSN = E.SSN

----Display All Employees data and the data of their dependents even if they have no dependents
select E.*,D.*
from Employee E left outer join Dependent D
on E.SSN=D.ESSN
----Insert your personal data to the employee table
----as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee (Fname ,Lname , SSN ,Salary,Superssn,Dno) 
values('abdelrahman' , 'medhat' , 102672,3000,112233,30)
----Insert another employee with personal data your friend as new employee in
----department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into Employee (Fname ,Lname , SSN ,Dno) 
values('salah' , 'eldin' , 102660,30)
----Upgrade your salary by 20 % of its last value.
update Employee set Salary  = Salary+ Salary *0.2 where SSN=102672

