use DBCEPRE;
goCepre_PersonaBuscarPorDni_SP
IF EXISTS ( SELECT * 
            FROM   sysobjects 
            WHERE  id = object_id(N'[dbo].[Cepre_ManPersona_SP]') 
                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    drop procedure Cepre_ManPersona_SP
END
GO
/*
execute Cepre_ManPersona_SP
			@Dni              = '',
			@CodigoRol        = '',
			@PrimerNombre     = '',
			@SegundoNombre    = '',
			@Apellidos        = '',
			@Genero           = '',
			@FechaNacimiento  = '',
			@UbigeoNacimiento = '',
			@Clave            = '',
			@Token            = '',


*/
CREATE PROCEDURE [dbo].[Cepre_ManPersona_SP]
	@Dni                  char(8)     ,
	@CodigoRol            char(4)     ,
	@PrimerNombre         varchar(50) ,
	@SegundoNombre        varchar(50) ,
	@Apellidos            varchar(100),
	@Genero               char(1)     ,
	@FechaNacimiento      datetime    ,
	@UbigeoNacimiento     char(6)         ,
	@Clave                varchar(100),
	@Token                varchar(300)

AS
set nocount on
begin

MERGE Persona AS D
USING (VALUES (@Dni)) AS S(Dni)
ON S.Dni = D.Dni
WHEN MATCHED THEN
  UPDATE SET 
			D.Dni              = @Dni              ,
			D.CodigoRol        = @CodigoRol        ,
			D.PrimerNombre     = @PrimerNombre     ,
			D.SegundoNombre    = @SegundoNombre    ,
			D.Apellidos        = @Apellidos        ,
			D.Genero           = @Genero           ,
			D.FechaNacimiento  = @FechaNacimiento  ,
			D.UbigeoNacimiento = @UbigeoNacimiento ,
			D.Clave            = @Clave            ,
			D.Token            = @Token            
WHEN NOT MATCHED THEN
  INSERT(
	Dni              ,
	CodigoRol        ,
	PrimerNombre     ,
	SegundoNombre    ,
	Apellidos        ,
	Genero           ,
	FechaNacimiento  ,
	UbigeoNacimiento ,
	Clave            ,
	Token            
  )
  VALUES(
		@Dni              ,
		@CodigoRol        ,
		@PrimerNombre     ,
		@SegundoNombre    ,
		@Apellidos        ,
		@Genero           ,
		@FechaNacimiento  ,
		@UbigeoNacimiento ,
		@Clave            ,
		@Token            
  
  );
END

GO
IF EXISTS ( SELECT * 
            FROM   sysobjects 
            WHERE  id = object_id(N'[dbo].[Cepre_PersonaBuscarPorDni_SP]') 
                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    drop procedure Cepre_PersonaBuscarPorDni_SP
END
GO
/*
execute Cepre_PersonaBuscarPorDni_SP
			@Dni              = ''
			


*/
CREATE PROCEDURE Cepre_PersonaBuscarPorDni_SP
	@Dni  char(8)     
	

AS
SET NOCOUNT ON
BEGIN
	SELECT *
	FROM Persona
	--WHERE Dni = @Dni
END
go

CREATE PROCEDURE  mmm_Lista_SP
AS
SET NOCOUNT ON
BEGIN
	SELECT *
	FROM Persona
END
