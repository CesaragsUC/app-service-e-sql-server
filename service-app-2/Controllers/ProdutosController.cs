using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using service_app_2.Context;
using service_app_2.Dtos;
using service_app_2.Entities;

namespace service_app_2.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILogger<ProdutosController> _logger;

        private readonly MeuDbContext _context;

        public ProdutosController(IMapper mapper, ILogger<ProdutosController> logger, MeuDbContext context)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        // GET: ProdutosController
        public ActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            var produtosDto = _mapper.Map<List<ProdutoDto>>(produtos);

            return View(produtosDto);
        }

        // GET: ProdutosController/Details/5
        public ActionResult Details(Guid id)
        {
            var produtos = _context.Produtos.FirstOrDefault(x=> x.Id == id);
            var produtosDto = _mapper.Map<ProdutoDto>(produtos);
            
            return View(produtosDto);
        }

        // GET: ProdutosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutosController/Create
        [HttpPost]
        public ActionResult Create(ProdutoDto model)
        {
            try
            {
                var produto = _mapper.Map<Produto>(model);
                _context.Produtos.Add(produto);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var produtos = _context.Produtos.FirstOrDefault(x => x.Id == id);
            var produtosDto = _mapper.Map<ProdutoDto>(produtos);

            return View(produtosDto);
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoDto model)
        {
            try
            {
                var produto = _mapper.Map<Produto>(model);
                _context.Produtos.Update(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var produtos = _context.Produtos.FirstOrDefault(x => x.Id == id);
            var produtosDto = _mapper.Map<ProdutoDto>(produtos);
            return View(produtosDto);
        }

        // POST: ProdutosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProdutoDto model)
        {
            try
            {
                var produto = _mapper.Map<Produto>(model);
                _context.Produtos.Remove(produto);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
