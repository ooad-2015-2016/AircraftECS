using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Official.PosadaBaza.Models;

namespace OfficialMigrations
{
    [ContextType(typeof(ClanPosadeDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160602151459_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Official.PosadaBaza.Models.ClanPosade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("fourSqaureId");

                    b.Key("Id");
                });
        }
    }
}
