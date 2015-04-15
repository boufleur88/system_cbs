SELECT * FROM itcompra;

SELECT * FROM itcompra WHERE c_cpdprod = '00003';

SELECT * FROM itcompra WHERE c_codigo = '000008';

SELECT * FROM sucursales;
SELECT * FROM status_mercaderia;

SELECT * FROM serv;
SELECT * FROM itserv;




SELECT * FROM venta;
SELECT * FROM itventa;
SELECT * FROM itventa WHERE c_venta = '0006687';

SELECT * FROM movis;
SELECT * FROM movis WHERE c_nota = '0006687';

SELECT * FROM prod_cant_suc;
SELECT * FROM prod_cant_suc WHERE c_cpdprod = '09162';


SELECT * FROM plancta ORDER BY c_cod;
SELECT * FROM parametros;
SELECT * FROM nivel;

SELECT * FROM lista_precio_compra_venta WHERE c_cpdprod = '09018';


select * from clasifclt
select * from movie where c_cpd = '09018'
select * from clasifclt
select * from itcompra where c_cpdprod = '00003' order by n_id

CREATE TABLE compra
(
  n_id serial NOT NULL,
  c_codigo character(6),
  c_factura character(15),
  c_cpdclt character(5),
  c_obs character(40),
  d_fecha date,
  n_moneda numeric(1,0),
  n_cotizacion numeric(10,0),
  c_status character(1),
  c_user character(15),
  n_iva00 numeric(15,2),
  n_iva05 numeric(15,2),
  n_iva10 numeric(15,2),
  n_desc numeric(15,2),
  n_total numeric(15,2),
  c_asiento character(7),
  c_sucursal character(3),
  ts_creacion timestamp without time zone DEFAULT now(),
  n_bpid numeric(10,0) DEFAULT pg_backend_pid(),
  c_zafra character(3),
  n_total_ini numeric(15,2),
  n_costotd_ini numeric(15,2),
  n_grab_05_ini numeric(15,2),
  n_grab_10_ini numeric(15,2),
  n_exentas_ini numeric(15,2),
  c_timbrado character(15),
  d_venc_timbra date,
  CONSTRAINT ind_compra_n_id_pk PRIMARY KEY (n_id )
)

CREATE TABLE movie
(
  n_id serial NOT NULL,
  d_emis date,
  c_cpd character(5),
  c_user character(15),
  n_cant numeric(15,5),
  c_tipo character(1),
  c_nota character(15),
  n_costogs numeric(20,5),
  n_costous numeric(15,5),
  n_costotd numeric(15,5),
  n_costofobmed numeric(15,5),
  n_costotdmed numeric(15,5),
  n_venta numeric(20,5),
  c_obs character(500),
  c_clt character(5),
  n_iva numeric(2,0),
  c_asiento character(7),
  c_sucursal character(3),
  ts_creacion timestamp without time zone DEFAULT now(),
  n_bpid numeric(10,0) DEFAULT pg_backend_pid(),
  CONSTRAINT ind_movie_n_id_pk PRIMARY KEY (n_id )
)

CREATE TABLE itcompra
(
  n_id serial NOT NULL,
  c_codigo character(6),
  c_cpdprod character(5),
  n_cant numeric(15,5),
  n_unit numeric(15,5),
  n_pcosto numeric(6,2),
  n_ncosto numeric(15,5),
  n_nventa numeric(15,5),
  n_pminimo numeric(15,5),
  n_pcostors numeric(15,5),
  ts_creacion timestamp without time zone DEFAULT now(),
  n_bpid numeric(10,0) DEFAULT pg_backend_pid(),
  c_costos character(1200),
  CONSTRAINT ind_itcompra_n_id_pk PRIMARY KEY (n_id )
)

CREATE TABLE itnotacreditocompra
(
  n_id serial NOT NULL,
  n_autocod serial NOT NULL,
  c_codigo character(6),
  c_cpdprod character(5),
  n_cant numeric(15,5),
  n_unit numeric(15,2),
  n_costotd numeric(15,5),
  ts_creacion timestamp without time zone DEFAULT now(),
  n_bpid numeric(10,0) DEFAULT pg_backend_pid(),
  CONSTRAINT ind_itnotacreditocompra_n_id_pk PRIMARY KEY (n_id )
)
