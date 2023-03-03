using Hollywood.ApiRest.Repositories;
using Hollywood.RestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hollywood.ApiRest.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActorsController : ControllerBase
  {
    private readonly IActorRepository _actorRepository;

    public ActorsController(IActorRepository actorRepository)
    {
      _actorRepository = actorRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Actor>> GetActor()
    {
      return await _actorRepository.Get();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Actor>> GetActor(ushort id)
    {
      return await _actorRepository.Get(id);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Actor>> UpdateActor(int? id, Actor actor)
    {
      if (id.Value != actor.ActorId)
      {
        return BadRequest("actorId must be equals.");
      }

      await _actorRepository.Update(actor);
      return NoContent();

    }
  }
}