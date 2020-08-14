using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.DATA.Migrations
{
    public partial class ChangeNameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_==============OrderDetail table============ _Orders_OrderId",
                table: "==============OrderDetail table============ ");

            migrationBuilder.DropForeignKey(
                name: "FK_==============OrderDetail table============ _Table of products_ProductId",
                table: "==============OrderDetail table============ ");

            migrationBuilder.DropForeignKey(
                name: "FK_===========Product In Categories!==========_Category Table_CategoryId",
                table: "===========Product In Categories!==========");

            migrationBuilder.DropForeignKey(
                name: "FK_===========Product In Categories!==========_Table of products_ProductId",
                table: "===========Product In Categories!==========");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Table of products_ProductId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Category Table_CategoryId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Table of products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Table of products_ProductId",
                table: "ProductTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table of products",
                table: "Table of products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTranslations",
                table: "ProductTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category Table",
                table: "Category Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_===========Product In Categories!==========",
                table: "===========Product In Categories!==========");

            migrationBuilder.DropPrimaryKey(
                name: "PK_==============OrderDetail table============ ",
                table: "==============OrderDetail table============ ");

            migrationBuilder.RenameTable(
                name: "Table of products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "ProductTranslations",
                newName: "Product Translations");

            migrationBuilder.RenameTable(
                name: "Category Table",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "===========Product In Categories!==========",
                newName: "Product Categories");

            migrationBuilder.RenameTable(
                name: "==============OrderDetail table============ ",
                newName: "Order Detail");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "Product Translations",
                newName: "IX_Product Translations_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "Product Translations",
                newName: "IX_Product Translations_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_===========Product In Categories!==========_ProductId",
                table: "Product Categories",
                newName: "IX_Product Categories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_==============OrderDetail table============ _ProductId",
                table: "Order Detail",
                newName: "IX_Order Detail_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product Translations",
                table: "Product Translations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product Categories",
                table: "Product Categories",
                columns: new[] { "CategoryId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order Detail",
                table: "Order Detail",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Categories_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order Detail_Orders_OrderId",
                table: "Order Detail",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order Detail_Products_ProductId",
                table: "Order Detail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product Categories_Categories_CategoryId",
                table: "Product Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product Categories_Products_ProductId",
                table: "Product Categories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product Translations_Languages_LanguageId",
                table: "Product Translations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product Translations_Products_ProductId",
                table: "Product Translations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Categories_CategoryId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_Order Detail_Orders_OrderId",
                table: "Order Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order Detail_Products_ProductId",
                table: "Order Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Product Categories_Categories_CategoryId",
                table: "Product Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Product Categories_Products_ProductId",
                table: "Product Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Product Translations_Languages_LanguageId",
                table: "Product Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Product Translations_Products_ProductId",
                table: "Product Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product Translations",
                table: "Product Translations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product Categories",
                table: "Product Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order Detail",
                table: "Order Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Table of products");

            migrationBuilder.RenameTable(
                name: "Product Translations",
                newName: "ProductTranslations");

            migrationBuilder.RenameTable(
                name: "Product Categories",
                newName: "===========Product In Categories!==========");

            migrationBuilder.RenameTable(
                name: "Order Detail",
                newName: "==============OrderDetail table============ ");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category Table");

            migrationBuilder.RenameIndex(
                name: "IX_Product Translations_ProductId",
                table: "ProductTranslations",
                newName: "IX_ProductTranslations_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product Translations_LanguageId",
                table: "ProductTranslations",
                newName: "IX_ProductTranslations_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Product Categories_ProductId",
                table: "===========Product In Categories!==========",
                newName: "IX_===========Product In Categories!==========_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Order Detail_ProductId",
                table: "==============OrderDetail table============ ",
                newName: "IX_==============OrderDetail table============ _ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table of products",
                table: "Table of products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTranslations",
                table: "ProductTranslations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_===========Product In Categories!==========",
                table: "===========Product In Categories!==========",
                columns: new[] { "CategoryId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_==============OrderDetail table============ ",
                table: "==============OrderDetail table============ ",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category Table",
                table: "Category Table",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_==============OrderDetail table============ _Orders_OrderId",
                table: "==============OrderDetail table============ ",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_==============OrderDetail table============ _Table of products_ProductId",
                table: "==============OrderDetail table============ ",
                column: "ProductId",
                principalTable: "Table of products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_===========Product In Categories!==========_Category Table_CategoryId",
                table: "===========Product In Categories!==========",
                column: "CategoryId",
                principalTable: "Category Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_===========Product In Categories!==========_Table of products_ProductId",
                table: "===========Product In Categories!==========",
                column: "ProductId",
                principalTable: "Table of products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Table of products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Table of products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Category Table_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId",
                principalTable: "Category Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Table of products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Table of products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Table of products_ProductId",
                table: "ProductTranslations",
                column: "ProductId",
                principalTable: "Table of products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
