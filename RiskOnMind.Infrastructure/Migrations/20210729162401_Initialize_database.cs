using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RiskOnMind.Infrastructure.Migrations
{
    public partial class Initialize_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ToDoId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Priority = table.Column<int>(maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ToDoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
