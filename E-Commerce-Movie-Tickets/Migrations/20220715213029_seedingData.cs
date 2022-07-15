using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Movie_Tickets.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "profilePictureURL" },
                values: new object[,]
                {
                    { 1, "Bio 1", "Liam Hemsworth", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a1.jpg" },
                    { 2, "Bio 2", "Tom Cruise", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a2.jpg" },
                    { 3, "Bio 3", "Brad Pitt", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Description 1", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/1.jpg", "Cinema 1" },
                    { 2, "Description 2", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/2.jpg", "Cinema 2" },
                    { 3, "Description 3", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/3.jpg", "Cinema 3" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "profilePictureURL" },
                values: new object[,]
                {
                    { 1, "producer 1", "Producer 1", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg" },
                    { 2, "producer 2", "Producer 2", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg" },
                    { 3, "producer 3", "Producer 3", "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[] { 2, 2, "Description 2", new DateTime(2022, 7, 23, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8054), "", 3, "Movie 2", 30.0, 1, new DateTime(2022, 7, 16, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[] { 1, 1, "Description 1", new DateTime(2022, 7, 11, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(4028), "", 2, "Movie 1", 20.5, 2, new DateTime(2022, 7, 6, 0, 30, 28, 630, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[] { 3, 3, "Description 3", new DateTime(2022, 8, 5, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8076), "", 1, "Movie 3", 15.0, 3, new DateTime(2022, 7, 19, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 3 },
                    { 1, 3 },
                    { 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
