// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Ropes.API.Data;

namespace Ropes.API.Migrations
{
    [DbContext(typeof(OperationContext))]
    [Migration("20210709022025_CreatePermissionTable")]
    partial class CreatePermissionTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("USER_ID");

                    b.Property<string>("RoleId")
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR2(11)")
                        .HasColumnName("ROLE_ID");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Value")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.AccountExecutive", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(6)
                        .HasColumnType("NVARCHAR2(6)")
                        .HasColumnName("SP_CODE");

                    b.Property<string>("AreaCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("SP_MA_CODE");

                    b.Property<string>("Company")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CO");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("SP_FIRST_NAME");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("SP_LAST_NAME");

                    b.Property<string>("MiddleInitial")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("SP_MID_INITIAL");

                    b.Property<string>("RegionCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("SP_MA_SR_CODE");

                    b.HasKey("Code");

                    b.ToTable("SPERSONS");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Customer", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR2(40)")
                        .HasColumnName("CUS_CODE");

                    b.Property<string>("AECode")
                        .HasMaxLength(6)
                        .HasColumnType("NVARCHAR2(6)")
                        .HasColumnName("CUS_SP_CODE");

                    b.Property<string>("AEName")
                        .HasMaxLength(1050)
                        .HasColumnType("NVARCHAR2(1050)")
                        .HasColumnName("SP_NAME");

                    b.Property<string>("AreaCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("CUS_MA_CODE");

                    b.Property<string>("BillingAddress")
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)")
                        .HasColumnName("CUS_BILLING_ADDR");

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("CUS_CONTACT");

                    b.Property<decimal?>("CreditLimit")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("CUS_CREDIT_LIMIT");

                    b.Property<string>("CreditStatus")
                        .HasMaxLength(5)
                        .HasColumnType("NVARCHAR2(5)")
                        .HasColumnName("CUS_CREDIT_STATUS");

                    b.Property<string>("CreditTermsCode")
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR2(8)")
                        .HasColumnName("CUS_CT_CODE");

                    b.Property<string>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("CUS_FAX");

                    b.Property<string>("GroupCode")
                        .HasMaxLength(5)
                        .HasColumnType("NVARCHAR2(5)")
                        .HasColumnName("CUS_CG_CODE");

                    b.Property<string>("IsActive")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CUS_ACTIVE");

                    b.Property<string>("IsVatInclusive")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CUS_VAT_INCLUSIVE");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("CUS_NAME");

                    b.Property<string>("RegionCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("CUS_MA_SR_CODE");

                    b.Property<string>("TIN")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("CUS_TIN");

                    b.Property<string>("Telephone")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("CUS_TELEPHONE");

                    b.Property<string>("Type")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CUS_TYPE");

                    b.HasKey("Code");

                    b.ToTable("EZ_DEBTORS_VW");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("\"NormalizedName\" IS NOT NULL");

                    b.ToTable("EZ_ROLES");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("ID");

                    b.Property<int>("AccessFailedCount")
                        .HasMaxLength(50)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ACCESSFAILEDCOUNT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("CONCURRENTCURRENCYSTAMP");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("EMAIL");

                    b.Property<bool>("EmailConfirmed")
                        .HasMaxLength(50)
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("EMAILCONFIRMED");

                    b.Property<DateTime?>("EnrolledOn")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("AU_ENROLLED_ON");

                    b.Property<DateTime?>("LockedOn")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("AU_LOCKED_ON");

                    b.Property<bool>("LockoutEnabled")
                        .HasMaxLength(50)
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("LOCKOUTENABLED");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE")
                        .HasColumnName("LOCKOUTEND");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("AU_NAME");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("NORMALIZEDEMAIL");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("NORMALIZEDUSERNAME");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("AU_PASSWORD");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("PHONENUMBER");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasMaxLength(50)
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("PHONENUMBERCONFIRMED");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("SECURITYSTAMP");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasMaxLength(50)
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("TWOFACTORENABLED");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("\"NORMALIZEDUSERNAME\" IS NOT NULL");

                    b.ToTable("EZ_USERS");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.ImplementationOrder", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CODE")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountExecutiveCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("AE_CODE");

                    b.Property<string>("AgencyCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("AGENCY_CODE");

                    b.Property<string>("BookingOrderNo")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("BO_NO");

                    b.Property<string>("ClientCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("CLIENT_CODE");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("CREATED_AT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedByCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("CREATED_BY_CODE");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATE");

                    b.Property<string>("ProductCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("PRODUCT_CODE");

                    b.Property<string>("PurchaseOrderNo")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("PO_NO");

                    b.Property<string>("ReferenceCENo")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("REF_NO");

                    b.Property<string>("Tagline")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("TAGLINE");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("UPDATED_AT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedByCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("UPDATED_BY_CODE");

                    b.HasKey("Code");

                    b.ToTable("IMPLEMENTATION_ORDER");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.ImplementationOrderBooking", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CODE")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("CREATED_AT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedByCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("UPDATED_BY_CODE");

                    b.Property<int>("Duration")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("DURATION");

                    b.Property<bool>("Friday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("FRIDAY");

                    b.Property<decimal>("Gross")
                        .HasColumnType("NUMBER(18,2)")
                        .HasColumnName("GROSS");

                    b.Property<int>("ImplementationOrderCode")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IMPLEMENTATION_ORDER_CODE");

                    b.Property<bool>("Monday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("MONDAY");

                    b.Property<DateTime>("PeriodEnd")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("PERIOD_END");

                    b.Property<DateTime>("PeriodStart")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("PERIOD_START");

                    b.Property<bool>("Saturday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("SATURDAY");

                    b.Property<int>("Spot")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("SPOT");

                    b.Property<string>("StationCode")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("STATION_CODE");

                    b.Property<bool>("Sunday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("SUNDAY");

                    b.Property<bool>("Thursday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("THURSDAY");

                    b.Property<bool>("Tuesday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("TUESDAY");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("UPDATED_AT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("Wednesday")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("WEDNESDAY");

                    b.HasKey("Code");

                    b.HasIndex("ImplementationOrderCode");

                    b.ToTable("IMPLEMENTATION_ORDER_BOOKING");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.MediaAgency", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR2(40)")
                        .HasColumnName("CODE");

                    b.Property<string>("ContactNo")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("CONTACT_NO");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR2(40)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("FAX");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("NAME");

                    b.Property<string>("Remarks")
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)")
                        .HasColumnName("REMARKS");

                    b.HasKey("Code");

                    b.ToTable("MEDIAAGENCY");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Permission", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CODE")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR2(20)")
                        .HasColumnName("NAME");

                    b.HasKey("Code");

                    b.ToTable("PERMISSION");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.RadioStation", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("STN_CODE");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR2(60)")
                        .HasColumnName("STN_NAME");

                    b.HasKey("Code");

                    b.ToTable("EZ_STATIONS");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.RolePermission", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CODE")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Add")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("ADD");

                    b.Property<bool>("Delete")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("DELETE");

                    b.Property<bool>("Edit")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("EDIT");

                    b.Property<int>("PermissionCode")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PERMISSION_CODE");

                    b.Property<bool>("View")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("VIEW");

                    b.HasKey("Code");

                    b.HasIndex("PermissionCode");

                    b.ToTable("ROLEPERMISSION");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Vendor", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR2(8)")
                        .HasColumnName("VCODE");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("VADDR");

                    b.Property<string>("Company")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CO");

                    b.Property<string>("Contact")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("VCONTACT");

                    b.Property<string>("FAX")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("VFAX");

                    b.Property<string>("IsUtility")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("IS_UTILITY");

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("NVARCHAR2(35)")
                        .HasColumnName("VNAME");

                    b.Property<string>("PayTo")
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR2(40)")
                        .HasColumnName("PAYTO");

                    b.Property<string>("TIN")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("VTIN");

                    b.Property<string>("Telephone")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("VTEL");

                    b.Property<string>("Type")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("VTYPE");

                    b.HasKey("Code");

                    b.ToTable("VENDORS");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Identity.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.Property<int>("BranchId")
                        .HasMaxLength(11)
                        .HasColumnType("NUMBER")
                        .HasColumnName("BRANCH_ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATE")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedById")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("CREATED_BY");

                    b.Property<string>("Type")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("TYPE");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATE")
                        .HasColumnName("UPDATED_AT");

                    b.Property<string>("UpdatedById")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("UPDATED_BY");

                    b.ToTable("EZ_USER_ROLES");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UBSI_Ops.server.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.ImplementationOrderBooking", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.ImplementationOrder", "ImplementationOrder")
                        .WithMany()
                        .HasForeignKey("ImplementationOrderCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImplementationOrder");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.RolePermission", b =>
                {
                    b.HasOne("UBSI_Ops.server.Entities.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", null)
                        .WithOne()
                        .HasForeignKey("UBSI_Ops.server.Entities.Identity.UserRole", "UserId", "RoleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
