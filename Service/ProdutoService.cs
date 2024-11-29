using IfoodSocial.Data;
using IfoodSocial.Model;
using Microsoft.EntityFrameworkCore;

namespace IfoodSocial.Service
{
    public class ProdutoService
    {
        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProdutoDTO>> ConsultarProdutos(string?nome = null, string?categoria = null, string? empreendimento = null  )
        {
            var query = _context.Set<Produto>()
                .Include(p => p.Categoria)
                .Include(p => p.Empreedimento)
                .AsQueryable();
            
            if(!string.IsNullOrEmpty(nome))
            {
                query = query.Where(p => EF.Functions.Like(p.Dcr_Produto, $"%{nome}%"));
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                query = query.Where(p => EF.Functions.Like(p.Categoria.Dcr_Categoria, $"%{categoria}%"));
            }

            if (!string.IsNullOrEmpty(empreendimento))
            {
                query = query.Where(p => EF.Functions.Like(p.Empreedimento.Dcr_Empreendimento, $"%{empreendimento}%"));
            }

            var produtos = await query
                .OrderByDescending(p => p.Flag_Disponivel == 'T')
                .ThenBy(p=> p.Dcr_Produto)
                .Select(p=>new ProdutoDTO
                {
                    Cod_Produto = p.Cod_Produto,
                    Dcr_Produto = p.Dcr_Produto ?? string.Empty,
                    Vlr_Produto = p.Vlr_Produto,
                    Cod_Categoria = p.Categoria.Cod_Categoria,
                    Cod_Empreedimento = p.Empreedimento.Cod_Empreedimento

                })
                .ToListAsync();

            return produtos;
        }
    }
}
