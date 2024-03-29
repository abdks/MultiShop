using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrdouctImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public PrdouctImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public async Task<IActionResult> productImageList()
        {
            var values = await _productImageService.GetAllProductImageAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetproductImageById(string id)
        {
            var values = _productImageService.GetByIdProductImageAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateproductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("Ürün Görselleri eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteproductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Ürün Görselleri silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateproductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Ürün Görselleri Güncellendi");
        }
    }
}
