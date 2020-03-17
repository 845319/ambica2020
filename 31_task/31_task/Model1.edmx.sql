
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2020 17:26:02
-- Generated from EDMX file: C:\Users\pyr\source\repos\31_task\31_task\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [cake];
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

-- Creating table 'movies'
CREATE TABLE [dbo].[movies] (
    [Mv_Id] int IDENTITY(1,1) NOT NULL,
    [Mv_Name] nvarchar(max)  NOT NULL,
    [Mv_Rate] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'theatres'
CREATE TABLE [dbo].[theatres] (
    [Th_Id] int IDENTITY(1,1) NOT NULL,
    [Th_name] nvarchar(max)  NOT NULL,
    [Th_loc] nvarchar(max)  NOT NULL,
    [dist] nvarchar(max)  NOT NULL,
    [movieMv_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Mv_Id] in table 'movies'
ALTER TABLE [dbo].[movies]
ADD CONSTRAINT [PK_movies]
    PRIMARY KEY CLUSTERED ([Mv_Id] ASC);
GO

-- Creating primary key on [Th_Id] in table 'theatres'
ALTER TABLE [dbo].[theatres]
ADD CONSTRAINT [PK_theatres]
    PRIMARY KEY CLUSTERED ([Th_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [movieMv_Id] in table 'theatres'
ALTER TABLE [dbo].[theatres]
ADD CONSTRAINT [FK_movietheatre]
    FOREIGN KEY ([movieMv_Id])
    REFERENCES [dbo].[movies]
        ([Mv_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_movietheatre'
CREATE INDEX [IX_FK_movietheatre]
ON [dbo].[theatres]
    ([movieMv_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------