using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsuranceWebApi.Models;

namespace InsuranceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        private readonly InsuranceContext _context;

        public AgentsController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: api/Agents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agents>>> GetAgents()
        {
            return await _context.Agents.ToListAsync();
        }

        // GET: api/Agents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agents>> GetAgents(int id)
        {
            var agents = await _context.Agents.FindAsync(id);

            if (agents == null)
            {
                return NotFound();
            }

            return agents;
        }

        // PUT: api/Agents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgents(int id, Agents agents)
        {
            if (id != agents.AgentId)
            {
                return BadRequest();
            }

            _context.Entry(agents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Agents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Agents>> PostAgents(Agents agents)
        {
            _context.Agents.Add(agents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgents", new { id = agents.AgentId }, agents);
        }

        // DELETE: api/Agents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgents(int id)
        {
            var agents = await _context.Agents.FindAsync(id);
            if (agents == null)
            {
                return NotFound();
            }

            _context.Agents.Remove(agents);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgentsExists(int id)
        {
            return _context.Agents.Any(e => e.AgentId == id);
        }
    }
}
