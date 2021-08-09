using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Files;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.FileEntries.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/file")]
    [ApiController]
    [Produces("application/json")]
    public class FileController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IFileEntryRepository _fileEntryRepository;
        public FileController(IMapper mapper,
            IFileEntryRepository fileEntryRepository)
        {
            _mapper = mapper;
            _fileEntryRepository = fileEntryRepository;
        }

        [HttpPost]
        public async Task<ActionResult<FileEntryDto>> Upload(
            [FromForm(Name = "file")] IFormFile formFile,
            [FromServices] IFilesystem filesystem)
        {
            try
            {

                var target = $"{formFile.FileName}";

                await filesystem.Move(formFile, target);

                var fileEntry = new FileEntry();
                fileEntry.Filename = formFile.FileName;
                fileEntry.MediaType = formFile.ContentType;
                fileEntry.Length = formFile.Length;
                fileEntry.Path = target;

                await _fileEntryRepository.Create(fileEntry);

                var dto = _mapper.Map<FileEntryDto>(fileEntry);

                return dto;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
