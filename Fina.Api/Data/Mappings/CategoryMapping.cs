using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fina.Api.Data.Mappings;

public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category"); //Nome Tabela

        builder.HasKey(x => x.Id); //Chave primária

        builder.Property(x => x.Title)
            .IsRequired(true) //Obrigatório
            .HasColumnType("NVARCHAR") //Tipagem NVARCHAR
            .HasMaxLength(80); //Máximo de caracteres

        builder.Property(x => x.Description)
            .IsRequired(false) //Não obrigatório
            .HasColumnType("NVARCHAR") //Tipagem NVARCHAR
            .HasMaxLength(255); //Máximo de caracteres (255 é limite máximo para busca)

        builder.Property(x => x.UserId)
            .IsRequired(true) //Obrigatório 
            .HasColumnType("VARCHAR") //Tipagem NVARCHAR
            .HasMaxLength(160); //Máximo de caracteres
    }
}
