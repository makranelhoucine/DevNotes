using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
            
        }

        //  GET all
        [HttpGet]
        public ActionResult<List<Pizza>> Pizze()
        {
            return PizzaService.GetAll();
        }

        //  GET by Id
        [HttpGet("{id}")]
        public ActionResult<Pizza> Pizza(int id)
        {
            var pizza = PizzaService.Get(id);

            return pizza == null ? NotFound() : pizza;
        }

        //  POST
        [HttpPost]
        public IActionResult Crea(Pizza pizza)
        {
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Crea), new { id = pizza.Id }, pizza);
        }

        //  PUT
        [HttpPut]
        public IActionResult Modifica(int id, Pizza pizza)
        {
            if(id != pizza.Id)
            {
                return BadRequest();
            }

            var pizzaEsistente = PizzaService.Get(id);
            if(pizzaEsistente == null)
            {
                return NotFound();
            }
            
            PizzaService.Update(pizza);

            return NoContent();
        }

        //  DELETE
        [HttpDelete]
        public IActionResult Elimina(int id)
        {
            var pizza = PizzaService.Get(id);
            if(pizza == null)
            {
                return NotFound();
            }
            
            PizzaService.Delete(id);

            return NoContent();
        }
    }
}