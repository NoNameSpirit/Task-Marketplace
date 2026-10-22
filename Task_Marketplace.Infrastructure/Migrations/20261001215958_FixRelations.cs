using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResponse",
                table: "TaskResponse");

            migrationBuilder.RenameTable(
                name: "TaskResponse",
                newName: "TaskResponses");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResponse_TaskId",
                table: "TaskResponses",
                newName: "IX_TaskResponses_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResponses",
                table: "TaskResponses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponses_ProjectTasks_TaskId",
                table: "TaskResponses",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponses_ProjectTasks_TaskId",
                table: "TaskResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResponses",
                table: "TaskResponses");

            migrationBuilder.RenameTable(
                name: "TaskResponses",
                newName: "TaskResponse");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResponses_TaskId",
                table: "TaskResponse",
                newName: "IX_TaskResponse_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResponse",
                table: "TaskResponse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
