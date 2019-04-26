CREATE TABLE [dbo].[Actor] (
    [ActorID]    INT NOT NULL PRIMARY KEY IDENTITY,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [DOB]        DATE         NOT NULL,
    [Background] VARCHAR (50) NULL
) GO

CREATE TABLE [dbo].[ActorMovie] (
    [ActorMovieID] INT NOT NULL PRIMARY KEY IDENTITY,
    [ActorID]      INT NOT NULL,
    [MovieID]      INT NOT NULL
) GO

CREATE TABLE [dbo].[Customers] (
    [MovieID]     INT NOT NULL PRIMARY KEY IDENTITY,
    [Title]       VARCHAR (50) NOT NULL,
    [DirectorID]  INT          NOT NULL,
    [ProducerID]  INT          NOT NULL,
    [GenreID]     INT          NOT NULL,
    [Duration]    TIME (7)     NOT NULL,
    [ReleaseYear] DATE         NOT NULL
) go

CREATE TABLE [dbo].[Directors] (
    [DirectorID] INT NOT NULL PRIMARY KEY IDENTITY,
    [FisrtName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [DOB]        DATE         NOT NULL,
    [Background] VARCHAR (50) NOT NULL
) GO


CREATE TABLE [dbo].[Genre] (
    [GenreID] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name]    VARCHAR (50) NOT NULL
) GO

CREATE TABLE [dbo].[GenreMovie] (
    [GenreMovieID] INT NOT NULL PRIMARY KEY IDENTITY,
    [GenreID]      INT NOT NULL,
    [MovieID]      INT NOT NULL
) GO

CREATE TABLE [dbo].[Movies] (
    [CustomerID]       INT NOT NULL PRIMARY KEY IDENTITY,
    [FirstName]        VARCHAR (50) NOT NULL,
    [LastName]         VARCHAR (50) NOT NULL,
    [StreetAddress]    VARCHAR (50) NOT NULL,
    [City]             VARCHAR (50) NOT NULL,
    [StateID]          INT          NOT NULL,
    [Zipcode]          VARCHAR (10) NOT NULL,
    [PhoneNumer]       VARCHAR (10) NOT NULL,
    [EMailAddress]     VARCHAR (50) NOT NULL,
    [DOB]              DATE         NOT NULL,
    [CCNumber]         VARCHAR (16) NULL,
    [CCExpirationDate] VARCHAR (4)  NULL,
    [CCSecurityCode]   VARCHAR (6)  NULL,
    [Password]         VARCHAR (50) NULL
) GO

CREATE TABLE [dbo].[OrderDetails] (
    [OrderID]  INT NOT NULL,
    [MovieID]  INT NOT NULL PRIMARY KEY IDENTITY,
    [Quantity] INT NOT NULL
) GO

CREATE TABLE [dbo].[Orders] (
    [OrderID]         INT NOT NULL PRIMARY KEY IDENTITY,
    [OrderDate]       DATE  NOT NULL,
    [CustomerID]      INT   NOT NULL,
    [TotalQtyOrdered] INT   NOT NULL,
    [OrderTotal]      MONEY NOT NULL
) GO

CREATE TABLE [dbo].[Producers] (
    [ProducerID] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name]       VARCHAR (50) NOT NULL
) GO

CREATE TABLE [dbo].[States] (
    [Id]           INT NOT NULL PRIMARY KEY IDENTITY,
    [Name]         VARCHAR (50) NOT NULL,
    [Abbreviation] VARCHAR (2)  NOT NULL
) GO

CREATE TABLE [dbo].[Video] (
    [VideoID] INT          INT NOT NULL PRIMARY KEY IDENTITY,
    [MovieID] INT          NOT NULL,
    [Format]  VARCHAR (50) NOT NULL,
    [Price]   MONEY        NOT NULL
) GO


