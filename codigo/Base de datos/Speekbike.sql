create database speekbik;
use speekbik;

create table productos(
codigo varchar(15) primary key,
nombre varchar (50) not null,
marca varchar (50) not null,
categoria int not null,
precio decimal (14,2) not null,
cantiadad int not null,
color_sabor varchar(30) null,
constraint foreign key fk_cat(categoria) references categorias(id)
);

alter table productos drop foreign key fk_cat;

create table categorias(
id int primary key,
nombre varchar(50) not null
);



create table usuarios
(
idUsuario varchar(5)primary key,
nombre varchar (55) not null,
pass varchar (55) not null
);


