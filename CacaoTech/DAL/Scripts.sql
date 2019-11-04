create database CacaoDB

use CacaoDB

create table Cacaos (
	CacaoID int primary key identity,
	Precio decimal,
	Tipo varchar(25)
);

if not exists (Select 1 from Cacaos)
	Begin
		insert into Cacaos(Precio, Tipo) Values (63660, 'HISPANIOLA ORGANICO')
		insert into Cacaos(Precio, Tipo) Values (6366.00, 'HISPANIOLA CONVENCIONAL')
		insert into Cacaos(Precio, Tipo) Values (3366.00, 'SANCHEZ ORGANICO')
		insert into Cacaos(Precio, Tipo) Values (6366.00, 'SANCHEZ CONVENCIONAL')
	end

create table Vendedores (
	VendedorID int primary key identity,
	Nombre varchar(10),
	Apellidos varchar(25),
	Direccion varchar(20),
	Cedula varchar(11),
	Telefono varchar(11),
	Celular varchar(11),
	Email varchar(20)
);

create table Contratos (
	ContratoID int primary key identity,

	VendedorID int constraint fk_Vendedor
	foreign key (VendedorID) references 
	Vendedores(VendedorID),

	CacaoID int constraint fk_Cacao
	foreign key (CacaoID) references 
	Cacaos(CacaoID),

	Cantidad int,
	FechaInicio Datetime,
	FechaFin Datetime,
);

create table VendedoresAmbulantes (
	VendedorID int primary key identity,

	CacaoID int constraint fk_VendedorAmbulanteCacao
	foreign key (CacaoID) references 
	Cacaos(CacaoID),

	Nombre varchar(10),
	Apellidos varchar(25),
	Direccion varchar(20),
	Cedula varchar(11),
	Telefono varchar(11),
	Celular varchar(11),
	Email varchar(20)
);

create table Depositos (
	DepositoID int primary key identity,

	VendedorID int constraint fk_VendedorDeosito
	foreign key (VendedorID) references 
	Vendedores(VendedorID),
);