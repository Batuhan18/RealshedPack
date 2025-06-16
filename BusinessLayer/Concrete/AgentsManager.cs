using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AgentsManager : IAgentsService
    {
        private readonly IAgentsDal _agentsDal;

        public AgentsManager(IAgentsDal agentsDal)
        {
            _agentsDal = agentsDal;
        }

        public void TAdd(Agents entity)
        {
            _agentsDal.Add(entity);
        }

        public void TDelete(Agents entity)
        {
            _agentsDal.Delete(entity);
        }

        public Agents TGetById(int id)
        {
            return _agentsDal.GetById(id);
        }

        public List<Agents> TGetListAll()
        {
            return _agentsDal.GetAllList();
        }

        public void TUpdate(Agents entity)
        {
            _agentsDal.Update(entity);
        }
    }
}
