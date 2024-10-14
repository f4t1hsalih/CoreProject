using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    internal class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDal _portfolioManager;

        public PortfolioManager(IPortfolioDal portfolioManager)
        {
            _portfolioManager = portfolioManager;
        }

        public void TAdd(Portfolio entity)
        {
            _portfolioManager.Add(entity);
        }

        public void TDelete(Portfolio entity)
        {
            _portfolioManager.Delete(entity);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioManager.GetById(id);
        }

        public List<Portfolio> TGetListAll()
        {
            return _portfolioManager.GetListAll();
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioManager.Update(entity);
        }
    }
}
