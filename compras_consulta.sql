SELECT produto.id_produto, produto.pro_descr, pro_costocon, produto.pro_costoadm, produto.pro_ventamay, produto.pro_ventamin, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs FROM produto, st_grupo, st_marca, st_subgrupo WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo order by produto.id_produto
-- 32ms = 360rows.

SELECT 
	p.id_produto, p.pro_descr, p.pro_costocon, p.pro_costoadm, p.pro_ventamay, p.pro_ventamin, p.pro_cantmin 
FROM 
	produto AS p
ORDER BY
	p.id_produto
	
WHERE 
	produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo order by produto.id_produto


SELECT p.id_produto, p.pro_descr, p.pro_costocon, p.pro_costoadm, p.pro_ventamay, p.pro_ventamin, p.pro_cantmin FROM produto AS p ORDER BY p.id_produto;