--Listar produtos distintos limitados a 3
SELECT DISTINCT codigo_produto FROM palete LIMIT 3;

--Listar determinado produto entre lotes 1 e 2
SELECT * FROM palete WHERE codigo_produto = 1022 and lote BETWEEN 1 AND 2;

--Buscar entre datas de produção
SELECT * FROM palete WHERE data_producao BETWEEN '2026/06/11' AND '2026/06/13';

--Buscar dois produtos com status liberado
SELECT * FROM palete WHERE codigo_produto IN (1022, 1033) AND status = 'Liberado';

--Listar produtos retidos ou determinado produto
SELECT * FROM palete WHERE status = 'Retido' OR codigo_produto = '1022'; 