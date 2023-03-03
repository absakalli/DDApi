using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElementController : ControllerBase
    {
        private readonly ElementContext _context;

        public ElementController(ElementContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Element>>> GetElements()
        {
            if (_context.Elements == null)
            {
                return NotFound();
            }

            return await _context.Elements.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Element>> PostElement(Element element)
        {
            element.id = Guid.NewGuid();
            _context.Elements.Add(element);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetElements), new { id = element.id }, element);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(string id)
        {
            if (_context.Elements == null)
            {
                return NotFound();
            }

            var element = await _context.Elements.FindAsync(id);

            if (element == null)
            {
                return NotFound();
            }

            _context.Elements.Remove(element);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
