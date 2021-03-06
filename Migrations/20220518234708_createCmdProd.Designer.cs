// <auto-generated />
using CommandeProduct.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommandeProduct.Migrations
{
    [DbContext(typeof(CPDbContext))]
    [Migration("20220518234708_createCmdProd")]
    partial class createCmdProd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CommandeProduct.Models.Client", b =>
                {
                    b.Property<string>("Cin")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientNom")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LocationPays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationRue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationVille")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type_C")
                        .HasColumnType("int");

                    b.HasKey("Cin");

                    b.ToTable("Client", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
