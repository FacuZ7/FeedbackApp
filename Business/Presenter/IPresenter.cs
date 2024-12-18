using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Presenter
{
    public interface IPresenter<TEntity,TOutput>
    {
        public IEnumerable<TOutput> Present(IEnumerable<TEntity> data);
        public TOutput Present(TEntity data);
    }
}
