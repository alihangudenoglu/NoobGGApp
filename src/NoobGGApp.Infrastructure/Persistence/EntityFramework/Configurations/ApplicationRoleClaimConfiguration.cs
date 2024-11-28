using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoobGGApp.Domain.Identity;

namespace NoobGGApp.Infrastructure.Persistence.EntityFramework.Configurations;

public sealed class ApplicationRoleClaimConfiguration : IEntityTypeConfiguration<ApplicationRoleClaim>
{
    public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
    {
        // Primary key
        builder.HasKey(rc => rc.Id);
        // Maps to the AspNetRoleClaims table
        builder.ToTable("application_role_claims");
    }
}