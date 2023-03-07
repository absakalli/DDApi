using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PageController : ControllerBase
    {
        private readonly PageContext _pageContext;

        public PageController(PageContext pageContext)
        {
            _pageContext = pageContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Page>>> GetPages()
        {
            if (_pageContext.Pages == null)
            {
                return NotFound();
            }

            return await _pageContext.Pages.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Page>> PostPage(Page page)
        {
            page.id = Guid.NewGuid();
            _pageContext.Pages.Add(page);
            await _pageContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPages), new { id = page.id }, page);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(string id)
        {
            if (_pageContext.Pages == null)
            {
                return NotFound();
            }

            var page = await _pageContext.Pages.FindAsync(id);

            if (page == null)
            {
                return NotFound();
            }

            _pageContext.Pages.Remove(page);
            await _pageContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
