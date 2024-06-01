using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class InitEventAndComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Events",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Events",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");
        }
    }
}
