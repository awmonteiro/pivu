using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore.Metadata;
using Pivu.Areas.Identity.Data;

namespace Pivu.Data
{
    public class PivuContextIdentity : IdentityDbContext<PivuUserIdentity>
    {
        public PivuContextIdentity(DbContextOptions<PivuContextIdentity> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);     

            builder.Entity<PivuUserIdentity>(b =>
            {
                b.ToTable("USUARIO");
            });

            builder.Entity<PivuUserIdentity>(b =>
            {
                b.Property(e => e.Id).HasColumnName("ID_USUARIO");                
            });

            builder.Entity<PivuUserIdentity>().HasKey(b => b.Id);

            builder.Entity<PivuUserIdentity>().Property(p => p.UserName).HasColumnName("USERNAME");
            builder.Entity<PivuUserIdentity>().Property(p => p.NormalizedUserName).HasColumnName("NORMALIZEDUSERNAME");
            builder.Entity<PivuUserIdentity>().Property(p => p.Email).HasColumnName("EMAIL");
            builder.Entity<PivuUserIdentity>().Property(p => p.NormalizedEmail).HasColumnName("NORMALIZEDEMAIL");
            builder.Entity<PivuUserIdentity>().Property(p => p.EmailConfirmed).HasColumnName("EMAILCONFIRMED");
            builder.Entity<PivuUserIdentity>().Property(P => P.PasswordHash).HasColumnName("PASSWORDHASH");
            builder.Entity<PivuUserIdentity>().Property(p => p.SecurityStamp).HasColumnName("SECURITYSTAMP");
            builder.Entity<PivuUserIdentity>().Property(p => p.TwoFactorEnabled).HasColumnName("TWOFACTORENABLED");
            builder.Entity<PivuUserIdentity>().Property(p => p.ConcurrencyStamp).HasColumnName("CONCURRENCYSTAMP");
            builder.Entity<PivuUserIdentity>().Property(p => p.PhoneNumber).HasColumnName("PHONENUMBER");
            builder.Entity<PivuUserIdentity>().Property(p => p.PhoneNumberConfirmed).HasColumnName("PHONENUMBERCONFIRMED");
            builder.Entity<PivuUserIdentity>().Property(p => p.TwoFactorEnabled).HasColumnName("TWOFACTORENABLED");
            builder.Entity<PivuUserIdentity>().Property(p => p.LockoutEnd).HasColumnName("LOCKOUTEND");
            builder.Entity<PivuUserIdentity>().Property(p => p.LockoutEnabled).HasColumnName("LOCKOUTENABLED");                                  
            builder.Entity<PivuUserIdentity>().Property(p => p.AccessFailedCount).HasColumnName("ACCESSFAILEDCOUNT");
            builder.Entity<PivuUserIdentity>().Property(p => p.Nome).HasColumnName("NOME");
            builder.Entity<PivuUserIdentity>().Property(p => p.CPF).HasColumnName("CPF");
            builder.Entity<PivuUserIdentity>().Property(p => p.Nascimento).HasColumnName("NASCIMENTO");
            builder.Entity<PivuUserIdentity>().Property(p => p.id_endereco_pricipal).HasColumnName("ID_ENDERECO_PRINCIPAL");

            builder.Entity<IdentityRoleClaim<string>>().ToTable("ASPNETROLECLAIMS");
            builder.Entity<IdentityRoleClaim<string>>().Property(p => p.Id).HasColumnName("ID");
            builder.Entity<IdentityRoleClaim<string>>().Property(p => p.RoleId).HasColumnName("ROLEID");
            builder.Entity<IdentityRoleClaim<string>>().Property(p => p.ClaimType).HasColumnName("CLAIMTYPE");
            builder.Entity<IdentityRoleClaim<string>>().Property(p => p.ClaimValue).HasColumnName("CLAIMVALUE");

            builder.Entity<IdentityRole>().ToTable("ASPNETROLES");
            builder.Entity<IdentityRole>().Property(p => p.Id).HasColumnName("ID");
            builder.Entity<IdentityRole>().Property(p => p.Name).HasColumnName("NAME");
            builder.Entity<IdentityRole>().Property(p => p.NormalizedName).HasColumnName("NORMALIZEDNAME");
            builder.Entity<IdentityRole>().Property(p => p.ConcurrencyStamp).HasColumnName("CONCURRENCYSTAMP");

            builder.Entity<IdentityUserClaim<string>>().ToTable("ASPNETUSERCLAIMS");
            builder.Entity<IdentityUserClaim<string>>().Property(p => p.Id).HasColumnName("ID");
            builder.Entity<IdentityUserClaim<string>>().Property(p => p.UserId).HasColumnName("USERID");
            builder.Entity<IdentityUserClaim<string>>().Property(p => p.ClaimType).HasColumnName("CLAIMTYPE");
            builder.Entity<IdentityUserClaim<string>>().Property(p => p.ClaimValue).HasColumnName("CLAIMVALUE");

            builder.Entity<IdentityUserLogin<string>>().ToTable("ASPNETUSERLOGINS");
            builder.Entity<IdentityUserLogin<string>>().Property(p => p.LoginProvider).HasColumnName("LOGINPROVIDER");
            builder.Entity<IdentityUserLogin<string>>().Property(p => p.ProviderKey).HasColumnName("PROVIDERKEY");
            builder.Entity<IdentityUserLogin<string>>().Property(p => p.ProviderDisplayName).HasColumnName("PROVIDERDISPLAYNAME");
            builder.Entity<IdentityUserLogin<string>>().Property(p => p.UserId).HasColumnName("USERID");

            builder.Entity<IdentityUserRole<string>>().ToTable("ASPNETUSERROLES");
            builder.Entity<IdentityUserRole<string>>().Property(p => p.UserId).HasColumnName("USERID");
            builder.Entity<IdentityUserRole<string>>().Property(p => p.RoleId).HasColumnName("ROLEID");

            builder.Entity<IdentityUserToken<string>>().ToTable("ASPNETUSERTOKENS");
            builder.Entity<IdentityUserToken<string>>().Property(p => p.UserId).HasColumnName("USERID");
            builder.Entity<IdentityUserToken<string>>().Property(p => p.LoginProvider).HasColumnName("LOGINPROVIDER");
            builder.Entity<IdentityUserToken<string>>().Property(p => p.Name).HasColumnName("NAME");
            builder.Entity<IdentityUserToken<string>>().Property(p => p.Value).HasColumnName("VALUE");
                  

        }

    }
}
