using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.IO;
using System.Threading.Tasks;
using TesteCapgeminiWebApi.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using TesteCapgeminiWebApi.Data;

namespace TesteCapgeminiWebApi.Controllers
{
    [ApiController]
    [Route("api/importacoes")]
    public class ExcelController : ControllerBase
    {
        Excel excel = new Excel();

        private readonly IRepository _repo;

        public ExcelController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllExcelAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var result = await _repo.GetExcelAsyncById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return RedirectToAction("");
            }
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream).ConfigureAwait(false);
                using (var package = new ExcelPackage(memoryStream))
                {
                    for (int i = 1; i <= package.Workbook.Worksheets.Count; i++)
                    {
                        var totalRows = package.Workbook.Worksheets[i].Dimension?.Rows;
                        var totalCollumns = package.Workbook.Worksheets[i].Dimension?.Columns;
                        for (int j = 1; j <= totalRows.Value; j++)
                        {
                            for (int k = 1; k <= totalCollumns.Value; k++)
                            {
                                excel.DtEntrega = Convert.ToDateTime(package.Workbook.Worksheets[i].Cells[j, k].Value);
                                excel.NomeProduto = package.Workbook.Worksheets[i].Cells[j, k].Value.ToString();
                                excel.Quantidade = Convert.ToInt32(package.Workbook.Worksheets[i].Cells[j, k].Value.ToString());
                                excel.ValorUnitario = Convert.ToDecimal(package.Workbook.Worksheets[i].Cells[j, k].Value.ToString());
                            }
                        }
                    }
                    return Content(excel.NomeProduto);
                }
            }
        }
    }
}