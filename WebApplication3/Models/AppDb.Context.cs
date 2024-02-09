﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AppManagement : DbContext
    {
        public AppManagement()
            : base("name=AppManagement")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AddProductLocation> AddProductLocation { get; set; }
        public virtual DbSet<ApiLog> ApiLog { get; set; }
        public virtual DbSet<AssignmentType> AssignmentType { get; set; }
        public virtual DbSet<BluetoothPrintDesign> BluetoothPrintDesign { get; set; }
        public virtual DbSet<CargoProvider> CargoProvider { get; set; }
        public virtual DbSet<ChangeOrderList> ChangeOrderList { get; set; }
        public virtual DbSet<CollectedOrderItems> CollectedOrderItems { get; set; }
        public virtual DbSet<CompanyInformations> CompanyInformations { get; set; }
        public virtual DbSet<DeliveryTransactionHeader> DeliveryTransactionHeader { get; set; }
        public virtual DbSet<DeliveryTransactionLine> DeliveryTransactionLine { get; set; }
        public virtual DbSet<DraftStockTransaction> DraftStockTransaction { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<ExportOrdersViaInternetInfo> ExportOrdersViaInternetInfo { get; set; }
        public virtual DbSet<InventoryControlWarehouse> InventoryControlWarehouse { get; set; }
        public virtual DbSet<InvoicePackageDetail> InvoicePackageDetail { get; set; }
        public virtual DbSet<LocationCountingHeader> LocationCountingHeader { get; set; }
        public virtual DbSet<LocationCountingLine> LocationCountingLine { get; set; }
        public virtual DbSet<LocationGroups> LocationGroups { get; set; }
        public virtual DbSet<LocationLevelNames> LocationLevelNames { get; set; }
        public virtual DbSet<LocationParameters> LocationParameters { get; set; }
        public virtual DbSet<Logger> Logger { get; set; }
        public virtual DbSet<MarketPlaceExportOrderHeader> MarketPlaceExportOrderHeader { get; set; }
        public virtual DbSet<MarketPlaceExportOrderLine> MarketPlaceExportOrderLine { get; set; }
        public virtual DbSet<MarketPlaceExportOrderPackageHistory> MarketPlaceExportOrderPackageHistory { get; set; }
        public virtual DbSet<NebimParameters> NebimParameters { get; set; }
        public virtual DbSet<OrderLineColumns> OrderLineColumns { get; set; }
        public virtual DbSet<OrderListFromSalesChannel> OrderListFromSalesChannel { get; set; }
        public virtual DbSet<OrderManagementList> OrderManagementList { get; set; }
        public virtual DbSet<OrderManagementTransactionType> OrderManagementTransactionType { get; set; }
        public virtual DbSet<OrderServiceItemList> OrderServiceItemList { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<PackageType> PackageType { get; set; }
        public virtual DbSet<PrintQueues> PrintQueues { get; set; }
        public virtual DbSet<PurchaseStatus> PurchaseStatus { get; set; }
        public virtual DbSet<Roundsman> Roundsman { get; set; }
        public virtual DbSet<rpReportConnectionString> rpReportConnectionString { get; set; }
        public virtual DbSet<rpSettings> rpSettings { get; set; }
        public virtual DbSet<SaleChannelCargo> SaleChannelCargo { get; set; }
        public virtual DbSet<SaleChannelCargoFile> SaleChannelCargoFile { get; set; }
        public virtual DbSet<SaleChannelCargoLine> SaleChannelCargoLine { get; set; }
        public virtual DbSet<SaleChannelCargoPackage> SaleChannelCargoPackage { get; set; }
        public virtual DbSet<SaleChannels> SaleChannels { get; set; }
        public virtual DbSet<ShelfAssignments> ShelfAssignments { get; set; }
        public virtual DbSet<ShelfTransferHeader> ShelfTransferHeader { get; set; }
        public virtual DbSet<ShelfTransferLine> ShelfTransferLine { get; set; }
        public virtual DbSet<ShipmentManagementList> ShipmentManagementList { get; set; }
        public virtual DbSet<srRefNumberCargo> srRefNumberCargo { get; set; }
        public virtual DbSet<srRefNumberLocationCounting> srRefNumberLocationCounting { get; set; }
        public virtual DbSet<srRefNumberShelfPicking> srRefNumberShelfPicking { get; set; }
        public virtual DbSet<srRefNumberTransfers> srRefNumberTransfers { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<TransType> TransType { get; set; }
        public virtual DbSet<UserProductGroups> UserProductGroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<WarehouseLocationDefinition> WarehouseLocationDefinition { get; set; }
        public virtual DbSet<WarehouseLocationERP> WarehouseLocationERP { get; set; }
        public virtual DbSet<zt_RGN_PackageToInvoiceStatus> zt_RGN_PackageToInvoiceStatus { get; set; }
        public virtual DbSet<zt_RGN_PackageToInvoiceTransaction> zt_RGN_PackageToInvoiceTransaction { get; set; }
        public virtual DbSet<zt_RGN_PackageToShelfTransaction> zt_RGN_PackageToShelfTransaction { get; set; }
        public virtual DbSet<zt_RGN_srRefNumberPackageList> zt_RGN_srRefNumberPackageList { get; set; }
        public virtual DbSet<zt_RGN_trAssigmentOrderUser> zt_RGN_trAssigmentOrderUser { get; set; }
        public virtual DbSet<zt_RGN_trOrderPackageList> zt_RGN_trOrderPackageList { get; set; }
        public virtual DbSet<zt_RGN_trOrderPackageListQty> zt_RGN_trOrderPackageListQty { get; set; }
        public virtual DbSet<zt_RGN_trPickingToInvoiceListQty> zt_RGN_trPickingToInvoiceListQty { get; set; }
        public virtual DbSet<zt_RGN_trShelfPackageListQty> zt_RGN_trShelfPackageListQty { get; set; }
        public virtual DbSet<CargoCityAndDistrictList> CargoCityAndDistrictList { get; set; }
        public virtual DbSet<Tokens> Tokens { get; set; }
        public virtual DbSet<vw_WarehouseLocationName> vw_WarehouseLocationName { get; set; }
        public virtual DbSet<vw_WarehouseLocationWithProduct> vw_WarehouseLocationWithProduct { get; set; }
        public virtual DbSet<ReportParameters> ReportParameters { get; set; }
        public virtual DbSet<ReportQueries> ReportQueries { get; set; }
    
        public virtual ObjectResult<sp_GetWarehouseLocationID_Result> sp_GetWarehouseLocationID(string locationCode)
        {
            var locationCodeParameter = locationCode != null ?
                new ObjectParameter("LocationCode", locationCode) :
                new ObjectParameter("LocationCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetWarehouseLocationID_Result>("sp_GetWarehouseLocationID", locationCodeParameter);
        }
    
        public virtual ObjectResult<usp_FindEmptyLocation_Result> usp_FindEmptyLocation(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_FindEmptyLocation_Result>("usp_FindEmptyLocation", userNameParameter);
        }
    
        public virtual int usp_RGN_AttributesAndHierarchyDev(Nullable<int> groupType)
        {
            var groupTypeParameter = groupType.HasValue ?
                new ObjectParameter("GroupType", groupType) :
                new ObjectParameter("GroupType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_RGN_AttributesAndHierarchyDev", groupTypeParameter);
        }
    
        public virtual int usp_RGN_GetLocationInventory(string locationCode)
        {
            var locationCodeParameter = locationCode != null ?
                new ObjectParameter("LocationCode", locationCode) :
                new ObjectParameter("LocationCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_RGN_GetLocationInventory", locationCodeParameter);
        }
    
        public virtual ObjectResult<usp_RGN_LocationAndGroups_Result> usp_RGN_LocationAndGroups(string warehouseCode)
        {
            var warehouseCodeParameter = warehouseCode != null ?
                new ObjectParameter("WarehouseCode", warehouseCode) :
                new ObjectParameter("WarehouseCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_RGN_LocationAndGroups_Result>("usp_RGN_LocationAndGroups", warehouseCodeParameter);
        }
    
        public virtual ObjectResult<usp_RGN_LocationAndGroupsDev_Result> usp_RGN_LocationAndGroupsDev(string warehouseCode)
        {
            var warehouseCodeParameter = warehouseCode != null ?
                new ObjectParameter("WarehouseCode", warehouseCode) :
                new ObjectParameter("WarehouseCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_RGN_LocationAndGroupsDev_Result>("usp_RGN_LocationAndGroupsDev", warehouseCodeParameter);
        }
    }
}