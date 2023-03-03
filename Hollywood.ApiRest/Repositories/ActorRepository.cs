using Hollywood.RestApi.Data;
using Hollywood.RestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hollywood.ApiRest.Repositories
{
  public class ActorRepository : IActorRepository
  {
    public SakilaContext _context { get; set; }

    public ActorRepository(SakilaContext context)
    {
      _context = context;
    }

    public Task<ActionResult<Actor>> Create(Actor actor)
    {
      throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<Actor>> Get()
    {
      return await _context.Actors.ToListAsync();
    }

    public async Task<ActionResult<Actor>> Get(ushort? id)
    {
      return await _context.Actors.FindAsync(id.Value);
    }

    public async Task Update(Actor actor)
    {
      _context.Update(actor);
      await _context.SaveChangesAsync();
    }
  }
}
