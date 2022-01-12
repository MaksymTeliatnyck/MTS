using System.Collections.Generic;
using MTS.BLL.DTO.ModelsDTO;
using MTS.BLL.DTO.SelectedDTO;
using System;

namespace MTS.BLL.Interfaces
{
   public interface IMtsNomenclaturesService
    {
        IEnumerable<MtsNomenclaturessDTO> GetNomenclarures();


        IEnumerable<MTSGostDTO> GetGosts();




        IEnumerable<MtsNomenclatureGroupssDTO> GetNomenclatureGroups();






        #region Nomenclatures CRUD method's

        long NomenclarureCreate(MTSNomenclaturesDTO mtsNomenclature);


        void NomenclarureUpdate(MTSNomenclaturesDTO mtsNomenclature);


        bool NomenclarureDelete(long id);

        #endregion

        #region MtsNomenclatureGroups CRUD method's

        int NomenclarureGroupCreate(MTSNomenclatureGroupsDTO mtsNomenclatureGroup);


        void NomenclarureGroupUpdate(MTSNomenclatureGroupsDTO mtsNomenclatureGroup);


        bool NomenclarureGroupDelete(int id);


        #endregion

        #region MtsGosts CRUD method's

        long GostCreate(MTSGostDTO mtsGost);


        void GostUpdate(MTSGostDTO mtsGost);


        bool GostDelete(long id);
        #endregion


        void Dispose();
    }
}
