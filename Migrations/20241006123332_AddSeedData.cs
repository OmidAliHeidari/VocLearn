using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VocabCard.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "CardId", "Example", "Mean", "UploadTime", "Word" },
                values: new object[,]
                {
                    { 1, "Finding the keys was pure serendipity.", "An unexpected pleasant discovery.", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serendipity" },
                    { 2, "The ephemeral beauty of autumn leaves.", "Lasting for a very short time.", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ephemeral" },
                    { 3, "The petrichor after the rain was refreshing.", "The pleasant smell after rain.", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrichor" },
                    { 4, "Winning the game filled him with euphoria.", "A feeling of intense excitement and happiness.", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Euphoria" },
                    { 5, "He spoke with a hint of melancholy in his voice.", "A deep, long-lasting sadness.", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melancholy" },
                    { 6, "The beauty of the sunset was ineffable.", "Too great or extreme to be expressed in words.", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ineffable" },
                    { 7, "She experienced limerence for the first time.", "The state of being infatuated or obsessed with another person.", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limerence" },
                    { 8, "He was the quintessential gentleman.", "Representing the most perfect or typical example of something.", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quintessential" },
                    { 9, "He enjoyed the solitude of the mountains.", "The state of being alone without feeling lonely.", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solitude" },
                    { 10, "Navigating the city was like moving through a labyrinth.", "A complex maze.", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labyrinth" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "CardId",
                keyValue: 10);
        }
    }
}
