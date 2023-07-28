using Microsoft.AspNetCore.Mvc;

using CRUDCORE.Datos;
using CRUDCORE.Models;

namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactosDatos = new ContactoDatos();


        public IActionResult Listar()
        {
            var oLista = _ContactosDatos.Listar();

            return View(oLista);
        }
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult Guardar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();


            var respuesta = _ContactosDatos.Guardar(oContacto);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else {
                return View();
            }
                
        }
        public IActionResult Editar(int IdContacto)
        {
            var ocontacto = _ContactosDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {

           if (!ModelState.IsValid)
                return View();


            var respuesta = _ContactosDatos.Editar(oContacto);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else {
                return View();
            }
        }

        public IActionResult Eliminar(int IdContacto)
        {
            var ocontacto = _ContactosDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {

            var respuesta = _ContactosDatos.Eliminar(oContacto.IdContacto);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }
    }
}
