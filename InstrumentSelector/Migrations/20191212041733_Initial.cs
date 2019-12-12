using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstrumentSelector.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    InstrumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Size = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    RangeDescription = table.Column<string>(nullable: true),
                    Tone = table.Column<string>(nullable: true),
                    ToneDescription = table.Column<string>(nullable: true),
                    Technical = table.Column<string>(nullable: true),
                    DescriptionText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.InstrumentID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentText = table.Column<string>(nullable: true),
                    CommentTime = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Instrument = table.Column<string>(nullable: true),
                    InstrumentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Instruments_InstrumentID",
                        column: x => x.InstrumentID,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Selections",
                columns: table => new
                {
                    SelectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PreferredSize = table.Column<string>(nullable: true),
                    PreferredRange = table.Column<string>(nullable: true),
                    PreferredTone = table.Column<string>(nullable: true),
                    PreferredTechnical = table.Column<string>(nullable: true),
                    PreferredInstrumentInstrumentID = table.Column<int>(nullable: true),
                    SecondInstrumentInstrumentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selections", x => x.SelectionID);
                    table.ForeignKey(
                        name: "FK_Selections_Instruments_PreferredInstrumentInstrumentID",
                        column: x => x.PreferredInstrumentInstrumentID,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Selections_Instruments_SecondInstrumentInstrumentID",
                        column: x => x.SecondInstrumentInstrumentID,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_InstrumentID",
                table: "Comments",
                column: "InstrumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Selections_PreferredInstrumentInstrumentID",
                table: "Selections",
                column: "PreferredInstrumentInstrumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Selections_SecondInstrumentInstrumentID",
                table: "Selections",
                column: "SecondInstrumentInstrumentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Selections");

            migrationBuilder.DropTable(
                name: "Instruments");
        }
    }
}
