
using SurveyBasket.Abstractions.Consts;

namespace SurveyBasket.Persistence.EntitiesConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.OwnsMany(x=>x.RefreshTokens).ToTable("RefreshTokens").WithOwner().HasForeignKey("UserId");

		builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);

		//Default Data

		var passwordHasher = new PasswordHasher<ApplicationUser>();
		builder.HasData(new ApplicationUser
		{
			Id = DefaultUsers.AdminId,
			FirstName = "Survey Basket",
			LastName = "Admin",
			UserName = DefaultUsers.AdminEmail,
			NormalizedUserName = DefaultUsers.AdminNormalizedEmail,
			Email = DefaultUsers.AdminEmail,
			NormalizedEmail = DefaultUsers.AdminNormalizedEmail,
			SecurityStamp = DefaultUsers.AdminSecurityStamp,
			ConcurrencyStamp = DefaultUsers.AdminConcurrencyStamp,
			EmailConfirmed = true,
			PasswordHash = DefaultUsers.AdminPasswordHash
		});
	}
}