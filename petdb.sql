-- Database generated with pgModeler (PostgreSQL Database Modeler).
-- pgModeler  version: 0.9.0
-- PostgreSQL version: 9.6
-- Project Site: pgmodeler.com.br
-- Model Author: ---


-- Database creation must be done outside an multicommand file.
-- These commands were put in this file only for convenience.
-- -- object: petdb | type: DATABASE --
-- -- DROP DATABASE IF EXISTS petdb;
-- CREATE DATABASE petdb
-- ;
-- -- ddl-end --
-- 

-- object: public."PK_clientes_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_clientes_id_seq" CASCADE;
CREATE SEQUENCE public."PK_clientes_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_clientes_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.clientes | type: TABLE --
-- DROP TABLE IF EXISTS public.clientes CASCADE;
CREATE TABLE public.clientes(
	id bigint NOT NULL DEFAULT nextval('public."PK_clientes_id_seq"'::regclass),
	nome_completo character varying(50) NOT NULL,
	data_nascimento date,
	cpf character varying(14) NOT NULL,
	rg character varying(25),
	orgao_expedidor_rg character varying(6),
	data_emissao_rg date,
	email character varying(90),
	pre_cadastro boolean NOT NULL,
	CONSTRAINT "UQ_clientes_cpf" UNIQUE (cpf),
	CONSTRAINT "UQ_clientes_rg" UNIQUE (rg),
	CONSTRAINT clientes_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.clientes OWNER TO postgres;
-- ddl-end --

-- object: public."PK_cliente_enderecos_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_cliente_enderecos_id_seq" CASCADE;
CREATE SEQUENCE public."PK_cliente_enderecos_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_cliente_enderecos_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.clientes_enderecos | type: TABLE --
-- DROP TABLE IF EXISTS public.clientes_enderecos CASCADE;
CREATE TABLE public.clientes_enderecos(
	id bigint NOT NULL DEFAULT nextval('public."PK_cliente_enderecos_id_seq"'::regclass),
	cliente_id bigint NOT NULL,
	endereco character varying(55) NOT NULL,
	endereco_numero character varying(10) NOT NULL,
	bairro character varying(25) NOT NULL,
	complemento character varying(25),
	CONSTRAINT clientes_enderecos_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.clientes_enderecos OWNER TO postgres;
-- ddl-end --

-- object: public."PK_clientes_contatos_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_clientes_contatos_id_seq" CASCADE;
CREATE SEQUENCE public."PK_clientes_contatos_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_clientes_contatos_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.clientes_contatos | type: TABLE --
-- DROP TABLE IF EXISTS public.clientes_contatos CASCADE;
CREATE TABLE public.clientes_contatos(
	id bigint NOT NULL DEFAULT nextval('public."PK_clientes_contatos_id_seq"'::regclass),
	cliente_id bigint NOT NULL,
	telefone character varying(15) NOT NULL,
	fala_com character varying(35) NOT NULL,
	CONSTRAINT clientes_contatos_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.clientes_contatos OWNER TO postgres;
-- ddl-end --

-- object: public."PK_pets_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_pets_id_seq" CASCADE;
CREATE SEQUENCE public."PK_pets_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_pets_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.pets | type: TABLE --
-- DROP TABLE IF EXISTS public.pets CASCADE;
CREATE TABLE public.pets(
	id bigint NOT NULL DEFAULT nextval('public."PK_pets_id_seq"'::regclass),
	cliente_id bigint NOT NULL,
	nome_pet character varying(20) NOT NULL,
	data_nascimento date,
	tem_pacote boolean NOT NULL,
	valor_pacote decimal(19,3),
	com_tosa_higienica boolean,
	especie integer NOT NULL,
	raca_id integer NOT NULL,
	dia_pacote integer,
	transporte boolean,
	turno_servico char(1),
	pre_cadastro boolean NOT NULL,
	porte integer NOT NULL,
	CONSTRAINT pets_pk PRIMARY KEY (id)

);
-- ddl-end --
COMMENT ON COLUMN public.pets.especie IS '''0''->canino, ''1''->felino';
-- ddl-end --
COMMENT ON COLUMN public.pets.dia_pacote IS '0->segunda, 6->sabado';
-- ddl-end --
COMMENT ON COLUMN public.pets.turno_servico IS '''0''->manha, ''1''->tarde';
-- ddl-end --
COMMENT ON COLUMN public.pets.porte IS '0 - min ''1'' - pequeno ''2'' - medio ''3'' - grande ''4'' - gigante'; 
-- ddl-end --
ALTER TABLE public.pets OWNER TO postgres;
-- ddl-end --

-- object: public."PK_racas_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_racas_id_seq" CASCADE;
CREATE SEQUENCE public."PK_racas_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_racas_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.racas | type: TABLE --
-- DROP TABLE IF EXISTS public.racas CASCADE;
CREATE TABLE public.racas(
	id integer NOT NULL DEFAULT nextval('public."PK_racas_id_seq"'::regclass),
	raca_descricao character varying(40) NOT NULL,
	tipo_raca integer NOT NULL,
	CONSTRAINT "UQ_racas_descricao" UNIQUE (raca_descricao),
	CONSTRAINT racas_pk PRIMARY KEY (id)

);
-- ddl-end --
COMMENT ON COLUMN public.racas.tipo_raca IS '''0''->canina, ''1''->felina';
-- ddl-end --
ALTER TABLE public.racas OWNER TO postgres;
-- ddl-end --

-- object: public."PK_caixas_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_caixas_id_seq" CASCADE;
CREATE SEQUENCE public."PK_caixas_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_caixas_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.caixas | type: TABLE --
-- DROP TABLE IF EXISTS public.caixas CASCADE;
CREATE TABLE public.caixas(
	id bigint NOT NULL DEFAULT nextval('public."PK_caixas_id_seq"'::regclass),
	data_abertura date NOT NULL,
	valor_abertura decimal(19,3) NOT NULL,
	valor_fechamento_total decimal(19,3),
	valor_fecha_dinheiro decimal(19,3),
	valor_fecha_cheque decimal(19,3),
	valor_fecha_debito decimal(19,3),
	valor_fecha_credito decimal(19,3),
	CONSTRAINT "UQ_caixas_abertura" UNIQUE (data_abertura),
	CONSTRAINT caixas_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.caixas OWNER TO postgres;
-- ddl-end --

-- object: public."PK_produtos_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_produtos_id_seq" CASCADE;
CREATE SEQUENCE public."PK_produtos_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_produtos_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.produtos | type: TABLE --
-- DROP TABLE IF EXISTS public.produtos CASCADE;
CREATE TABLE public.produtos(
	codigo bigint NOT NULL DEFAULT nextval('public."PK_produtos_id_seq"'::regclass),
	descricao character varying(50) NOT NULL,
	codigobarra character varying(20) NOT NULL,
	codigofabrica character varying(22) NOT NULL,
	embalagem character varying(2) NOT NULL,
	qtdembalagem numeric(19,3) NOT NULL,
	custonota numeric(19,3) NOT NULL,
	custofrete numeric(19,3) NOT NULL,
	custofinal numeric(19,3) NOT NULL,
	precoultimavenda numeric(19,3),
	precominimo numeric(19,3) NOT NULL,
	precoavista numeric(19,3) NOT NULL,
	precoparcelado numeric(19,3) NOT NULL,
	CONSTRAINT produtos_pk PRIMARY KEY (codigo),
	CONSTRAINT "UQ_produtos_codigobarras" UNIQUE (codigobarra)

);
-- ddl-end --
ALTER TABLE public.produtos OWNER TO postgres;
-- ddl-end --

-- object: public."PK_servicos_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_servicos_id_seq" CASCADE;
CREATE SEQUENCE public."PK_servicos_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_servicos_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.servicos | type: TABLE --
-- DROP TABLE IF EXISTS public.servicos CASCADE;
CREATE TABLE public.servicos(
	id integer NOT NULL DEFAULT nextval('public."PK_servicos_id_seq"'::regclass),
	descricao_servico character varying(50) NOT NULL,
	valor_servico numeric(19,3) NOT NULL,
	habilitado boolean NOT NULL,
	CONSTRAINT servicos_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.servicos OWNER TO postgres;
-- ddl-end --

-- object: public."PK_servicos_diarios_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_servicos_diarios_id_seq" CASCADE;
CREATE SEQUENCE public."PK_servicos_diarios_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_servicos_diarios_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.servicos_diarios | type: TABLE --
-- DROP TABLE IF EXISTS public.servicos_diarios CASCADE;
CREATE TABLE public.servicos_diarios(
	id bigint NOT NULL DEFAULT nextval('public."PK_servicos_diarios_id_seq"'::regclass),
	data_realizado date NOT NULL,
	servico_id integer NOT NULL,
	descricao_servico character varying(50) NOT NULL,
	cliente_id bigint NOT NULL,
	pet_id bigint NOT NULL,
	quantidade integer NOT NULL,
	valor_unitario decimal(19,3) NOT NULL,
	valor_total decimal(19,3) NOT NULL,
	em_ficha boolean NOT NULL,
	recebido boolean NOT NULL,
	CONSTRAINT servicos_diarios_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.servicos_diarios OWNER TO postgres;
-- ddl-end --

-- object: public."PK_produtos_vendas_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_produtos_vendas_id_seq" CASCADE;
CREATE SEQUENCE public."PK_produtos_vendas_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_produtos_vendas_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.produtos_vendas | type: TABLE --
-- DROP TABLE IF EXISTS public.produtos_vendas CASCADE;
CREATE TABLE public.produtos_vendas(
	id bigint NOT NULL DEFAULT nextval('public."PK_produtos_vendas_id_seq"'::regclass),
	produto_id bigint NOT NULL,
	cliente_id bigint NOT NULL,
	em_ficha boolean NOT NULL,
	recebido boolean NOT NULL,
	quantidade smallint NOT NULL,
	descricao_produto character varying(55) NOT NULL,
	valor_unitario decimal(19,3) NOT NULL,
	valor_total decimal(19,3) NOT NULL,
	und_medida_venda char(2) NOT NULL,
	CONSTRAINT produtos_vendas_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.produtos_vendas OWNER TO postgres;
-- ddl-end --

-- object: public."PK_acertos_clientes_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_acertos_clientes_id_seq" CASCADE;
CREATE SEQUENCE public."PK_acertos_clientes_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_acertos_clientes_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.acertos_fichas_clientes | type: TABLE --
-- DROP TABLE IF EXISTS public.acertos_fichas_clientes CASCADE;
CREATE TABLE public.acertos_fichas_clientes(
	id bigint NOT NULL DEFAULT nextval('public."PK_acertos_clientes_id_seq"'::regclass),
	data_acerto date NOT NULL,
	valor_total decimal(19,3) NOT NULL,
	credito_cliente_id bigint,
	valor_credito_cliente decimal(19,3),
	caixa_id bigint NOT NULL,
	categoria char(2) NOT NULL,
	cliente_id bigint NOT NULL,
	CONSTRAINT acertos_fichas_clientes_pk PRIMARY KEY (id)

);
-- ddl-end --
COMMENT ON COLUMN public.acertos_fichas_clientes.categoria IS '''BL''->Boleto,''RS''->Dinheiro,''CC''->Cartao Debito';
-- ddl-end --
ALTER TABLE public.acertos_fichas_clientes OWNER TO postgres;
-- ddl-end --

-- object: public."PK_acertos_clientes_pagamentos_id_seq" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_acertos_clientes_pagamentos_id_seq" CASCADE;
CREATE SEQUENCE public."PK_acertos_clientes_pagamentos_id_seq"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_acertos_clientes_pagamentos_id_seq" OWNER TO postgres;
-- ddl-end --

-- object: public.acertos_fichas_clientes_pagamentos | type: TABLE --
-- DROP TABLE IF EXISTS public.acertos_fichas_clientes_pagamentos CASCADE;
CREATE TABLE public.acertos_fichas_clientes_pagamentos(
	id bigint NOT NULL DEFAULT nextval('public."PK_acertos_clientes_pagamentos_id_seq"'::regclass),
	acerto_ficha_id bigint NOT NULL,
	tipo_recebimento character varying(2) NOT NULL,
	valor_recebimento numeric(19,3) NOT NULL,
	autorizacao_cartao character varying(12),
	numero_cheque character varying(12),
	bandeira_cartao character varying(20),
	CONSTRAINT acertos_fichas_clientes_pagamentos_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.acertos_fichas_clientes_pagamentos OWNER TO postgres;
-- ddl-end --

-- object: public."PK_produtos_vendas_pagamentos_id" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_produtos_vendas_pagamentos_id" CASCADE;
CREATE SEQUENCE public."PK_produtos_vendas_pagamentos_id"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_produtos_vendas_pagamentos_id" OWNER TO postgres;
-- ddl-end --

-- object: public.produtos_vendas_pagamentos | type: TABLE --
-- DROP TABLE IF EXISTS public.produtos_vendas_pagamentos CASCADE;
CREATE TABLE public.produtos_vendas_pagamentos(
	id bigint NOT NULL DEFAULT nextval('public."PK_produtos_vendas_pagamentos_id"'::regclass),
	produto_venda_id bigint NOT NULL,
	tipo_recebimento character varying(2) NOT NULL,
	valor_recebimento numeric(19,3) NOT NULL,
	autorizacao_cartao character varying(12),
	numero_cheque character varying(12),
	bandeira_cartao character varying(20),
	CONSTRAINT produtos_vendas_pagamentos_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.produtos_vendas_pagamentos OWNER TO postgres;
-- ddl-end --

-- object: public."PK_creditos_clientes_id" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_creditos_clientes_id" CASCADE;
CREATE SEQUENCE public."PK_creditos_clientes_id"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_creditos_clientes_id" OWNER TO postgres;
-- ddl-end --

-- object: public.creditos_clientes | type: TABLE --
-- DROP TABLE IF EXISTS public.creditos_clientes CASCADE;
CREATE TABLE public.creditos_clientes(
	id integer NOT NULL DEFAULT nextval('public."PK_creditos_clientes_id"'::regclass),
	cliente_id bigint NOT NULL,
	valor_credito numeric(19,3) NOT NULL,
	data_credito date NOT NULL,
	utilizado boolean NOT NULL,
	data_utilizacao date,
	CONSTRAINT creditos_clientes_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.creditos_clientes OWNER TO postgres;
-- ddl-end --

-- object: public."PK_acertos_clientes_detalhes_id" | type: SEQUENCE --
-- DROP SEQUENCE IF EXISTS public."PK_acertos_clientes_detalhes_id" CASCADE;
CREATE SEQUENCE public."PK_acertos_clientes_detalhes_id"
	INCREMENT BY 1
	MINVALUE 0
	MAXVALUE 2147483647
	START WITH 1
	CACHE 1
	NO CYCLE
	OWNED BY NONE;
-- ddl-end --
ALTER SEQUENCE public."PK_acertos_clientes_detalhes_id" OWNER TO postgres;
-- ddl-end --

-- object: public.acertos_fichas_clientes_detalhes | type: TABLE --
-- DROP TABLE IF EXISTS public.acertos_fichas_clientes_detalhes CASCADE;
CREATE TABLE public.acertos_fichas_clientes_detalhes(
	id bigint NOT NULL DEFAULT nextval('public."PK_acertos_clientes_detalhes_id"'::regclass),
	acerto_ficha_cliente_id bigint NOT NULL,
	servico_diario_id bigint NOT NULL,
	produto_venda_id bigint NOT NULL,
	descricao_item character varying(55) NOT NULL,
	und_medida_item character varying(2) NOT NULL,
	qtd_item integer NOT NULL,
	valor_unitario_item numeric(19,3) NOT NULL,
	valor_total_item numeric(19,3) NOT NULL,
	CONSTRAINT acertos_fichas_clientes_detalhes_pk PRIMARY KEY (id)

);
-- ddl-end --
ALTER TABLE public.acertos_fichas_clientes_detalhes OWNER TO postgres;
-- ddl-end --

-- object: "FK_clientes_enderecos_id" | type: CONSTRAINT --
-- ALTER TABLE public.clientes_enderecos DROP CONSTRAINT IF EXISTS "FK_clientes_enderecos_id" CASCADE;
ALTER TABLE public.clientes_enderecos ADD CONSTRAINT "FK_clientes_enderecos_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: "FK_clientes_contatos_id" | type: CONSTRAINT --
-- ALTER TABLE public.clientes_contatos DROP CONSTRAINT IF EXISTS "FK_clientes_contatos_id" CASCADE;
ALTER TABLE public.clientes_contatos ADD CONSTRAINT "FK_clientes_contatos_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: "FK_clientes_pets_id" | type: CONSTRAINT --
-- ALTER TABLE public.pets DROP CONSTRAINT IF EXISTS "FK_clientes_pets_id" CASCADE;
ALTER TABLE public.pets ADD CONSTRAINT "FK_clientes_pets_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE CASCADE ON UPDATE CASCADE;
-- ddl-end --

-- object: "FK_pets_racas_id" | type: CONSTRAINT --
-- ALTER TABLE public.pets DROP CONSTRAINT IF EXISTS "FK_pets_racas_id" CASCADE;
ALTER TABLE public.pets ADD CONSTRAINT "FK_pets_racas_id" FOREIGN KEY (raca_id)
REFERENCES public.racas (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_servicos_diarios_servicos_id" | type: CONSTRAINT --
-- ALTER TABLE public.servicos_diarios DROP CONSTRAINT IF EXISTS "FK_servicos_diarios_servicos_id" CASCADE;
ALTER TABLE public.servicos_diarios ADD CONSTRAINT "FK_servicos_diarios_servicos_id" FOREIGN KEY (servico_id)
REFERENCES public.servicos (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_servicos_diarios_clientes_id" | type: CONSTRAINT --
-- ALTER TABLE public.servicos_diarios DROP CONSTRAINT IF EXISTS "FK_servicos_diarios_clientes_id" CASCADE;
ALTER TABLE public.servicos_diarios ADD CONSTRAINT "FK_servicos_diarios_clientes_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_servicos_diarios_pets_id" | type: CONSTRAINT --
-- ALTER TABLE public.servicos_diarios DROP CONSTRAINT IF EXISTS "FK_servicos_diarios_pets_id" CASCADE;
ALTER TABLE public.servicos_diarios ADD CONSTRAINT "FK_servicos_diarios_pets_id" FOREIGN KEY (pet_id)
REFERENCES public.pets (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_produtos_vendas_produtos_id" | type: CONSTRAINT --
-- ALTER TABLE public.produtos_vendas DROP CONSTRAINT IF EXISTS "FK_produtos_vendas_produtos_id" CASCADE;
ALTER TABLE public.produtos_vendas ADD CONSTRAINT "FK_produtos_vendas_produtos_id" FOREIGN KEY (produto_id)
REFERENCES public.produtos (codigo) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_produtos_vendas_clientes_id" | type: CONSTRAINT --
-- ALTER TABLE public.produtos_vendas DROP CONSTRAINT IF EXISTS "FK_produtos_vendas_clientes_id" CASCADE;
ALTER TABLE public.produtos_vendas ADD CONSTRAINT "FK_produtos_vendas_clientes_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_acertos_fichas_caixas_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes DROP CONSTRAINT IF EXISTS "FK_acertos_fichas_caixas_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes ADD CONSTRAINT "FK_acertos_fichas_caixas_id" FOREIGN KEY (caixa_id)
REFERENCES public.caixas (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_acertos_fichas_clientes_clientes_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes DROP CONSTRAINT IF EXISTS "FK_acertos_fichas_clientes_clientes_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes ADD CONSTRAINT "FK_acertos_fichas_clientes_clientes_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_acertos_creditos_clientes_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes DROP CONSTRAINT IF EXISTS "FK_acertos_creditos_clientes_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes ADD CONSTRAINT "FK_acertos_creditos_clientes_id" FOREIGN KEY (credito_cliente_id)
REFERENCES public.creditos_clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_acertos_fichas_pagamentos_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes_pagamentos DROP CONSTRAINT IF EXISTS "FK_acertos_fichas_pagamentos_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes_pagamentos ADD CONSTRAINT "FK_acertos_fichas_pagamentos_id" FOREIGN KEY (acerto_ficha_id)
REFERENCES public.acertos_fichas_clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_produtos_vendas_pgtos_produtos_venda_id" | type: CONSTRAINT --
-- ALTER TABLE public.produtos_vendas_pagamentos DROP CONSTRAINT IF EXISTS "FK_produtos_vendas_pgtos_produtos_venda_id" CASCADE;
ALTER TABLE public.produtos_vendas_pagamentos ADD CONSTRAINT "FK_produtos_vendas_pgtos_produtos_venda_id" FOREIGN KEY (produto_venda_id)
REFERENCES public.produtos_vendas (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_creditos_clientes_id" | type: CONSTRAINT --
-- ALTER TABLE public.creditos_clientes DROP CONSTRAINT IF EXISTS "FK_creditos_clientes_id" CASCADE;
ALTER TABLE public.creditos_clientes ADD CONSTRAINT "FK_creditos_clientes_id" FOREIGN KEY (cliente_id)
REFERENCES public.clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_acerto_ficha_detalhes_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes_detalhes DROP CONSTRAINT IF EXISTS "FK_acerto_ficha_detalhes_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes_detalhes ADD CONSTRAINT "FK_acerto_ficha_detalhes_id" FOREIGN KEY (acerto_ficha_cliente_id)
REFERENCES public.acertos_fichas_clientes (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_servico_diario_detalhes_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes_detalhes DROP CONSTRAINT IF EXISTS "FK_servico_diario_detalhes_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes_detalhes ADD CONSTRAINT "FK_servico_diario_detalhes_id" FOREIGN KEY (servico_diario_id)
REFERENCES public.servicos_diarios (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --

-- object: "FK_produto_venda_detalhes_id" | type: CONSTRAINT --
-- ALTER TABLE public.acertos_fichas_clientes_detalhes DROP CONSTRAINT IF EXISTS "FK_produto_venda_detalhes_id" CASCADE;
ALTER TABLE public.acertos_fichas_clientes_detalhes ADD CONSTRAINT "FK_produto_venda_detalhes_id" FOREIGN KEY (produto_venda_id)
REFERENCES public.produtos_vendas (id) MATCH FULL
ON DELETE NO ACTION ON UPDATE NO ACTION;
-- ddl-end --


