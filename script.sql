CREATE TABLE st_subgrupo (
  id_subgrupo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  st_subgrupo VARCHAR(40) NULL,
  PRIMARY KEY(id_subgrupo)
);

CREATE TABLE usuarios (
  id_user INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  user_nombre VARCHAR(40) NULL,
  user_usuario VARCHAR(15) NULL,
  user_clave VARCHAR(10) NULL,
  user_ci VARCHAR(10) NULL,
  user_tel1 VARCHAR(15) NULL,
  user_email VARCHAR(40) NULL,
  PRIMARY KEY(id_user)
);


CREATE TABLE st_marca (
  id_marca INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  st_marca VARCHAR(40) NULL,
  PRIMARY KEY(id_marca)
);

CREATE TABLE st_grupo (
  id_grupo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  st_grupo VARCHAR(40) NULL,
  PRIMARY KEY(id_grupo)
);

CREATE TABLE produto (
  id_produto INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  id_subgrupo INTEGER UNSIGNED NOT NULL,
  id_grupo INTEGER UNSIGNED NOT NULL,
  id_marca INTEGER UNSIGNED NOT NULL,
  pro_ean VARCHAR(20) NULL,
  pro_orig VARCHAR(20) NULL,
  pro_fabr VARCHAR(20) NULL,
  pro_descr VARCHAR(80) NULL,
  pro_unidad VARCHAR(4) NULL,
  pro_moneda NUMERIC(2,0) NULL,
  pro_iva NUMERIC(2,0) NULL,
  pro_costocon NUMERIC(20,2) NULL,
  pro_costoadm NUMERIC(20,2) NULL,
  pro_ventamay NUMERIC(20,2) NULL,
  pro_ventamin NUMERIC(20,2) NULL,
  pro_cantmin NUMERIC(6,2) NULL,
  pro_obs VARCHAR(500) NULL,
  PRIMARY KEY(id_produto)
);


select id_grupo, st_grupo from st_grupo order by id_grupo

-- EJEMPLO JOIN.
select l.id_produto, l.pro_descr, l.pro_costocon, l.pro_ventamay, l.id_grupo, e.st_grupo, l.pro_obs from produto as l
  join st_grupo as e
  on l.id_grupo=e.id_grupo;

  
select l.id_produto, l.pro_descr, l.pro_costocon, l.pro_ventamay, l.id_grupo, e.st_grupo, m.st_marca, l.pro_obs from (produto l, st_grupo e, st_marca m)
where l.id_grupo=e.id_grupo AND l.id_marca=m.id_marca;

SELECT produto.id_produto, produto.pro_descr, produto.id_grupo, st_grupo.st_grupo
   FROM produto, st_grupo
  WHERE produto.id_grupo = st_grupo.id_grupo;


SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, produto.pro_orig, produto.pro_fabr, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_ean, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm
   FROM produto, st_grupo, st_marca, st_subgrupo
  WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_grupo = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo  order by produto.id_produto;

select id_produto, pro_descr, pro_ventamay, pro_ventamin, pro_orig, pro_fabr, id_marca, id_grupo, id_subgrupo, pro_ean, pro_unidad, pro_cantmin, pro_moneda, pro_iva, pro_obs, pro_costocon, pro_costoadm from produto order by id_produto", con.conectar());
