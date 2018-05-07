using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlogApp.Migrations
{
    public partial class CategoriesFK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE \"Blogs\" SET \"CategoryID\" = 11 WHERE \"CategoryID\" IS NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
