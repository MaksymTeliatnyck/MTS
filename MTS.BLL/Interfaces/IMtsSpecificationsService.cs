using MTS.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;

namespace MTS.BLL.Interfaces
{
    public interface IMtsSpecificationsService
    {
        
        IEnumerable<CustomerOrdersDTO> GetCustomerOrders();
        IEnumerable<CustomerOrdersDTO> GetCustomerOrdersWithDrawing();


        IEnumerable<ContractorsDTO> GetContractors();
        IEnumerable<CustomerOrdersDTO> GetCustomerOrdersFull();
        IEnumerable<MTSCustomerOrdersDTO> GetMTSCustomerOrdersFull();
        IEnumerable<MTSCustomerOrdersDTO> GetMTSCustomerOrdersFullBySpecificationId(int specificId);

        IEnumerable<MTSSpecificationsDTO> GetAllSpecificationOldByPeriod(DateTime startDate, DateTime endDate);


        IEnumerable<MTSSpecificationsDTO> GetAllSpecificationOld();
        IEnumerable<MTSAdditCalculationsDTO> GetAdditCalculationUnits();

        IEnumerable<MTSDetailsDTO> GetAllDetailsSpecificShort(int specificId);


        IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecificShort(int specificId);


        IEnumerable<MTSMaterialsDTO> GetMaterialsSpecificShort(int specificId);


        IEnumerable<MTSDetailsDTO> GetAllDetailsSpecific(int spesificId);



        //Nomenclature_id = (int)i.NOMENCLATURES_ID,
        //                                   Quantity = (decimal)(i.QUANTITY * val),
        //                                   Price = (decimal)i.MTS_NOMENCLATURES.PRICE * val,
        //                                   Name = i.MTS_NOMENCLATURES.NAME,
        //                                   Guage = i.MTS_NOMENCLATURES.GUAGE,
        //                                   Gost = i.MTS_NOMENCLATURES.MTS_GOST.NAME,
        //                                   Measure = i.MTS_NOMENCLATURES.MTS_MEASURE.NAME,
        //                                   Note = i.MTS_NOMENCLATURES.NOTE,
        //                                   SortPosition = (int)i.MTS_NOMENCLATURES.MTS_NOMENCLATURE_GROUPS.SORTPOSITION

        IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecific(int spesificId);



        IEnumerable<MTSMaterialsDTO> GetMaterialsSpecific(int spesificId);


        IEnumerable<MTSNomenclatureGroupsDTO> GetAllNomenclatureGroupsOld();
        IEnumerable<MTSGostDTO> GetAllGostOld();
        IEnumerable<MTSGuagesDTO> GetAllGuagesOld();

        IEnumerable<MTSMeasureDTO> GetAllMeasureOld();


        IEnumerable<MTSNomenclaturesDTO> GetAllNomenclatures(int nomenGroupId);
        IEnumerable<MTSNomenclaturesDTO> GetAllNomenclaturesAll();


        IEnumerable<MTSDetalsProcessingDTO> GetDetailsProccesing();


        IEnumerable<MTSCreateDetalsDTO> GetAllCreateDetals();


        MTSCreateDetalsDTO GetCreateDetalsByDrawingNumber(string drawignNumber);
        MTSCreateDetalsDTO GetCreateDetalsById(int createDetails);






        int MTSSpecificationCreate(MTSSpecificationsDTO mtsSpecificationDTO);
        void MTSSpecificationUpdate(MTSSpecificationsDTO mtsSpecificationDTO);
        bool MTSSpecificationDelete(int id);

        //-------
        int MTSCreateDetailsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        void MTSCreateDetailsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        bool MTSCreateDetailsDelete(int id);

        int MTSDetailCreate(MTSDetailsDTO mtsDetalsDTO);
        void MTSDetailUpdate(MTSDetailsDTO mtsDetalsDTO);
        bool MTSDetailDelete(int id);


        int MTSPurchasedProductsCreate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO);
        void MTSPurchasedProductsCreateRange(List<MTSPurchasedProductsDTO> source);
        void MTSPurchasedProductsUpdate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO);
        bool MTSPurchasedProductsDelete(int id);




        int MTSMaterialCreate(MTSMaterialsDTO mtsMaterialsDTO);
        void MTSMaterialCreateRange(List<MTSMaterialsDTO> source);
        void MTSMaterialUpdate(MTSMaterialsDTO mtsMaterialsDTO);
        bool MTSMaterialDelete(int id);




        int MTSDetailsCreate(MTSDetailsDTO mtsDetailsDTO);
        void MTSDetailsCreateRange(List<MTSDetailsDTO> source);
        void MTSDetailsUpdate(MTSDetailsDTO mtsDetailsDTO);
        bool MTSDetailsDelete(int id);


        int MTSCreateDetalsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        void MTSCreateDetalsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        bool MTSCreateDetalDelete(int id);

        int MTSCreateGost(MTSGostDTO mtsGostDTO);
        void MTSUpdateGost(MTSGostDTO mtsGostDTO);
        bool MTSDeleteGost(int id);


        int MTSCreateMeasure(MTSMeasureDTO mtsMeasureDTO);
        void MTSUpdateMeasure(MTSMeasureDTO mtsMeasureDTO);
        bool MTSDeleteMeasure(int id);

        int MTSCreateCustumerOrders(MTSCustomerOrdersDTO mtsCustomerOrdersDTO);
        void MTSUpdateCustumerOrders(MTSCustomerOrdersDTO mtsCustomerOrdersDTO);
        bool MTSDeleteCustumerOrders(int id);


        void Dispose();
    }
}
