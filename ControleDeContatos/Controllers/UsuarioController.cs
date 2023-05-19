using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControleDeContatos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            var usuarios = _usuarioRepositorio.BuscarTodos(); // OU List<UsuarioModel> contatos = _contatoRepositorio.BuscarTodos();

            return View(usuarios);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Registro cadastrado com sucesso.";

                    return RedirectToAction(nameof(Index));
                }

                return View(usuario);
            }
            catch (System.Exception e)
            {
                TempData["MensagemErro"] = $"Falha ao cadastrar o registro: {e.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
