using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastruct;

public class TokenMap : IEntityTypeConfiguration<Token>
{
    public void Configure(EntityTypeBuilder<Token> builder)
    {
        builder.Property(c => c.UserId)
            .HasColumnName("user_id");

        builder.Property(c => c.ExpiresIn)
            .HasColumnName("expires_in");

        builder.Property(c => c.AccessToken)
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .IsRequired()
            .HasColumnName("access_token");

        builder.Property(c => c.RefreshToken)
            .HasColumnType("varchar(200)")
            .HasMaxLength(200)
            .IsRequired()
            .HasColumnName("refresh_token");
    }
}