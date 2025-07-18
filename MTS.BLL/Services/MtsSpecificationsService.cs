﻿using AutoMapper;
using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.DTO.SelectedDTO;
using MTS.BLL.Interfaces;
using MTS.DAL.Entities.Models;
using MTS.DAL.Entities.QueryModels;
using MTS.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTS.BLL.Services
{
    public class MtsSpecificationsService : IMtsSpecificationsService
    {
        private IUnitOfWork Database { get; set; }


        private IRepository<MTS_SPECIFICATIONS> mtsSpecificationsOld;
        private IRepository<MTS_AUTHORIZATION_USERS> mtsAuthorizationUsers;
        private IRepository<MTS_DETAILS> mtsDetails;
        private IRepository<MTS_GOST> mtsGost;
        private IRepository<MTS_CREATED_DETAILS> mtsCreateDetals;
        private IRepository<MTS_CUSTOMERORDERS> mtsCustomerOrders;
        private IRepository<MTS_DEATAILS_PROCESSING> mtsDetailsProcessing;
        private IRepository<MTS_GUAGES> mtsGuages;
        private IRepository<MTS_NOMENCLATURES> mtsNomenclatures;
        private IRepository<MTS_MEASURE> mtsMeasure;
        private IRepository<MTS_MEASURE> mtsMeasureAdc;
        private IRepository<MTS_PURCHASED_PRODUCTS> mtsPurchasedProducts;
        private IRepository<MTS_MATERIALS> mtsMaterials;
        private IRepository<MTS_NOMENCLATURE_GROUPS> mtsNomenclatureGroups;
        private IRepository<MTS_DETAILS> mtsDetals;
        private IRepository<MTS_ADDIT_CALCULATION> mtsAdditCalculation;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<Contractors> contractors;
        private IRepository<CustomerOrderSpecifications> customerOrderSpecifications;
        private IRepository<CustomerOrderAssemblies> customerOrderAssemblies;
        private IRepository<MtsAssemblies> mtsAssemblies;
        
        // private IRepository<MTSDetails> mtsDetals;

        private IMapper mapper;

        public MtsSpecificationsService(IUnitOfWork uow)
        {
            Database = uow;
            customerOrders = Database.GetRepository<CustomerOrders>();
            contractors = Database.GetRepository<Contractors>();
            mtsCustomerOrders = Database.GetRepository<MTS_CUSTOMERORDERS>();
            mtsSpecificationsOld = Database.GetRepository<MTS_SPECIFICATIONS>();
            mtsAuthorizationUsers = Database.GetRepository<MTS_AUTHORIZATION_USERS>();
            mtsDetails = Database.GetRepository<MTS_DETAILS>();
            mtsGost = Database.GetRepository<MTS_GOST>();
            mtsCreateDetals = Database.GetRepository<MTS_CREATED_DETAILS>();
            mtsDetailsProcessing = Database.GetRepository<MTS_DEATAILS_PROCESSING>();
            mtsGuages = Database.GetRepository<MTS_GUAGES>();
            mtsNomenclatures = Database.GetRepository<MTS_NOMENCLATURES>();
            mtsMeasure = Database.GetRepository<MTS_MEASURE>();
            mtsMeasureAdc = Database.GetRepository<MTS_MEASURE>();
            mtsPurchasedProducts = Database.GetRepository<MTS_PURCHASED_PRODUCTS>();
            mtsMaterials = Database.GetRepository<MTS_MATERIALS>();
            mtsNomenclatureGroups = Database.GetRepository<MTS_NOMENCLATURE_GROUPS>();
            mtsDetals = Database.GetRepository<MTS_DETAILS>();
            mtsAdditCalculation = Database.GetRepository<MTS_ADDIT_CALCULATION>();
            customerOrderSpecifications = Database.GetRepository<CustomerOrderSpecifications>();
            customerOrderAssemblies = Database.GetRepository<CustomerOrderAssemblies>();
            mtsAssemblies = Database.GetRepository<MtsAssemblies>();

            var config = new MapperConfiguration(cfg =>
            {

                //cfg.CreateMap<MTS_SPECIFICATIONS, MtsSpecificationnsDTO>();
                //cfg.CreateMap<MtsSpecificationnsDTO, MTS_SPECIFICATIONS>();
                cfg.CreateMap<MtsDetailsInfo, MtsDetailsInfoDTO>();
                cfg.CreateMap<MtsAssembliesCustomerInfo, MtsAssembliesCustomerInfoDTO>();

                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                cfg.CreateMap<CustomerOrdersDTO, CustomerOrders>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<ContractorsDTO, Contractors>();
                cfg.CreateMap<MTS_CUSTOMERORDERS, MTSCustomerOrdersDTO>();
                cfg.CreateMap<MTSCustomerOrdersDTO, MTS_CUSTOMERORDERS>();

                cfg.CreateMap<MTS_SPECIFICATIONS, MTSSpecificationsDTO>();
                cfg.CreateMap<MTSSpecificationsDTO, MTS_SPECIFICATIONS>();
                cfg.CreateMap<MTSAuthorizationUsersDTO, MTS_AUTHORIZATION_USERS>();
                cfg.CreateMap<MTS_AUTHORIZATION_USERS, MTSAuthorizationUsersDTO>();
                cfg.CreateMap<MTSDetailsDTO, MTS_DETAILS>();
                cfg.CreateMap<MTS_DETAILS, MTSDetailsDTO>();

                cfg.CreateMap<MTSGostDTO, MTS_GOST>();
                cfg.CreateMap<MTS_GOST, MTSGostDTO>();
                cfg.CreateMap<MTSCreateDetalsDTO, MTS_CREATED_DETAILS>();
                cfg.CreateMap<MTS_CREATED_DETAILS, MTSCreateDetalsDTO>();
                cfg.CreateMap<MTSDetalsProcessingDTO, MTS_DEATAILS_PROCESSING>();
                cfg.CreateMap<MTS_DEATAILS_PROCESSING, MTSDetalsProcessingDTO>();
                cfg.CreateMap<MTSGuagesDTO, MTS_GUAGES>();
                cfg.CreateMap<MTS_GUAGES, MTSGuagesDTO>();
                cfg.CreateMap<MTSNomenclaturesDTO, MTS_NOMENCLATURES>();
                cfg.CreateMap<MTS_NOMENCLATURES, MTSNomenclaturesDTO>();
                cfg.CreateMap<MTSMeasureDTO, MTS_MEASURE>();
                cfg.CreateMap<MTS_MEASURE, MTSMeasureDTO>();
                cfg.CreateMap<MTSPurchasedProductsDTO, MTS_PURCHASED_PRODUCTS>();
                cfg.CreateMap<MTS_PURCHASED_PRODUCTS, MTSPurchasedProductsDTO>();
                cfg.CreateMap<MTSMaterialsDTO, MTS_MATERIALS>();
                cfg.CreateMap<MTS_MATERIALS, MTSMaterialsDTO>();
                cfg.CreateMap<MTSNomenclatureGroupsDTO, MTS_NOMENCLATURE_GROUPS>();
                cfg.CreateMap<MTS_NOMENCLATURE_GROUPS, MTSNomenclatureGroupsDTO>();
                cfg.CreateMap<MTSDetailsDTO, MTS_DETAILS>();
                cfg.CreateMap<MTS_DETAILS, MTSDetailsDTO>();
                cfg.CreateMap<MTSAdditCalculationsDTO, MTS_ADDIT_CALCULATION>();
                cfg.CreateMap<MTS_ADDIT_CALCULATION, MTSAdditCalculationsDTO>();

            });

            mapper = config.CreateMapper();
        }

        #region Get method's

        public IEnumerable<CustomerOrdersDTO> GetCustomerOrdersFull()
        {
            var result = (from co in customerOrders.GetAll()
                          join c in contractors.GetAll() on co.ContractorId equals c.Id into coc
                          from c in coc.DefaultIfEmpty()

                          where !(co.OrderNumber.Trim() == null || co.OrderNumber.Trim() == String.Empty)
                          orderby co.OrderDate, co.OrderNumber

                          select new CustomerOrdersDTO
                          {
                              Id = co.Id,
                              OrderNumber = co.OrderNumber,
                              OrderDate = co.OrderDate,
                              OrderPrice = co.OrderPrice,
                              CurrencyPrice = co.CurrencyPrice,
                              ContractorId = co.ContractorId,
                              ContractorName = c.Name,
                              DateCreate = co.DateCreate,
                              DateUpdate = co.DateUpdate,
                              UserId = co.UserId     
                          });

            return result.ToList();
        }

        public IEnumerable<CustomerOrdersDTO> GetCustomerOrdersWithDrawing()
        {

            //Выборка данных из базы
            var result = (from co in customerOrders.GetAll()
                          join c in contractors.GetAll() on co.ContractorId equals c.Id into coc
                          from c in coc.DefaultIfEmpty()
                          join cos in customerOrderSpecifications.GetAll() on co.Id equals cos.CustomerOrderId into coss
                          from cos in coss.DefaultIfEmpty()
                          join coa in customerOrderAssemblies.GetAll() on cos.Id equals coa.CustomerOrderSpecId into coaa
                          from coa in coaa.DefaultIfEmpty()
                          join mts in mtsAssemblies.GetAll() on coa.AssemblyId equals mts.Id into mtss
                          from mts in mtss.DefaultIfEmpty()


                          select new CustomerOrdersDTO
                          {
                              Id = co.Id,
                              OrderNumber = co.OrderNumber,
                              ContractorId = co.ContractorId,
                              OrderDate = co.OrderDate,
                              Details = co.Details,
                              OrderPrice = co.OrderPrice,
                              Drawing = mts.Drawing,
                              AssemblyId = mts.Id,
                              AssemblyName = mts.Name,
                              DateCreate = co.DateCreate,
                              DateUpdate = co.DateUpdate,
                              UserId = co.UserId,
                              ContractorName = c.Name,
                          });

            // Групировка и конкатенация поля: Чертеж и Разработчик
            var groupByRezult = result.AsEnumerable()
                .GroupBy(l => new
                {
                    l.Id,
                    l.OrderNumber,
                    l.ContractorId,
                    l.OrderDate,
                    l.Details,
                    l.OrderPrice,
                    l.DateCreate,
                    l.DateUpdate,
                    l.UserId,
                    l.ContractorName,
                }).Select(g => new CustomerOrdersDTO
                {
                    Id = g.Key.Id,
                    OrderNumber = g.Key.OrderNumber,
                    ContractorId = g.Key.ContractorId,
                    OrderDate = g.Key.OrderDate,
                    Details = g.Key.Details,
                    OrderPrice = g.Key.OrderPrice,
                    DateCreate = g.Key.DateCreate,
                    DateUpdate = g.Key.DateUpdate,
                    UserId = g.Key.UserId,
                    ContractorName = g.Key.ContractorName,
                    DesignerName = string.Join(", ", g.Select(md => md.DesignerName).ToList()) != "" ? string.Join(", ", g.Select(md => md.DesignerName).ToList()) : "",
                    Drawing = string.Join(",", g.Select(md => md.Drawing).ToList()) != "" ? string.Join(",", g.Select(md => md.Drawing).ToList()) : ""
                });

            List<CustomerOrdersDTO> returnSortList = new List<CustomerOrdersDTO>();

            //Убираем дубликаты
            foreach (var item in groupByRezult.ToList())
            {
                string[] splitDrawingString = item.Drawing.Split(',');
                string[] splitDesignerNameString = item.DesignerName.Split(',');

                item.Drawing = string.Join(",", (splitDrawingString.Distinct()).ToArray());
                item.DesignerName = string.Join(",", (splitDesignerNameString.Distinct()).ToArray());
                returnSortList.Add(item);
            }

            return returnSortList.OrderByDescending(srt => srt.OrderDate).ToList();
        }

        public IEnumerable<MTSCustomerOrdersDTO> GetMTSCustomerOrdersFull()
        {
            var result = (from mco in mtsCustomerOrders.GetAll()
                          join co in customerOrders.GetAll() on mco.CustomerOrderId equals co.Id into coc
                          from co in coc.DefaultIfEmpty()
                          join mso in mtsSpecificationsOld.GetAll() on mco.SpecificationId equals mso.ID into msoo
                          from mso in msoo.DefaultIfEmpty()
                          join con in contractors.GetAll() on co.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()

                         //where !(co.OrderNumber.Trim() == null || co.OrderNumber.Trim() == String.Empty)
                          //orderby co.OrderDate, co.OrderNumber

                          select new MTSCustomerOrdersDTO
                          {
                              Id = mco.Id,
                              OrderNumber = co.OrderNumber,
                              CustomerOrderId = co.Id,
                              SpecificationId = mso.ID,
                              DataCreateCustomerOrder = co.DateCreate,
                              ContractorName = con.Name,
                              DateCreate = mco.DateCreate,
                              DateUpdate = mco.DateUpdate
                          });

            return result.ToList();
        }

        public IEnumerable<MTSCustomerOrdersDTO> GetMTSCustomerOrdersFullBySpecificationId(int specificId)
        {
            var result = (from mco in mtsCustomerOrders.GetAll()
                          join co in customerOrders.GetAll() on mco.CustomerOrderId equals co.Id into coc
                          from co in coc.DefaultIfEmpty()
                          join mso in mtsSpecificationsOld.GetAll() on mco.SpecificationId equals mso.ID into msoo
                          from mso in msoo.DefaultIfEmpty()
                          join con in contractors.GetAll() on co.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()

                          where mco.SpecificationId == specificId
                          //orderby co.OrderDate, co.OrderNumber

                          select new MTSCustomerOrdersDTO
                          {
                              Id = mco.Id,
                              OrderNumber = co.OrderNumber,
                              CustomerOrderId = co.Id,
                              
                              SpecificationId = mso.ID,
                              DataCreateCustomerOrder = co.DateCreate,
                              ContractorName = con.Name,
                              DateCreate = mco.DateCreate,
                              DateUpdate = mco.DateUpdate
                          });

            return result.ToList();
        }

        public IEnumerable<CustomerOrdersDTO> GetCustomerOrders()
        {
            return mapper.Map<IEnumerable<CustomerOrders>, IList<CustomerOrdersDTO>>(customerOrders.GetAll());
        }

        public IEnumerable<ContractorsDTO> GetContractors()
        {
            return mapper.Map<IEnumerable<Contractors>, IList<ContractorsDTO>>(contractors.GetAll());
        }

        public IEnumerable<MTSSpecificationsDTO> GetAllSpecificationOldByPeriod(DateTime startDate, DateTime endDate)
        {

            var result = (from mts in mtsSpecificationsOld.GetAll()
                          join autUser in mtsAuthorizationUsers.GetAll() on mts.AUTHORIZATION_USERS_ID equals autUser.ID into autUs
                          from autUser in autUs.DefaultIfEmpty()
                          join mtsCust in mtsCustomerOrders.GetAll() on mts.ID equals mtsCust.SpecificationId into mtsCustt
                          from mtsCust in mtsCustt.DefaultIfEmpty()
                          join сust in customerOrders.GetAll() on mtsCust.CustomerOrderId equals сust.Id into сustt
                          from сust in сustt.DefaultIfEmpty()

                          where (mts.CREATION_DATE >= startDate && mts.CREATION_DATE <= endDate)
                          select new MTSSpecificationsDTO()
                          {
                              ID = mts.ID,
                              NAME = mts.NAME,
                              AUTHORIZATION_USERS_ID = mts.AUTHORIZATION_USERS_ID,
                              WEIGHT = mts.WEIGHT,
                              CREATION_DATE = mts.CREATION_DATE,
                              DRAWING = mts.DRAWING,
                              AUTHORIZATION_USERS_NAME = autUser.NAME,
                              QUANTITY = mts.QUANTITY,
                              COMPILATION_DRAWINGS = mts.COMPILATION_DRAWINGS,
                              COMPILATION_NAMES = mts.COMPILATION_NAMES,
                              COMPILATION_QUANTITIES = mts.COMPILATION_QUANTITIES,
                              SET_COLOR = mts.SET_COLOR,
                              ASSEMBLY = mts.ASSEMBLY,
                              CustomerOrders = сust.OrderNumber
                          }).ToList();

            // Групировка и конкатенация поля: Зака
            var groupByRezult = result.AsEnumerable()
                .GroupBy(l => new
                {
                    l.ID,
                    l.NAME,
                    l.AUTHORIZATION_USERS_ID,
                    l.WEIGHT,
                    l.CREATION_DATE,
                    l.DRAWING,
                    l.AUTHORIZATION_USERS_NAME,
                    l.QUANTITY,
                    l.COMPILATION_DRAWINGS,
                    l.COMPILATION_NAMES,
                    l.COMPILATION_QUANTITIES,
                    l.SET_COLOR,
                    l.ASSEMBLY
                }).Select(g => new MTSSpecificationsDTO
                {
                    ID = g.Key.ID,
                    NAME = g.Key.NAME,
                    AUTHORIZATION_USERS_ID = g.Key.AUTHORIZATION_USERS_ID,
                    WEIGHT = g.Key.WEIGHT,
                    CREATION_DATE = g.Key.CREATION_DATE,
                    DRAWING = g.Key.DRAWING,
                    AUTHORIZATION_USERS_NAME = g.Key.AUTHORIZATION_USERS_NAME,
                    QUANTITY = g.Key.QUANTITY,
                    COMPILATION_DRAWINGS = g.Key.COMPILATION_DRAWINGS,
                    COMPILATION_NAMES = g.Key.COMPILATION_NAMES,
                    COMPILATION_QUANTITIES = g.Key.COMPILATION_QUANTITIES,
                    SET_COLOR = g.Key.SET_COLOR,
                    ASSEMBLY = g.Key.ASSEMBLY,
                    CustomerOrders = string.Join(",", g.Select(md => md.CustomerOrders).ToList()) != "" ? string.Join(",", g.Select(md => md.CustomerOrders).ToList()) : ""
                });

            List<MTSSpecificationsDTO> returnSortList = new List<MTSSpecificationsDTO>();

            //Убираем дубликаты
            foreach (var item in groupByRezult.ToList())
            {
                string[] splitDrawingString = item.CustomerOrders.Split(',');

                item.CustomerOrders = string.Join(",", (splitDrawingString.Distinct()).ToArray());
                returnSortList.Add(item);
            }

            //return returnSortList.OrderByDescending(srt => srt.OrderDate).ToList();
            return returnSortList;
        }

        public IEnumerable<MTSSpecificationsDTO> GetAllSpecificationOld()
        {

            var result = (from mts in mtsSpecificationsOld.GetAll()
                          join autUser in mtsAuthorizationUsers.GetAll() on mts.AUTHORIZATION_USERS_ID equals autUser.ID into autUs
                          from autUser in autUs.DefaultIfEmpty()

                          select new MTSSpecificationsDTO()
                          {
                              ID = mts.ID,
                              NAME = mts.NAME,
                              AUTHORIZATION_USERS_ID = mts.AUTHORIZATION_USERS_ID,
                              WEIGHT = mts.WEIGHT,
                              CREATION_DATE = mts.CREATION_DATE,
                              DRAWING = mts.DRAWING,
                              AUTHORIZATION_USERS_NAME = autUser.NAME,
                              QUANTITY = mts.QUANTITY,

                          }).ToList();

            return result;
        }

        //public IEnumerable<MTSCreateDetalsDTO> GetAllDetailsSpecific(int spesificId)
        //{
        //    var result = (from mtsSpec in mtsSpecificationsOld.GetAll()

        //                  join mtsDetal in mtsDetails.GetAll() on mtsSpec.ID equals mtsDetal.SPECIFICATIONS_ID into mtsDetals
        //                  from mtsDetal in mtsDetals.DefaultIfEmpty()

        //                  join mtsCreateDet in mtsCreateDetals.GetAll() on mtsDetal.CREATED_DETAILS_ID equals mtsCreateDet.ID into mtsCeateDetals
        //                  from mtsCreateDet in mtsCeateDetals.DefaultIfEmpty()

        //                  join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
        //                  from mtsNom in mtsNomen.DefaultIfEmpty()

        //                  join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
        //                  from mtsG in mtsGos.DefaultIfEmpty()

        //                  join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
        //                  from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

        //                  join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
        //                  from mtsGua in mtsGuag.DefaultIfEmpty()

        //                  where (mtsSpec.ID == spesificId /*&& mtsSpec.ID != null*/)

        //                  select new MTSCreateDetalsDTO()
        //                  {
        //                      ID = mtsCreateDet.ID,//mtsDetal.CREATED_DETAILS_ID,//??????????
        //                      NAME = mtsCreateDet.NAME,//1 
        //                      GOSTNAME = mtsG.NAME,//2 
        //                      NOMENCLATURESNOTE = mtsNom.NOTE,//3 
        //                      DRAWING = mtsCreateDet.DRAWING,//4
        //                      QUANTITY = mtsDetal.QUANTITY,//5
        //                      DETALSPROCESSING = mtsDetalsProc.NAME,//6
        //                      NOMENCLATURESNAME = mtsNom.NAME,//7
        //                      GUAEGENAME = mtsGua.NAME,//8 
        //                      WIDTH = mtsCreateDet.WIDTH,//9
        //                      HEIGHT = mtsCreateDet.HEIGHT,//10
        //                      NOMENCLATURESWEIGHT = mtsNom.WEIGHT,//11 
        //                      QUANTITY_OF_BLANKS = mtsDetal.QUANTITY_OF_BLANKS,//12                              
        //                      PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
        //                      NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID
        //                  });

        //    if (result == null)
        //        return null;



        //    return result.ToList();
        //}

        //public IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecific(int spesificId)
        //{
        //    var rez = (from mtsSpec in mtsSpecificationsOld.GetAll()

        //               join mtsPurc in mtsPurchasedProducts.GetAll() on mtsSpec.ID equals mtsPurc.SPECIFICATIONS_ID into mtsPurchased
        //               from mtsPurc in mtsPurchased.DefaultIfEmpty()

        //               join mtsNom in mtsNomenclatures.GetAll() on mtsPurc.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
        //               from mtsNom in mtsNomen.DefaultIfEmpty()

        //               join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
        //               from mtsMeas in mtsMeasur.DefaultIfEmpty()

        //               join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
        //               from gost in gosts.DefaultIfEmpty()

        //               where mtsSpec.ID == spesificId && mtsSpec.ID != null
        //               select new MTSPurchasedProductsDTO()
        //               {
        //                   ID = mtsSpec.ID,//mtsPurc.ID,
        //                   NOMENCLATURESNAME = mtsNom.NAME,
        //                   GUAEGENAME = mtsNom.GUAGE,
        //                   GOSTNAME = gost.NAME,
        //                   NOMENCLATURESNOTE = mtsNom.NOTE,
        //                   MEASURENAME = mtsMeas.NAME,
        //                   WEIGHT = mtsNom.WEIGHT,
        //                   QUANTITY = mtsPurc.QUANTITY,
        //                   NOMENCLATURES_ID = mtsPurc.NOMENCLATURES_ID,
        //                   SPECIFICATIONS_ID = mtsPurc.SPECIFICATIONS_ID
        //               }).DefaultIfEmpty().ToList();

        //    return rez;
        //}

        //public IEnumerable<MTSMaterialsDTO> GetMaterialsSpecific(int spesificId)
        //{
        //    var rez = (from mtsSpec in mtsSpecificationsOld.GetAll()

        //               join mtsMat in mtsMaterials.GetAll() on mtsSpec.ID equals mtsMat.SPECIFICATIONS_ID into mtsMater
        //               from mtsMat in mtsMater.DefaultIfEmpty()

        //               join mtsNom in mtsNomenclatures.GetAll() on mtsMat.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
        //               from mtsNom in mtsNomen.DefaultIfEmpty()

        //               join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
        //               from mtsMeas in mtsMeasur.DefaultIfEmpty()

        //               join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
        //               from gost in gosts.DefaultIfEmpty()

        //               where mtsSpec.ID == spesificId && mtsSpec.ID != null

        //               select new MTSMaterialsDTO()
        //               {
        //                   ID = mtsSpec.ID,//mtsMat.ID,
        //                   NOMENCLATURES_ID = mtsNom.ID,
        //                   NOMENCLATURESNAME = mtsNom.NAME,//1
        //                   GUAGENAME = mtsNom.GUAGE,//2
        //                   GOSTNAME = gost.NAME,//3
        //                   NOMENCLATURESNOTE = mtsNom.NOTE,//4
        //                   MEASURENAME = mtsMeas.NAME,//5
        //                   NOMENCLATURESWEIGHT = mtsNom.WEIGHT,//6
        //                   QUANTITY = mtsMat.QUANTITY,//7
        //                   SPECIFICATIONS_ID = mtsMat.SPECIFICATIONS_ID

        //               }).DefaultIfEmpty().ToList();

        //    return rez;

        //}


        //public IEnumerable<MTSCreateDetalsDTO> GetAllDetailsSpecific(int spesificId)
        //{
        //    var result = (

        //                  from mtsDetal in mtsDetails.GetAll() 

        //                  join mtsCreateDet in mtsCreateDetals.GetAll() on mtsDetal.CREATED_DETAILS_ID equals mtsCreateDet.ID into mtsCeateDetals
        //                  from mtsCreateDet in mtsCeateDetals.DefaultIfEmpty()

        //                  join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
        //                  from mtsNom in mtsNomen.DefaultIfEmpty()

        //                  join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
        //                  from mtsG in mtsGos.DefaultIfEmpty()

        //                  join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
        //                  from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

        //                  join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
        //                  from mtsGua in mtsGuag.DefaultIfEmpty()

        //                  where (mtsDetal.SPECIFICATIONS_ID == spesificId /*&& mtsSpec.ID != null*/)

        //                  select new MTSCreateDetalsDTO()
        //                  {
        //                      ID = mtsCreateDet.ID,//mtsDetal.CREATED_DETAILS_ID,//??????????
        //                      NAME = mtsCreateDet.NAME,//1 ++
        //                      GOSTNAME = mtsG.NAME,//2 
        //                      NOMENCLATURESNOTE = mtsNom.NOTE,//3 --
        //                      DRAWING = mtsCreateDet.DRAWING,//4++
        //                      QUANTITY = mtsDetal.QUANTITY,//5
        //                      DETALSPROCESSING = mtsDetalsProc.NAME,//6
        //                      NOMENCLATURESNAME = mtsNom.NAME,//7 --
        //                      GUAEGENAME = mtsGua.NAME,//8 
        //                      WIDTH = mtsCreateDet.WIDTH,//9++
        //                      HEIGHT = mtsCreateDet.HEIGHT,//10++
        //                      NOMENCLATURESWEIGHT = mtsNom.WEIGHT,//11 --
        //                      QUANTITY_OF_BLANKS = mtsDetal.QUANTITY_OF_BLANKS,//12                              
        //                      PROCESSING_ID = mtsCreateDet.PROCESSING_ID,//++
        //                      NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID //--
        //                  }).ToList();




        //    return result;
        //}



        public IEnumerable<MTSDetailsDTO> GetAllDetailsSpecificShort(int specificId)
        {
            return mapper.Map<IEnumerable<MTS_DETAILS>, List<MTSDetailsDTO>>(mtsDetails.GetAll().Where(srch => srch.SPECIFICATIONS_ID == specificId));
        }

        public IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecificShort(int specificId)
        {
            return mapper.Map<IEnumerable<MTS_PURCHASED_PRODUCTS>, List<MTSPurchasedProductsDTO>>(mtsPurchasedProducts.GetAll().Where(srch => srch.SPECIFICATIONS_ID == specificId));
        }

        public IEnumerable<MTSMaterialsDTO> GetMaterialsSpecificShort(int specificId)
        {
            return mapper.Map<IEnumerable<MTS_MATERIALS>, List<MTSMaterialsDTO>>(mtsMaterials.GetAll().Where(srch => srch.SPECIFICATIONS_ID == specificId));
        }

        public IEnumerable<MTSDetailsDTO> GetAllDetailsSpecific(int spesificId)
        {
            var result = (

                          from mtsDetal in mtsDetails.GetAll()

                          join mtsCreateDet in mtsCreateDetals.GetAll() on mtsDetal.CREATED_DETAILS_ID equals mtsCreateDet.ID into mtsCeateDetals
                          from mtsCreateDet in mtsCeateDetals.DefaultIfEmpty()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          join mtsNomGroup in mtsNomenclatureGroups.GetAll() on mtsNom.NOMENCLATUREGROUPS_ID equals mtsNomGroup.ID into mtsNomGroupen
                          from mtsNomGroup in mtsNomGroupen.DefaultIfEmpty()

                          join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeases
                          from mtsMeas in mtsMeases.DefaultIfEmpty()

                          join mtsAdditCalc in mtsAdditCalculation.GetAll() on mtsNomGroup.ADDIT_CALCULATION_ID equals mtsAdditCalc.ID into mtsAdditCalcen
                          from mtsAdditCalc in mtsAdditCalcen.DefaultIfEmpty()

                          join mtsMeasAdc in mtsMeasureAdc.GetAll() on mtsAdditCalc.MEASURE_ID equals mtsMeasAdc.ID into mtsMeasAdcen
                          from mtsMeasAdc in mtsMeasAdcen.DefaultIfEmpty()

                          where (mtsDetal.SPECIFICATIONS_ID == spesificId /*&& mtsSpec.ID != null*/)

                          select new MTSDetailsDTO()
                          {
                              ID = mtsDetal.ID,//mtsDetal.CREATED_DETAILS_ID,//??????????
                              SPECIFICATIONS_ID = mtsDetal.SPECIFICATIONS_ID,
                              CREATED_DETAILS_ID = mtsDetal.CREATED_DETAILS_ID,
                              QUANTITY_OF_BLANKS = mtsDetal.QUANTITY_OF_BLANKS,
                              CODZAK = mtsDetal.CODZAK,
                              QUANTITY = mtsDetal.QUANTITY,
                              CHANGES = mtsDetal.CHANGES,
                              TIME_OF_ADD = mtsDetal.TIME_OF_ADD,

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              NOM_GROUP_ID = mtsNomGroup.ID,
                              NOM_GROUP_ADDIT_CALCULATION_ACTIVE = mtsNomGroup.ADDIT_CALCULATION_ACTIVE,
                              NOM_GROUP_ADDIT_CALCULATION_ID = mtsNomGroup.ADDIT_CALCULATION_ID,
                              NOM_GROUP_ADDIT_CALCULATION_MEASURE = mtsMeasAdc.NAME,
                              NOM_GROUP_CODPROD = mtsNomGroup.CODPROD,
                              NOM_GROUP_NAME = mtsNomGroup.NAME,
                              NOM_GROUP_PARENT_ID = mtsNomGroup.PARENT_ID,
                              NOM_GROUP_RATIO_OF_WASTE = mtsNomGroup.RATIO_OF_WASTE,
                              NOM_GROUP_SORTPOSITION = mtsNomGroup.SORTPOSITION,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsNom.GUAGE,
                              GUAEGESORT = mtsGua.SORTING,

                              MEASURE_NAME = mtsMeas.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT,
                              lastFocusedRov = false
                          }).ToList();
            return result;
        }

        //Nomenclature_id = (int)i.NOMENCLATURES_ID,
        //                                   Quantity = (decimal)(i.QUANTITY * val),
        //                                   Price = (decimal)i.MTS_NOMENCLATURES.PRICE * val,
        //                                   Name = i.MTS_NOMENCLATURES.NAME,
        //                                   Guage = i.MTS_NOMENCLATURES.GUAGE,
        //                                   Gost = i.MTS_NOMENCLATURES.MTS_GOST.NAME,
        //                                   Measure = i.MTS_NOMENCLATURES.MTS_MEASURE.NAME,
        //                                   Note = i.MTS_NOMENCLATURES.NOTE,
        //                                   SortPosition = (int)i.MTS_NOMENCLATURES.MTS_NOMENCLATURE_GROUPS.SORTPOSITION

        public IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecific(int spesificId)
        {
            var rez = (

                       from mtsPurc in mtsPurchasedProducts.GetAll()

                       join mtsNom in mtsNomenclatures.GetAll() on mtsPurc.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
                       from mtsNom in mtsNomen.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsNomGroup in mtsNomenclatureGroups.GetAll() on mtsNom.NOMENCLATUREGROUPS_ID equals mtsNomGroup.ID into mtsNomGroupen
                       from mtsNomGroup in mtsNomGroupen.DefaultIfEmpty()


                       where mtsPurc.SPECIFICATIONS_ID == spesificId
                       select new MTSPurchasedProductsDTO()
                       {
                           ID = mtsPurc.ID,//mtsPurc.ID,
                           CHANGES = mtsPurc.CHANGES,

                           GUAEGENAME = mtsNom.GUAGE,
                           GOSTNAME = gost.NAME,

                           NOMENCLATURESNAME = mtsNom.NAME,
                           NOMENCLATURESNOTE = mtsNom.NOTE,
                           NOMENCLATURESPRICE = mtsNom.PRICE,

                           NOM_GROUP_ID = mtsNomGroup.ID,
                           NOM_GROUP_SORTPOSITION = mtsNomGroup.SORTPOSITION,

                           MEASURENAME = mtsMeas.NAME,
                           WEIGHT = mtsNom.WEIGHT,
                           QUANTITY = mtsPurc.QUANTITY,

                           NOMENCLATURES_ID = mtsPurc.NOMENCLATURES_ID,
                           SPECIFICATIONS_ID = mtsPurc.SPECIFICATIONS_ID
                       }).ToList();

            return rez;
        }


        public IEnumerable<MTSMaterialsDTO> GetMaterialsSpecific(int spesificId)
        {
            var rez = (//from mtsSpec in mtsSpecificationsOld.GetAll()

                       from mtsMat in mtsMaterials.GetAll()

                       join mtsNom in mtsNomenclatures.GetAll() on mtsMat.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
                       from mtsNom in mtsNomen.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsNomGroup in mtsNomenclatureGroups.GetAll() on mtsNom.NOMENCLATUREGROUPS_ID equals mtsNomGroup.ID into mtsNomGroupen
                       from mtsNomGroup in mtsNomGroupen.DefaultIfEmpty()

                       where mtsMat.SPECIFICATIONS_ID == spesificId

                       select new MTSMaterialsDTO()
                       {
                           ID = mtsMat.ID,//mtsMat.ID,
                           CHANGES = mtsMat.CHANGES,
                           NOMENCLATURES_ID = mtsNom.ID,
                           NOMENCLATURESNAME = mtsNom.NAME,//1
                           GUAGENAME = mtsNom.GUAGE,//2
                           GOSTNAME = gost.NAME,//3
                           NOMENCLATURESNOTE = mtsNom.NOTE,//4
                           MEASURENAME = mtsMeas.NAME,//5

                           WEIGHT = mtsNom.WEIGHT,//6
                           QUANTITY = mtsMat.QUANTITY,//7
                           SPECIFICATIONS_ID = mtsMat.SPECIFICATIONS_ID,
                           NOM_GROUP_ID = mtsNomGroup.ID,
                           NOM_GROUP_SORTPOSITION = mtsNomGroup.SORTPOSITION,
                           NOMENCLATURESPRICE = mtsNom.PRICE

                       }).ToList();

            return rez;

        }

        public IEnumerable<MTSNomenclatureGroupsDTO> GetAllNomenclatureGroupsOld()
        {
            return mapper.Map<IEnumerable<MTS_NOMENCLATURE_GROUPS>, IList<MTSNomenclatureGroupsDTO>>(mtsNomenclatureGroups.GetAll());

        }
        public IEnumerable<MTSGostDTO> GetAllGostOld()
        {
            return mapper.Map<IEnumerable<MTS_GOST>, IList<MTSGostDTO>>(mtsGost.GetAll());
        }
        public IEnumerable<MTSGuagesDTO> GetAllGuagesOld()
        {
            return mapper.Map<IEnumerable<MTS_GUAGES>, IList<MTSGuagesDTO>>(mtsGuages.GetAll());
        }

        public IEnumerable<MTSMeasureDTO> GetAllMeasureOld()
        {
            return mapper.Map<IEnumerable<MTS_MEASURE>, IList<MTSMeasureDTO>>(mtsMeasure.GetAll());
        }


        public IEnumerable<MTSNomenclaturesDTO> GetAllNomenclatures(int nomenGroupId)
        {
            var rez = (from mtsNomen in mtsNomenclatures.GetAll()

                       join mtsNomenGr in mtsNomenclatureGroups.GetAll() on mtsNomen.NOMENCLATUREGROUPS_ID equals mtsNomenGr.ID into mtsNomenGroup
                       from mtsNomenGr in mtsNomenGroup.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNomen.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNomen.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                           //join mtsGuage in mtsGuages.GetAll() on mtsNomen.GUAGE equals mtsGuage.NAME into mtsGuag
                           //from mtsGuage in mtsGuag.DefaultIfEmpty()

                       where mtsNomen.NOMENCLATUREGROUPS_ID == nomenGroupId
                       select new MTSNomenclaturesDTO()
                       {
                           ID = mtsNomen.ID,
                           COD_PROD_ID = mtsNomen.COD_PROD_ID,
                           NAME = mtsNomen.NAME,
                           //  GUAGE_ID= mtsNomen.ID,
                           MEASURE_ID = mtsNomen.MEASURE_ID,
                           NOMENCLATUREGROUPS_ID = mtsNomen.NOMENCLATUREGROUPS_ID,
                           GOST = gost.NAME,
                           GOST_ID = gost.ID,
                           MEASURE = mtsMeas.NAME,
                           PRICE = mtsNomen.PRICE,
                           WEIGHT = mtsNomen.WEIGHT,
                           NOTE = mtsNomen.NOTE,
                           GUAGE = mtsNomen.GUAGE


                       }
                     ).ToList();
            return rez;
        }

        public IEnumerable<MTSNomenclaturesDTO> GetAllNomenclaturesAll()
        {
            var rez = (from mtsNomen in mtsNomenclatures.GetAll()

                       join mtsNomenGr in mtsNomenclatureGroups.GetAll() on mtsNomen.NOMENCLATUREGROUPS_ID equals mtsNomenGr.ID into mtsNomenGroup
                       from mtsNomenGr in mtsNomenGroup.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNomen.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNomen.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                       select new MTSNomenclaturesDTO()
                       {
                           ID = mtsNomen.ID,
                           NAME = mtsNomen.NAME,
                           GOST = gost.NAME,
                           MEASURE = mtsMeas.NAME,
                           PRICE = mtsNomen.PRICE,
                           WEIGHT = mtsNomen.WEIGHT,
                           NOTE = mtsNomen.NOTE,
                           GUAGE = mtsNomen.GUAGE
                       }
                     ).ToList();
            return rez;
        }


        public IEnumerable<MTSDetalsProcessingDTO> GetDetailsProccesing()
        {
            return mapper.Map<IEnumerable<MTS_DEATAILS_PROCESSING>, IList<MTSDetalsProcessingDTO>>(mtsDetailsProcessing.GetAll());
        }


        public IEnumerable<MTSCreateDetalsDTO> GetAllCreateDetals()
        {
            var result = (

                          from mtsCreateDet in mtsCreateDetals.GetAll()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          select new MTSCreateDetalsDTO()
                          {
                              ID = mtsCreateDet.ID,
                              PROCCESINGNAME = mtsDetalsProc.NAME,

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsGua.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT
                          }).ToList();
            return result;
        }

        public MTSCreateDetalsDTO GetCreateDetalsByDrawingNumber(string drawignNumber)
        {
            var result = (

                          from mtsCreateDet in mtsCreateDetals.GetAll()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          where mtsCreateDet.DRAWING == drawignNumber

                          select new MTSCreateDetalsDTO()
                          {
                              ID = mtsCreateDet.ID,
                              PROCCESINGNAME = mtsDetalsProc.NAME,

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsGua.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT
                          }).FirstOrDefault();
            return result;
        }

        public MTSCreateDetalsDTO GetCreateDetalsById(int createDetails)
        {
            var result = (

                          from mtsCreateDet in mtsCreateDetals.GetAll()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          where mtsCreateDet.ID == createDetails

                          select new MTSCreateDetalsDTO()
                          {
                              ID = mtsCreateDet.ID,
                              PROCCESINGNAME = mtsDetalsProc.NAME,

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsGua.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT
                          }).FirstOrDefault();
            return result;
        }


        public IEnumerable<MTSAdditCalculationsDTO> GetAdditCalculationUnits()
        {
            var result = (from g in mtsAdditCalculation.GetAll()
                          join ua in mtsMeasure.GetAll() on g.MEASURE_ID equals ua.ID into aua
                          from ua in aua.DefaultIfEmpty()
                          select new MTSAdditCalculationsDTO
                          {
                              ID = g.ID,
                              MEASURE_ID = ua.ID,
                              Name = ua.NAME
                          });

            return result.ToList();
        }


        #endregion

        #region MTSSpecification CRUD method's

        public int MTSSpecificationCreate(MTSSpecificationsDTO mtsSpecificationDTO)
        {
            var createSpec = mtsSpecificationsOld.Create(mapper.Map<MTS_SPECIFICATIONS>(mtsSpecificationDTO));
            return (int)createSpec.ID;
        }

        public void MTSSpecificationUpdate(MTSSpecificationsDTO mtsSpecificationDTO)
        {
            var updateSpec = mtsSpecificationsOld.GetAll().SingleOrDefault(c => c.ID == mtsSpecificationDTO.ID);
            mtsSpecificationsOld.Update((mapper.Map<MTSSpecificationsDTO, MTS_SPECIFICATIONS>(mtsSpecificationDTO, updateSpec)));
        }

        public bool MTSSpecificationDelete(int id)
        {
            try
            {
                mtsSpecificationsOld.Delete(mtsSpecificationsOld.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //-------
        public int MTSCreateDetailsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var createDetail = mtsCreateDetals.Create(mapper.Map<MTS_CREATED_DETAILS>(mtsCreateDetalsDTO));
            return (int)createDetail.ID;
        }

        public void MTSCreateDetailsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var updateDetail = mtsCreateDetals.GetAll().SingleOrDefault(c => c.ID == mtsCreateDetalsDTO.ID);
            mtsCreateDetals.Update((mapper.Map<MTSCreateDetalsDTO, MTS_CREATED_DETAILS>(mtsCreateDetalsDTO, updateDetail)));
        }

        public bool MTSCreateDetailsDelete(int id)
        {
            try
            {
                mtsCreateDetals.Delete(mtsCreateDetals.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //----

        public int MTSDetailCreate(MTSDetailsDTO mtsDetalsDTO)
        {
            var createDetail = mtsDetals.Create(mapper.Map<MTS_DETAILS>(mtsDetalsDTO));
            return (int)createDetail.ID;
        }

        public void MTSDetailUpdate(MTSDetailsDTO mtsDetalsDTO)
        {
            var updateDetail = mtsDetals.GetAll().SingleOrDefault(c => c.ID == mtsDetalsDTO.ID);
            mtsDetals.Update((mapper.Map<MTSDetailsDTO, MTS_DETAILS>(mtsDetalsDTO, updateDetail)));
        }

        public bool MTSDetailDelete(int id)
        {
            try
            {
                mtsCreateDetals.Delete(mtsCreateDetals.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSPurchasedProducts CRUD method's

        public int MTSPurchasedProductsCreate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO)
        {
            var createPurchprod = mtsPurchasedProducts.Create(mapper.Map<MTS_PURCHASED_PRODUCTS>(mtsPurchasedProductsDTO));
            return (int)createPurchprod.ID;
        }

        public void MTSPurchasedProductsCreateRange(List<MTSPurchasedProductsDTO> source)
        {
            mtsPurchasedProducts.CreateRange(mapper.Map<List<MTSPurchasedProductsDTO>, IEnumerable<MTS_PURCHASED_PRODUCTS>>(source));
        }

        public void MTSPurchasedProductsUpdate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO)
        {
            var updatePurchProd = mtsPurchasedProducts.GetAll().SingleOrDefault(c => c.ID == mtsPurchasedProductsDTO.ID);
            mtsPurchasedProducts.Update((mapper.Map<MTSPurchasedProductsDTO, MTS_PURCHASED_PRODUCTS>(mtsPurchasedProductsDTO, updatePurchProd)));
        }

        public bool MTSPurchasedProductsDelete(int id)
        {
            try
            {
                mtsPurchasedProducts.Delete(mtsPurchasedProducts.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSMaterial CRUD method's

        public int MTSMaterialCreate(MTSMaterialsDTO mtsMaterialsDTO)
        {
            var createMaterial = mtsMaterials.Create(mapper.Map<MTS_MATERIALS>(mtsMaterialsDTO));
            return (int)createMaterial.ID;
        }

        public void MTSMaterialCreateRange(List<MTSMaterialsDTO> source)
        {
            mtsMaterials.CreateRange(mapper.Map<List<MTSMaterialsDTO>, IEnumerable<MTS_MATERIALS>>(source));
        }

        public void MTSMaterialUpdate(MTSMaterialsDTO mtsMaterialsDTO)
        {
            var updateMaterial = mtsMaterials.GetAll().SingleOrDefault(c => c.ID == mtsMaterialsDTO.ID);
            mtsMaterials.Update((mapper.Map<MTSMaterialsDTO, MTS_MATERIALS>(mtsMaterialsDTO, updateMaterial)));
        }

        public bool MTSMaterialDelete(int id)
        {
            try
            {
                mtsMaterials.Delete(mtsMaterials.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSDetails CRUD method's

        public int MTSDetailsCreate(MTSDetailsDTO mtsDetailsDTO)
        {
            var createDetails = mtsDetails.Create(mapper.Map<MTS_DETAILS>(mtsDetailsDTO));
            return (int)createDetails.ID;
        }

        public void MTSDetailsCreateRange(List<MTSDetailsDTO> source)
        {
            mtsDetails.CreateRange(mapper.Map<List<MTSDetailsDTO>, IEnumerable<MTS_DETAILS>>(source));
        }

        public void MTSDetailsUpdate(MTSDetailsDTO mtsDetailsDTO)
        {
            var updateDetail = mtsDetails.GetAll().SingleOrDefault(c => c.ID == mtsDetailsDTO.ID);
            mtsDetails.Update((mapper.Map<MTSDetailsDTO, MTS_DETAILS>(mtsDetailsDTO, updateDetail)));
        }



        public bool MTSDetailsDelete(int id)
        {
            try
            {
                mtsDetails.Delete(mtsDetails.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSCreateDetals CRUD method's

        public int MTSCreateDetalsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var createCreateDetails = mtsCreateDetals.Create(mapper.Map<MTS_CREATED_DETAILS>(mtsCreateDetalsDTO));
            return (int)createCreateDetails.ID;
        }

        public void MTSCreateDetalsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var updateCreateDetail = mtsCreateDetals.GetAll().SingleOrDefault(c => c.ID == mtsCreateDetalsDTO.ID);
            mtsCreateDetals.Update((mapper.Map<MTSCreateDetalsDTO, MTS_CREATED_DETAILS>(mtsCreateDetalsDTO, updateCreateDetail)));
        }

        public bool MTSCreateDetalDelete(int id)
        {
            try
            {
                mtsCreateDetals.Delete(mtsCreateDetals.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSGost CRUD method's
        public int MTSCreateGost(MTSGostDTO mtsGostDTO)
        {
            var createGost = mtsGost.Create(mapper.Map<MTS_GOST>(mtsGostDTO));
            return (int)createGost.ID;
        }

        public void MTSUpdateGost(MTSGostDTO mtsGostDTO)
        {
            var updateGost = mtsGost.GetAll().SingleOrDefault(c => c.ID == mtsGostDTO.ID);
            mtsGost.Update((mapper.Map<MTSGostDTO, MTS_GOST>(mtsGostDTO, updateGost)));
        }
        public bool MTSDeleteGost(int id)
        {
            try
            {
                mtsGost.Delete(mtsGost.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region MTSMEASURE CRUD method's

        public int MTSCreateMeasure(MTSMeasureDTO mtsMeasureDTO)
        {
            var createMeasure = mtsMeasure.Create(mapper.Map<MTS_MEASURE>(mtsMeasureDTO));
            return (int)createMeasure.ID;
        }
        public void MTSUpdateMeasure(MTSMeasureDTO mtsMeasureDTO)
        {
            var updateMeasure = mtsMeasure.GetAll().SingleOrDefault(c => c.ID == mtsMeasureDTO.ID);
            mtsMeasure.Update((mapper.Map<MTSMeasureDTO, MTS_MEASURE>(mtsMeasureDTO, updateMeasure)));
        }
        public bool MTSDeleteMeasure(int id)
        {
            try
            {
                mtsMeasure.Delete(mtsMeasure.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSCOSTUMERORDER CRUD method's

        public int MTSCreateCustumerOrders(MTSCustomerOrdersDTO mtsCustomerOrdersDTO)
        {
            var createMTSCUstomerOrder = mtsCustomerOrders.Create(mapper.Map<MTS_CUSTOMERORDERS>(mtsCustomerOrdersDTO));
            return (int)createMTSCUstomerOrder.Id;
        }
        public void MTSUpdateCustumerOrders(MTSCustomerOrdersDTO mtsCustomerOrdersDTO)
        {
            var updateMTSCustomerOrders = mtsCustomerOrders.GetAll().SingleOrDefault(c => c.Id == mtsCustomerOrdersDTO.Id);
            mtsCustomerOrders.Update((mapper.Map<MTSCustomerOrdersDTO, MTS_CUSTOMERORDERS>(mtsCustomerOrdersDTO, updateMTSCustomerOrders)));
        }
        public bool MTSDeleteCustumerOrders(int id)
        {
            try
            {
                mtsCustomerOrders.Delete(mtsCustomerOrders.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
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
