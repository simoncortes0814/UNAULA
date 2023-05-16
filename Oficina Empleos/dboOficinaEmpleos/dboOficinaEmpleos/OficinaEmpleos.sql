create database dboOficinadeEmpleos;

use dboOficinadeEmpleos;

create table tblModuloEmpleados(
intNoDocumento int,
strDocumentoIdentidad varchar(95),
strNombre varchar(95),
strApellido varchar(95) ,
dateFechaNacimiento varchar(95),
strNivelEstudios varchar(95),
strTituloAcademico varchar(95),
primary key (intNoDocumento)
);



create table tblModuloEmpleos(
intCodigoEmpleo int,
strNombreEmpleo varchar(55),
strDescripcion varchar(95),
intRangoSalarial int,
strExperienciaNecesaria varchar (55),
primary Key (intCodigoEmpleo)
);

insert into tblModuloEmpleos (intCodigoEmpleo, strNombreEmpleo, strDescripcion, intRangoSalarial,strExperienciaNecesaria)
values (001, 'Ingeniero Infórmatico', 'Programador y diseñador de paginas web', 6000000, '3 años');
insert into tblModuloEmpleos (intCodigoEmpleo, strNombreEmpleo, strDescripcion, intRangoSalarial,strExperienciaNecesaria)
values (002, 'Diseñador Grafico', 'Gestor publicitario', 1500000, '6 meses');
insert into tblModuloEmpleos (intCodigoEmpleo, strNombreEmpleo, strDescripcion, intRangoSalarial,strExperienciaNecesaria)
values (003, 'Contador', 'Manejar las cuentas semanales, mensuales y anuales de la empresa', 2600000, '2 años');
insert into tblModuloEmpleos (intCodigoEmpleo, strNombreEmpleo, strDescripcion, intRangoSalarial,strExperienciaNecesaria)
values (004, 'Abogado', 'Atento hacia los contratos y diferentes movimientos los cuales gestiona la empresa', 3500000, '1 año');
insert into tblModuloEmpleos (intCodigoEmpleo, strNombreEmpleo, strDescripcion, intRangoSalarial,strExperienciaNecesaria)
values (005, 'Médico', 'Dedicado a sus pacientes', 5500000, '6 años');
insert into tblModuloEmpleos (intCodigoEmpleo, strNombreEmpleo, strDescripcion, intRangoSalarial,strExperienciaNecesaria)
values (006, 'Carpintero', 'Buen trabajo con madera', 1200000, '1 año');

Select* from tblModuloEmpleos
Where intCodigoEmpleo = 5