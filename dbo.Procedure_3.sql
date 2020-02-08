CREATE PROCEDURE [dbo].[InsertRecord]
	@courseid int,
	@coursename varchar(max),
	@Startdate date,
	@fee int
AS
	insert into Courses(courseid,coursename,Startdate,fee) values (@courseid,@coursename,@Startdate,@fee)
