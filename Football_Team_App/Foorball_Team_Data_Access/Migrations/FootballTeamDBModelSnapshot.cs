// <auto-generated />
using Foorball_Team_Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Foorball_Team_Data_Access.Migrations
{
    [DbContext(typeof(FootballTeamDB))]
    partial class FootballTeamDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Football_Team_Domain.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = "03-10-1981",
                            Firstname = "Zlatan",
                            Lastname = "Ibrahimovic",
                            Value = 2500000.0
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = "08-05-2000",
                            Firstname = "Sandro",
                            Lastname = "Tonali",
                            Value = 65000000.0
                        });
                });

            modelBuilder.Entity("Football_Team_Domain.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoundedYear")
                        .HasColumnType("int");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Milano",
                            FoundedYear = 1899,
                            History = "AC Milan was founded as Milan Foot-Ball and Cricket Club in 1899 by English expatriates Alfred Edwards and Herbert Kilpin. The club claims 16 December of that year as their foundation date, but historical evidence seems to suggest that the club was actually founded a few days earlier, most likely on 13 December.",
                            Name = "AC Milan",
                            Stadium = "San Siro"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
