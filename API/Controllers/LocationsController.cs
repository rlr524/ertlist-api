using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class LocationsController : BaseApiController
{
    private readonly DataContext _context;

    public LocationsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet] // /api/locations
    public async Task<ActionResult<List<Location>>> GetLocations()
    {
        return await _context.Locations.ToListAsync();
    }

    [HttpGet("{id}")] // /api/locations/[id]
    public async Task<ActionResult<Location>> GetLocation(Guid id)
    {
        return await _context.Locations.FindAsync(id);
    }
}