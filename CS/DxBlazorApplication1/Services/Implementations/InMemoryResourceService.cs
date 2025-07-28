using DxBlazorApplication1.Models;
using DxBlazorApplication1.Services.DataHelpers;
using DxBlazorApplication1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Implementations.InMemory
{
    public class InMemoryResourceService : IResourceService<Lecturer>
    {
        private readonly IList<Lecturer> resources;

        public InMemoryResourceService()
        {
            resources = ResourceDataHelper.GetResources();
        }

        public Task<IList<Lecturer>> GetResourcesAsync()
        {
            return Task.FromResult(resources);
        }
    }
}
