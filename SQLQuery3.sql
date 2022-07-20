create procedure sp_Salvar
@nombre varchar(50),
@cedula varchar(30),
@telefono varchar(12),
@direccion varchar(50),
@montoPagar money,
@descuento money,
@subTotal money,
@iva money,
@total money
as
  begin
  insert into Cliente values (@nombre,@cedula,@telefono,@direccion,@montoPagar,@descuento,@subTotal,@iva,@total)
  end