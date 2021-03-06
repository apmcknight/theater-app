﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TheaterApp.Client.Migrations
{
    [DbContext(typeof(CustomersDatabaseContext))]
    [Migration("20210212035449_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("TheaterApp.Client.Models.Customers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("EMailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyContactFullName")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmergencyContactPhone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodAlergey")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasFoodAlergey")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSeasonTicketHolder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingAddress")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SeatingPreference")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
