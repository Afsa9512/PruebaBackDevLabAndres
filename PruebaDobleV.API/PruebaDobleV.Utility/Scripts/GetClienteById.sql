USE [DevLab]
GO
/****** Object:  StoredProcedure [dbo].[GetAllClientes]    Script Date: 2/11/2023 12:49:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetClienteById]
(
@IdCliente int
)
AS

SELECT 
CL.Id,
RazonSocial,
IdTipoCliente,
CTCL.TipoCliente,
FechaCreacion,
RFC

FROM DevLab.dbo.TblClientes CL INNER JOIN CatTipoCliente CTCL ON CL.IdTipoCliente = CTCL.Id where CL.Id = @IdCliente