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
//     public class InventarioTallaController : BaseController
//     {
//         private readonly IUnitOfWork _unitOfWork;
//         private readonly IMapper _mapper;

//         public InventarioTallaController (IUnitOfWork unitOfWork, IMapper mapper)
//         {
//             _unitOfWork = unitOfWork;
//             _mapper = mapper;
//         }

//         [HttpGet]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         public async Task<ActionResult<IEnumerable<InventarioTallaDto>>> Get()
//         {
//             var results = await _unitOfWork.InventarioTallas.GetAllAsync();
//             return _mapper.Map<List<InventarioTallaDto>>(results);
//         }
//         [HttpGet("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]
//         public async Task<ActionResult<InventarioTallaDto>> Get(int id)
//         {
//             var result = await _unitOfWork.InventarioTallas.GetByIdAsync(id);
//             if (result == null)
//             {
//                 return NotFound();
//             }
//             return _mapper.Map<InventarioTallaDto>(result);
//         }
//         [HttpPut("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]
//         public async Task<ActionResult<InventarioTallaDto>> Put(int id, [FromBody] InventarioTallaDto resultDto)
//         {
//             var exists = await _unitOfWork.InventarioTallas.GetByIdAsync(id);
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
//             return _mapper.Map<InventarioTallaDto>(exists);
//         }
//         [HttpPost]
//         [ProducesResponseType(StatusCodes.Status201Created)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         public async Task<ActionResult<InventarioTallaDto>> Post(InventarioTallaDto resultDto)
//         {
//             var result = _mapper.Map<InventarioTalla>(resultDto);
//             _unitOfWork.InventarioTallas.Add(result);
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
//             var result = await _unitOfWork.InventarioTallas.GetByIdAsync(id);
//             if (result == null)
//             {
//                 return NotFound();
//             }
//             _unitOfWork.InventarioTallas.Remove(result);
//             await _unitOfWork.SaveAsync();
//             return NoContent();
//         }
//     }
// }