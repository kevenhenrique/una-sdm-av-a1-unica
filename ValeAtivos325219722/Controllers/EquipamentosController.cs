using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos325219722.Data;
using ValeAtivos325219722.Models;

namespace ValeAtivos325219722.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EquipamentosController : ControllerBase
{
    private readonly AppDbContext _context;

    public EquipamentosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Equipamento>> CadastrarEquipamento(Equipamento equipamento)
    {
        _context.Equipamentos.Add(equipamento);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(BuscarEquipamentoPorId),
            new { id = equipamento.Id },
            equipamento
        );
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Equipamento>>> ListarEquipamentos()
    {
        var equipamentos = await _context.Equipamentos
            .AsNoTracking()
            .ToListAsync();

        return Ok(equipamentos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Equipamento>> BuscarEquipamentoPorId(int id)
    {
        var equipamento = await _context.Equipamentos
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id == id);

        if (equipamento is null)
        {
            return NotFound(new { mensagem = "Equipamento não encontrado." });
        }

        return Ok(equipamento);
    }
}
