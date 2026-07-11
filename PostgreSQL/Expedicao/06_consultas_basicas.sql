--Listar todos os produtos
SELECT * FROM produtos;

--Listar todos os paletes
SELECT * FROM palete;

--Listar as localizações
SELECT * FROM localizacao;

--Mostrar apenas paletes retidos
SELECT * FROM palete WHERE status LIKE 'R%';

--Listar produtos de um codigo especifico
SELECT * FROM palete WHERE codigo_produto = 1022;

--Produto especifico que está retido
SELECT * FROM palete WHERE codigo_produto = 1022 AND status = 'Retido';

--Listar paletes por lote de forma crescente
SELECT * FROM palete ORDER BY lote ASC;

--Listar paletes retidos do mais antigo ao mais recente
SELECT * FROM palete WHERE status = 'Retido' ORDER BY data_producao ASC;


