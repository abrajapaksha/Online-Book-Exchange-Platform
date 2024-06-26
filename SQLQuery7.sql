
DROP TABLE RequsetTable;
CREATE TABLE RequsetTable (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NULL,
    LastName VARCHAR(50) NULL,
    Location1 VARCHAR(50) NULL,
    Mobile VARCHAR(20) NULL,
    RequestDate DATE,
    OwnerID VARCHAR(10) NULL
);
