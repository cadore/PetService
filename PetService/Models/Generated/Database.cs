using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;
using PetService.Connection;

namespace PetService
{

	public partial class PetRepo : Database
	{
        public static IMapper DefaultIMapper { get; private set; }
        public static void LoadIMapper(IMapper _DefaultMapper)
        {
            DefaultIMapper = _DefaultMapper;
        }
        public PetRepo() : base(ConnectionUtil.ConnectionString, ConnectionUtil.InvariantName)
		{
			CommonConstruct();
		}

		public PetRepo(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			PetRepo GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static PetRepo GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new PetRepo();
        }

		[ThreadStatic] static PetRepo _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static PetRepo repo { get { return PetRepo.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
            public static String Concat(object s) { return String.Format("%{0}%", s); }

		}

	}
	



    

	[TableName("public.acertos_fichas_clientes_detalhes")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class acertos_fichas_clientes_detalhe : PetRepo.Record<acertos_fichas_clientes_detalhe>  
    {



		[Column] public long id { get; set; }





		[Column] public long acerto_ficha_cliente_id { get; set; }





		[Column] public long servico_diario_id { get; set; }





		[Column] public long produto_venda_id { get; set; }





		[Column] public string descricao_item { get; set; }





		[Column] public string und_medida_item { get; set; }





		[Column] public int qtd_item { get; set; }





		[Column] public decimal valor_unitario_item { get; set; }





		[Column] public decimal valor_total_item { get; set; }



	}

    

	[TableName("public.produtos_vendas")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class produtos_venda : PetRepo.Record<produtos_venda>  
    {



		[Column] public long id { get; set; }





		[Column] public long produto_id { get; set; }





		[Column] public long cliente_id { get; set; }





		[Column] public bool em_ficha { get; set; }





		[Column] public bool recebido { get; set; }





		[Column] public short quantidade { get; set; }





		[Column] public string descricao_produto { get; set; }





		[Column] public decimal valor_unitario { get; set; }





		[Column] public decimal valor_total { get; set; }





		[Column] public string und_medida_venda { get; set; }



	}

    

	[TableName("public.servicos_diarios")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class servicos_diario : PetRepo.Record<servicos_diario>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime data_realizado { get; set; }





		[Column] public int servico_id { get; set; }





        [Column]
        public string observacao_servico { get; set; }





		[Column] public long cliente_id { get; set; }





		[Column] public long pet_id { get; set; }





		[Column] public int quantidade { get; set; }





		[Column] public decimal valor_unitario { get; set; }





		[Column] public decimal valor_total { get; set; }





		[Column] public bool em_ficha { get; set; }





		[Column] public bool recebido { get; set; }

        [Column] public int turno_servico { get; set; }

        [Column] public int em_execucao { get; set; }

        public string descricao_servico { get; set; }



	}

    

	[TableName("public.acertos_fichas_clientes")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class acertos_fichas_cliente : PetRepo.Record<acertos_fichas_cliente>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime data_acerto { get; set; }





		[Column] public decimal valor_total { get; set; }





		[Column] public long? credito_cliente_id { get; set; }





		[Column] public decimal? valor_credito_cliente { get; set; }





		[Column] public long caixa_id { get; set; }





		[Column] public string categoria { get; set; }





		[Column] public long cliente_id { get; set; }



	}

    

	[TableName("public.creditos_clientes")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class creditos_cliente : PetRepo.Record<creditos_cliente>  
    {



		[Column] public int id { get; set; }





		[Column] public long cliente_id { get; set; }





		[Column] public decimal valor_credito { get; set; }





		[Column] public DateTime data_credito { get; set; }





		[Column] public bool utilizado { get; set; }





		[Column] public DateTime? data_utilizacao { get; set; }



	}

    

	[TableName("public.clientes")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class cliente : PetRepo.Record<cliente>  
    {



		[Column] public long id { get; set; }





		[Column] public string nome_completo { get; set; }





		[Column] public DateTime? data_nascimento { get; set; }





		[Column] public string cpf { get; set; }





		[Column] public string rg { get; set; }





		[Column] public string orgao_expedidor_rg { get; set; }





		[Column] public DateTime? data_emissao_rg { get; set; }





		[Column] public string email { get; set; }





		[Column] public bool pre_cadastro { get; set; }



	}

    

	[TableName("public.produtos_vendas_pagamentos")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class produtos_vendas_pagamento : PetRepo.Record<produtos_vendas_pagamento>  
    {



		[Column] public long id { get; set; }





		[Column] public long produto_venda_id { get; set; }





		[Column] public string tipo_recebimento { get; set; }





		[Column] public decimal valor_recebimento { get; set; }





		[Column] public string autorizacao_cartao { get; set; }





		[Column] public string numero_cheque { get; set; }





		[Column] public string bandeira_cartao { get; set; }



	}

    

	[TableName("public.acertos_fichas_clientes_pagamentos")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class acertos_fichas_clientes_pagamento : PetRepo.Record<acertos_fichas_clientes_pagamento>  
    {



		[Column] public long id { get; set; }





		[Column] public long acerto_ficha_id { get; set; }





		[Column] public string tipo_recebimento { get; set; }





		[Column] public decimal valor_recebimento { get; set; }





		[Column] public string autorizacao_cartao { get; set; }





		[Column] public string numero_cheque { get; set; }





		[Column] public string bandeira_cartao { get; set; }



	}

    

	[TableName("public.caixas")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class caixa : PetRepo.Record<caixa>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime data_abertura { get; set; }





		[Column] public decimal valor_abertura { get; set; }





		[Column] public decimal? valor_fechamento_total { get; set; }





		[Column] public decimal? valor_fecha_dinheiro { get; set; }





		[Column] public decimal? valor_fecha_cheque { get; set; }





		[Column] public decimal? valor_fecha_debito { get; set; }





		[Column] public decimal? valor_fecha_credito { get; set; }



	}

    

	[TableName("public.produtos")]



	[PrimaryKey("codigo")]




	[ExplicitColumns]

    public partial class produto : PetRepo.Record<produto>  
    {



		[Column] public long codigo { get; set; }





		[Column] public string descricao { get; set; }





		[Column] public string codigobarra { get; set; }





		[Column] public string codigofabrica { get; set; }





		[Column] public string embalagem { get; set; }





		[Column] public decimal qtdembalagem { get; set; }





		[Column] public decimal custonota { get; set; }





		[Column] public decimal custofrete { get; set; }





		[Column] public decimal custofinal { get; set; }





		[Column] public decimal? precoultimavenda { get; set; }





		[Column] public decimal precominimo { get; set; }





		[Column] public decimal precoavista { get; set; }





		[Column] public decimal precoparcelado { get; set; }



	}

    

	[TableName("public.pets")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class pet : PetRepo.Record<pet>  
    {



		[Column] public long id { get; set; }





		[Column] public long cliente_id { get; set; }





		[Column] public string nome_pet { get; set; }





		[Column] public DateTime? data_nascimento { get; set; }





		[Column] public bool tem_pacote { get; set; }





		[Column] public decimal? valor_pacote { get; set; }





		[Column] public bool? com_tosa_higienica { get; set; }





		[Column] public int especie { get; set; }





		[Column] public int raca_id { get; set; }





		[Column] public int? dia_pacote { get; set; }





		[Column] public bool? transporte { get; set; }





		[Column] public int turno_servico { get; set; }





		[Column] public bool pre_cadastro { get; set; }





		[Column] public int porte { get; set; }



	}

    

	[TableName("public.servicos")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class servico : PetRepo.Record<servico>  
    {



		[Column] public int id { get; set; }





		[Column] public string descricao_servico { get; set; }





		[Column] public decimal valor_servico { get; set; }





		[Column] public bool habilitado { get; set; }



	}

    

	[TableName("public.racas")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class raca : PetRepo.Record<raca>  
    {



		[Column] public int id { get; set; }





		[Column] public string raca_descricao { get; set; }





		[Column] public int tipo_raca { get; set; }

        public string tipo_raca_desc { get; set; }




	}

    

	[TableName("public.clientes_contatos")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class clientes_contato : PetRepo.Record<clientes_contato>  
    {



		[Column] public long id { get; set; }





		[Column] public long cliente_id { get; set; }





		[Column] public string telefone { get; set; }





		[Column] public string fala_com { get; set; }
        [Column] public bool principal { get; set; }



	}

    

	[TableName("public.clientes_enderecos")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class clientes_endereco : PetRepo.Record<clientes_endereco>  
    {



		[Column] public long id { get; set; }





		[Column] public long cliente_id { get; set; }





		[Column] public string endereco { get; set; }





		[Column] public string endereco_numero { get; set; }





		[Column] public long bairro { get; set; }





		[Column] public string complemento { get; set; }
        [Column] public string cidade { get; set; }
        [Column] public string estado { get; set; }
        [Column] public bool principal { get; set; }

        public string bairro_descricao { get; set; }



	}
    
    [TableName("public.bairros")]
    [PrimaryKey("id")]
    [ExplicitColumns]

    public partial class bairro : PetRepo.Record<bairro>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public string nome { get; set; }
        [Column]
        public decimal taxa_entrega { get; set; }

    }

    public partial class ServicosDiariosModal
    {
        public string turno_servico { get; set; }
        public bool em_execucao { get; set; }
        public string cliente { get; set; }
        public long cliente_id { get; set; }
        public string pet { get; set; }
        public long pet_id { get; set; }
        public string porte { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public bool taxi_dog { get; set; }

    }
}
