Create database Examen2DB

use Examen2DB

Create table Cliente(

Nombre varchar(50) not null,
Cedula varchar(30) not null,
Telefono varchar(12) not null,
Direccion varchar(50) not null,
MontoPagar money,
Descuento money,
SubTotal money,
IVA money,
Total money
)

select * from Cliente

