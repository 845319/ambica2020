CREATE PROCEDURE [dbo].[Inserts]
	@courseid int,
	@coursename varchar(max),
	@Startdate date,
	@fee int
AS
	insert into Courses(courseid,coursename,Startdate,fee) values (@courseid,@coursename,@Startdate,@fee);
RETURN 0
