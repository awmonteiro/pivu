using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pivu.Migrations
{
    public partial class criaDBIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ASPNETROLES",
                columns: table => new
                {
                    ID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    NAME = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NORMALIZEDNAME = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    CONCURRENCYSTAMP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETROLES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    NOME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CPF = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NASCIMENTO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ID_ENDERECO_PRINCIPAL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    USERNAME = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NORMALIZEDUSERNAME = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NORMALIZEDEMAIL = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EMAILCONFIRMED = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PASSWORDHASH = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SECURITYSTAMP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CONCURRENCYSTAMP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PHONENUMBER = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PHONENUMBERCONFIRMED = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TWOFACTORENABLED = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LOCKOUTEND = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LOCKOUTENABLED = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    ACCESSFAILEDCOUNT = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "ASPNETROLECLAIMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    ROLEID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    CLAIMTYPE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CLAIMVALUE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETROLECLAIMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ASPNETROLECLAIMS_ASPNETROLES_ROLEID",
                        column: x => x.ROLEID,
                        principalTable: "ASPNETROLES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASPNETUSERCLAIMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    USERID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    CLAIMTYPE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CLAIMVALUE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETUSERCLAIMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ASPNETUSERCLAIMS_USUARIO_USERID",
                        column: x => x.USERID,
                        principalTable: "USUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASPNETUSERLOGINS",
                columns: table => new
                {
                    LOGINPROVIDER = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    PROVIDERKEY = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    PROVIDERDISPLAYNAME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    USERID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETUSERLOGINS", x => new { x.LOGINPROVIDER, x.PROVIDERKEY });
                    table.ForeignKey(
                        name: "FK_ASPNETUSERLOGINS_USUARIO_USERID",
                        column: x => x.USERID,
                        principalTable: "USUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASPNETUSERROLES",
                columns: table => new
                {
                    USERID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ROLEID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETUSERROLES", x => new { x.USERID, x.ROLEID });
                    table.ForeignKey(
                        name: "FK_ASPNETUSERROLES_ASPNETROLES_ROLEID",
                        column: x => x.ROLEID,
                        principalTable: "ASPNETROLES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASPNETUSERROLES_USUARIO_USERID",
                        column: x => x.USERID,
                        principalTable: "USUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASPNETUSERTOKENS",
                columns: table => new
                {
                    USERID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    LOGINPROVIDER = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    NAME = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    VALUE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETUSERTOKENS", x => new { x.USERID, x.LOGINPROVIDER, x.NAME });
                    table.ForeignKey(
                        name: "FK_ASPNETUSERTOKENS_USUARIO_USERID",
                        column: x => x.USERID,
                        principalTable: "USUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ASPNETROLECLAIMS_ROLEID",
                table: "ASPNETROLECLAIMS",
                column: "ROLEID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "ASPNETROLES",
                column: "NORMALIZEDNAME",
                unique: true,
                filter: "\"NORMALIZEDNAME\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ASPNETUSERCLAIMS_USERID",
                table: "ASPNETUSERCLAIMS",
                column: "USERID");

            migrationBuilder.CreateIndex(
                name: "IX_ASPNETUSERLOGINS_USERID",
                table: "ASPNETUSERLOGINS",
                column: "USERID");

            migrationBuilder.CreateIndex(
                name: "IX_ASPNETUSERROLES_ROLEID",
                table: "ASPNETUSERROLES",
                column: "ROLEID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "USUARIO",
                column: "NORMALIZEDEMAIL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "USUARIO",
                column: "NORMALIZEDUSERNAME",
                unique: true,
                filter: "\"NORMALIZEDUSERNAME\" IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASPNETROLECLAIMS");

            migrationBuilder.DropTable(
                name: "ASPNETUSERCLAIMS");

            migrationBuilder.DropTable(
                name: "ASPNETUSERLOGINS");

            migrationBuilder.DropTable(
                name: "ASPNETUSERROLES");

            migrationBuilder.DropTable(
                name: "ASPNETUSERTOKENS");

            migrationBuilder.DropTable(
                name: "ASPNETROLES");

            migrationBuilder.DropTable(
                name: "USUARIO");
        }
    }
}
