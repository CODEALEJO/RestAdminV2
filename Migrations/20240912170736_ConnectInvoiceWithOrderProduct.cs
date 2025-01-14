using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class ConnectInvoiceWithOrderProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "order_products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "order_products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_order_products_InvoiceId",
                table: "order_products",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_products_invoices_InvoiceId",
                table: "order_products",
                column: "InvoiceId",
                principalTable: "invoices",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_products_invoices_InvoiceId",
                table: "order_products");

            migrationBuilder.DropIndex(
                name: "IX_order_products_InvoiceId",
                table: "order_products");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "order_products");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "order_products");
        }
    }
}
