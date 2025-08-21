using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Services.Interfaces {
    public interface ILabelService<TLabel> {
        public Task<IList<TLabel>> GetLabelsAsync();
    }
}
