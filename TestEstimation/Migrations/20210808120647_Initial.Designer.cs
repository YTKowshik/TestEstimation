﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEstimation.Data;

namespace TestEstimation.Migrations
{
    [DbContext(typeof(CreateMeetingContext))]
    [Migration("20210808120647_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
