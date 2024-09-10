using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClinicalLink.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cuzin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ESPECIALIDADES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DESCRICAO = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESPECIALIDADES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "STATUS_CONSULTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    STATUS = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS_CONSULTA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_USUARIOS_SISTEMA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TIPO = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_USUARIOS_SISTEMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UNIVERSIDADES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "text", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNIVERSIDADES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AVALIACAO_ESPECIALISTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DESCRICAO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UsuarioAvaliacaoId = table.Column<int>(type: "integer", nullable: false),
                    EspecialistaAvaliadoId = table.Column<int>(type: "integer", nullable: false),
                    ESTRELAS = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AVALIACAO_ESPECIALISTA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONSULTAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DESCRICAO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    EspecialistaId = table.Column<int>(type: "integer", nullable: false),
                    DATA_CONSULTA = table.Column<string>(type: "text", nullable: false),
                    UsuarioConsultaId = table.Column<int>(type: "integer", nullable: false),
                    StatusConsultaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSULTAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONSULTAS_STATUS_CONSULTA_StatusConsultaId",
                        column: x => x.StatusConsultaId,
                        principalTable: "STATUS_CONSULTA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especialistas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioEspecialistaId = table.Column<int>(type: "integer", nullable: false),
                    DESCRICAO = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialistas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SUPERVISAO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DESCRICAO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UsuarioSupervisaoId = table.Column<int>(type: "integer", nullable: false),
                    UsuarioSupervisorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPERVISAO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS_SISTEMA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "text", nullable: false),
                    SENHA = table.Column<string>(type: "text", nullable: false),
                    EMAIL = table.Column<string>(type: "text", nullable: false),
                    FONE = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    SEXO = table.Column<string>(type: "text", nullable: false),
                    TipoId = table.Column<int>(type: "integer", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    SupervisaoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS_SISTEMA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USUARIOS_SISTEMA_SUPERVISAO_SupervisaoId",
                        column: x => x.SupervisaoId,
                        principalTable: "SUPERVISAO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_USUARIOS_SISTEMA_TIPO_USUARIOS_SISTEMA_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TIPO_USUARIOS_SISTEMA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AVALIACAO_ESPECIALISTA_EspecialistaAvaliadoId",
                table: "AVALIACAO_ESPECIALISTA",
                column: "EspecialistaAvaliadoId");

            migrationBuilder.CreateIndex(
                name: "IX_AVALIACAO_ESPECIALISTA_UsuarioAvaliacaoId",
                table: "AVALIACAO_ESPECIALISTA",
                column: "UsuarioAvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAS_EspecialistaId",
                table: "CONSULTAS",
                column: "EspecialistaId");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAS_StatusConsultaId",
                table: "CONSULTAS",
                column: "StatusConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAS_UsuarioConsultaId",
                table: "CONSULTAS",
                column: "UsuarioConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialistas_UsuarioEspecialistaId",
                table: "Especialistas",
                column: "UsuarioEspecialistaId");

            migrationBuilder.CreateIndex(
                name: "IX_SUPERVISAO_UsuarioSupervisaoId",
                table: "SUPERVISAO",
                column: "UsuarioSupervisaoId");

            migrationBuilder.CreateIndex(
                name: "IX_SUPERVISAO_UsuarioSupervisorId",
                table: "SUPERVISAO",
                column: "UsuarioSupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOS_SISTEMA_SupervisaoId",
                table: "USUARIOS_SISTEMA",
                column: "SupervisaoId");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOS_SISTEMA_TipoId",
                table: "USUARIOS_SISTEMA",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AVALIACAO_ESPECIALISTA_Especialistas_EspecialistaAvaliadoId",
                table: "AVALIACAO_ESPECIALISTA",
                column: "EspecialistaAvaliadoId",
                principalTable: "Especialistas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AVALIACAO_ESPECIALISTA_USUARIOS_SISTEMA_UsuarioAvaliacaoId",
                table: "AVALIACAO_ESPECIALISTA",
                column: "UsuarioAvaliacaoId",
                principalTable: "USUARIOS_SISTEMA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAS_Especialistas_EspecialistaId",
                table: "CONSULTAS",
                column: "EspecialistaId",
                principalTable: "Especialistas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAS_USUARIOS_SISTEMA_UsuarioConsultaId",
                table: "CONSULTAS",
                column: "UsuarioConsultaId",
                principalTable: "USUARIOS_SISTEMA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialistas_USUARIOS_SISTEMA_UsuarioEspecialistaId",
                table: "Especialistas",
                column: "UsuarioEspecialistaId",
                principalTable: "USUARIOS_SISTEMA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SUPERVISAO_USUARIOS_SISTEMA_UsuarioSupervisaoId",
                table: "SUPERVISAO",
                column: "UsuarioSupervisaoId",
                principalTable: "USUARIOS_SISTEMA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SUPERVISAO_USUARIOS_SISTEMA_UsuarioSupervisorId",
                table: "SUPERVISAO",
                column: "UsuarioSupervisorId",
                principalTable: "USUARIOS_SISTEMA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SUPERVISAO_USUARIOS_SISTEMA_UsuarioSupervisaoId",
                table: "SUPERVISAO");

            migrationBuilder.DropForeignKey(
                name: "FK_SUPERVISAO_USUARIOS_SISTEMA_UsuarioSupervisorId",
                table: "SUPERVISAO");

            migrationBuilder.DropTable(
                name: "AVALIACAO_ESPECIALISTA");

            migrationBuilder.DropTable(
                name: "CONSULTAS");

            migrationBuilder.DropTable(
                name: "ESPECIALIDADES");

            migrationBuilder.DropTable(
                name: "UNIVERSIDADES");

            migrationBuilder.DropTable(
                name: "Especialistas");

            migrationBuilder.DropTable(
                name: "STATUS_CONSULTA");

            migrationBuilder.DropTable(
                name: "USUARIOS_SISTEMA");

            migrationBuilder.DropTable(
                name: "SUPERVISAO");

            migrationBuilder.DropTable(
                name: "TIPO_USUARIOS_SISTEMA");
        }
    }
}
