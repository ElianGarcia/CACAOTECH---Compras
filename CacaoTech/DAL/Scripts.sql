drop database CacaoDB

use CacaoDB

if not exists (Select 1 from Cacaos)
	Begin
		insert into Cacaos(Precio, Tipo, Existencia, UsuarioID) Values (6660.33, 'HISPANIOLA ORGANICO', 0, 1)
		insert into Cacaos(Precio, Tipo, Existencia, UsuarioID) Values (6366.85, 'HISPANIOLA CONVENCIONAL', 0, 1)
		insert into Cacaos(Precio, Tipo, Existencia, UsuarioID) Values (3366.92, 'SANCHEZ ORGANICO', 0, 1)
		insert into Cacaos(Precio, Tipo, Existencia, UsuarioID) Values (6366.17, 'SANCHEZ CONVENCIONAL', 0, 1)
	end

	insert into Usuarios(Nombre, Contraseña, Nivel) values ("Administrador", "wfwrw32", true)