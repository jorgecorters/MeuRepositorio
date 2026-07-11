
CREATE TABLE produtos(
codigo SMALLINT,
nome VARCHAR(50) PRIMARY KEY
);

CREATE TABLE localizacao(
id_localizacao SERIAL PRIMARY KEY,
rua SMALLINT,
andar CHAR(1),
posicao SMALLINT,
codigo_localizacao CHAR(5)
);

CREATE TABLE palete(
id_palete SERIAL PRIMARY KEY,
codigo_produto SMALLINT,
lote SMALLINT,
data_producao DATE,
status VARCHAR(10),
id_localizacao SMALLINT
);







