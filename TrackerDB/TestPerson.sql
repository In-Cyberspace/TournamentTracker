-- Create a new table called 'TestPerson' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.TestPerson', 'U') IS NOT NULL
DROP TABLE dbo.TestPerson
GO
-- Create the table in the specified schema
CREATE TABLE dbo.TestPerson
(
    SampleId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    -- primary key column
    FirstName [NVARCHAR](100) NOT NULL,
    LastName [NVARCHAR](100) NOT NULL,
    EmailAddress [NVARCHAR](200) NOT NULL,
    PhoneNumber [VARCHAR](20) DEFAULT NULL,
    NumberOfKids INT DEFAULT 0,
    CreateDate DATETIME2 NOT NULL DEFAULT GETUTCDATE()
    -- specify more columns here
);
GO