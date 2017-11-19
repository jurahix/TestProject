if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Accesos') and o.name = 'FK_ACCESOS_RELATIONS_ROLES')
alter table Accesos
   drop constraint FK_ACCESOS_RELATIONS_ROLES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Contactos') and o.name = 'FK_CONTACTO_RELATIONS_PERSONA')
alter table Contactos
   drop constraint FK_CONTACTO_RELATIONS_PERSONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FichaSocio') and o.name = 'FK_FICHASOC_RELATIONS_PERSONA')
alter table FichaSocio
   drop constraint FK_FICHASOC_RELATIONS_PERSONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Matriculas') and o.name = 'FK_MATRICUL_RELATIONS_PERSONA')
alter table Matriculas
   drop constraint FK_MATRICUL_RELATIONS_PERSONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Parentescos') and o.name = 'FK_PARENTES_RELATIONS_PERSONA')
alter table Parentescos
   drop constraint FK_PARENTES_RELATIONS_PERSONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Persona') and o.name = 'FK_PERSONA_RELATIONS_ROLES')
alter table Persona
   drop constraint FK_PERSONA_RELATIONS_ROLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Persona')
            and   type = 'U')
   drop table Persona
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Roles')
            and   type = 'U')
   drop table Roles
go

/*==============================================================*/
/* Table: Persona                                               */
/*==============================================================*/
create table Persona (
   Dni                  char(8)              not null,
   CodigoRol            char(4)              not null,
   PrimerNombre         varchar(50)          null,
   SegundoNombre        varchar(50)          null,
   Apellidos            varchar(100)         null,
   Genero               char(1)              null,
   FechaNacimiento      datetime             null,
   UbigeoNacimiento     CHAR(6)                  null,
   Clave                varchar(100)         null,
   Token                varchar(300)         null,
   constraint PK_PERSONA primary key nonclustered (Dni)
)
go

/*==============================================================*/
/* Table: Roles                                                 */
/*==============================================================*/
create table Roles (
   CodigoRol            char(4)              not null,
   Descripcion          varchar(50)          null,
   Estado               tinyint              null,
   constraint PK_ROLES primary key nonclustered (CodigoRol)
)
go

alter table Persona
   add constraint FK_PERSONA_RELATIONS_ROLES foreign key (CodigoRol)
      references Roles (CodigoRol)
go



select * from Roles