using Hollywood.RestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hollywood.ApiRest.Repositories
{
  public interface IActorRepository
  {
    Task<IEnumerable<Actor>> Get();

    Task<ActionResult<Actor>> Get(ushort? id);

    Task<ActionResult<Actor>> Create(Actor actor);

    Task Update(Actor actor);
    Task Delete(int id);
  }
}
