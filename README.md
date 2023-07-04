# Practical-13
------**Practical_13_1**------

Create an MVC Project to demonstrate Entity Framework with Code First migration.

·  Create a table employee with the following columns & data type using the Code First migration

**Column Name || Data Type || Null Allowed**

Id || Int (Primary Key, Auto Increment) || N

Name || Varchar (50) || No

DOB || Date || No

Age || int || Yes

·         Create a listing page that lists all the records from the table like below
![image](https://github.com/AbhayChothaniSimform/Practical-13/assets/125371527/53581370-734f-4f70-aecd-a7c5a9e03ae6)


·         The “Create New” link should open a page that helps users to insert a record into the database.

·         On click of the “Edit” link, the user should be displayed a page that can update the records

·         On click of the “Delete” link, the user should be asked for confirmation with Yes/No button & on click of the Yes button that record should be deleted.


------**Practical_13_2**------


Create an MVC Project to demonstrate Entity Framework with Code First migration.

·         Create below tables columns & data type using the Code First migration

**Table 1: Designation**

**Column Name || Data Type || Null Allowed**

Id || Int (Primary Key, Auto Increment) || N

Designation || Varchar (50) || No

 **Table 2: Employee**

**Column Name || Data Type || Null Allowed**

Id || Int (Primary Key, Auto Increment) || N

First Name || Varchar (50) || No

Middle Name || Varchar (50) || Yes

Last Name || Varchar (50) || No

DOB || Date || No

Mobile Number || Varchar (10) || No

Address || Varchar (100) || Yes

Salary || Decimal || No

DesignationId || Int (FK to Designation Table) || Yes

 

·         Implement CRUD functionality for both tables.

·         While implementing Insert/Update functionality for Employee table, a list of inserted Designations should be displayed to the user. Whichever designation is selected by the user should be inserted/updated into the database.

·         Add a button to the page and on click of that button, Columns should be displayed with the help of LINQ query. Columns are Employee Id, First Name, Middle Name, Last Name, Designation Name, DOB, Mobile Number, Address & Salary

·         Add a button to the page and on click of that button, display the count number of records of the employee by designation name using LINQ query.
