using Microsoft.AspNetCore.Mvc;

namespace minimalapi.Entities;

public class SignatureController : ControllerBase
{
    private readonly ILogger<SignatureController> _logger;
    private readonly List<Signature> _signatures;

    public SignatureController(ILogger<SignatureController> logger)
    {
        _logger = logger;
        _signatures = new List<Signature>();
    }

    [HttpGet("api/signatures")]
    public ActionResult<IEnumerable<Signature>> GetSignatures()
    {
        return Ok(_signatures);
    }

    [HttpGet("api/signatures/{id}")]
    public ActionResult<Signature> GetSignature(int id)
    {
        var signature = _signatures.FirstOrDefault(s => s.Id == id);
        if (signature == null)
            return NotFound();

        return Ok(signature);
    }

    [HttpPost("api/signatures")]
    public ActionResult<Signature> CreateSignature(Signature signature)
    {
        signature.Id = _signatures.Count > 0 ? _signatures.Max(s => s.Id) + 1 : 1;
        _signatures.Add(signature);
        return CreatedAtAction(nameof(GetSignature), new { id = signature.Id }, signature);
    }
}