//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       VSDT_BusinessGen.cst
//-- Date Generated: Wednesday, April , 2011
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entity;
namespace SystemManageService
{
    public partial class SYS_PopulationService 
    {
        private SYS_PopulationDataAccess _sys_populationDataAccess = new SYS_PopulationDataAccess();

        public int InsertSYS_Population(SYS_Population sys_population)
        {
            return _sys_populationDataAccess.InsertSYS_Population(sys_population);
        }

        public int UpdateSYS_Population(List<SYS_Population> sys_populations)
        {
            return _sys_populationDataAccess.UpdateSYS_Population(sys_populations);
        }

        public void UpdateSYS_Population(SYS_Population sys_population)
        {
            _sys_populationDataAccess.UpdateSYS_Population(sys_population);
        }

        public void DeleteSYS_Population(List<SYS_Population> sys_populations)
        {
            _sys_populationDataAccess.DeleteSYS_Population(sys_populations);
        }

        public void DeleteSYS_Population(SYS_Population sys_populations)
        {
            _sys_populationDataAccess.DeleteSYS_Population(sys_populations);
        }

        public SYS_Population SelectSYS_Population(int sys_populationId)
        {
            return _sys_populationDataAccess.SelectSYS_Population(sys_populationId);
        }

        public List<SYS_Population> SelectAllSYS_Population()
        {
            return _sys_populationDataAccess.SelectAllSYS_Population();
        }

    }

}


