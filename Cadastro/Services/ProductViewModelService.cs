using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Services
{
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _producRepository;
        private readonly IMapper _mapper;

        public ProductViewModelService(IProductRepository producRepository, IMapper mapper)
        {
            _producRepository = producRepository;
            _mapper = mapper;
        }

        public ProductViewModel Get(int id)
        {
            var entity = _producRepository.Get(id);
            if (entity == null)
                return null;
            return _mapper.Map<ProductViewModel>(entity);
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var list = _producRepository.GetAll();
            if (list == null)
                return new ProductViewModel[] { };

            return _mapper.Map<IEnumerable<ProductViewModel>>(list);
        }

        public void Insert(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _producRepository.Insert(entity);
        }

        public void Update(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _producRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _producRepository.Delete(id);
        }
    }
}
