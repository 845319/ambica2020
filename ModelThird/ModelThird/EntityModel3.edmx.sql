
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 12:26:18
-- Generated from EDMX file: C:\Users\pyr\Desktop\ambica2020\ModelThird\ModelThird\EntityModel3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EmployeDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'prods'
CREATE TABLE [dbo].[prods] (
    [prodid] int IDENTITY(1,1) NOT NULL primary key,
    [prodprice] float  NOT NULL,
    [prodtitle] nvarchar(max)  NOT NULL,
    [catoid] int  NOT NULL constraint fk_ps foreign key references catoes(catoid)
);
GO

-- Creating table 'catoes'
CREATE TABLE [dbo].[catoes] (
    [catoid] int IDENTITY(1,1) NOT NULL primary key,
    [catoname] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [prodid] in table 'prods'
ALTER TABLE [dbo].[prods]
ADD CONSTRAINT [PK_prods]
    PRIMARY KEY CLUSTERED ([prodid] ASC);
GO

-- Creating primary key on [catoid] in table 'catoes'
ALTER TABLE [dbo].[catoes]
ADD CONSTRAINT [PK_catoes]
    PRIMARY KEY CLUSTERED ([catoid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------