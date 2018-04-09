--
-- PostgreSQL database dump
--

-- Dumped from database version 10.1
-- Dumped by pg_dump version 10.1

-- Started on 2018-04-07 12:49:43

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 12924)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 3000 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

--
-- TOC entry 224 (class 1259 OID 24952)
-- Name: PK_acertos_clientes_detalhes_id; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_acertos_clientes_detalhes_id"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_acertos_clientes_detalhes_id" OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 24920)
-- Name: PK_acertos_clientes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_acertos_clientes_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_acertos_clientes_id_seq" OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 24928)
-- Name: PK_acertos_clientes_pagamentos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_acertos_clientes_pagamentos_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_acertos_clientes_pagamentos_id_seq" OWNER TO postgres;

--
-- TOC entry 206 (class 1259 OID 24876)
-- Name: PK_caixas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_caixas_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_caixas_id_seq" OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 24842)
-- Name: PK_cliente_enderecos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_cliente_enderecos_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_cliente_enderecos_id_seq" OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 24850)
-- Name: PK_clientes_contatos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_clientes_contatos_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_clientes_contatos_id_seq" OWNER TO postgres;

--
-- TOC entry 196 (class 1259 OID 24830)
-- Name: PK_clientes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_clientes_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_clientes_id_seq" OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 24944)
-- Name: PK_creditos_clientes_id; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_creditos_clientes_id"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_creditos_clientes_id" OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 24858)
-- Name: PK_pets_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_pets_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_pets_id_seq" OWNER TO postgres;

--
-- TOC entry 208 (class 1259 OID 24886)
-- Name: PK_produtos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_produtos_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_produtos_id_seq" OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 24912)
-- Name: PK_produtos_vendas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_produtos_vendas_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_produtos_vendas_id_seq" OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 24936)
-- Name: PK_produtos_vendas_pagamentos_id; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_produtos_vendas_pagamentos_id"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_produtos_vendas_pagamentos_id" OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 24866)
-- Name: PK_racas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_racas_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_racas_id_seq" OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 24904)
-- Name: PK_servicos_diarios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_servicos_diarios_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_servicos_diarios_id_seq" OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 24896)
-- Name: PK_servicos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "PK_servicos_id_seq"
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    MAXVALUE 2147483647
    CACHE 1;


ALTER TABLE "PK_servicos_id_seq" OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 217 (class 1259 OID 24922)
-- Name: acertos_fichas_clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE acertos_fichas_clientes (
    id bigint DEFAULT nextval('"PK_acertos_clientes_id_seq"'::regclass) NOT NULL,
    data_acerto date NOT NULL,
    valor_total numeric(19,3) NOT NULL,
    credito_cliente_id bigint,
    valor_credito_cliente numeric(19,3),
    caixa_id bigint NOT NULL,
    categoria character(2) NOT NULL,
    cliente_id bigint NOT NULL
);


ALTER TABLE acertos_fichas_clientes OWNER TO postgres;

--
-- TOC entry 3001 (class 0 OID 0)
-- Dependencies: 217
-- Name: COLUMN acertos_fichas_clientes.categoria; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN acertos_fichas_clientes.categoria IS '''BL''->Boleto,''RS''->Dinheiro,''CC''->Cartao Debito';


--
-- TOC entry 225 (class 1259 OID 24954)
-- Name: acertos_fichas_clientes_detalhes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE acertos_fichas_clientes_detalhes (
    id bigint DEFAULT nextval('"PK_acertos_clientes_detalhes_id"'::regclass) NOT NULL,
    acerto_ficha_cliente_id bigint NOT NULL,
    servico_diario_id bigint NOT NULL,
    produto_venda_id bigint NOT NULL,
    descricao_item character varying(55) NOT NULL,
    und_medida_item character varying(2) NOT NULL,
    qtd_item integer NOT NULL,
    valor_unitario_item numeric(19,3) NOT NULL,
    valor_total_item numeric(19,3) NOT NULL
);


ALTER TABLE acertos_fichas_clientes_detalhes OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 24930)
-- Name: acertos_fichas_clientes_pagamentos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE acertos_fichas_clientes_pagamentos (
    id bigint DEFAULT nextval('"PK_acertos_clientes_pagamentos_id_seq"'::regclass) NOT NULL,
    acerto_ficha_id bigint NOT NULL,
    tipo_recebimento character varying(2) NOT NULL,
    valor_recebimento numeric(19,3) NOT NULL,
    autorizacao_cartao character varying(12),
    numero_cheque character varying(12),
    bandeira_cartao character varying(20)
);


ALTER TABLE acertos_fichas_clientes_pagamentos OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 25133)
-- Name: bairros; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE bairros (
    id bigint NOT NULL,
    nome character varying,
    taxa_entrega numeric(19,2)
);


ALTER TABLE bairros OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 25131)
-- Name: bairros_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE bairros_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE bairros_id_seq OWNER TO postgres;

--
-- TOC entry 3002 (class 0 OID 0)
-- Dependencies: 226
-- Name: bairros_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE bairros_id_seq OWNED BY bairros.id;


--
-- TOC entry 207 (class 1259 OID 24878)
-- Name: caixas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE caixas (
    id bigint DEFAULT nextval('"PK_caixas_id_seq"'::regclass) NOT NULL,
    data_abertura date NOT NULL,
    valor_abertura numeric(19,3) NOT NULL,
    valor_fechamento_total numeric(19,3),
    valor_fecha_dinheiro numeric(19,3),
    valor_fecha_cheque numeric(19,3),
    valor_fecha_debito numeric(19,3),
    valor_fecha_credito numeric(19,3)
);


ALTER TABLE caixas OWNER TO postgres;

--
-- TOC entry 197 (class 1259 OID 24832)
-- Name: clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE clientes (
    id bigint DEFAULT nextval('"PK_clientes_id_seq"'::regclass) NOT NULL,
    nome_completo character varying(50) NOT NULL,
    data_nascimento date,
    cpf character varying(14) NOT NULL,
    rg character varying(25),
    orgao_expedidor_rg character varying(6),
    data_emissao_rg date,
    email character varying(90),
    pre_cadastro boolean NOT NULL
);


ALTER TABLE clientes OWNER TO postgres;

--
-- TOC entry 201 (class 1259 OID 24852)
-- Name: clientes_contatos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE clientes_contatos (
    id bigint DEFAULT nextval('"PK_clientes_contatos_id_seq"'::regclass) NOT NULL,
    cliente_id bigint NOT NULL,
    telefone character varying(15) NOT NULL,
    fala_com character varying(35) NOT NULL,
    principal boolean DEFAULT false NOT NULL
);


ALTER TABLE clientes_contatos OWNER TO postgres;

--
-- TOC entry 199 (class 1259 OID 24844)
-- Name: clientes_enderecos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE clientes_enderecos (
    id bigint DEFAULT nextval('"PK_cliente_enderecos_id_seq"'::regclass) NOT NULL,
    cliente_id bigint NOT NULL,
    endereco character varying(55) NOT NULL,
    endereco_numero character varying(10) NOT NULL,
    complemento character varying,
    cidade character varying(255) NOT NULL,
    estado character varying(255) NOT NULL,
    principal boolean DEFAULT false NOT NULL,
    bairro bigint
);


ALTER TABLE clientes_enderecos OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 24946)
-- Name: creditos_clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE creditos_clientes (
    id integer DEFAULT nextval('"PK_creditos_clientes_id"'::regclass) NOT NULL,
    cliente_id bigint NOT NULL,
    valor_credito numeric(19,3) NOT NULL,
    data_credito date NOT NULL,
    utilizado boolean NOT NULL,
    data_utilizacao date
);


ALTER TABLE creditos_clientes OWNER TO postgres;

--
-- TOC entry 203 (class 1259 OID 24860)
-- Name: pets; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE pets (
    id bigint DEFAULT nextval('"PK_pets_id_seq"'::regclass) NOT NULL,
    cliente_id bigint NOT NULL,
    nome_pet character varying(20) NOT NULL,
    data_nascimento date,
    tem_pacote boolean NOT NULL,
    valor_pacote numeric(19,3),
    com_tosa_higienica boolean,
    especie integer NOT NULL,
    raca_id integer NOT NULL,
    dia_pacote integer,
    transporte boolean,
    pre_cadastro boolean NOT NULL,
    porte integer NOT NULL,
    turno_servico integer
);


ALTER TABLE pets OWNER TO postgres;

--
-- TOC entry 3003 (class 0 OID 0)
-- Dependencies: 203
-- Name: COLUMN pets.especie; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN pets.especie IS '''0''->canino, ''1''->felino';


--
-- TOC entry 3004 (class 0 OID 0)
-- Dependencies: 203
-- Name: COLUMN pets.dia_pacote; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN pets.dia_pacote IS '2->segunda, 7->sabado';


--
-- TOC entry 3005 (class 0 OID 0)
-- Dependencies: 203
-- Name: COLUMN pets.porte; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN pets.porte IS '0 - min ''1'' - pequeno ''2'' - medio ''3'' - grande ''4'' - gigante';


--
-- TOC entry 209 (class 1259 OID 24888)
-- Name: produtos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE produtos (
    codigo bigint DEFAULT nextval('"PK_produtos_id_seq"'::regclass) NOT NULL,
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
    precoparcelado numeric(19,3) NOT NULL
);


ALTER TABLE produtos OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 24914)
-- Name: produtos_vendas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE produtos_vendas (
    id bigint DEFAULT nextval('"PK_produtos_vendas_id_seq"'::regclass) NOT NULL,
    produto_id bigint NOT NULL,
    cliente_id bigint NOT NULL,
    em_ficha boolean NOT NULL,
    recebido boolean NOT NULL,
    quantidade smallint NOT NULL,
    descricao_produto character varying(55) NOT NULL,
    valor_unitario numeric(19,3) NOT NULL,
    valor_total numeric(19,3) NOT NULL,
    und_medida_venda character(2) NOT NULL
);


ALTER TABLE produtos_vendas OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 24938)
-- Name: produtos_vendas_pagamentos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE produtos_vendas_pagamentos (
    id bigint DEFAULT nextval('"PK_produtos_vendas_pagamentos_id"'::regclass) NOT NULL,
    produto_venda_id bigint NOT NULL,
    tipo_recebimento character varying(2) NOT NULL,
    valor_recebimento numeric(19,3) NOT NULL,
    autorizacao_cartao character varying(12),
    numero_cheque character varying(12),
    bandeira_cartao character varying(20)
);


ALTER TABLE produtos_vendas_pagamentos OWNER TO postgres;

--
-- TOC entry 205 (class 1259 OID 24868)
-- Name: racas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE racas (
    id integer DEFAULT nextval('"PK_racas_id_seq"'::regclass) NOT NULL,
    raca_descricao character varying(40) NOT NULL,
    tipo_raca integer NOT NULL
);


ALTER TABLE racas OWNER TO postgres;

--
-- TOC entry 3006 (class 0 OID 0)
-- Dependencies: 205
-- Name: COLUMN racas.tipo_raca; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN racas.tipo_raca IS '''0''->canina, ''1''->felina';


--
-- TOC entry 211 (class 1259 OID 24898)
-- Name: servicos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE servicos (
    id integer DEFAULT nextval('"PK_servicos_id_seq"'::regclass) NOT NULL,
    descricao_servico character varying(50) NOT NULL,
    valor_servico numeric(19,3) NOT NULL,
    habilitado boolean NOT NULL
);


ALTER TABLE servicos OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 24906)
-- Name: servicos_diarios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE servicos_diarios (
    id bigint DEFAULT nextval('"PK_servicos_diarios_id_seq"'::regclass) NOT NULL,
    data_realizado date NOT NULL,
    servico_id integer NOT NULL,
    observacao_servico text NOT NULL,
    cliente_id bigint NOT NULL,
    pet_id bigint NOT NULL,
    quantidade integer NOT NULL,
    valor_unitario numeric(19,3) NOT NULL,
    valor_total numeric(19,3) NOT NULL,
    em_ficha boolean NOT NULL,
    recebido boolean NOT NULL,
    turno_servico integer NOT NULL,
    em_execucao boolean NOT NULL
);


ALTER TABLE servicos_diarios OWNER TO postgres;

--
-- TOC entry 2780 (class 2604 OID 25136)
-- Name: bairros id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY bairros ALTER COLUMN id SET DEFAULT nextval('bairros_id_seq'::regclass);


--
-- TOC entry 2983 (class 0 OID 24922)
-- Dependencies: 217
-- Data for Name: acertos_fichas_clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2991 (class 0 OID 24954)
-- Dependencies: 225
-- Data for Name: acertos_fichas_clientes_detalhes; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2985 (class 0 OID 24930)
-- Dependencies: 219
-- Data for Name: acertos_fichas_clientes_pagamentos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2993 (class 0 OID 25133)
-- Dependencies: 227
-- Data for Name: bairros; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO bairros (id, nome, taxa_entrega) VALUES (1, 'BANDEIRANTES 1', NULL);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (2, 'INDUSTRIAL', NULL);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (5, 'PARQUE DAS EMAS', NULL);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (6, 'JARDIM PRIMAVERA', 2.00);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (4, 'CENTRO', 0.50);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (3, 'CIDADE NOVA', 3.00);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (7, 'ALVORADA', 7.00);
INSERT INTO bairros (id, nome, taxa_entrega) VALUES (8, 'LUIS CARLOS TESSELE JUNIOR ', 10.00);


--
-- TOC entry 2973 (class 0 OID 24878)
-- Dependencies: 207
-- Data for Name: caixas; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2963 (class 0 OID 24832)
-- Dependencies: 197
-- Data for Name: clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO clientes (id, nome_completo, data_nascimento, cpf, rg, orgao_expedidor_rg, data_emissao_rg, email, pre_cadastro) VALUES (5, 'TESTE', NULL, '564.646.464-56', NULL, NULL, NULL, NULL, true);
INSERT INTO clientes (id, nome_completo, data_nascimento, cpf, rg, orgao_expedidor_rg, data_emissao_rg, email, pre_cadastro) VALUES (7, 'WILLIAM CADORE', '1996-09-27', '787.989.714-16', '123', 'SSP/SC', '2011-05-27', 'cadore.william@gmail.com', false);
INSERT INTO clientes (id, nome_completo, data_nascimento, cpf, rg, orgao_expedidor_rg, data_emissao_rg, email, pre_cadastro) VALUES (3, 'WILLIAM CADORE', NULL, '050.425.459-64', '6427046', NULL, NULL, NULL, true);


--
-- TOC entry 2967 (class 0 OID 24852)
-- Dependencies: 201
-- Data for Name: clientes_contatos; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO clientes_contatos (id, cliente_id, telefone, fala_com, principal) VALUES (1, 3, '(65)99953-4755', 'WILLIAM', true);
INSERT INTO clientes_contatos (id, cliente_id, telefone, fala_com, principal) VALUES (3, 5, '(79)8787-4874', 'TESTE', true);
INSERT INTO clientes_contatos (id, cliente_id, telefone, fala_com, principal) VALUES (4, 7, '(65)99953-4755', 'WILLIAM', false);


--
-- TOC entry 2965 (class 0 OID 24844)
-- Dependencies: 199
-- Data for Name: clientes_enderecos; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO clientes_enderecos (id, cliente_id, endereco, endereco_numero, complemento, cidade, estado, principal, bairro) VALUES (3, 3, 'AVENIDA MARANHAO', '1736', 'N', 'LUCAS DO RIO VERDE', 'MT - MATO GROSSO', true, 1);
INSERT INTO clientes_enderecos (id, cliente_id, endereco, endereco_numero, complemento, cidade, estado, principal, bairro) VALUES (5, 5, 'TESTE', '456456', NULL, 'LUCAS DO RIO VERDE', 'MT - MATO GROSSO', true, 8);
INSERT INTO clientes_enderecos (id, cliente_id, endereco, endereco_numero, complemento, cidade, estado, principal, bairro) VALUES (6, 7, 'AVENIDA MARANHAO', '1736', 'N', 'LUCAS DO RIO VERDE', 'MT - MATO GROSSO', false, 2);


--
-- TOC entry 2989 (class 0 OID 24946)
-- Dependencies: 223
-- Data for Name: creditos_clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2969 (class 0 OID 24860)
-- Dependencies: 203
-- Data for Name: pets; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO pets (id, cliente_id, nome_pet, data_nascimento, tem_pacote, valor_pacote, com_tosa_higienica, especie, raca_id, dia_pacote, transporte, pre_cadastro, porte, turno_servico) VALUES (3, 3, 'THOR', NULL, false, NULL, NULL, 0, 2, NULL, NULL, true, 1, 0);
INSERT INTO pets (id, cliente_id, nome_pet, data_nascimento, tem_pacote, valor_pacote, com_tosa_higienica, especie, raca_id, dia_pacote, transporte, pre_cadastro, porte, turno_servico) VALUES (5, 5, 'TESTE', NULL, false, NULL, NULL, 0, 2, NULL, NULL, true, 1, 0);


--
-- TOC entry 2975 (class 0 OID 24888)
-- Dependencies: 209
-- Data for Name: produtos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2981 (class 0 OID 24914)
-- Dependencies: 215
-- Data for Name: produtos_vendas; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2987 (class 0 OID 24938)
-- Dependencies: 221
-- Data for Name: produtos_vendas_pagamentos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2971 (class 0 OID 24868)
-- Dependencies: 205
-- Data for Name: racas; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO racas (id, raca_descricao, tipo_raca) VALUES (3, 'COFAP', 0);
INSERT INTO racas (id, raca_descricao, tipo_raca) VALUES (1, 'PASTOR ALEMÃO', 0);
INSERT INTO racas (id, raca_descricao, tipo_raca) VALUES (2, 'PITBULL', 0);
INSERT INTO racas (id, raca_descricao, tipo_raca) VALUES (4, 'SIAMES', 1);
INSERT INTO racas (id, raca_descricao, tipo_raca) VALUES (5, 'PINCHER', 0);


--
-- TOC entry 2977 (class 0 OID 24898)
-- Dependencies: 211
-- Data for Name: servicos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2979 (class 0 OID 24906)
-- Dependencies: 213
-- Data for Name: servicos_diarios; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3007 (class 0 OID 0)
-- Dependencies: 224
-- Name: PK_acertos_clientes_detalhes_id; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_acertos_clientes_detalhes_id"', 1, false);


--
-- TOC entry 3008 (class 0 OID 0)
-- Dependencies: 216
-- Name: PK_acertos_clientes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_acertos_clientes_id_seq"', 1, false);


--
-- TOC entry 3009 (class 0 OID 0)
-- Dependencies: 218
-- Name: PK_acertos_clientes_pagamentos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_acertos_clientes_pagamentos_id_seq"', 1, false);


--
-- TOC entry 3010 (class 0 OID 0)
-- Dependencies: 206
-- Name: PK_caixas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_caixas_id_seq"', 1, false);


--
-- TOC entry 3011 (class 0 OID 0)
-- Dependencies: 198
-- Name: PK_cliente_enderecos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_cliente_enderecos_id_seq"', 6, true);


--
-- TOC entry 3012 (class 0 OID 0)
-- Dependencies: 200
-- Name: PK_clientes_contatos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_clientes_contatos_id_seq"', 4, true);


--
-- TOC entry 3013 (class 0 OID 0)
-- Dependencies: 196
-- Name: PK_clientes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_clientes_id_seq"', 7, true);


--
-- TOC entry 3014 (class 0 OID 0)
-- Dependencies: 222
-- Name: PK_creditos_clientes_id; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_creditos_clientes_id"', 1, false);


--
-- TOC entry 3015 (class 0 OID 0)
-- Dependencies: 202
-- Name: PK_pets_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_pets_id_seq"', 5, true);


--
-- TOC entry 3016 (class 0 OID 0)
-- Dependencies: 208
-- Name: PK_produtos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_produtos_id_seq"', 1, false);


--
-- TOC entry 3017 (class 0 OID 0)
-- Dependencies: 214
-- Name: PK_produtos_vendas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_produtos_vendas_id_seq"', 1, false);


--
-- TOC entry 3018 (class 0 OID 0)
-- Dependencies: 220
-- Name: PK_produtos_vendas_pagamentos_id; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_produtos_vendas_pagamentos_id"', 1, false);


--
-- TOC entry 3019 (class 0 OID 0)
-- Dependencies: 204
-- Name: PK_racas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_racas_id_seq"', 5, true);


--
-- TOC entry 3020 (class 0 OID 0)
-- Dependencies: 212
-- Name: PK_servicos_diarios_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_servicos_diarios_id_seq"', 1, false);


--
-- TOC entry 3021 (class 0 OID 0)
-- Dependencies: 210
-- Name: PK_servicos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"PK_servicos_id_seq"', 1, false);


--
-- TOC entry 3022 (class 0 OID 0)
-- Dependencies: 226
-- Name: bairros_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('bairros_id_seq', 8, true);


--
-- TOC entry 2798 (class 2606 OID 24885)
-- Name: caixas UQ_caixas_abertura; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY caixas
    ADD CONSTRAINT "UQ_caixas_abertura" UNIQUE (data_abertura);


--
-- TOC entry 2782 (class 2606 OID 24839)
-- Name: clientes UQ_clientes_cpf; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes
    ADD CONSTRAINT "UQ_clientes_cpf" UNIQUE (cpf);


--
-- TOC entry 2784 (class 2606 OID 24841)
-- Name: clientes UQ_clientes_rg; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes
    ADD CONSTRAINT "UQ_clientes_rg" UNIQUE (rg);


--
-- TOC entry 2802 (class 2606 OID 24895)
-- Name: produtos UQ_produtos_codigobarras; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos
    ADD CONSTRAINT "UQ_produtos_codigobarras" UNIQUE (codigobarra);


--
-- TOC entry 2794 (class 2606 OID 24875)
-- Name: racas UQ_racas_descricao; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY racas
    ADD CONSTRAINT "UQ_racas_descricao" UNIQUE (raca_descricao);


--
-- TOC entry 2820 (class 2606 OID 24959)
-- Name: acertos_fichas_clientes_detalhes acertos_fichas_clientes_detalhes_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes_detalhes
    ADD CONSTRAINT acertos_fichas_clientes_detalhes_pk PRIMARY KEY (id);


--
-- TOC entry 2814 (class 2606 OID 24935)
-- Name: acertos_fichas_clientes_pagamentos acertos_fichas_clientes_pagamentos_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes_pagamentos
    ADD CONSTRAINT acertos_fichas_clientes_pagamentos_pk PRIMARY KEY (id);


--
-- TOC entry 2812 (class 2606 OID 24927)
-- Name: acertos_fichas_clientes acertos_fichas_clientes_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes
    ADD CONSTRAINT acertos_fichas_clientes_pk PRIMARY KEY (id);


--
-- TOC entry 2822 (class 2606 OID 25141)
-- Name: bairros bairros_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY bairros
    ADD CONSTRAINT bairros_pkey PRIMARY KEY (id);


--
-- TOC entry 2800 (class 2606 OID 24883)
-- Name: caixas caixas_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY caixas
    ADD CONSTRAINT caixas_pk PRIMARY KEY (id);


--
-- TOC entry 2790 (class 2606 OID 24857)
-- Name: clientes_contatos clientes_contatos_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes_contatos
    ADD CONSTRAINT clientes_contatos_pk PRIMARY KEY (id);


--
-- TOC entry 2788 (class 2606 OID 24849)
-- Name: clientes_enderecos clientes_enderecos_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes_enderecos
    ADD CONSTRAINT clientes_enderecos_pk PRIMARY KEY (id);


--
-- TOC entry 2786 (class 2606 OID 24837)
-- Name: clientes clientes_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes
    ADD CONSTRAINT clientes_pk PRIMARY KEY (id);


--
-- TOC entry 2818 (class 2606 OID 24951)
-- Name: creditos_clientes creditos_clientes_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY creditos_clientes
    ADD CONSTRAINT creditos_clientes_pk PRIMARY KEY (id);


--
-- TOC entry 2792 (class 2606 OID 24865)
-- Name: pets pets_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pets
    ADD CONSTRAINT pets_pk PRIMARY KEY (id);


--
-- TOC entry 2804 (class 2606 OID 24893)
-- Name: produtos produtos_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos
    ADD CONSTRAINT produtos_pk PRIMARY KEY (codigo);


--
-- TOC entry 2816 (class 2606 OID 24943)
-- Name: produtos_vendas_pagamentos produtos_vendas_pagamentos_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos_vendas_pagamentos
    ADD CONSTRAINT produtos_vendas_pagamentos_pk PRIMARY KEY (id);


--
-- TOC entry 2810 (class 2606 OID 24919)
-- Name: produtos_vendas produtos_vendas_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos_vendas
    ADD CONSTRAINT produtos_vendas_pk PRIMARY KEY (id);


--
-- TOC entry 2796 (class 2606 OID 24873)
-- Name: racas racas_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY racas
    ADD CONSTRAINT racas_pk PRIMARY KEY (id);


--
-- TOC entry 2808 (class 2606 OID 24911)
-- Name: servicos_diarios servicos_diarios_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY servicos_diarios
    ADD CONSTRAINT servicos_diarios_pk PRIMARY KEY (id);


--
-- TOC entry 2806 (class 2606 OID 24903)
-- Name: servicos servicos_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY servicos
    ADD CONSTRAINT servicos_pk PRIMARY KEY (id);


--
-- TOC entry 2838 (class 2606 OID 25035)
-- Name: acertos_fichas_clientes_detalhes FK_acerto_ficha_detalhes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes_detalhes
    ADD CONSTRAINT "FK_acerto_ficha_detalhes_id" FOREIGN KEY (acerto_ficha_cliente_id) REFERENCES acertos_fichas_clientes(id) MATCH FULL;


--
-- TOC entry 2834 (class 2606 OID 25015)
-- Name: acertos_fichas_clientes FK_acertos_creditos_clientes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes
    ADD CONSTRAINT "FK_acertos_creditos_clientes_id" FOREIGN KEY (credito_cliente_id) REFERENCES creditos_clientes(id) MATCH FULL;


--
-- TOC entry 2832 (class 2606 OID 25005)
-- Name: acertos_fichas_clientes FK_acertos_fichas_caixas_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes
    ADD CONSTRAINT "FK_acertos_fichas_caixas_id" FOREIGN KEY (caixa_id) REFERENCES caixas(id) MATCH FULL;


--
-- TOC entry 2833 (class 2606 OID 25010)
-- Name: acertos_fichas_clientes FK_acertos_fichas_clientes_clientes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes
    ADD CONSTRAINT "FK_acertos_fichas_clientes_clientes_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL;


--
-- TOC entry 2835 (class 2606 OID 25020)
-- Name: acertos_fichas_clientes_pagamentos FK_acertos_fichas_pagamentos_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes_pagamentos
    ADD CONSTRAINT "FK_acertos_fichas_pagamentos_id" FOREIGN KEY (acerto_ficha_id) REFERENCES acertos_fichas_clientes(id) MATCH FULL;


--
-- TOC entry 2824 (class 2606 OID 24965)
-- Name: clientes_contatos FK_clientes_contatos_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes_contatos
    ADD CONSTRAINT "FK_clientes_contatos_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2823 (class 2606 OID 24960)
-- Name: clientes_enderecos FK_clientes_enderecos_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY clientes_enderecos
    ADD CONSTRAINT "FK_clientes_enderecos_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2825 (class 2606 OID 24970)
-- Name: pets FK_clientes_pets_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pets
    ADD CONSTRAINT "FK_clientes_pets_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2837 (class 2606 OID 25030)
-- Name: creditos_clientes FK_creditos_clientes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY creditos_clientes
    ADD CONSTRAINT "FK_creditos_clientes_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL;


--
-- TOC entry 2826 (class 2606 OID 24975)
-- Name: pets FK_pets_racas_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pets
    ADD CONSTRAINT "FK_pets_racas_id" FOREIGN KEY (raca_id) REFERENCES racas(id) MATCH FULL;


--
-- TOC entry 2840 (class 2606 OID 25045)
-- Name: acertos_fichas_clientes_detalhes FK_produto_venda_detalhes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes_detalhes
    ADD CONSTRAINT "FK_produto_venda_detalhes_id" FOREIGN KEY (produto_venda_id) REFERENCES produtos_vendas(id) MATCH FULL;


--
-- TOC entry 2831 (class 2606 OID 25000)
-- Name: produtos_vendas FK_produtos_vendas_clientes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos_vendas
    ADD CONSTRAINT "FK_produtos_vendas_clientes_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL;


--
-- TOC entry 2836 (class 2606 OID 25025)
-- Name: produtos_vendas_pagamentos FK_produtos_vendas_pgtos_produtos_venda_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos_vendas_pagamentos
    ADD CONSTRAINT "FK_produtos_vendas_pgtos_produtos_venda_id" FOREIGN KEY (produto_venda_id) REFERENCES produtos_vendas(id) MATCH FULL;


--
-- TOC entry 2830 (class 2606 OID 24995)
-- Name: produtos_vendas FK_produtos_vendas_produtos_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtos_vendas
    ADD CONSTRAINT "FK_produtos_vendas_produtos_id" FOREIGN KEY (produto_id) REFERENCES produtos(codigo) MATCH FULL;


--
-- TOC entry 2839 (class 2606 OID 25040)
-- Name: acertos_fichas_clientes_detalhes FK_servico_diario_detalhes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY acertos_fichas_clientes_detalhes
    ADD CONSTRAINT "FK_servico_diario_detalhes_id" FOREIGN KEY (servico_diario_id) REFERENCES servicos_diarios(id) MATCH FULL;


--
-- TOC entry 2828 (class 2606 OID 24985)
-- Name: servicos_diarios FK_servicos_diarios_clientes_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY servicos_diarios
    ADD CONSTRAINT "FK_servicos_diarios_clientes_id" FOREIGN KEY (cliente_id) REFERENCES clientes(id) MATCH FULL;


--
-- TOC entry 2829 (class 2606 OID 24990)
-- Name: servicos_diarios FK_servicos_diarios_pets_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY servicos_diarios
    ADD CONSTRAINT "FK_servicos_diarios_pets_id" FOREIGN KEY (pet_id) REFERENCES pets(id) MATCH FULL;


--
-- TOC entry 2827 (class 2606 OID 24980)
-- Name: servicos_diarios FK_servicos_diarios_servicos_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY servicos_diarios
    ADD CONSTRAINT "FK_servicos_diarios_servicos_id" FOREIGN KEY (servico_id) REFERENCES servicos(id) MATCH FULL;


-- Completed on 2018-04-07 12:49:44

--
-- PostgreSQL database dump complete
--

