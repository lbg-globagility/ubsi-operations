using AutoMapper;
using UBSI_Ops.server.AccountExecutives.Models;
using UBSI_Ops.server.BillingStatements;
using UBSI_Ops.server.BillingStatements.Models;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.CertificatesofPerformance.Models;
using UBSI_Ops.server.Customers.Models;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.ImplementationOrders;
using UBSI_Ops.server.ImplementationOrders.Models;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.RadioStations.Models;
using UBSI_Ops.server.Roles.Models;
using UBSI_Ops.server.UserRoles.Models;
using UBSI_Ops.server.Users.Models;
using UBSI_Ops.server.Vendors.Models;

namespace UBSI_Ops.server.AutoMapperProfile
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("My Profile")
        {
        }

        private AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<MediaAgency, MediaAgencyDto>();
            CreateMap<MediaAgencyDto, MediaAgency>();
            CreateMap<RadioStation, RadioStationDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<User, UserDto>();
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Vendor, VendorDto>();
            CreateMap<AccountExecutive, AccountExecutiveDto>();
            CreateMap<MediaAgency, MediaAgencyDto>();
            CreateMap<CertificateOfPerformance, CertificateOfPerformanceDto>();

            CreateMap<Role, RoleDto>();
            CreateMap<CreateImplementationOrderDto, ImplementationOrder>();
            CreateMap<CreateImplementationOrderDto.BookingDto, ImplementationOrderBooking>();

            CreateMap<ImplementationOrder, ImplementationOrderDto>();
            CreateMap<ImplementationOrderBooking, ImplementationOrderDto.BookingDto>();

            CreateMap<Role, RoleDto>();
            CreateMap<Role, CreateRoleDto>();

            CreateMap<BillingStatement, BillingStatementDto>();
        }
    }
}
