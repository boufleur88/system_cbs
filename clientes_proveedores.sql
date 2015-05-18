SELECT
	id_per, per_nombre, per_ruc, per_tel1 
FROM
	persona
WHERE 
	per_clt = 'S'
ORDER BY 
	id_per

-- 61ms - 141 rows.
SELECT
	id_per, per_nombre, per_ruc, per_tel1
FROM
	persona
WHERE
	per_prov = 'S'
ORDER BY 
	id_per
-- 12ms - 141 rows

SELECT id_per, per_nombre, per_ruc, per_tel1 FROM persona WHERE per_prov = 'S' ORDER BY id_per;

SELECT id_per, per_nombre, per_ruc, per_tel1 FROM persona WHERE per_clt = 'S' ORDER BY id_per;

-- Contar la cantidad de datos insertados en una tabla.
SELECT count (id_per) FROM persona;
-- forma correcta: 10ms

SELECT count (*) FROM persona;
-- forma erronea: 21ms



