using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SWAD_L4.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FillDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "AttractionId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Батут", 150m },
                    { 2, "Лабіринт", 200m },
                    { 3, "Колесо огляду", 250m },
                    { 4, "Гойдалки", 100m },
                    { 5, "Зимова карусель", 180m }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CostumeName", "Price" },
                values: new object[,]
                {
                    { 1, "Міккі Маус", 300m },
                    { 2, "Поні Іскорка", 350m },
                    { 3, "Соня з Ведмедиком", 250m },
                    { 4, "Кіт Матроскін", 270m },
                    { 5, "Снігуронька", 400m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "CustomerName", "CustomerPhone", "Date", "ProgramType", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, "Олена", "0987654821", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 2, 2, "Іван", "1234567860", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 3, 3, "Марія", "0987654341", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 4, 4, "Андрій", "1234567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 5, 5, "Наталя", "0987654321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "ZoneId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ігрова зона", 200m },
                    { 2, "Спортивна зона", 150m },
                    { 3, "Зона релаксу", 175m },
                    { 4, "Квест-зона", 300m },
                    { 5, "Тематична зона", 290m }
                });

            migrationBuilder.InsertData(
                table: "OrderAttractions",
                columns: new[] { "AttractionId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderCharacters",
                columns: new[] { "CharacterId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderZones",
                columns: new[] { "OrderId", "ZoneId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderAttractions",
                keyColumns: new[] { "AttractionId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderAttractions",
                keyColumns: new[] { "AttractionId", "OrderId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "OrderAttractions",
                keyColumns: new[] { "AttractionId", "OrderId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "OrderAttractions",
                keyColumns: new[] { "AttractionId", "OrderId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "OrderAttractions",
                keyColumns: new[] { "AttractionId", "OrderId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "OrderCharacters",
                keyColumns: new[] { "CharacterId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderCharacters",
                keyColumns: new[] { "CharacterId", "OrderId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OrderCharacters",
                keyColumns: new[] { "CharacterId", "OrderId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "OrderCharacters",
                keyColumns: new[] { "CharacterId", "OrderId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "OrderCharacters",
                keyColumns: new[] { "CharacterId", "OrderId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "OrderZones",
                keyColumns: new[] { "OrderId", "ZoneId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderZones",
                keyColumns: new[] { "OrderId", "ZoneId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "OrderZones",
                keyColumns: new[] { "OrderId", "ZoneId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "OrderZones",
                keyColumns: new[] { "OrderId", "ZoneId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OrderZones",
                keyColumns: new[] { "OrderId", "ZoneId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "AttractionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "ZoneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "ZoneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "ZoneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "ZoneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "ZoneId",
                keyValue: 5);
        }
    }
}
