using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_STORE_PORTAL_Project_.Migrations
{
    /// <inheritdoc />
    public partial class initialsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    au_id = table.Column<int>(type: "int", nullable: false),
                    au_lname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    au_fname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    zip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contract = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.au_id);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false),
                    job_desc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    min_lvl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    max_lvl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.job_id);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    pub_id = table.Column<int>(type: "int", nullable: false),
                    pub_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.pub_id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    stor_id = table.Column<int>(type: "int", nullable: false),
                    stor_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    stor_address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    zip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.stor_id);
                });

            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    title_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    pub_id = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    advance = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    royalty = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ytd_sales = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    pubdate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles", x => x.title_id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    emp_id = table.Column<int>(type: "int", nullable: false),
                    fname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    minit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    lname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    job_id = table.Column<int>(type: "int", nullable: true),
                    job_lvl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    pub_id = table.Column<int>(type: "int", nullable: true),
                    hire_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.emp_id);
                    table.ForeignKey(
                        name: "FK_employee_jobs",
                        column: x => x.job_id,
                        principalTable: "jobs",
                        principalColumn: "job_id");
                    table.ForeignKey(
                        name: "FK_employee_publishers",
                        column: x => x.pub_id,
                        principalTable: "publishers",
                        principalColumn: "pub_id");
                });

            migrationBuilder.CreateTable(
                name: "pub_info",
                columns: table => new
                {
                    pub_id = table.Column<int>(type: "int", nullable: true),
                    logo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    pr_info = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_pub_info_publishers",
                        column: x => x.pub_id,
                        principalTable: "publishers",
                        principalColumn: "pub_id");
                });

            migrationBuilder.CreateTable(
                name: "discounts",
                columns: table => new
                {
                    dicounttype = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    stor_id = table.Column<int>(type: "int", nullable: true),
                    lowqty = table.Column<int>(type: "int", nullable: true),
                    highqty = table.Column<int>(type: "int", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_discounts_stores",
                        column: x => x.stor_id,
                        principalTable: "stores",
                        principalColumn: "stor_id");
                });

            migrationBuilder.CreateTable(
                name: "roysched",
                columns: table => new
                {
                    title_id = table.Column<int>(type: "int", nullable: true),
                    lorange = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    hirange = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    royalty = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_roysched_titles",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id");
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    ord_num = table.Column<int>(type: "int", nullable: false),
                    stor_id = table.Column<int>(type: "int", nullable: true),
                    ord_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    qty = table.Column<int>(type: "int", nullable: true),
                    payterms = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    title_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.ord_num);
                    table.ForeignKey(
                        name: "FK_sales_stores",
                        column: x => x.stor_id,
                        principalTable: "stores",
                        principalColumn: "stor_id");
                    table.ForeignKey(
                        name: "FK_sales_titles",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id");
                });

            migrationBuilder.CreateTable(
                name: "titleauthor",
                columns: table => new
                {
                    au_id = table.Column<int>(type: "int", nullable: true),
                    title_id = table.Column<int>(type: "int", nullable: true),
                    au_ord = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    royaltyper = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_titleauthor_authors",
                        column: x => x.au_id,
                        principalTable: "authors",
                        principalColumn: "au_id");
                    table.ForeignKey(
                        name: "FK_titleauthor_titles",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_discounts_stor_id",
                table: "discounts",
                column: "stor_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_job_id",
                table: "employee",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_pub_id",
                table: "employee",
                column: "pub_id");

            migrationBuilder.CreateIndex(
                name: "IX_pub_info_pub_id",
                table: "pub_info",
                column: "pub_id");

            migrationBuilder.CreateIndex(
                name: "IX_roysched_title_id",
                table: "roysched",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "IX_sales_stor_id",
                table: "sales",
                column: "stor_id");

            migrationBuilder.CreateIndex(
                name: "IX_sales_title_id",
                table: "sales",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "IX_titleauthor_au_id",
                table: "titleauthor",
                column: "au_id");

            migrationBuilder.CreateIndex(
                name: "IX_titleauthor_title_id",
                table: "titleauthor",
                column: "title_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "discounts");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "pub_info");

            migrationBuilder.DropTable(
                name: "roysched");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "titleauthor");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "publishers");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "titles");
        }
    }
}
