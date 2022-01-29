using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _prodcutDal;

        public ProductManager(IProductDal prodcutDal)
        {
            _prodcutDal = prodcutDal;
        }

        public IResult Add(Product product)
        {
            _prodcutDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _prodcutDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int product)
        {
            return new SuccessDataResult<Product>(_prodcutDal.Get(p => p.ProductId == product));
        }

        public IDataResult<List<Product>> GetList()
        {
            
            return new SuccessDataResult<List<Product>>(_prodcutDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_prodcutDal.GetList(p => p.CategoryId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _prodcutDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
