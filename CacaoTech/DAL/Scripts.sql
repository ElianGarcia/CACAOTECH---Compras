use CacaoDB

if not exists (Select 1 from Cacaos)
	Begin
		insert into Cacaos(Precio, Tipo, Existencia) Values (63660, 'HISPANIOLA ORGANICO', 0)
		insert into Cacaos(Precio, Tipo, Existencia) Values (6366.00, 'HISPANIOLA CONVENCIONAL', 0)
		insert into Cacaos(Precio, Tipo, Existencia) Values (3366.00, 'SANCHEZ ORGANICO', 0)
		insert into Cacaos(Precio, Tipo, Existencia) Values (6366.00, 'SANCHEZ CONVENCIONAL', 0)
	end