using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace IntelligentFormsAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly CosmosClient _cosmosClient;
        private readonly string _databaseId = "Users";
        private readonly string _containerId = "Items";

        public UserController(CosmosClient cosmosClient)
        {
            _cosmosClient = cosmosClient;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocument(string id)
        {
            try
            {
                Microsoft.Azure.Cosmos.Container container = _cosmosClient.GetContainer(_databaseId, _containerId);
                var itemResponse = await container.ReadItemAsync<dynamic>(id, new PartitionKey(id));

                return Ok(itemResponse.Resource.ToString());
            }
            catch (CosmosException ex)
            {
                return StatusCode((int)ex.StatusCode, ex.Message);
            }
        }
    }
}
