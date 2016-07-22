SELECT * FROM compras


-- Adicionar nueva columna personas.
SELECT * FROM persona

ALTER TABLE persona ADD COLUMN per_situacion CHAR(1) DEFAULT 'A';

SELECT id_per, per_nombre, per_ruc, per_tel1 FROM persona WHERE per_clt = 'S' AND per_situacion = 'S' ORDER BY id_per;

SELECT id_per, per_nombre, per_ruc, per_tel1 FROM persona WHERE per_clt = 'S' AND per_situacion = 'N' ORDER BY id_per;

SELECT id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs, per_situacion FROM persona WHERE per_situacion = 'A' AND id_per < 50 ORDER BY id_per;


select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs from persona WHERE per_situacion = 'A'


select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs from persona order by id_per desc

SELECT id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs, per_situacion FROM persona WHERE per_situacion = 'A' ORDER BY id_per desc