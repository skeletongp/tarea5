Create Database Todo;

Use Todo
Go

Create Table tbTareas (idTarea int Primary Key Not Null Identity,
Tarea nvarchar(55) not null, Fecha Date not null, Estado nvarchar(15)
not null)

Create Procedure insertTarea @Tarea nvarchar(50), @fecha Date
as 
Insert into tbTareas (Tarea, Fecha, Estado) Values
(@Tarea, @fecha, 'Activa');


Create Procedure marcarTarea @idTarea int 
as
Update tbTareas set Estado='Completada' Where idTarea=@idTarea;

Create Procedure deleteTarea @idTarea int
as
Delete tbTareas Where idTarea=@idTarea

Select * From tbTareas