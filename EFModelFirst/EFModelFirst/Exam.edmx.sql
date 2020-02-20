
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 09:46:39
-- Generated from EDMX file: C:\Users\pyr\Desktop\ambica2020\EFModelFirst\EFModelFirst\Exam.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Exam];
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

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Stid] int IDENTITY(1,1) NOT NULL,
    [Stname] nvarchar(max)  NOT NULL,
    [CourseCid] int  NOT NULL,
    [ExamEid] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Cid] int IDENTITY(1,1) NOT NULL,
    [Cname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [Subid] int IDENTITY(1,1) NOT NULL,
    [Subname] nvarchar(max)  NOT NULL,
    [CourseCid] int  NOT NULL,
    [SchoolSid] int  NOT NULL
);
GO

-- Creating table 'Invigilators'
CREATE TABLE [dbo].[Invigilators] (
    [Iid] int IDENTITY(1,1) NOT NULL,
    [Iname] nvarchar(max)  NOT NULL,
    [SchoolSid] int  NOT NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Sid] int IDENTITY(1,1) NOT NULL,
    [Sname] nvarchar(max)  NOT NULL,
    [Slocation] nvarchar(max)  NOT NULL,
    [ExamEid] int  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [Eid] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Stid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Stid] ASC);
GO

-- Creating primary key on [Cid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Cid] ASC);
GO

-- Creating primary key on [Subid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([Subid] ASC);
GO

-- Creating primary key on [Iid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [PK_Invigilators]
    PRIMARY KEY CLUSTERED ([Iid] ASC);
GO

-- Creating primary key on [Sid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Sid] ASC);
GO

-- Creating primary key on [Eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [SchoolSid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [FK_SchoolInvigilator]
    FOREIGN KEY ([SchoolSid])
    REFERENCES [dbo].[Schools]
        ([Sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolInvigilator'
CREATE INDEX [IX_FK_SchoolInvigilator]
ON [dbo].[Invigilators]
    ([SchoolSid]);
GO

-- Creating foreign key on [ExamEid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [FK_ExamSchool]
    FOREIGN KEY ([ExamEid])
    REFERENCES [dbo].[Exams]
        ([Eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamSchool'
CREATE INDEX [IX_FK_ExamSchool]
ON [dbo].[Schools]
    ([ExamEid]);
GO

-- Creating foreign key on [SchoolSid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [FK_SchoolSubject]
    FOREIGN KEY ([SchoolSid])
    REFERENCES [dbo].[Schools]
        ([Sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolSubject'
CREATE INDEX [IX_FK_SchoolSubject]
ON [dbo].[Subjects]
    ([SchoolSid]);
GO

-- Creating foreign key on [ExamEid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_ExamStudent]
    FOREIGN KEY ([ExamEid])
    REFERENCES [dbo].[Exams]
        ([Eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamStudent'
CREATE INDEX [IX_FK_ExamStudent]
ON [dbo].[Students]
    ([ExamEid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------