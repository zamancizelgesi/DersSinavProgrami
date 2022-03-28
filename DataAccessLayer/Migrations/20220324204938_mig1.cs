using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersliks",
                columns: table => new
                {
                    DerslikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DerslikBina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DerslikKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DerslikTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kapasite = table.Column<int>(type: "int", nullable: true),
                    KullanimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SinavKapasitesi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersliks", x => x.DerslikId);
                });

            migrationBuilder.CreateTable(
                name: "Donems",
                columns: table => new
                {
                    DonemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonemAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donems", x => x.DonemId);
                });

            migrationBuilder.CreateTable(
                name: "Fakultes",
                columns: table => new
                {
                    FakulteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakulteAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultes", x => x.FakulteId);
                });

            migrationBuilder.CreateTable(
                name: "SablonZamans",
                columns: table => new
                {
                    SablonZamanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersBaslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DersBitis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gun = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SablonZamans", x => x.SablonZamanId);
                });

            migrationBuilder.CreateTable(
                name: "Akademisyens",
                columns: table => new
                {
                    AkademisyenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademisyenAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkademisyenSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkademisyenMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asistan = table.Column<bool>(type: "bit", nullable: true),
                    AkademisyenUnvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akademisyens", x => x.AkademisyenId);
                    table.ForeignKey(
                        name: "FK_Akademisyens_Donems_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donems",
                        principalColumn: "DonemId");
                });

            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FakulteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.BolumId);
                    table.ForeignKey(
                        name: "FK_Bolums_Fakultes_FakulteId",
                        column: x => x.FakulteId,
                        principalTable: "Fakultes",
                        principalColumn: "FakulteId");
                });

            migrationBuilder.CreateTable(
                name: "DerslikKisits",
                columns: table => new
                {
                    DerslikKisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SablonZamanId = table.Column<int>(type: "int", nullable: false),
                    DerslikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerslikKisits", x => x.DerslikKisitId);
                    table.ForeignKey(
                        name: "FK_DerslikKisits_Dersliks_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Dersliks",
                        principalColumn: "DerslikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DerslikKisits_SablonZamans_SablonZamanId",
                        column: x => x.SablonZamanId,
                        principalTable: "SablonZamans",
                        principalColumn: "SablonZamanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkademisyenKisits",
                columns: table => new
                {
                    AkademisyenKisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SablonZamanId = table.Column<int>(type: "int", nullable: true),
                    AkademisyenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademisyenKisits", x => x.AkademisyenKisitId);
                    table.ForeignKey(
                        name: "FK_AkademisyenKisits_Akademisyens_AkademisyenId",
                        column: x => x.AkademisyenId,
                        principalTable: "Akademisyens",
                        principalColumn: "AkademisyenId");
                    table.ForeignKey(
                        name: "FK_AkademisyenKisits_SablonZamans_SablonZamanId",
                        column: x => x.SablonZamanId,
                        principalTable: "SablonZamans",
                        principalColumn: "SablonZamanId");
                });

            migrationBuilder.CreateTable(
                name: "BolumKisits",
                columns: table => new
                {
                    BolumKisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SablonZamanId = table.Column<int>(type: "int", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolumKisits", x => x.BolumKisitId);
                    table.ForeignKey(
                        name: "FK_BolumKisits_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "BolumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BolumKisits_SablonZamans_SablonZamanId",
                        column: x => x.SablonZamanId,
                        principalTable: "SablonZamans",
                        principalColumn: "SablonZamanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Derses",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UygulamaSaati = table.Column<int>(type: "int", nullable: true),
                    TeorikSaati = table.Column<int>(type: "int", nullable: true),
                    ÖğrenciSayisi = table.Column<int>(type: "int", nullable: true),
                    Kontenjan = table.Column<int>(type: "int", nullable: true),
                    BolumId = table.Column<int>(type: "int", nullable: true),
                    AkademisyenId = table.Column<int>(type: "int", nullable: true),
                    DonemId = table.Column<int>(type: "int", nullable: true),
                    DersTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersSube = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derses", x => x.DersId);
                    table.ForeignKey(
                        name: "FK_Derses_Akademisyens_AkademisyenId",
                        column: x => x.AkademisyenId,
                        principalTable: "Akademisyens",
                        principalColumn: "AkademisyenId");
                    table.ForeignKey(
                        name: "FK_Derses_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "BolumId");
                    table.ForeignKey(
                        name: "FK_Derses_Donems_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donems",
                        principalColumn: "DonemId");
                });

            migrationBuilder.CreateTable(
                name: "DerslikDersKisits",
                columns: table => new
                {
                    DerslikDersKisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DerslikId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerslikDersKisits", x => x.DerslikDersKisitId);
                    table.ForeignKey(
                        name: "FK_DerslikDersKisits_Derses_DersId",
                        column: x => x.DersId,
                        principalTable: "Derses",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DerslikDersKisits_Dersliks_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Dersliks",
                        principalColumn: "DerslikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersProgramis",
                columns: table => new
                {
                    DersProgramiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersGunu = table.Column<int>(type: "int", nullable: true),
                    DersSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: true),
                    DerslikId = table.Column<int>(type: "int", nullable: true),
                    DonemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgramis", x => x.DersProgramiId);
                    table.ForeignKey(
                        name: "FK_DersProgramis_Derses_DersId",
                        column: x => x.DersId,
                        principalTable: "Derses",
                        principalColumn: "DersId");
                    table.ForeignKey(
                        name: "FK_DersProgramis_Dersliks_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Dersliks",
                        principalColumn: "DerslikId");
                    table.ForeignKey(
                        name: "FK_DersProgramis_Donems_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donems",
                        principalColumn: "DonemId");
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciNumarasi = table.Column<int>(type: "int", nullable: true),
                    AkademisyenId = table.Column<int>(type: "int", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciId);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Akademisyens_AkademisyenId",
                        column: x => x.AkademisyenId,
                        principalTable: "Akademisyens",
                        principalColumn: "AkademisyenId");
                    table.ForeignKey(
                        name: "FK_Ogrencis_Derses_DersId",
                        column: x => x.DersId,
                        principalTable: "Derses",
                        principalColumn: "DersId");
                });

            migrationBuilder.CreateTable(
                name: "SinavProgramis",
                columns: table => new
                {
                    SinavProgramiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinavGunu = table.Column<int>(type: "int", nullable: true),
                    SinavSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: true),
                    DerslikId = table.Column<int>(type: "int", nullable: true),
                    DonemId = table.Column<int>(type: "int", nullable: true),
                    AkademisyenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavProgramis", x => x.SinavProgramiId);
                    table.ForeignKey(
                        name: "FK_SinavProgramis_Akademisyens_AkademisyenId",
                        column: x => x.AkademisyenId,
                        principalTable: "Akademisyens",
                        principalColumn: "AkademisyenId");
                    table.ForeignKey(
                        name: "FK_SinavProgramis_Derses_DersId",
                        column: x => x.DersId,
                        principalTable: "Derses",
                        principalColumn: "DersId");
                    table.ForeignKey(
                        name: "FK_SinavProgramis_Dersliks_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Dersliks",
                        principalColumn: "DerslikId");
                    table.ForeignKey(
                        name: "FK_SinavProgramis_Donems_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donems",
                        principalColumn: "DonemId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AkademisyenKisits_AkademisyenId",
                table: "AkademisyenKisits",
                column: "AkademisyenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademisyenKisits_SablonZamanId",
                table: "AkademisyenKisits",
                column: "SablonZamanId");

            migrationBuilder.CreateIndex(
                name: "IX_Akademisyens_DonemId",
                table: "Akademisyens",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_BolumKisits_BolumId",
                table: "BolumKisits",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_BolumKisits_SablonZamanId",
                table: "BolumKisits",
                column: "SablonZamanId");

            migrationBuilder.CreateIndex(
                name: "IX_Bolums_FakulteId",
                table: "Bolums",
                column: "FakulteId");

            migrationBuilder.CreateIndex(
                name: "IX_Derses_AkademisyenId",
                table: "Derses",
                column: "AkademisyenId");

            migrationBuilder.CreateIndex(
                name: "IX_Derses_BolumId",
                table: "Derses",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Derses_DonemId",
                table: "Derses",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_DerslikDersKisits_DersId",
                table: "DerslikDersKisits",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_DerslikDersKisits_DerslikId",
                table: "DerslikDersKisits",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_DerslikKisits_DerslikId",
                table: "DerslikKisits",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_DerslikKisits_SablonZamanId",
                table: "DerslikKisits",
                column: "SablonZamanId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramis_DersId",
                table: "DersProgramis",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramis_DerslikId",
                table: "DersProgramis",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramis_DonemId",
                table: "DersProgramis",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_AkademisyenId",
                table: "Ogrencis",
                column: "AkademisyenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_DersId",
                table: "Ogrencis",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_SinavProgramis_AkademisyenId",
                table: "SinavProgramis",
                column: "AkademisyenId");

            migrationBuilder.CreateIndex(
                name: "IX_SinavProgramis_DersId",
                table: "SinavProgramis",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_SinavProgramis_DerslikId",
                table: "SinavProgramis",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_SinavProgramis_DonemId",
                table: "SinavProgramis",
                column: "DonemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AkademisyenKisits");

            migrationBuilder.DropTable(
                name: "BolumKisits");

            migrationBuilder.DropTable(
                name: "DerslikDersKisits");

            migrationBuilder.DropTable(
                name: "DerslikKisits");

            migrationBuilder.DropTable(
                name: "DersProgramis");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "SinavProgramis");

            migrationBuilder.DropTable(
                name: "SablonZamans");

            migrationBuilder.DropTable(
                name: "Derses");

            migrationBuilder.DropTable(
                name: "Dersliks");

            migrationBuilder.DropTable(
                name: "Akademisyens");

            migrationBuilder.DropTable(
                name: "Bolums");

            migrationBuilder.DropTable(
                name: "Donems");

            migrationBuilder.DropTable(
                name: "Fakultes");
        }
    }
}
