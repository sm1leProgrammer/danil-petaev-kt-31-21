﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PetaevDanilKt_31_21.Database;

#nullable disable

namespace PetaevDanilKt_31_21.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор предмета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DisciplineName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("disciplineName")
                        .HasComment("Название предмета");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bool")
                        .HasColumnName("isDeleted")
                        .HasComment("Удален ли предмет");

                    b.Property<bool>("IsHumanities")
                        .HasColumnType("bool")
                        .HasColumnName("isHumanities")
                        .HasComment("Гуманитарное направление");

                    b.Property<bool>("IsTechnical")
                        .HasColumnType("bool")
                        .HasColumnName("isTechnical")
                        .HasComment("Техническое направление");

                    b.HasKey("Id")
                        .HasName("pk_Discipline_discipline_id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор оценки");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int4")
                        .HasColumnName("disciplineId")
                        .HasComment("Идентификатор предмета");

                    b.Property<int>("Score")
                        .HasColumnType("int4")
                        .HasColumnName("score")
                        .HasComment("Оценка");

                    b.Property<int>("StudentId")
                        .HasColumnType("int4")
                        .HasColumnName("studentId")
                        .HasComment("Идентификатор студента");

                    b.HasKey("Id")
                        .HasName("pk_Grade_grade_id");

                    b.HasIndex(new[] { "DisciplineId" }, "ind_Grade_fk_discipline_id");

                    b.HasIndex(new[] { "StudentId" }, "ind_Grade_fk_student_id");

                    b.ToTable("Grade", (string)null);
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор группы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Название группы");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bool")
                        .HasColumnName("isDeleted")
                        .HasComment("Удалена ли группа");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("speciality")
                        .HasComment("Специальность группы");

                    b.Property<int?>("StartYear")
                        .IsRequired()
                        .HasColumnType("int4")
                        .HasColumnName("startYear")
                        .HasComment("Год начала обучения");

                    b.Property<int>("YearGraduation")
                        .HasColumnType("int4")
                        .HasColumnName("yearGraduation")
                        .HasComment("Год выпуска");

                    b.HasKey("Id")
                        .HasName("pk_Group_group_id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор записи студента");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("firstName")
                        .HasComment("Имя студента");

                    b.Property<int>("GroupId")
                        .HasColumnType("int4")
                        .HasColumnName("groupId")
                        .HasComment("Идентификатор группы");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bool")
                        .HasColumnName("isDeleted")
                        .HasComment("Удален ли пользователь");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("lastName")
                        .HasComment("Фамилия студента");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("middleName")
                        .HasComment("Отчество студента");

                    b.HasKey("Id")
                        .HasName("pk_Student_student_id");

                    b.HasIndex("GroupId")
                        .HasDatabaseName("ind_Student_fk_group_id");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasComment("Идентификатор зачета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bool")
                        .HasColumnName("isPassed")
                        .HasComment("Зачет сдан/не сдан");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_Test_test_id");

                    b.HasIndex("DisciplineId")
                        .HasDatabaseName("ind_Test_fk_discipline_id");

                    b.HasIndex("StudentId")
                        .HasDatabaseName("ind_Test_fk_student_id");

                    b.ToTable("Test", (string)null);
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Grade", b =>
                {
                    b.HasOne("PetaevDanilKt_31_21.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetaevDanilKt_31_21.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Student", b =>
                {
                    b.HasOne("PetaevDanilKt_31_21.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Student_group");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("PetaevDanilKt_31_21.Models.Test", b =>
                {
                    b.HasOne("PetaevDanilKt_31_21.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Test_discipline");

                    b.HasOne("PetaevDanilKt_31_21.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Test_student");

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
