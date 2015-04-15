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
	compra_id serial NOT NULL,
	PRIMARY KEY (compra_id),
	cliente_id serial NOT NULL,
	factura VARCHAR(15),
	timbrado VARCHAR(12),
	observacion VARCHAR(40),
	f_inclusion date,
	f_factura date,
	status character(1),
	iva00 numeric(15,2),
	iva05 numeric(15,2),
	iva10 numeric(15,2),
	total numeric(15,2),
	ts_creacion timestamp without time zone DEFAULT now()
);




