using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Examen2.Migrations
{
    public partial class materiasDB_Damaso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    estudiante_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.estudiante_id);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    materia_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    codigo = table.Column<string>(nullable: true),
                    nombre_materia = table.Column<string>(nullable: true),
                    creditos = table.Column<int>(nullable: false),
                    estudiante_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.materia_id);
                    table.ForeignKey(
                        name: "FK_Materia_Estudiante_estudiante_id",
                        column: x => x.estudiante_id,
                        principalTable: "Estudiante",
                        principalColumn: "estudiante_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materia_estudiante_id",
                table: "Materia",
                column: "estudiante_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
