using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MTS.BLL.DTO.SelectedDTO;
using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.Interfaces;
using MTS.DAL.Entities.Models;
using MTS.DAL.Entities.QueryModels;
using MTS.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MTS.BLL.Services
{
    public class MtsNomenclaturesService : IMtsNomenclaturesService
    {
        private IUnitOfWork Database { get; set; }
 
        private IRepository<MTS_ADDIT_CALCULATION> mtsAdditCalculations;
        private IRepository<MTS_SPECIFICATIONS> mtsSpecifications;
        private IRepository<MTS_NOMENCLATURES> mtsNomenclatures;
        private IRepository<MTS_NOMENCLATURE_GROUPS> mtsNomenclatureGroups;
        private IRepository<MTS_GOST> mtsGosts;
        

        private IMapper mapper;

        public MtsNomenclaturesService(IUnitOfWork uow)
        {
            Database = uow;
            mtsNomenclatures = Database.GetRepository<MTS_NOMENCLATURES>();
            mtsNomenclatureGroups = Database.GetRepository<MTS_NOMENCLATURE_GROUPS>();
            mtsAdditCalculations = Database.GetRepository<MTS_ADDIT_CALCULATION>();
            mtsGosts = Database.GetRepository<MTS_GOST>();

            mtsSpecifications = Database.GetRepository<MTS_SPECIFICATIONS>();
         
            var config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<MTS_NOMENCLATURES, MTSNomenclaturesDTO>();
                 cfg.CreateMap<MTSNomenclaturesDTO, MTS_NOMENCLATURES>();
                 cfg.CreateMap<MTS_NOMENCLATURE_GROUPS, MTSNomenclatureGroupsDTO>();
                 cfg.CreateMap<MTSNomenclatureGroupsDTO, MTS_NOMENCLATURE_GROUPS>();
                 cfg.CreateMap<MTS_GOST, MTSGostDTO>();
                 cfg.CreateMap<MTSGostDTO, MTS_GOST>();
                 cfg.CreateMap<MTS_ADDIT_CALCULATION, MTSAdditCalculationsDTO>();

             });

            mapper = config.CreateMapper();
        }

        #region Get method's

        public IEnumerable<MtsNomenclaturessDTO> GetNomenclarures()
        {
            var result = (from g in mtsNomenclatureGroups.GetAll()
                          join a in mtsAdditCalculations.GetAll() on g.ADDIT_CALCULATION_ID equals a.ID into na
                          from a in na.DefaultIfEmpty()
                          join n in mtsNomenclatures.GetAll() on g.ID equals n.NOMENCLATUREGROUPS_ID
                          join c in mtsGosts.GetAll() on n.GOST_ID equals c.ID into nc
                          from c in nc.DefaultIfEmpty()

                          select new MtsNomenclaturessDTO
                          {
                              Id = n.ID,
                              MtsNomenclatureGroupId = n.NOMENCLATUREGROUPS_ID,
                              MtsGostId = n.GOST_ID,
                              Note = n.NOTE,
                              Name = n.NAME,
                              Gauge = n.GUAGE,
                              Weight = n.WEIGHT,
                              Price = n.PRICE,
                              AdditCalculationActive = g.ADDIT_CALCULATION_ID,
                              GostName = c.NAME,
                              GroupName = g.NAME,
                              RatioOfWaste = g.RATIO_OF_WASTE,
                           //   UnitLocalName = u.UnitLocalName,
                           //   AdditUnitLocalName = ua.UnitLocalName
                          });

            return result.ToList();
        }

        public IEnumerable<MTSGostDTO> GetGosts()
        {
            return mapper.Map<IEnumerable<MTS_GOST>, List<MTSGostDTO>>(mtsGosts.GetAll().OrderBy(s => s.NAME));
        }

      
        //public IEnumerable<MTSAdditCalculationsDTO> GetAdditCalculationUnits()
        //{
        //    var result = (from g in mtsAdditCalculations.GetAll()
        //                  join ua in units.GetAll() on g.UnitId equals ua.UnitId into aua
        //                  from ua in aua.DefaultIfEmpty()
        //                  select new MTSAdditCalculationsDTO
        //                  {
        //                      Id = g.Id,
        //                      UnitId = ua.UnitId,
        //                      AdditUnitLocalName = ua.UnitLocalName
        //                  });

        //    return result.ToList();
        //}

        public IEnumerable<MtsNomenclatureGroupssDTO> GetNomenclatureGroups()
        {
            var result = (from g in mtsNomenclatureGroups.GetAll()
                          join a in mtsAdditCalculations.GetAll() on g.ADDIT_CALCULATION_ID equals a.ID into na
                          from a in na.DefaultIfEmpty()
                          orderby g.NAME
                          select new MtsNomenclatureGroupssDTO
                          {
                              Id = g.ID,
                              Name = g.NAME,
                              AdditCalculationActive = (short?)g.ADDIT_CALCULATION_ACTIVE,
                              RatioOfWaste = g.RATIO_OF_WASTE,
                              MtsAdditCalculationId = g.ADDIT_CALCULATION_ID
                          });

            return result.ToList();
        }

       

        #endregion

        #region Nomenclatures CRUD method's

        public long NomenclarureCreate(MTSNomenclaturesDTO mtsNomenclature)
        {
            var createrecord = mtsNomenclatures.Create(mapper.Map<MTS_NOMENCLATURES>(mtsNomenclature));
            return (long)createrecord.ID;
        }

        public void NomenclarureUpdate(MTSNomenclaturesDTO mtsNomenclature)
        {
            var eGroup = mtsNomenclatures.GetAll().SingleOrDefault(c => c.ID == mtsNomenclature.ID);
            mtsNomenclatures.Update((mapper.Map<MTSNomenclaturesDTO, MTS_NOMENCLATURES>(mtsNomenclature, eGroup)));
        }

        public bool NomenclarureDelete(long id)
        {
            try
            {
                mtsNomenclatures.Delete(mtsNomenclatures.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region MtsNomenclatureGroups CRUD method's

        public int NomenclarureGroupCreate(MTSNomenclatureGroupsDTO mtsNomenclatureGroup)
        {
            var createrecord = mtsNomenclatureGroups.Create(mapper.Map<MTS_NOMENCLATURE_GROUPS>(mtsNomenclatureGroup));
            return (int)createrecord.ID;
        }

        public void NomenclarureGroupUpdate(MTSNomenclatureGroupsDTO mtsNomenclatureGroup)
        {
            var eGroup = mtsNomenclatureGroups.GetAll().SingleOrDefault(c => c.ID == mtsNomenclatureGroup.ID);
            mtsNomenclatureGroups.Update((mapper.Map<MTSNomenclatureGroupsDTO, MTS_NOMENCLATURE_GROUPS>(mtsNomenclatureGroup, eGroup)));
        }

        public bool NomenclarureGroupDelete(int id)
        {
            try
            {
                mtsNomenclatureGroups.Delete(mtsNomenclatureGroups.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region MtsGosts CRUD method's
        
        public long GostCreate(MTSGostDTO mtsGost)
        {
            var createrecord = mtsGosts.Create(mapper.Map<MTS_GOST>(mtsGost));
            return (long)createrecord.ID;
        }

        public void GostUpdate(MTSGostDTO mtsGost)
        {

            var eGroup = mtsGosts.GetAll().SingleOrDefault(c => c.ID == mtsGost.ID);
            mtsGosts.Update((mapper.Map<MTSGostDTO, MTS_GOST>(mtsGost, eGroup)));
        }

        public bool GostDelete(long id)
        {
            try
            {
                mtsGosts.Delete(mtsGosts.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
