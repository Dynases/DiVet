USE [BD_VET]
GO
/****** Object:  StoredProcedure [dbo].[sp_Mam_TV00121Cheque]    Script Date: 20/09/2019 5:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--drop procedure sp_Mam_TV00121Cheque
ALTER PROCEDURE [dbo].[sp_Mam_TV00121Cheque] (@tipo int,@tenumi int=-1,@tefdoc date=null,
@tety4vend int=-1,@teobs nvarchar(100)='',@tdnumi int=-1,@teuact nvarchar(10)='',@TV00121 TV00121TypeCheque ReadOnly,
@credito int=-1)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()
	
	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY

		DELETE FROM TV00121  WHERE tdtv13numi =@tenumi 
		delete from TV0013 where tenumi=@tenumi 
			select @tdnumi as newNumi  --Consultar que hace newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@teuact)
		END CATCH
	END
	
	IF @tipo=1 --NUEVO REGISTRO
	BEGIN
		BEGIN TRY 

		      set @tenumi=IIF((select COUNT(tenumi) from TV0013)=0,0,(select MAX(tenumi) from TV0013))+1
			  insert into TV0013 values(@tenumi ,@tefdoc,@tety4vend ,@teobs ,@newFecha ,@newHora ,@teuact )
		----INSERTO EL DETALLE
				INSERT INTO TV00121 (tdtv12numi,tdtv13numi  ,tdnrodoc ,tdfechaPago ,tdmonto ,tdnrorecibo,tdty3banco ,
				tdnrocheque ,tdfact ,tdhact ,tduact)

			SELECT td.tdtv12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
			td.tdnrocheque, @newFecha  ,@newHora  ,@teuact 
			FROM @TV00121 AS td where td.estado =0

			select @tdnumi as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

		IF @tipo=2 --NUEVO REGISTRO
	BEGIN
		BEGIN TRY 

			  update TV0013 set tefdoc =@tefdoc ,
			  tety4vend =@tety4vend ,teobs=@teobs,
			  tefact =@newFecha ,tehact =@newHora ,teuact =@teuact  
			  where tenumi =@tenumi 
		----INSERTO EL DETALLE
				INSERT INTO TV00121 (tdtv12numi ,tdtv13numi ,tdnrodoc ,tdfechaPago ,tdmonto ,tdnrorecibo,tdty3banco ,
				tdnrocheque ,tdfact ,tdhact ,tduact)
			SELECT td.tdtv12numi,@tenumi  ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
			td.tdnrocheque, @newFecha  ,@newHora  ,@teuact 
			FROM @TV00121 AS td where td.estado =0

		    UPDATE TV00121 
			SET tdmonto=td.tdmonto ,tdnrorecibo =td.tdnrorecibo ,
			tdty3banco =td.tdty3banco ,tdnrocheque =td.tdnrocheque  
			FROM TV00121  INNER JOIN @TV00121 AS td
			ON TV00121.tdnumi     = td.tdnumi   and td.estado=2;

				--ELIMINO LOS REGISTROS
			DELETE FROM TV00121 WHERE tdnumi   in (SELECT td.tdnumi   FROM @TV00121 AS td WHERE td.estado=-1)

			select @tdnumi as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
		IF @tipo=3
	BEGIN
		BEGIN TRY 
				select a.tenumi ,detalle.tdnrodoc, a.tefdoc ,a.tety4vend,vendedor .ecNomb  as vendedor,
		a.teobs ,a.tefact ,a.tehact ,a.teuact  ,Sum(detalle .tdmonto) as total 
		from TV0013 as a
		inner join REG.EMP002 as vendedor on vendedor .ecId  =a.tety4vend 
		inner join TV00121 as detalle on detalle .tdtv13numi =a.tenumi 
		group by a.tenumi, detalle.tdnrodoc, a.tefdoc ,a.tety4vend,vendedor .ecNomb,a.teobs ,a.tefact ,a.tehact ,a.teuact 
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
		IF @tipo=4
	BEGIN
		BEGIN TRY 
		select  detalle .tdnumi as numidetalle,concat(cliente.canomb,' ',cliente.caapell )  as cliente,Concat(venta.vaId  ,'-',Year(a.tcfdoc)) NroDoc,
	'0' as factura,a.tcnumi as numiCredito,cobranza .tenumi as numiCobranza
	,a.tctv1numi ,a.tcty4clie ,detalle.tdfechaPago,
	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))
	 as pendiente,detalle .tdmonto  as PagoAc,detalle .tdnrorecibo  as NumeroRecibo,
    banco.ycdes3 as DescBanco,detalle .tdty3banco as banco, detalle.tdnrocheque,Cast('' as image)as img ,1 as estado 
	from TV0012 as a inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002 as vendedor on vendedor .ecId  =a.tcty4vend 
	inner join VEN.VEN001 as venta on venta.vaId   =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm  
	inner join TV00121 as detalle on detalle .tdtv12numi =a.tcnumi 
	inner join TV0013 as cobranza on cobranza .tenumi =detalle .tdtv13numi 
	inner join TY0031 as banco on banco .yccod1 =6 and banco .yccod2 =1 and banco .yccod3 =detalle .tdty3banco 
	and cobranza.tenumi =@tenumi 
	order by a.tcnumi asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

			IF @tipo=6  ---------LISTAR DEUDAS PENDIENTES
	BEGIN
		BEGIN TRY 
	
	select a.tcnumi,sucursal .aabdes as sucursal,Concat(venta.vaId ,'-',Year(a.tcfdoc)) NroDoc,
	'0' as factura
	,a.tctv1numi ,a.tcty4clie,cliente.caid as ydcod, concat(cliente.canomb,' ',cliente.caapell )  as cliente,a.tcty4vend,
	vendedor.ecNomb  as vendedor,a.tcfdoc ,tctotcre as totalfactura,
	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))as pendiente
	,Cast(0 as decimal(18,2)) as PagoAc,'' as NumeroRecibo
	from TV0012 as a inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002 as vendedor on vendedor .ecId  =a.tcty4vend 
	inner join VEN.VEN001 as venta on venta.vaId =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm 
		where (tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))>0
	order by a.tcnumi asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

			IF @tipo=7  ---------LISTAR DEUDAS PENDIENTES
	BEGIN
		BEGIN TRY 
	select a.tdnumi ,a.tdtv12numi ,a.tdtv13numi ,a.tdnrodoc ,a.tdfechaPago ,a.tdmonto ,a.tdnrorecibo ,a.tdty3banco ,
	a.tdnrocheque ,a.tdfact ,a.tdhact ,a.tduact,Cast('' as image) as img,1 as estado
	from TV00121 as a where a.tdnumi =@tdnumi 

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
		IF @tipo=8  ---------LISTAR DEUDAS PENDIENTES
	BEGIN
		BEGIN TRY 
	
		select cobranza.tenumi as numiCobranza,vendedor .ecId   AS numiVendedor,vendedor .ecNomb  as vendedor,a.tcty4clie numiCliente,concat(cliente.canomb,' ',cliente.caapell )  as cliente,FORMAT (cobranza .tefdoc, 'dd-MM-yyyy')  as fechaPago
	,Concat(venta.vaId  ,'-',Year(a.tcfdoc)) NroDocVenta,sucursal .aabdes as sucursal,detalle .tdmonto  as importe,
	detalle .tdnrorecibo as nroRecibo,
	banco.ycdes3 as banco,detalle .tdnrocheque as NroCheque,
	 IIF
                      ((SELECT Sum(auxdetallepago.tdmonto)
                        FROM      TV00121 AS auxdetallepago
                        WHERE   auxdetallepago.tdtv12numi = a.tcnumi) = a.tctotcre, IIF
                      ((SELECT Max(ayuda.tdnumi)
                        FROM      TV00121 ayuda
                        WHERE   ayuda.tdtv12numi = a.tcnumi) = detalle.tdnumi, 'CANCELACION TOTAL', 'CANCELACION PARCIAL'), 'CANCELACION PARCIAL') AS observacion,
						cobranza .teobs as glosa
	from TV0012 as a inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002 as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001 as venta on venta.vaId  =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm  
	inner join TV00121 as detalle on detalle .tdtv12numi =a.tcnumi 
	inner join TV0013 as cobranza on cobranza .tenumi =detalle .tdtv13numi 
	inner join TY0031 as banco on banco .yccod1 =6 and banco .yccod2 =1 and banco .yccod3 =detalle .tdty3banco 
	and cobranza.tenumi =@tenumi
	order by a.tcnumi asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
		IF @tipo=9 ---------LISTAR DEUDAS PENDIENTES POR CLIENTES
	BEGIN
		BEGIN TRY 
	
		select a.tcnumi,Concat(venta.vaId ,'-',Year(a.tcfdoc)) NroDoc,
	'0' as factura
	,a.tctv1numi ,a.tcty4clie , concat(cliente.canomb,' ',cliente.caapell)  as cliente,a.tcty4vend,
	vendedor.ecNomb as vendedor,a.tcfdoc ,a.tcfvencre,tctotcre as totalfactura,
	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))as pendiente
	,Cast(0 as decimal(18,2)) as PagoAc,cast(0 as bit) as Pagar,(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi )) as pendiente2
	from TV0012 as a inner join REG.CLI001 as cliente
	on cliente .caid  =a.tcty4clie 
	inner join REG.EMP002 as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001 as venta on venta.vaId   =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm 
		where (tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))>0
		and cliente.caid =@tenumi
	order by a.tcnumi asc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
	IF @tipo=10 --NUEVO REGISTRO
	BEGIN
		BEGIN TRY 

		      set @tenumi=IIF((select COUNT(tenumi) from TV0013)=0,0,(select MAX(tenumi) from TV0013))+1
			  insert into TV0013 values(@tenumi ,@tefdoc,(select top 1 td.tdty3banco from @TV00121 as td) ,@teobs ,@newFecha ,@newHora ,@teuact )
		----INSERTO EL DETALLE
				INSERT INTO TV00121 (tdtv12numi,tdtv13numi  ,tdnrodoc ,tdfechaPago ,tdmonto ,tdnrorecibo,tdty3banco ,
				tdnrocheque ,tdfact ,tdhact ,tduact)

			SELECT td.tdtv12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,1,
			td.tdnrocheque, @newFecha  ,@newHora  ,@teuact 
			FROM @TV00121 AS td where td.estado =0

			select @tdnumi as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END


End










