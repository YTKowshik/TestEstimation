// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEstimation.Data;

namespace TestEstimation.Migrations
{
    [DbContext(typeof(CreateMeetingContext))]
    partial class CreateMeetingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("EstimationModels.Meeting", b =>
                {
                    b.Property<string>("MeetingId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("MeetingId");

                    b.ToTable("Meetings");
                });
#pragma warning restore 612, 618
        }
    }
}
