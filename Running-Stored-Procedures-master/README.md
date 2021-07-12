# Running-Stored-Procedures
DEMO2_L3_2


Usamos procedures

<pre><code>
string cmdCreateProcedure = @"CREATE PROCEDURE spUpdateGrades @CourseName nvarchar(30), @GradeChange int
                                        AS
                                        BEGIN
	                                        DECLARE @CourseId int
                                            SELECT @CourseId = CourseId 
                                            FROM Courses 
                                            WHERE  Name = 'ASP.NET Core' 
                                            UPDATE Persons SET Grade = (CASE WHEN (Grade + 10) <= 100 THEN (Grade + 10)
                                            								ELSE 100
                                            								END )
                                            WHERE PersonType = 'Student' 
                                                  AND CourseId = @CourseId
                                            END";
                                              </code></pre>
  Y tenemos como resultado:
                                              
![Result](https://github.com/JuanjoSalva/Running-Stored-Procedures/blob/master/img/Result.PNG)


Lo podemos ver en el Azure Daya Studio:

![Result](https://github.com/JuanjoSalva/Running-Stored-Procedures/blob/master/img/Captura.PNG)
