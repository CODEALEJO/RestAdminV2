using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnProductStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$q5R9ksGnqXnJyyvt0k5bEedWlN1xEbyBAcH0VJW10TzgAe8pt7/9m");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$6hUutDpT5onwM6CJQwlC.eYINVfdJyAQJTV19d0Hph6Gd4YWGy102");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$umbkz0iJ9aHz0yUW8cIBnuG5CMznSNV9fn6np7trvs58.7gT8dYqG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$ZmO9joUNFh1oH1p6tvaKlOPQHi1BbnsGsg4aoVP6ktJogAgPF1KjG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$7WFzOWsoK/vt6VF9l1Y/yOsIM18k.DiYWXAfdTM8AIRWlFsBjhCJy");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$WOrqiMT3bZAFhWRC8FpGHeHBRjvPqpvRj2lUDpqyV/c9ZcLuuxCfa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$j76cj4iHVmOtDirkSUaewOKvXS2eYP39VzWw.f6ACqpZ0/o5.rUgO");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$6Btndm1Rzug3CClecZNQreYGnFlYgbJImWSH5YGFX5mnmqYS3yWRG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$WJlvrqEYGhKZ.O1XhKTGUe1.81D1r/3f4ym.1jYMOQfp5QmmdLafq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$T7BvORAKxXxicM4TvWVzx.Sf.1k.Jt7ZLiGttY4ZgB3R6oz5spq4G");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$Fe0I5937bCV08sZIhB6sKukFWHVyCHGeJei71Y4iYYh2yu2sEPeTm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$2A8phYIMzK/zO3guESX/OuetQRMKZT77tEdtC0pbzhfaiK.wG6hyi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$CtUcHwUerOeJfsQGY7MNP.D9UMzdYgNsOnPu3DGZ3h1oqwqUV/.QG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$sYc3yc7Ziv07zHtbycTXweEkMxQjbUWC6AcZHVyuyViZKE6dZqmq2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$TjlYEyvE5kcKmLgeElBlxuGwn.TzpCg8VcqOD03u.FlPPxZO2KPw6");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$hwenwyxHkcMMIS5jq0Va7O7hevvGR0IWJ3SSmUTwK61Z.DQDUy4tG");
        }
    }
}
