// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using API.Dtos;
// using AutoMapper;
// using Core.Interfaces;
// using Core.Models;
// using Infrastructure.UnitOfWork;
// using Microsoft.AspNetCore.Mvc;

// namespace API.Controllers
// {
//     public class InsumoProveedorController : BaseController
//     {
//         private readonly IUnitOfWork _unitOfWork;
//         private readonly IMapper _mapper;

//         public InsumoProveedorController (IUnitOfWork unitOfWork, IMapper mapper)
//         {
//             _unitOfWork = unitOfWork;
//             _mapper = mapper;
//         }

//         [HttpGet]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         public async Task<ActionResult<IEnumerable<InsumoProveedorDto>>> Get()
//         {
//             var results = await _unitOfWork.InsumoProveedores.GetAllAsync();
//             return _mapper.Map<List<InsumoProveedorDto>>(results);
//         }
//         [HttpGet("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]
//         public async Task<ActionResult<InsumoProveedorDto>> Get(int id)
//         {
//             var result = await _unitOfWork.InsumoProveedores.GetByIdAsync(id);
//             if (result == null)
//             {
//                 return NotFound();
//             }
//             return _mapper.Map<InsumoProveedorDto>(result);
//         }
//         [HttpPut("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]
//         public async Task<ActionResult<InsumoProveedorDto>> Put(int id, [FromBody] InsumoProveedorDto resultDto)
//         {
//             var exists = await _unitOfWork.InsumoProveedores.GetByIdAsync(id);
//             if (exists == null)
//             {
//                 return NotFound();
//             }
//             if (resultDto.Id == 0)
//             {
//                 resultDto.Id = id;
//             }
//             if (resultDto.Id != id)
//             {
//                 return BadRequest();
//             }
//             // Update the properties of the existing entity with values from resultDto
//             _mapper.Map(resultDto, exists);
//             // The context is already tracking result, so no need to attach it
//             await _unitOfWork.SaveAsync();
//             // Return the updated entity
//             return _mapper.Map<InsumoProveedorDto>(exists);
//         }
//         [HttpPost]
//         [ProducesResponseType(StatusCodes.Status201Created)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         public async Task<ActionResult<InsumoProveedorDto>> Post(InsumoProveedorDto resultDto)
//         {
//             var result = _mapper.Map<InsumoProveedor>(resultDto);
//             _unitOfWork.InsumoProveedores.Add(result);
//             await _unitOfWork.SaveAsync();
//             if (result == null)
//             {
//                 return BadRequest();
//             }
//             resultDto.Id = result.Id;
//             return CreatedAtAction(nameof(Post), new { id = resultDto.Id }, resultDto);
//         }
//         [HttpDelete("{id}")]
//         [ProducesResponseType(StatusCodes.Status204NoContent)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]
//         public async Task<IActionResult> Delete(int id)
//         {
//             var result = await _unitOfWork.InsumoProveedores.GetByIdAsync(id);
//             if (result == null)
//             {
//                 return NotFound();
//             }
//             _unitOfWork.InsumoProveedores.Remove(result);
//             await _unitOfWork.SaveAsync();
//             return NoContent();
//         }
//     }
// }