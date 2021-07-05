﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{

    public class ImplementationOrderConfiguration : IEntityTypeConfiguration<ImplementationOrder>
    {
        public void Configure(EntityTypeBuilder<ImplementationOrder> builder)
        {
            builder.ToTable("IMPLEMENTATION_ORDER");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("CODE").HasColumnType("NUMBER(10)");

            builder.Property(t => t.Date).HasColumnName("DATE").HasColumnType("TIMESTAMP(7)");

            builder.Property(t => t.ClientCode).HasColumnName("CLIENT_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.AgencyCode).HasColumnName("AGENCY_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.AccountExecutiveCode).HasColumnName("AE_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.Tagline).HasColumnName("TAGLINE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.ProductCode).HasColumnName("PRODUCT_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.BookingOrderNo).HasColumnName("BO_NO").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.PurchaseOrderNo).HasColumnName("PO_NO").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.ReferenceCENo).HasColumnName("REF_NO").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.CreatedByCode).HasColumnName("CREATED_BY_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.UpdatedByCode).HasColumnName("UPDATED_BY_CODE").HasColumnType("VARCHAR2(20)");

            builder.HasBaseEntityProperties();

        }
    }
}