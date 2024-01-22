using BarberAPI.Context;
using BarberAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace BarberAPI.Repository
{
    public class ClientRepository: ControllerBase,IRepository<Client>
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> Get()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<ActionResult<Client>> Get(int id)
        {
            var clientId= await _context.Clients.FindAsync(id);
            if (clientId is null) return NotFound();
            return Ok(clientId);
        }

        public async Task<ActionResult<Client>> Post(Client client)
        {
            if (client is null) return BadRequest();
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
            return Ok(client);
        }

        public async Task<ActionResult<Client>> Put(Client client, int id)
        {
            if(client.Id!=id) return BadRequest();
            var clientId = await _context.Clients.FindAsync(id);
            clientId.Name = client.Name;
            clientId.Gender = client.Gender;
            await _context.SaveChangesAsync();
            return Ok(clientId);
        }
        public async Task<ActionResult<Client>> Delete(int id)
        {
            var clientId = await _context.Clients.FindAsync(id);
            if (clientId is null) return BadRequest();
            _context.Clients.Remove(clientId);
            await _context.SaveChangesAsync();
            return NotFound();
        }
    }
}
