
CREATE DATABASE BusinessDb



 IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'BusinessDb')
  BEGIN
    CREATE DATABASE BusinessDb
  END
  else print'ss'




  IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BusinessDb].[dbo].[Category]') AND type in (N'U'))
BEGIN
  -- create
  
USE BusinessDb
Create TABLE   Category
 (  
   Id INT IDENTITY PRIMARY KEY,
   Name nvarchar(100) NOT NULL Unique 
    ); 
END
else print'ss'



USE BusinessDb
Create TABLE   Category
 (  
   Id INT IDENTITY PRIMARY KEY,
   Name nvarchar(100) NOT NULL Unique 
    ); 



	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BusinessDb].[dbo].[Business]') AND type in (N'U'))
BEGIN
  -- create
 USE BusinessDb
CREATE TABLE Business
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL Unique,
	[Text] NVARCHAR(200) NOT NULL,
	StartDate DATETIME NOT NULL,
	Deadline DATETIME NOT NULL,
	[State] NVARCHAR(20) NOT NULL,
	id_Category int  NOT NULL FOREIGN KEY REFERENCES Category(id)   
);
END
else print'ss'



USE BusinessDb
CREATE TABLE Business
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL Unique,
	[Text] NVARCHAR(200) NOT NULL,
	StartDate DATETIME NOT NULL,
	Deadline DATETIME NOT NULL,
	[State] NVARCHAR(20) NOT NULL,
	id_Category int  NOT NULL FOREIGN KEY REFERENCES Category(id)   
);

