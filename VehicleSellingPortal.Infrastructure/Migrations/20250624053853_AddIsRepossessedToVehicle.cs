using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleSellingPortal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsRepossessedToVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRepossessed",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRepossessed",
                table: "Vehicles");
        }
    }
}
