create database Gestor_Inventario
go

use Gestor_Inventario
go

create table Usuarios (
  id int identity(1,1) primary key,
  usuario varchar(50) not null unique,
  contraseña varchar(20) not null,
  rol varchar(20)
);
go

create table Articulos (
  codigo varchar(5),
  nombre varchar(50) NOT NULL,
  descripcion varchar(255) NULL,
  precio decimal(10,2) NOT NULL,
  cantidad int NOT NULL
);
go

create proc sp_Lista_Articulos
as
select * from Articulos order by codigo
go

create proc sp_Busqueda_Articulos
@nombre varchar(20)
as
select codigo,nombre,descripcion,precio,cantidad from Articulos where nombre like @nombre + '%'
go

create proc sp_Mantenimiento_Articulos
    @codigo varchar(5),
    @nombre varchar(50),
    @descripcion varchar(255),
    @precio decimal(10,2),
    @cantidad int,
    @accion varchar(50) output
as
begin
    set nocount on;

    -- Verificar el rol de usuario
    declare @usuario_rol varchar(20);
    select @usuario_rol = u.rol
    from usuarios u
    
    if (@usuario_rol = 'administrador') -- permite todas las funciones
    begin
        if (@accion = '1') -- Insertar nuevo registro
        begin
            declare @nuevo_codigo varchar(5), @max_codigo varchar(5);
            set @max_codigo = (select max(codigo) from Articulos);
            set @max_codigo = isnull(@max_codigo, 'A0000');
            set @nuevo_codigo = 'A' + RIGHT(RIGHT(@max_codigo, 4) + 10001, 4);
            insert into Articulos(codigo, nombre, descripcion, precio, cantidad)
            values(@nuevo_codigo, @nombre, @descripcion, @precio, @cantidad);
            set @accion = 'Se generó un nuevo código: ' + @nuevo_codigo;
        end
        else if (@accion = '2') -- Actualizar registro existente
        begin
            update Articulos
            set nombre = @nombre,
                descripcion = @descripcion,
                precio = @precio,
                cantidad = @cantidad
            where codigo = @codigo;
            set @accion = 'Se actualizó el registro con código: ' + @codigo;
        end
        else if (@accion) = '3' -- Eliminar registro existente
        begin
            delete from Articulos
            where codigo = @codigo;
            set @accion = 'Se eliminó el registro con código: ' + @codigo;
        end
    end
end
    if (@usuario_rol = 'normal') --Solo tiene permitido agrgar datos de lo contrario, establecer un mensaje de error
			begin
				set @accion = 'No tiene permisos para realizar ninguna accion';
			end	
go


insert into Usuarios values ('admin', '12345', 'administrador')

select * from Usuarios

select * from Articulos