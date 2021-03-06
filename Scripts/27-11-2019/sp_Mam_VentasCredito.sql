USE [BD_VET]
GO
/****** Object:  StoredProcedure [dbo].[sp_Mam_VentasCredito]    Script Date: 27/11/2019 6:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--drop procedure sp_Mam_TY004
ALTER PROCEDURE [dbo].[sp_Mam_VentasCredito] (@tipo int=-1,@fechaI date=null,@fechaF date=null,@yduact nvarchar(10)='',
@cliente int=-1,@codCredito int=-1,@catPrecio int=-1,@almacen int=-1,@vendedor int=-1)

--TZ0013Type
AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))
	declare @numi int
	DECLARE @newFecha date
	set @newFecha=GETDATE()

	IF @tipo=1 --
	BEGIN
		BEGIN TRY 
	select concat (cliente.caid ,'')  as numicliente,concat(cliente.canomb,' ',cliente.caapell )    as cliente,
(select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid  
and totalcredito.tcfdoc  >=@fechaI and totalcredito.tcfdoc <=@fechaF)as credito,

isnull((select Sum(aporte.tdmonto )  from TV00121 as aporte ,TV0012 as aux where aux.tcnumi =aporte .tdtv12numi 
and aux.tcty4clie =cliente .caid  and aux.tcfdoc >=@fechaI and aux.tcfdoc <=@fechaF),0) as aporte

,isnull(((select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid   and totalcredito .tcfdoc >=@fechaI
and totalcredito .tcfdoc <=@fechaF)-
(select Sum(aporte.tdmonto )  from TV00121 as aporte ,TV0012 as aux where aux.tcnumi =aporte .tdtv12numi 
and aux.tcty4clie =cliente .caid  and aux.tcfdoc >=@fechaI and aux .tcfdoc <=@fechaF )),
 (select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid 
 and totalcredito .tcfdoc >=@fechaI and totalcredito .tcfdoc <=@fechaF))as deuda,
venta.vaId  as numiventa,almacen .aabdes ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy') as fechaventa,FORMAT (venta.vaFechaVenCre  , 'dd-MM-yyyy') as fechacredito,a.tctotcre,
detallepago .tdnrorecibo ,FORMAT (detallepago .tdfechaPago , 'dd-MM-yyyy') as tdfechaPago ,detallepago .tdnrodoc  ,detallepago .tdmonto 
,IIF((select Sum(auxdetallepago.tdmonto) from TV00121 as auxdetallepago where auxdetallepago.tdtv12numi=a.tcnumi)=a.tctotcre 
,IIF((select Max(ayuda.tdnumi) from TV00121 ayuda where ayuda.tdtv12numi=a.tcnumi)=detallepago.tdnumi,'CANCELACION TOTAL',
'CANCELACION PARCIAL'),'CANCELACION PARCIAL')as observacion
from TV0012  as a 
inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
left join TV00121 as detallepago on detallepago .tdtv12numi =a.tcnumi 
inner join VEN.VEN001 as venta on venta.vaId =a.tctv1numi 
inner join TA001 as almacen on almacen .aanumi =venta.vaAlm 
and venta.vaFechaDoc >=@fechaI and venta.vaFechaDoc <=@fechaF 
group by cliente .caid   ,cliente .canomb ,cliente.caapell   ,venta.vaId  ,almacen .aabdes ,venta .vaFechaDoc  ,venta.vaFechaVenCre   ,a.tctotcre,
detallepago .tdnrorecibo ,detallepago .tdfechaPago ,detallepago .tdnrodoc  ,detallepago .tdmonto ,a.tcnumi,detallepago .tdnumi 
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@yduact)
		END CATCH
	END

	IF @tipo=3 --
	BEGIN
		BEGIN TRY 
	select concat (cliente.caid ,'')  as numicliente,concat(cliente.canomb,' ',cliente.caapell )    as cliente,
(select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid  
and totalcredito.tcfdoc  >=@fechaI and totalcredito.tcfdoc <=@fechaF)as credito,

isnull((select Sum(aporte.tdmonto )  from TV00121 as aporte ,TV0012 as aux where aux.tcnumi =aporte .tdtv12numi 
and aux.tcty4clie =cliente .caid  and aux.tcfdoc >=@fechaI and aux.tcfdoc <=@fechaF),0) as aporte

,isnull(((select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid   and totalcredito .tcfdoc >=@fechaI
and totalcredito .tcfdoc <=@fechaF)-
(select Sum(aporte.tdmonto )  from TV00121 as aporte ,TV0012 as aux where aux.tcnumi =aporte .tdtv12numi 
and aux.tcty4clie =cliente .caid  and aux.tcfdoc >=@fechaI and aux .tcfdoc <=@fechaF )),
 (select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid 
 and totalcredito .tcfdoc >=@fechaI and totalcredito .tcfdoc <=@fechaF))as deuda,
venta.vaId  as numiventa,almacen .aabdes ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy') as fechaventa,FORMAT (venta.vaFechaVenCre  , 'dd-MM-yyyy') as fechacredito,a.tctotcre,
detallepago .tdnrorecibo ,FORMAT (detallepago .tdfechaPago , 'dd-MM-yyyy') as tdfechaPago ,detallepago .tdnrodoc  ,detallepago .tdmonto 
,IIF((select Sum(auxdetallepago.tdmonto) from TV00121 as auxdetallepago where auxdetallepago.tdtv12numi=a.tcnumi)=a.tctotcre 
,IIF((select Max(ayuda.tdnumi) from TV00121 ayuda where ayuda.tdtv12numi=a.tcnumi)=detallepago.tdnumi,'CANCELACION TOTAL',
'CANCELACION PARCIAL'),'CANCELACION PARCIAL')as observacion
from TV0012  as a 
inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
left join TV00121 as detallepago on detallepago .tdtv12numi =a.tcnumi 
inner join VEN.VEN001 as venta on venta.vaId =a.tctv1numi 
inner join TA001 as almacen on almacen .aanumi =venta.vaAlm 
and venta.vaFechaDoc >=@fechaI and venta.vaFechaDoc <=@fechaF 
and cliente .caid  =@cliente
group by cliente .caid   ,cliente .canomb ,cliente.caapell   ,venta.vaId  ,almacen .aabdes ,venta .vaFechaDoc  ,venta.vaFechaVenCre   ,a.tctotcre,
detallepago .tdnrorecibo ,detallepago .tdfechaPago ,detallepago .tdnrodoc  ,detallepago .tdmonto ,a.tcnumi,detallepago .tdnumi 
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@yduact)
		END CATCH
	END
	IF @tipo=5 
	BEGIN
		BEGIN TRY
	select concat (cliente.caid ,'')  as numicliente,concat(cliente.canomb,' ',cliente.caapell )    as cliente,
(select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid  
and totalcredito.tcfdoc  >=@fechaI and totalcredito.tcfdoc <=@fechaF)as credito,

isnull((select Sum(aporte.tdmonto )  from TV00121 as aporte ,TV0012 as aux where aux.tcnumi =aporte .tdtv12numi 
and aux.tcty4clie =cliente .caid  and aux.tcfdoc >=@fechaI and aux.tcfdoc <=@fechaF),0) as aporte

,isnull(((select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid   and totalcredito .tcfdoc >=@fechaI
and totalcredito .tcfdoc <=@fechaF)-
(select Sum(aporte.tdmonto )  from TV00121 as aporte ,TV0012 as aux where aux.tcnumi =aporte .tdtv12numi 
and aux.tcty4clie =cliente .caid  and aux.tcfdoc >=@fechaI and aux .tcfdoc <=@fechaF )),
 (select  Sum(totalcredito .tctotcre ) from TV0012 as totalcredito where totalcredito .tcty4clie =cliente .caid 
 and totalcredito .tcfdoc >=@fechaI and totalcredito .tcfdoc <=@fechaF))as deuda,
venta.vaId  as numiventa,almacen .aabdes ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy') as fechaventa,FORMAT (venta.vaFechaVenCre  , 'dd-MM-yyyy') as fechacredito,a.tctotcre,
detallepago .tdnrorecibo ,FORMAT (detallepago .tdfechaPago , 'dd-MM-yyyy') as tdfechaPago ,detallepago .tdnrodoc  ,detallepago .tdmonto 
,IIF((select Sum(auxdetallepago.tdmonto) from TV00121 as auxdetallepago where auxdetallepago.tdtv12numi=a.tcnumi)=a.tctotcre 
,IIF((select Max(ayuda.tdnumi) from TV00121 ayuda where ayuda.tdtv12numi=a.tcnumi)=detallepago.tdnumi,'CANCELACION TOTAL',
'CANCELACION PARCIAL'),'CANCELACION PARCIAL')as observacion
from TV0012  as a 
inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
left join TV00121 as detallepago on detallepago .tdtv12numi =a.tcnumi 
inner join VEN.VEN001 as venta on venta.vaId =a.tctv1numi 
inner join TA001 as almacen on almacen .aanumi =venta.vaAlm 
and a.tcnumi =@codCredito
group by cliente .caid   ,cliente .canomb ,cliente.caapell   ,venta.vaId  ,almacen .aabdes ,venta .vaFechaDoc  ,venta.vaFechaVenCre   ,a.tctotcre,
detallepago .tdnrorecibo ,detallepago .tdfechaPago ,detallepago .tdnrodoc  ,detallepago .tdmonto ,a.tcnumi,detallepago .tdnumi  
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END
		IF @tipo=2 --
	BEGIN
		BEGIN TRY
	select a.ydnumi ,a.ydcod ,a.ydrazonsocial as yddesc  ,a.yddctnum ,a.yddirec 
		,a.ydtelf1 ,a.ydfnac 
		from TY004 as a inner join TY0031 as tipodocumento on
		 tipodocumento .yccod1 =2 and tipodocumento .yccod2 =1 and tipodocumento .yccod3 =a.yddct and a.ydtip =1
				order by ydcod 
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END


	


	IF @tipo=6 -- REPORTE UTILIDAD 
	BEGIN
		BEGIN TRY
	
SELECT      deposito .aanumi as abnumi ,deposito .aabdes as abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod,Sum(c.iccven) as iccven, b.yccod3 , b.ycdes3 ,precio.yhprecio  as preciou,
 Cast((Sum(c.iccven)*precio.yhprecio ) as decimal(18,2))as total
FROM            dbo.TY005  AS a INNER JOIN
                         dbo.TI001 AS c ON a.yfnumi  = c.iccprod INNER JOIN
                         dbo.TY0031 AS b ON a.yfMed  = b.yccod3 
						 inner join TA001 as deposito on deposito .aanumi =c.icalm 
						 inner join TY007 as precio on precio .yhalm=@almacen--almacen
						 and precio.yhcatpre =@catPrecio and precio .yhprod =a.yfnumi 
WHERE        (b.yccod1  = 1) AND (b.yccod2  = 5)

group by deposito .aanumi ,deposito .aabdes   ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod ,b.yccod3 , b.ycdes3 ,precio.yhprecio 
order by deposito .aanumi asc
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END
		IF @tipo=4 -- LISTAR CUENTAS POR CLIENTES
	BEGIN
		BEGIN TRY
	select a.tcnumi ,a.tctv1numi as numiVenta,'0'
 as numeroFactura,a.tcfdoc as fechaVenta, a.tcfvencre as FechaVencCredito,a.tctotcre as totalVenta
from TV0012 as a where a.tcty4clie =@cliente 
order by a.tctv1numi 
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END
IF @tipo=7 -- LISTAR PRECIOS DE VENTA
	BEGIN
		BEGIN TRY
	
select a.ygnumi  ,a.ygdesc 
from TY006 as a where a.ygpcv =1  ----precio de venta
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END
IF @tipo=8 -- LISTAR PRECIOS DE VENTA
	BEGIN
		BEGIN TRY
	
select a.ygnumi  ,a.ygdesc 
from TY006 as a where a.ygpcv =0  ----precio de costo
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END

IF @tipo=9 -- utilidad de productos
	BEGIN
		BEGIN TRY
	
SELECT      deposito .aanumi as abnumi ,deposito .aabdes   as abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod,Sum(c.iccven) as iccven, b.yccod3 , b.ycdes3 ,precio.yhprecio  as preciou,
 Cast((Sum(c.iccven)*precio.yhprecio ) as decimal(18,2))as total
FROM            dbo.TY005  AS a INNER JOIN
                         dbo.TI001 AS c ON a.yfnumi  = c.iccprod INNER JOIN
                         dbo.TY0031 AS b ON a.yfMed  = b.yccod3 
						 inner join TA001 as deposito on deposito .aanumi =c.icalm 
						 inner join TY007 as precio on precio .yhalm=@almacen ---almacen
						 and precio.yhcatpre =@catPrecio  and precio .yhprod =a.yfnumi 
WHERE        (b.yccod1  = 1) AND (b.yccod2  = 5)

group by deposito .aanumi ,deposito .aabdes   ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod ,b.yccod3 , b.ycdes3 ,precio.yhprecio 
order by a.yfcdprod1 asc
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END



IF @tipo=13 -- utilidad de productos stock mayor a cero
	BEGIN
		BEGIN TRY
	
SELECT      deposito .aanumi as abnumi ,deposito .aabdes as abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod,Sum(c.iccven) as iccven, b.yccod3 , b.ycdes3 ,precio.yhprecio  as preciou,
 Cast((Sum(c.iccven)*precio.yhprecio ) as decimal(18,2))as total
FROM            dbo.TY005  AS a INNER JOIN
                         dbo.TI001 AS c ON a.yfnumi  = c.iccprod INNER JOIN
                         dbo.TY0031 AS b ON a.yfMed  = b.yccod3 
						 inner join TA001 as deposito on deposito .aanumi =c.icalm 
						 inner join TY007 as precio on precio .yhalm=@almacen ---almacen
						 and precio.yhcatpre =@catPrecio  and precio .yhprod =a.yfnumi 
WHERE        (b.yccod1  = 1) AND (b.yccod2  = 5) and (c.iccven>0)

group by deposito .aanumi ,deposito .aabdes   ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod ,b.yccod3 , b.ycdes3 ,precio.yhprecio 
order by a.yfcdprod1 asc
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@yduact)
		END CATCH

END
End



