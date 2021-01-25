
Create database DbPeliculas

use DbPeliculas 
Create table Pelicula(
	Peli_Id int identity(1,1) primary key,
	Peli_Nombre varchar(50),
	Peli_Duracion int,
	Peli_Categoria int foreign key(Peli_Categoria) references Categoria(Cate_Id)
)

Create table Categoria(
	Cate_Id int primary key,
	Cate_Nombre varchar(50)
)

select * from Pelicula
select * from Categoria


