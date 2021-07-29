create database PruebaTecnica
use PruebaTecnica
go

create table Personas (
 Id int primary key identity(1,1),
 Nombre varchar(100),
 Apellido varchar(100),
 FechaNacimiento date,
 pasaporte varchar(100),
 direccion varchar(200),
 sexo varchar(100)





)

go

create table Estados(
Estado varchar(100)

)
go

insert into Estados values('Abierta')
insert into Estados values('Aprobada')
insert into Estados values('Cancelada')



create table Solicitud (
Id int primary key identity(1,1),
PersonaId int foreign key references Personas(Id) on delete cascade on update cascade,
Estado varchar(100),
FechaCreacion date


)

