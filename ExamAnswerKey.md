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

