ELECT diario.c_ref, diario.c_codclt, diario.d_emis, 
        CASE
            WHEN refinanciados(diario.c_ref) > diario.d_venc THEN refinanciados(diario.c_ref)
            ELSE diario.d_venc
        END AS d_venc, diario.n_debe, diario.n_debeaux, diario.c_sucursal, diario.c_asiento, diario.c_factura, diario.n_moneda
   FROM diario
  WHERE diario.c_codcta = '1010301001'::bpchar AND diario.c_tipo = 'REC'::bpchar AND (diario.n_debe + diario.n_debeaux) > (diario.n_haber + diario.n_haberaux)
  ORDER BY diario.c_ref;

SELECT pedidoventa.c_codigo, pedidoventa.c_pedido, pedidoventa.c_cpdclt, pedidoventa.n_moneda, itpedidoventa.c_cpdprod, itpedidoventa.n_cant, itpedidoventa.n_unit, pedidoventa.c_cpdvend, pedidoventa.c_sucursal, pedidoventa.n_id_direccion
   FROM itpedidoventa, pedidoventa
  WHERE pedidoventa.c_codigo = itpedidoventa.c_codigo;
