using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace OfficialMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "ClanPosade",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanPosade", x => x.Id);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("ClanPosade");
        }
    }
}
