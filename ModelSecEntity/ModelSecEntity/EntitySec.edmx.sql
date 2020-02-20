
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 11:48:04
-- Generated from EDMX file: C:\Users\pyr\Desktop\ambica2020\ModelSecEntity\ModelSecEntity\EntitySec.edmx
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

-- Creating table 'cats'
CREATE TABLE [dbo].[cats] (
    [catid] int IDENTITY(1,1) NOT NULL,
    [catname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'pros'
CREATE TABLE [dbo].[pros] (
    [proid] int IDENTITY(1,1) NOT NULL,
    [proname] nvarchar(max)  NOT NULL,
    [proprice] float  NOT NULL,
    [catid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [catid] in table 'cats'
ALTER TABLE [dbo].[cats]
ADD CONSTRAINT [PK_cats]
    PRIMARY KEY CLUSTERED ([catid] ASC);
GO

-- Creating primary key on [proid] in table 'pros'
ALTER TABLE [dbo].[pros]
ADD CONSTRAINT [PK_pros]
    PRIMARY KEY CLUSTERED ([proid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------