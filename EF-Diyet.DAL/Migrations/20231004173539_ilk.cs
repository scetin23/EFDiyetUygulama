using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Diyet.DAL.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BesinBilgi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BesinAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlcuBirimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramKarsiligi = table.Column<float>(type: "real", nullable: false),
                    Kalori = table.Column<float>(type: "real", nullable: true),
                    Karbonhidrat = table.Column<float>(type: "real", nullable: true),
                    Protein = table.Column<float>(type: "real", nullable: true),
                    Yag = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinBilgi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    KullaniciSoyadi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Boy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Makale",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakaleAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makale", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tarif",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarifAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarif", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciHedef",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hedef = table.Column<int>(type: "int", nullable: false),
                    HedefKatSayi = table.Column<float>(type: "real", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciHedef", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciHedef_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuketilenBesinler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    BesinBilgileriID = table.Column<int>(type: "int", nullable: false),
                    Ogun = table.Column<int>(type: "int", nullable: false),
                    ToplamKalori = table.Column<float>(type: "real", nullable: false),
                    TuketilenTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuketilenBesinler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TuketilenBesinler_BesinBilgi_BesinBilgileriID",
                        column: x => x.BesinBilgileriID,
                        principalTable: "BesinBilgi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuketilenBesinler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VucutAnalizleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VKI = table.Column<double>(type: "float", nullable: false),
                    VYO = table.Column<double>(type: "float", nullable: false),
                    BMH = table.Column<double>(type: "float", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VucutAnalizleri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VucutAnalizleri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciHedef_KullaniciId",
                table: "KullaniciHedef",
                column: "KullaniciId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TuketilenBesinler_BesinBilgileriID",
                table: "TuketilenBesinler",
                column: "BesinBilgileriID");

            migrationBuilder.CreateIndex(
                name: "IX_TuketilenBesinler_KullaniciID",
                table: "TuketilenBesinler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_VucutAnalizleri_KullaniciId",
                table: "VucutAnalizleri",
                column: "KullaniciId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciHedef");

            migrationBuilder.DropTable(
                name: "Makale");

            migrationBuilder.DropTable(
                name: "Tarif");

            migrationBuilder.DropTable(
                name: "TuketilenBesinler");

            migrationBuilder.DropTable(
                name: "VucutAnalizleri");

            migrationBuilder.DropTable(
                name: "BesinBilgi");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
