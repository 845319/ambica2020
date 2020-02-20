
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 10:32:54
-- Generated from EDMX file: C:\Users\pyr\Desktop\ambica2020\EF2\EF2\EFentity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SchoolExam];
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

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [SCid] int IDENTITY(1,1) NOT NULL,
    [SCname] nvarchar(max)  NOT NULL,
    [SClocation] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [Eid] int IDENTITY(1,1) NOT NULL,
    [SchoolSCid] int  NOT NULL
);
GO

-- Creating table 'Invigilators'
CREATE TABLE [dbo].[Invigilators] (
    [Iid] int IDENTITY(1,1) NOT NULL,
    [Iname] nvarchar(max)  NOT NULL,
    [SchoolSCid] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Cid] int IDENTITY(1,1) NOT NULL,
    [Cname] nvarchar(max)  NOT NULL,
    [SchoolSCid] int  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [Sid] int IDENTITY(1,1) NOT NULL,
    [Sname] nvarchar(max)  NOT NULL,
    [CourseCid] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [STid] int IDENTITY(1,1) NOT NULL,
    [STname] nvarchar(max)  NOT NULL,
    [CourseCid] int  NOT NULL,
    [SchoolSCid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SCid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([SCid] ASC);
GO

-- Creating primary key on [Eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- Creating primary key on [Iid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [PK_Invigilators]
    PRIMARY KEY CLUSTERED ([Iid] ASC);
GO

-- Creating primary key on [Cid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Cid] ASC);
GO

-- Creating primary key on [Sid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([Sid] ASC);
GO

-- Creating primary key on [STid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([STid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SchoolSCid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [FK_SchoolExam]
    FOREIGN KEY ([SchoolSCid])
    REFERENCES [dbo].[Schools]
        ([SCid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolExam'
CREATE INDEX [IX_FK_SchoolExam]
ON [dbo].[Exams]
    ([SchoolSCid]);
GO

-- Creating foreign key on [SchoolSCid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [FK_SchoolInvigilator]
    FOREIGN KEY ([SchoolSCid])
    REFERENCES [dbo].[Schools]
        ([SCid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolInvigilator'
CREATE INDEX [IX_FK_SchoolInvigilator]
ON [dbo].[Invigilators]
    ([SchoolSCid]);
GO

-- Creating foreign key on [SchoolSCid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_SchoolCourse]
    FOREIGN KEY ([SchoolSCid])
    REFERENCES [dbo].[Schools]
        ([SCid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolCourse'
CREATE INDEX [IX_FK_SchoolCourse]
ON [dbo].[Courses]
    ([SchoolSCid]);
GO

-- Creating foreign key on [CourseCid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [FK_CourseSubject]
    FOREIGN KEY ([CourseCid])
    REFERENCES [dbo].[Courses]
        ([Cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseSubject'
CREATE INDEX [IX_FK_CourseSubject]
ON [dbo].[Subjects]
    ([CourseCid]);
GO

-- Creating foreign key on [CourseCid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CourseStudent]
    FOREIGN KEY ([CourseCid])
    REFERENCES [dbo].[Courses]
        ([Cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseStudent'
CREATE INDEX [IX_FK_CourseStudent]
ON [dbo].[Students]
    ([CourseCid]);
GO

-- Creating foreign key on [SchoolSCid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_SchoolStudent]
    FOREIGN KEY ([SchoolSCid])
    REFERENCES [dbo].[Schools]
        ([SCid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolStudent'
CREATE INDEX [IX_FK_SchoolStudent]
ON [dbo].[Students]
    ([SchoolSCid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------