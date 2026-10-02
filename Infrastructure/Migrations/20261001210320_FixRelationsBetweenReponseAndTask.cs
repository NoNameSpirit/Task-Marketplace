using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelationsBetweenReponseAndTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponse_ProjectTasks_ProjectTaskId",
                table: "TaskResponse");

            migrationBuilder.DropIndex(
                name: "IX_TaskResponse_ProjectTaskId",
                table: "TaskResponse");

            migrationBuilder.DropColumn(
                name: "ProjectTaskId",
                table: "TaskResponse");

            migrationBuilder.CreateIndex(
                name: "IX_TaskResponse_TaskId",
                table: "TaskResponse",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse");

            migrationBuilder.DropIndex(
                name: "IX_TaskResponse_TaskId",
                table: "TaskResponse");

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectTaskId",
                table: "TaskResponse",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskResponse_ProjectTaskId",
                table: "TaskResponse",
                column: "ProjectTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponse_ProjectTasks_ProjectTaskId",
                table: "TaskResponse",
                column: "ProjectTaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id");
        }
    }
}
