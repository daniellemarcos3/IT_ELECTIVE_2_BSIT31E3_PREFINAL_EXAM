\# IT ELECTIVE 2 - PREFINAL EXAM

\## Answer Key Progress



\### Question 1



\*\*Question:\*\*

What is the main problem solved by using a database instead of an in-memory collection?



\*\*Answer:\*\*

C. It allows data to persist after the application stops.



\*\*Explanation:\*\*

A database stores data persistently, so information remains available even after the application stops or restarts.



\---



\### Question 2



\*\*Question:\*\*

Which approach is being used when an existing database is used to generate EF Core entity classes?



\*\*Answer:\*\*

B. Database-First



\*\*Explanation:\*\*

Database-First starts with an existing database and generates EF Core entity classes and a DbContext from it.



\---



\### Question 3



\*\*Question:\*\*

What is the primary purpose of Entity Framework Core?



\*\*Answer:\*\*

C. To map objects in code to relational database data.



\*\*Explanation:\*\*

Entity Framework Core is an ORM that allows .NET objects and classes to work with relational database data.



\---



\### Question 4



\*\*Question:\*\*

Which EF Core component is primarily responsible for communicating with the database?



\*\*Answer:\*\*

A. DbContext



\*\*Explanation:\*\*

DbContext manages the connection and communication between the application and the database.



\---



\### Question 5



\*\*Question:\*\*  

What does the following command generate?



`dotnet ef dbcontext scaffold "ConnectionString" Microsoft.EntityFrameworkCore.SqlServer -o Models`



\*\*Answer:\*\*  

C. EF Core models and a DbContext from an existing database



\*\*Explanation:\*\*  

The Scaffold-DbContext command reads the existing database structure and automatically generates the entity model classes and DbContext needed by EF Core.



\---



\### Question 6



\*\*Question:\*\*  

Where is the connection string commonly stored in an ASP.NET Core MVC application?



\*\*Answer:\*\*  

B. appsettings.json



\*\*Explanation:\*\*  

The connection string is commonly placed in appsettings.json so that database connection settings can be configured separately from the application code.



\---



\### Question 7



\*\*Question:\*\*  

A Student belongs to one Section, while a Section can have many Students. What type of relationship is this?



\*\*Answer:\*\*  

B. One-to-Many



\*\*Explanation:\*\*  

One Section can have many Students, while each Student belongs to only one Section. This is a One-to-Many relationship.



\---



\### Question 8



\*\*Question:\*\*  

What is the purpose of SectionId in the Student table?



\*\*Answer:\*\*  

B. It is a foreign key referencing the Section table



\*\*Explanation:\*\*  

SectionId connects each Student record to the Section it belongs to. It serves as a foreign key that references the primary key of the Section table.



\---



\### Question 9



\*\*Question:\*\*  

What is a navigation property in an EF Core entity?



\*\*Answer:\*\*  

B. A property that represents a relationship to another entity



\*\*Explanation:\*\*  

A navigation property allows an entity to access related data from another entity. For example, a Student entity can have a Section navigation property to represent its relationship with a Section.



**---**



**### Question 10**



**\*\*Question:\*\***  

**What does the `.Include()` method do in Entity Framework Core?**



**\*\*Answer:\*\***  

**B. It loads related data from another entity**



**\*\*Explanation:\*\***  

**The `.Include()` method is used to load related navigation properties together with the main entity. For example, it can load the Section data together with Students.**



**---**



**### Question 11**



**\*\*Question:\*\***  

**What is the purpose of a ViewModel in an ASP.NET Core MVC application?**



**\*\*Answer:\*\***  

**B. To combine and shape data specifically needed by the view**



**\*\*Explanation:\*\***  

**A ViewModel contains the data and information that a specific view needs. It helps organize and present data without directly exposing the entire entity model.**



**---**



**### Question 12**



**\*\*Question:\*\***  

**What does `.Include(s => s.Section)` do in an EF Core query?**



**\*\*Answer:\*\***  

**A. It loads the related Section navigation property**



**\*\*Explanation:\*\***  

**The `.Include()` method tells Entity Framework Core to load the related Section data together with the Student records.**



**---**



**### Question 13**



**\*\*Question:\*\***  

**What type of validation happens in the browser before the form is submitted to the server?**



**\*\*Answer:\*\***  

**B. Client-side validation**



**\*\*Explanation:\*\***  

**Client-side validation checks the user's input in the browser before the form is sent to the server. It provides immediate feedback when the entered data is invalid.**



**---**



**### Question 14**



**\*\*Question:\*\***  

**Why is server-side validation still necessary even when client-side validation is implemented?**



**\*\*Answer:\*\***  

**A. Client-side validation can be bypassed**



**\*\*Explanation:\*\***  

**Client-side validation happens in the user's browser and can be disabled or bypassed. Server-side validation ensures that data is properly validated before it is processed or saved by the application.**

