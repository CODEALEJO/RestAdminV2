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
            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_tables_id",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "tables_id",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 8,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 9,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 10,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 11,
                column: "status",
                value: 0);

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
                value: "$2a$11$.tdMbb9tosaCTbrGbnOWbOo0miZdxpLvCVxPlZJy60fAgUQDFMAeK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$5XPL5xPS2XHvmniZzKVIM.62RsEmuzlgwwBsacbQGpMkxU6jf48dq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$MIFcILY/heweAzEnvBQ2fOY75vS1KejQdO00u.GNlRJlaOZ6817wa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$9N1vxRKXTWwedlBipvRrr.FZqRztZF0BiZt8A.NDBMFjEinJoq8G2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$jXZkgbjIHytGbsoyVq26Le9vO6aryHKB18gLTR/qQgMU8.qNgvY.S");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$A/iIanilCjNYYRazD2ETkOuCMg5XJ5dwdv7OhI1H.hirUxNcgjKJW");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$m31IdQhcM4yWs6kh3pTxrOoywlJd9Z05Nv3Ok2bAJzp8MP1UedbOi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$5k5KeG.IrAYJJYeMfQYzt.RROX4tKV4CqUs3NYepuiMr1IswQDL1u");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_tables_id",
                table: "orders",
                column: "tables_id",
                principalTable: "tables",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_tables_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "status",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "tables_id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$LDbukTZ6/hgaRKDsyXYGqedi/HqVkCRuFb3Ds1Qics6cAZ95fhoju");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$0dajCxatcj0AG6QVbabsIuPeZiayjmzO4Cj/Q954SAxcecWbQAtMa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$PfqGBGy1VUrSlP5ZTXrPhODdS.9mvbpH45CqSB9WyFbiwC5yfr6/W");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$M7q6FzkKDIucKBMLMXx8SOZntRn254iy94km21CLa9k6LKJUE2MWS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$P38WO93YMUvNDuGJyjyArOLfMDtoToRtiMuKzf3ug.RW24wF0C32O");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$lxgUkXh4qua.rm6HDNA06.V5MYYWpIHrigc72S2sSj/AJDPsvYiKa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$r4vrnnMq7AmFpIo2eLzR9eh.OTy5EPHBZfJ9Nyt3JOj6psbH.7Jhm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$AYIvdtJxEzg1LsdL96IQJ.HIQ4Cw69lJwF0P10Y3U0fQLWPBOZehi");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_tables_id",
                table: "orders",
                column: "tables_id",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
