CREATE TABLE compra
(
  id_compra serial NOT NULL,
  id_cliente integer NOT NULL,
  com_factura character varying(15),
  com_obs character varying(40),
  com_fecha date,
  com_status character(1),
  com_tiva00 numeric(15,2),
  com_tiva05 numeric(15,2),
  com_tiva10 numeric(15,2),
  com_total numeric(15,2),
  com_fechafactura date,
  com_timbrado character varying(12),
  ts_creacion timestamp without time zone DEFAULT now(),
  CONSTRAINT compra_pkey PRIMARY KEY (id_compra )
)


SELECT * FROM compras

/* Nueva tabla para compras mas estandarizada y facil de interpretar */
CREATE TABLE compras
(
  id_compra serial NOT NULL,
  PRIMARY KEY (id_compra),
  id_cliente integer NOT NULL,
  id_user integer NOT NULL,
  observacion character varying(40),
  d_inclusion date,
  d_factura date,
  status character(1),
  tiva00 numeric(15,2),
  tiva05 numeric(15,2),
  tiva10 numeric(15,2),
  total numeric(15,2),
  n_factura character varying(15),
  n_timbrado character varying(12),
  ts_creacion timestamp without time zone DEFAULT now()
);

drop table compras;

/* CONSULTA TABLA DE COMPRAS */
SELECT c.id_compra, c.d_inclusion, p.per_nombre, c.total, c.observacion FROM compras AS c, persona AS p WHERE c.id_cliente = p.id_per ORDER BY 	c.id_compra;

/* CONSULTA TABLA DE COMPRAS */
SELECT c.id_compra, c.d_inclusion, p.per_nombre, c.total, c.observacion FROM compras AS c, persona AS p WHERE c.id_cliente = p.id_per ORDER BY c.id_compra;
	

INSERT INTO compras (d_inclusion, id_cliente, id_user, total, observacion) VALUES ('20-04-2015', '3', '2', 100000, 'Insert manualmente');

SELECT * FROM persona;

SELECT id_per FROM persona where id_per = (select max(id_per) from persona);

SELECT id_compra FROM compras where id_compra = (select max(id_compra) from compras);

SELECT id_compra FROM compras ORDER BY id_compra DESC LIMIT 1;

