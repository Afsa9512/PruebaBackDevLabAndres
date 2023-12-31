USE [DevLab]
GO
/****** Object:  StoredProcedure [dbo].[GetFacturaById]    Script Date: 2/11/2023 3:37:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetFacturaByFilter]
(
@filter int
)
AS
select
F.Id,
FechaEmisionFactura,
IdCliente,
NumeroFactura,
NumeroTotalArticulos,
SubTotalFactura,
TotalImpuesto,
TotalFactura,
C.RazonSocial

from TblFacturas F INNER JOIN TblClientes C ON F.IdCliente = C.Id where F.NumeroFactura = @filter OR F.IdCliente = @filter
