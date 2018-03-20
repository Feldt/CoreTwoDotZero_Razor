using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BoolList_Razor_2.Migrations
{
    public partial class ChangedNanmeAvaibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Avainility",
                table: "Books",
                newName: "Avaibility");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Avaibility",
                table: "Books",
                newName: "Avainility");
        }
    }
}
