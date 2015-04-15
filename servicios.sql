select * from servicio

SELECT
	s.id_servicio,
	s.descripcion,
	s.preciomin,
	s.precio,
	g.sgrupo,
	s.observacion
FROM 
	servicio AS s
LEFT JOIN
	ser_grupo AS g
ON
	s.id_sgrupo = g.id_sgrupo
ORDER BY
	id_servicio

UPDATE 
	servicio 
SET 
	descripcion = @descripcion,
	costo = @costo, 
	precio_min = @preciominimo, 
	precio = @ventamin, 
	observacion = @observacion,
	id_sgrupo = @idgrupo
WHERE   
	id_servicio = @idservicio;


UPDATE 
	servicio 
SET 
	descripcion = 'MANTENIMIENTO DE DESKTOP',
	costo = '5000', 
	precio_min = '150000', 
	precio = '180000', 
	observacion = 'ALTERADO MANUALMENTE',
	id_sgrupo = '3'
WHERE   
	id_servicio = '4';

select * from servicio;

	SELECT	s.id_servicio, s.descripcion, s.precio, g.sgrupo, s.observacion FROM servicio AS s LEFT JOIN ser_grupo AS g ON	s.id_sgrupo = g.id_sgrupo WHERE s.descripcion LIKE '%{0}%' ORDER BY id_servicio

SELECT	s.id_servicio, s.descripcion, s.precio, g.sgrupo, s.observacion FROM servicio AS s, ser_grupo AS g WHERE s.id_sgrupo = g.id_sgrupo LIKE 'MANO' ORDER BY id_servicio;

SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm FROM produto, st_grupo, st_marca, st_subgrupo 
WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo AND produto.pro_descr LIKE '%{0}%' order by produto.id_produto

	SELECT  FROM produto, st_grupo, st_marca, st_subgrupo WHERdescr LIKE '%{0}%' order by produto.id_produto

	