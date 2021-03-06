// <auto-generated />
using EsFinaleMeteo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EsFinaleMeteo.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("EsFinaleMeteo.Model.DCitta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("adminArea")
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .HasColumnType("TEXT");

                    b.Property<double>("lat")
                        .HasColumnType("REAL");

                    b.Property<double>("lon")
                        .HasColumnType("REAL");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .HasColumnType("TEXT");

                    b.Property<string>("timezone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("DatiCittà");
                });

            modelBuilder.Entity("EsFinaleMeteo.Model.DMeteo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("cloudiness")
                        .HasColumnType("INTEGER");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("maxDewPoint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("maxFeelsLikeTemp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("maxRelHumidity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("maxTemp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("maxWindGust")
                        .HasColumnType("INTEGER");

                    b.Property<int>("maxWindSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("minDewPoint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("minFeelsLikeTemp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("minRelHumidity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("minTemp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("minVisibility")
                        .HasColumnType("INTEGER");

                    b.Property<int>("moonPhase")
                        .HasColumnType("INTEGER");

                    b.Property<string>("moonrise")
                        .HasColumnType("TEXT");

                    b.Property<string>("moonset")
                        .HasColumnType("TEXT");

                    b.Property<double>("precipAccum")
                        .HasColumnType("REAL");

                    b.Property<int>("precipProb")
                        .HasColumnType("INTEGER");

                    b.Property<double>("pressure")
                        .HasColumnType("REAL");

                    b.Property<int>("snowAccum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sunrise")
                        .HasColumnType("TEXT");

                    b.Property<int>("sunriseEpoch")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sunset")
                        .HasColumnType("TEXT");

                    b.Property<int>("sunsetEpoch")
                        .HasColumnType("INTEGER");

                    b.Property<string>("symbol")
                        .HasColumnType("TEXT");

                    b.Property<string>("symbolPhrase")
                        .HasColumnType("TEXT");

                    b.Property<int>("uvIndex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("windDir")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("DatiMeteo");
                });

            modelBuilder.Entity("EsFinaleMeteo.Model.MeteoCittà", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idCitta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idMeteo")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("MetCitta");
                });

            modelBuilder.Entity("EsFinaleMeteo.Model.UtCitta", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<int>("idCit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("idUt")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("UtentiCitta");
                });
#pragma warning restore 612, 618
        }
    }
}
