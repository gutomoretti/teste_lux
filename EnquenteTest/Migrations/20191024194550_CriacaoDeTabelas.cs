using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnquenteTest.Migrations
{
    public partial class CriacaoDeTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enquete",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Poll_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enquente_Pergunta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnqueteId = table.Column<int>(nullable: false),
                    Option_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquente_Pergunta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enquente_Pergunta_Enquete_EnqueteId",
                        column: x => x.EnqueteId,
                        principalTable: "Enquete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enquete_Alternativa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnquentePerguntaId = table.Column<int>(nullable: false),
                    Enquente_PerguntaId = table.Column<int>(nullable: true),
                    Option_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquete_Alternativa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enquete_Alternativa_Enquente_Pergunta_Enquente_PerguntaId",
                        column: x => x.Enquente_PerguntaId,
                        principalTable: "Enquente_Pergunta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enquete_Resposta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enquete_AlternativaId = table.Column<int>(nullable: false),
                    Enquente_PerguntaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquete_Resposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enquete_Resposta_Enquente_Pergunta_Enquente_PerguntaId",
                        column: x => x.Enquente_PerguntaId,
                        principalTable: "Enquente_Pergunta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enquete_Resposta_Enquete_Alternativa_Enquete_AlternativaId",
                        column: x => x.Enquete_AlternativaId,
                        principalTable: "Enquete_Alternativa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enquente_Pergunta_EnqueteId",
                table: "Enquente_Pergunta",
                column: "EnqueteId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_Alternativa_Enquente_PerguntaId",
                table: "Enquete_Alternativa",
                column: "Enquente_PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_Resposta_Enquente_PerguntaId",
                table: "Enquete_Resposta",
                column: "Enquente_PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquete_Resposta_Enquete_AlternativaId",
                table: "Enquete_Resposta",
                column: "Enquete_AlternativaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enquete_Resposta");

            migrationBuilder.DropTable(
                name: "Enquete_Alternativa");

            migrationBuilder.DropTable(
                name: "Enquente_Pergunta");

            migrationBuilder.DropTable(
                name: "Enquete");
        }
    }
}
