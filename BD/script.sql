
-- -------------------------------------------------------------------
-- Script de Carga de Dados
-- -------------------------------------------------------------------

-- ****************************************************************************************
-- Dados básicos para localização de outros elementos
-- ****************************************************************************************
-- Dados básicos: Cidade ---------------------------------------------
select * from cidade;
INSERT INTO `ifoodsocial`.`cidade`
	(`COD_CIDADE`,		`DCR_CIDADE`)
VALUES
	(1,					'Itabuna');

INSERT INTO `ifoodsocial`.`cidade`
	(`COD_CIDADE`,		`DCR_CIDADE`)
VALUES
	(2,					'Ilhéus');

INSERT INTO `ifoodsocial`.`cidade`
	(`COD_CIDADE`,		`DCR_CIDADE`)
VALUES
	(3,					'Itauípe');
    
-- Dados básicos: Bairro  -------------------------------------------------------
select * from bairro order by cod_cidade;
INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(10,					'Centro',				1);

INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(11,					'Conceição',			1);

INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(12,					'Góes Calmon',			1);

INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(20,					'Salobrinho',			2);

INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(21,					'Centro',				2);

INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(22,					'Pontal',				2); 

INSERT INTO `ifoodsocial`.`bairro`
(`COD_BAIRRO`,			`DCR_BAIRRO`,			`COD_CIDADE`)
VALUES
(30,					'Centro',				3); 
   

-- ****************************************************************************************
--  Empreendedor
-- ****************************************************************************************
-- Empreendedor: Empreendimento --------------------------------------------------
INSERT INTO `ifoodsocial`.`empreendimento`
(`COD_EMPREEDIMENTO`,		`DCR_EMPREENDIMENTO`,		`DCR_NOME_FANTASIA`,	`DCR_ENDERECO`,
`DCR_COMPLEMENTO`,			`NUM_CEP`,					`COD_CIDADE`,			`BAIRRO_COD_BAIRRO`,
			`IMG_EMPREENDIMENTO`)
VALUES
(1,							'Esmeralda Delícias',		'Esmeralda Delícias',	'Rua Central, 20',
'-',						'45662-000',				2,						20,
						Null);

INSERT INTO `ifoodsocial`.`empreendimento`
(`COD_EMPREEDIMENTO`,		`DCR_EMPREENDIMENTO`,		`DCR_NOME_FANTASIA`,	`DCR_ENDERECO`,
`DCR_COMPLEMENTO`,			`NUM_CEP`,					`COD_CIDADE`,			`BAIRRO_COD_BAIRRO`,
			`IMG_EMPREENDIMENTO`)
VALUES
(2,							'Espaço das Empadas',		'Espaço das Empadas',	'Rua Aurora, 100',
'20 Andar',					'45605-340',				1,						11,
					Null);
-- ******************************************************************************************

-- ******************************************************************************************
-- Produtos
-- ******************************************************************************************
SELECT 
    e.COD_EMPREEDIMENTO,
    e.DCR_EMPREENDIMENTO,
    c.COD_CATEGORIA,
    c.DCR_CATEGORIA,
    p.cod_produto,
    p.DCR_PRODUTO,
    p.VLR_PRODUTO
FROM
    empreendimento e,
    categoria c,
    produto p
WHERE
    e.COD_EMPREEDIMENTO = c.COD_EMPREEDIMENTO
        AND c.COD_CATEGORIA = p.COD_CATEGORIA
ORDER BY e.COD_EMPREEDIMENTO , c.cod_categoria , p.cod_produto;


-- Produtos: Categoria -----------------------------------------------------------
INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(10,					'Refeições',			NULL,					1);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(11,					'Lasanhas',				NULL,					1);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(12,					'Bebidas',				NULL,					1);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(13,					'Sobremesas',			NULL,					1);


INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(20,					'Empadas salgadas',		NULL,					2);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(21,					'Empadas doces',		NULL,					2);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(22,					'Quiches',				NULL,					2);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(23,					'Salgados diversos',	NULL,					2);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(24,					'Salgados light',		NULL,					2);

INSERT INTO `ifoodsocial`.`categoria`
(`COD_CATEGORIA`,		`DCR_CATEGORIA`,		`IMG_CATEGORIA`,		`COD_EMPREEDIMENTO`)
VALUES
(25,					'Sucos',				NULL,					2);

-- Produtos: Produtos -------------------------------------------------------------------------
-- 10	Refeições		1
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(100,				'PF - 1 carne',		NULL,				15.00,
'S',				10,					1);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(101,				'PF - 2 carnes',		NULL,			19.00,
'S',				10,					1);

-- 11	Lasanhas		1
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(110,				'Lasanha de carne',	NULL,				16.00,
'S',				11,					1);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(111,				'Lasanha de frango',NULL,				13.00,
'S',				11,					1);

-- 12	Bebidas		1
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(120,				'Refri - Caçulinha', NULL,				2.50,
'S',				12,					1);

-- 12	Bebidas		1
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(121,				'Refri - Lata', 	NULL,				4.50,
'S',				12,					1);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(122,				'Suco do dia', 		NULL,				2.00,
'S',				12,					1);

-- 13	Sobremesas		1
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(130,				'Doce do dia', 		NULL,				2.20,
'S',				13,					1);

-- 20	Empadas salgadas		2
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(200,				'Frango', NULL,				5.00,
'S',				20,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(201,				'Frango com Catupiry', NULL,				5.50,
'S',				20,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(202,				'Camarão', NULL,				6.50,
'S',				20,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(203,				'Carne seca com banana', NULL,				5.00,
'S',				20,					2);

-- 21	Empadas doces		2
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(210,				'Brigadeiro', 		NULL,				4.00,
'S',				21,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(211,				'Romeu e Julieta', 	NULL,				4.00,
'S',				21,					2);

-- 22	Quiches		2
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(220,				'Alho poro com bacon', 	NULL,				6.50,
'S',				22,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(221,				'Calabresa apimentada', 	NULL,				5.50,
'S',				22,					2);

-- 23	Salgados diversos		2
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(230,				'Coxinha de frango', NULL,				4.50,
'S',				23,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(231,				'Quibe', 			NULL,				4.50,
'S',				23,					2);

-- 24	Salgados light		2
INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(240,				'Pastel integral - frango com ricota', 	NULL,				6.50,
'S',				24,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(241,				'Pastel integral - queijo e tomate seco', 	NULL,				6.50,
'S',				24,					2);


-- 25	Sucos		2

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(250,				'Cajá', 	NULL,	4.00,
'S',				25,					2);

INSERT INTO `ifoodsocial`.`produto`
(`COD_PRODUTO`, 	`DCR_PRODUTO`,		`IMG_PRODUTO`,		`VLR_PRODUTO`,
`FLAG_DISPONIVEL`,	`COD_CATEGORIA`,	`COD_EMPREEDIMENTO`)
VALUES
(251,				'Manga', 	NULL,	4.00,
'S',				25,					2);


-- *******************************************************************************************
--  Cliente
-- *******************************************************************************************
select * from cliente;
INSERT INTO `ifoodsocial`.`cliente`
(`COD_CLIENTE`,			`NOME_CLIENTE`,			`DCR_ENDERECO`,
`DCR_COMPLEMENTO`,		`NUM_CEP`,				`COD_CIDADE`,
`COD_BAIRRO`)
VALUES
(1,						'Carlos Alberto',		'UESC',
'UESC',					'45662-900',			2,
20);

INSERT INTO `ifoodsocial`.`cliente`
(`COD_CLIENTE`,			`NOME_CLIENTE`,			`DCR_ENDERECO`,
`DCR_COMPLEMENTO`,		`NUM_CEP`,				`COD_CIDADE`,
`COD_BAIRRO`)
VALUES
(2,						'João Marcos',			'UESC',
'UESC',					'45662-900',			2,
20);

INSERT INTO `ifoodsocial`.`cliente`
(`COD_CLIENTE`,			`NOME_CLIENTE`,			`DCR_ENDERECO`,
`DCR_COMPLEMENTO`,		`NUM_CEP`,				`COD_CIDADE`,
`COD_BAIRRO`		)
VALUES
(3,						'Marcela',				'Rua Bela Vista, 30',
'Apto 102',				'45605-255',			1,
11);



