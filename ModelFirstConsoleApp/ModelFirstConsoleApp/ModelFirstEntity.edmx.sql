
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 10:37:32
-- Generated from EDMX file: C:\Users\pyr\Desktop\ambica2020\ModelFirstConsoleApp\ModelFirstConsoleApp\ModelFirstEntity.edmx
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

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [pid] int IDENTITY(1,1) NOT NULL primary key,
    [ptitle] nvarchar(max)  NOT NULL,
    [price] float  NOT NULL,
    [cid] int  NOT NULL constraint fk_pr foreign key references categories(cid)
);
GO

-- Creating table 'categories'
CREATE TABLE [dbo].[categories] (
    [cid] int IDENTITY(1,1) NOT NULL primary key,
    [cname] nvarchar(max)  NOT NULL,

);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [pid] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([pid] ASC);
GO

-- Creating primary key on [cid] in table 'categories'
ALTER TABLE [dbo].[categories]
ADD CONSTRAINT [PK_categories]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------