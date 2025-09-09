using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ta23ALõppTöö.Models;
using Ta23ALõppTöö.DTOs;
using CinemaBackend.Data;
using Ta23ALõppTöö.DTOs;
using Ta23ALõppTöö.Models;

namespace T240P01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly CinemaDbContext _context;

        public CinemaController(CinemaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CinemaDto>>> GetCinemas()
        {
            var list = await _context.Cinemas
                .Select(c => new CinemaDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Address = c.Address,
                    City = c.City,
                    Phone = c.Phone,
                    Email = c.Email,
                    Website = c.Website,
                    Timezone = c.Timezone,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt
                })
                .ToListAsync();

            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CinemaDto>> GetCinema(long id)
        {
            var c = await _context.Cinemas.FindAsync(id);
            if (c == null)
                return NotFound();

            var dto = new CinemaDto
            {
                Id = c.Id,
                Name = c.Name,
                Address = c.Address,
                City = c.City,
                Phone = c.Phone,
                Email = c.Email,
                Website = c.Website,
                Timezone = c.Timezone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            };

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<CinemaDto>> CreateCinema(CinemaDto dto)
        {
            var entity = new Cinema
            {
                Name = dto.Name,
                Address = dto.Address,
                City = dto.City,
                Phone = dto.Phone,
                Email = dto.Email,
                Website = dto.Website,
                Timezone = dto.Timezone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Cinemas.Add(entity);
            await _context.SaveChangesAsync();

            dto.Id = entity.Id;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;

            return CreatedAtAction(nameof(GetCinema), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCinema(long id, CinemaDto dto)
        {
            if (id != dto.Id)
                return BadRequest();

            var entity = await _context.Cinemas.FindAsync(id);
            if (entity == null)
                return NotFound();

            entity.Name = dto.Name;
            entity.Address = dto.Address;
            entity.City = dto.City;
            entity.Phone = dto.Phone;
            entity.Email = dto.Email;
            entity.Website = dto.Website;
            entity.Timezone = dto.Timezone;
            entity.UpdatedAt = DateTime.UtcNow;

            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCinema(long id)
        {
            var entity = await _context.Cinemas.FindAsync(id);
            if (entity == null)
                return NotFound();

            _context.Cinemas.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
