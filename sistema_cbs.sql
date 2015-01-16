/* REGISTRO TABLA USUARIOS */
CREATE TABLE usuarios
(
  id_user serial not null,
  user_codigo character(4) not null,
  user_nombre character(40),
  user_usuario character(15),
  user_clave character(10),
  user_ci character(10),
  user_tel1 character(20),
  user_email character(40),
  PRIMARY KEY (user_codigo)
)

/* REGISTRO TABLA PROTUDO */
CREATE TABLE produto
(
  id_pro serial NOT NULL,
  ts_creacion timestamp without time zone DEFAULT now(),
  pro_ean character(20),
  pro_orig character(20),
  pro_fabr character(20),
  pro_descr character(80),
  pro_aplic character(80),
  pro_unidad character(2),
  pro_marca character(4),
  pro_grupo character(4),
  pro_subgrupo character(4),
  pro_moneda numeric(1,0),
  pro_iva numeric(2,0),
  pro_costocon numeric(20,2),
  pro_costoadm numeric(20,2),
  pro_ventamay numeric(20,2),
  pro_ventamin numeric(20,2),
  pro_cantmin numeric(5,0),
  pro_obs character(500),
  pro_peso numeric(15,2),
  PRIMARY KEY (id_pro)
)
select * from produto;
drop table produto

select id_pro, pro_descr, pro_ventamay, pro_ventamin, pro_orig, pro_fabr, pro_marca, pro_grupo, pro_subgrupo, pro_ean, pro_unidad, pro_cantmin, pro_moneda, pro_iva, pro_obs, pro_costocon, pro_costoadm from produto;  
update produto set pro_descr = @descripcion, pro_ventamay = @ventamay, pro_ventamin = @ventamin, pro_orig = @original, pro_fabr = @fabricante, pro_marca = @marca, pro_grupo = @grupo, pro_subgrupo = @subgrupo, pro_ean = @ean, pro_unidad = @unidad, pro_cantmin = @stminimo, pro_moneda = @moneda, pro_iva = @iva, pro_obs = @observacion, pro_costocon = @costocont, pro_costoadm = @costoadm

select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac from persona order by id_per;

insert into produto (pro_ean) values ('TESTE');
insert into produto (pro_ean, pro_orig, pro_fabr, pro_descr, pro_aplic, pro_unidad, pro_moneda, pro_iva, pro_costocon, pro_costoadm, pro_ventamay, pro_ventamin, pro_cantmin, pro_obs, pro_peso) 
values ('EAN','ORIGINAL','FABRICANTE','DESCRIPCION TESTE','TESTE', 'UN', 1, 10, 50000, 55000, 115000, 130000, 10, 'SOLO FUE UNA PRUEBA',1000);

insert into usuarios ( user_codigo, user_nombre, user_usuario, user_clave, user_ci, user_tel1, user_email) 
values ('0001','SUPERVISOR', 'SUPERVISOR', '123456', '4896598', '0983 509 687', 'boufleur88@gmail.com');

/* REGISTRO TABLA STOCK MARCA */
CREATE TABLE st_marca
(
	id_marca serial not null,
	st_marca character(40) not null,
	ts_creacion timestamp without time zone DEFAULT now(),
	PRIMARY KEY (id_marca)
)

insert into st_marca (st_marca) values ('APPLE');
select * from st_marca

select id_marca , st_marca from st_marca;

select id_marca, st_marca from st_marca order by id_marca; 

update st_marca set st_marca = @marca where id_marca = @codigo

select id_marca, st_marca from st_marca WHERE st_marca LIKE '%HP%'

/* REGISTRO TABLA STOCK GRUPO */
CREATE TABLE st_grupo
(
	id_grupo serial not null,
	st_grupo character(40) not null,
	ts_creacion timestamp without time zone DEFAULT now(),
	PRIMARY KEY (id_grupo)

)

select * from st_grupo;
insert into st_grupo (st_grupo) values ('INFORMATICA');

select id_grupo , st_grupo from st_grupo order by st_grupo;

select id_grupo as CODIGO, st_grupo as GRUPO from st_grupo

/* REGISTRO TABLA STOCK SUB GRUPO */
CREATE TABLE st_subgrupo
(
	id_subgrupo serial not null,
	st_subgrupo character(40) not null,
	ts_creacion timestamp without time zone DEFAULT now(),
	PRIMARY KEY (id_subgrupo)
)

update st_subgrupo set st_subgrupo = 'TESTE 1' where id_subgrupo = 6;
select id_subgrupo , st_subgrupo from st_subgrupo order by st_subgrupo;

select * from st_subgrupo ORDER BY id_subgrupo;
select id_subgrupo as CODIGO, st_subgrupo as SUBGRUPO from st_subgrupo
insert into st_subgrupo (st_subgrupo) values ('ACCESORIOS');

insert into st_subgrupo (st_subgrupo) values ('PRUEBAS');

select id_subgrupo, st_subgrupo from st_subgrupo WHERE st_subgrupo LIKE '%TE%'

SELECT * FROM st_subgrupo;

/*################################# PERSONAS ##########################*/
/* TABLA PERSONAS */
CREATE TABLE persona
(
  id_per serial NOT NULL,
  ts_creacion timestamp without time zone DEFAULT now(),
  per_ruc character(12),
  per_nombre character(80),
  per_ci character(12),
  per_fant character(80),
  per_dir character(80),
  per_ciudad character(40),
  per_pais character(2),
  per_grupo character(4),
  per_tel1 character(12),
  per_tel2 character(12),
  per_email character(40),
  per_nac character(12),
  per_clt character(1),
  per_prov character(1),
  per_func character(1),
  per_obs character(500),
  PRIMARY KEY (id_per )
)			

select count(*) from persona
select per_ciudad from persona


drop table persona
select * from persona order by id_per

insert into persona (per_ruc, per_nombre, per_ci, per_fant, per_dir, per_tel1, per_tel2, per_email, per_nac, per_clt, per_prov, per_func, per_obs, per_pais, per_ciudad) values ('1', 'teste','1', 'teste', 'centro', '0983555444', '', '', '', 'S', 'N', 'N', 'TESTE', 'PY', 'SANTA RITA')

delete from persona where id_per = '18'

select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac from persona order by id_per;
insert into persona (per_ruc, per_nombre, per_ci, per_fant, per_dir, per_ciudad, per_pais, per_tel1, per_tel2, per_email, per_nac, per_clt, per_prov, per_func, per_obs) values ('4896598-7', 'CRISTIANO BOUFLUER', '4896598', 'CBS INFORMATICA', 'CAMPINAS VERDES', 'SANTA RITA', 'PY', '0983 509 687', '', 'BOUFLEUR88@GMAIL.COM', '14/10/1988', 'S', 'S', 'S', 'TESTE TESTE');

update persona set per_nombre = @nombre, per_fant = @fantasia where  id_per = @codigo

update persona set per_nombre = @nombre, per_fant = @fantasia, per_ruc = @ruc, per_ci = @cedula, per_tel1 = @tel1, per_tel2 = @tel2, per_email = @email, per_dir = @dir, per_ciudad = @ciudad, per_pais = @ pais, per_nac = @nacimento where  id_per = @codigo

update persona set per_nombre = @nombre, per_fant = @fantasia, per_ruc = @ruc, per_ci = @cedula, per_tel1 = @tel1, per_tel2 = @tel2, per_email = @email, per_dir = @dir, per_ciudad = @ciudad, per_pais = @ pais, per_nac = @nacimento where  id_per = @codigo

update persona set per_nombre = 'FELIPE BOUFLEUR', per_fant =  'CBS INFORMATICA' where id_per = '2'


/* REGISTRO DE CIUDADES */
CREATE TABLE per_ciudad
(
  id_ciudad serial NOT NULL,
  per_ciudad character(40),
  ts_creacion timestamp without time zone DEFAULT now(),
  PRIMARY KEY (id_ciudad)
)
select id_ciudad, per_ciudad from per_ciudad
select * from per_ciudad
insert into per_ciudad (per_ciudad) values ('TOLEDO')

delete from per_ciudad where id_ciudad = 1

update per_ciudad set per_ciudad = 'SANTOS' where id_ciudad = '2'

select id_ciudad, per_ciudad from per_ciudad order by id_ciudad

select * from per_ciudad;
insert into per_ciudad (per_ciudad) values ('Santa Rita');
select id_ciudad, per_ciudad from per_ciudad;


/* REGISTRO DE GRUPOS PERSONAS */
CREATE TABLE per_grupo
(
  id_grupo serial NOT NULL,
  per_grupo character(40),
  ts_creacion timestamp without time zone DEFAULT now(),
  PRIMARY KEY (id_grupo)
)

select * from per_grupo;
insert into per_grupo (per_grupo) values ('UNIMED');

SELECT id_grupo, per_grupo FROM per_grupo ORDER BY id_grupo
select * from per_grupo

update per_ciudad set per_ciudad = 'SANTOS' where id_ciudad = '2'
update per_grupo set per_grupo = 'TESTE' where id_grupo = '1'

/* ELIMINAR TODAS LAS TABLAS DEL BANCO DE DATOS */
drop table usuarios

drop table stock;
drop table st_marca;
drop table st_grupo;
drop table st_subgrupo;
drop table per_grupo;
drop table per_ciudad;


-- Sirve para eliminar una tabla.
select * from usuarios
select user_codigo, user_nombre, user_tel1, user_email from usuarios;
select user_nombre from usuarios where user_nombre = 'SUPERVISOR';
select user_nombre from usuarios where user_nombre <> 'SUPERVISOR';

select count(user_codigo) from usuarios

insert into usuarios ( user_codigo, user_nombre, user_usuario, user_clave, user_ci, user_tel1, user_email) 
values ('0001','SUPERVISOR', 'SUPERVISOR', '123456', '4896598', '0983 509 687', 'boufleur88@gmail.com');
insert into usuarios (user_codigo, user_nombre, user_usuario, user_clave, user_ci, user_tel1, user_email) 
values ('0002','CRISTIANO BOUFLEUR', 'CRISTIANO', 'inter', '4896598', '0983 509 687', 'boufleur88@gmail.com');
insert into usuarios (user_codigo, user_nombre, user_usuario, user_clave, user_ci, user_tel1, user_email) 
values ('0003','SIRLEI LORES', 'SIRLEI', '555444', '4541598', '0983 870 493', 'sirleilores@gmail.com');
insert into usuarios (user_codigo, user_nombre, user_usuario, user_clave, user_ci, user_tel1, user_email) 
values ('0004','1', '1', '1', '1', '1', '1');

-- actualizar alguna fila del banco
update usuarios set user_clave='555444' where user_usuario='SIRLEI';

-- consultas sql para validar usuarios. 
  SELECT user_usuario, user_clave FROM usuarios 
  WHERE user_usuario='CRISTIANO' AND user_clave='inter'  

  SELECT * FROM usuarios 
  WHERE user_usuario='CRISTIANO' AND user_clave='inter'  

