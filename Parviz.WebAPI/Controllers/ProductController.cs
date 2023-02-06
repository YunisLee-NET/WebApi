using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parviz.WebAPI.Data;
using Parviz.WebAPI.Repositories;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Parviz.WebAPI.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllAsync()
        //{
        //    var result = await _productRepository.GetAllAsync();
        //    return Ok(result);
        //}


        [HttpGet]
        public async Task<IActionResult> GetAll2Async([FromServices]IProductRepository productRepository)
        {
            var result = await _productRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound($"{id} nomreli element tapilmadi");
            }
        }

        [HttpGet("getid/{id}")]
        public async Task<IActionResult> GetById2Async(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound($"{id} nomreli element tapilmadi");
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(Product product)
        //{
        //    var createData = await _productRepository.CreateAsync(product);
        //    return Created(string.Empty, createData);
        //}

        //Default hali FromBody-dir.
        [HttpPost]
        public async Task<IActionResult> Create2([FromQuery]Product product)
        {
            var createData = await _productRepository.CreateAsync(product);
            return Created(string.Empty, createData);
        }


        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            await _productRepository.UpdateAsync(product);
            return Ok($"{product.Id} nomreli mehsul yenilendi");

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _productRepository.RemoveAsync(id);
            return Ok($"{id} nomreli data ugurla silindi");
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile formFile)
        {
            var newName = Guid.NewGuid() + "." + Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", newName);
            var stream = new FileStream(path, FileMode.Create); await formFile.CopyToAsync(stream);
            return Created(string.Empty, formFile);
        }


    }
}
