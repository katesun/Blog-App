using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlogApp.Migrations
{
    public partial class AmendcateogiresFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Categories\" (\"Name\") VALUES ('Temp')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
