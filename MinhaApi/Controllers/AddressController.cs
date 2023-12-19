using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinhaApi.Contracts.Repository;
using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("address")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _addressRepository.Get());
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _addressRepository.GetById(id));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(AddressDTO address)
        {
            await _addressRepository.Add(address);
            return Ok();
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update(AddressEntity address)
        {
            await _addressRepository.Update(address);
            return Ok();
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _addressRepository.Delete(id);
            return Ok();
        }
    }
}
