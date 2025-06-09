using FirebirdSql.Data.FirebirdClient;
using MTS.DAL.Entities.Models;
using MTS.DAL.Entities.QueryModels;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MTS.DAL.EF
{
    public static class Connection
    {
        public static string ConnectionString;
    }

    public class ERP_Context : DbContext
    {


        #region DBSet`s

        public DbSet<Log> Log { get; set; }
        public DbSet<MTS_AUTHORIZATION_USERS> MTS_AUTHORIZATION_USERS { get; set; }
        public DbSet<MtsAssembliesInfo> MtsAssembliesInfo { get; set; }
        public DbSet<MtsAssembliesCustomerInfo> MtsAssembliesCustomerInfo { get; set; }
        public DbSet<MtsSpecificationTreeInfo> MtsSpeciicationTreeInfo { get; set; }
        public DbSet<MtsDetailsInfo> MtsDetailsInfo { get; set; }
        //public DbSet<MaterialsForAccountClothes> MaterialsForAccountClothes { get; set; }
        //public DbSet<MSPaymentsWithoutVat> MSPaymentsWithoutVat { get; set; }
        //public DbSet<MSTrialBalanceByAccounts> MSTrialBalanceByAccounts { get;set; }

        public DbSet<MTS_SPECIFICATIONS> MTSSpecificationsOld { get; set; }
        public DbSet<MTS_CREATED_DETAILS> MTSCreateDetals { get; set; }
        public DbSet<MTS_GOST> MTSGost { get; set; }
        public DbSet<MTS_NOMENCLATURES> MTSNomenclaturesOld { get; set; }
        public DbSet<MTS_GUAGES> MTS_GUAGES { get; set; }
        public DbSet<MTS_DEATAILS_PROCESSING> MTSDetailsProcessing { get; set; }
        public DbSet<MTS_DETAILS> MTS_DETAILS { get; set; }
        public DbSet<MTS_MATERIALS> MTS_MATERIALS { get; set; }
        public DbSet<MTS_MEASURE> MTS_MEASURE { get; set; }
        public DbSet<MTS_PURCHASED_PRODUCTS> MTS_PURCHASED_PRODUCTS { get; set; }
        public DbSet<MTS_NOMENCLATURE_GROUPS> MTS_NOMENCLATURE_GROUPS { get; set; }
        //public DbSet<MTS_NOMENCLATURE_GROUPS> MTSNomenclatureGroups { get; set; }
        public DbSet<MTS_ADDIT_CALCULATION> MTS_ADDIT_CALCULATION { get; set; }
        

        #endregion

        static ERP_Context()
        {
            FbConnectionStringBuilder csb;

            //string[] ipDB = File.ReadAllLines("ipDB.txt");
            //string[] portDB = File.ReadAllLines("portDB.txt");
            //string[] aliasDB = File.ReadAllLines("aliasDB.txt");

            csb = new FbConnectionStringBuilder()
            {
                DataSource = "10.0.0.50",
                //DataSource = "localhost",
               //  Port = Convert.ToInt32(portDB[0]),
                Database = "MTS_DB_TEST",
                UserID = "sysdba",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900
            };


            Connection.ConnectionString = csb.ConnectionString;
            Database.SetInitializer<ERP_Context>(null);
        }

        public ERP_Context()
            : base(new FbConnection(Connection.ConnectionString), true)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(15, 6));
        }
    }
}
