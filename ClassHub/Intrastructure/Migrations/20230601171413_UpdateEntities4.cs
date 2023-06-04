using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_UserEntity_TeacherId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentStudent_UserEntity_StudentsId",
                table: "AssignmentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_UserEntity_StudentId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_UserEntity_TeacherId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Notices_UserEntity_TeacherId",
                table: "Notices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_Groups_GroupId",
                table: "UserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_Groups_Teacher_GroupId",
                table: "UserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_Roles_RoleId",
                table: "UserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_UserEntity_TeacherId",
                table: "UserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEntity",
                table: "UserEntity");

            migrationBuilder.RenameTable(
                name: "UserEntity",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_TeacherId",
                table: "Users",
                newName: "IX_Users_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_Teacher_GroupId",
                table: "Users",
                newName: "IX_Users_Teacher_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_GroupId",
                table: "Users",
                newName: "IX_Users_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Users_TeacherId",
                table: "Assignments",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentStudent_Users_StudentsId",
                table: "AssignmentStudent",
                column: "StudentsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Users_StudentId",
                table: "Marks",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Users_TeacherId",
                table: "Marks",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notices_Users_TeacherId",
                table: "Notices",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupId",
                table: "Users",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_Teacher_GroupId",
                table: "Users",
                column: "Teacher_GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_TeacherId",
                table: "Users",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Users_TeacherId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentStudent_Users_StudentsId",
                table: "AssignmentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Users_StudentId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Users_TeacherId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Notices_Users_TeacherId",
                table: "Notices");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_Teacher_GroupId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_TeacherId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UserEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TeacherId",
                table: "UserEntity",
                newName: "IX_UserEntity_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Teacher_GroupId",
                table: "UserEntity",
                newName: "IX_UserEntity_Teacher_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "UserEntity",
                newName: "IX_UserEntity_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_GroupId",
                table: "UserEntity",
                newName: "IX_UserEntity_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEntity",
                table: "UserEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_UserEntity_TeacherId",
                table: "Assignments",
                column: "TeacherId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentStudent_UserEntity_StudentsId",
                table: "AssignmentStudent",
                column: "StudentsId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_UserEntity_StudentId",
                table: "Marks",
                column: "StudentId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_UserEntity_TeacherId",
                table: "Marks",
                column: "TeacherId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notices_UserEntity_TeacherId",
                table: "Notices",
                column: "TeacherId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_Groups_GroupId",
                table: "UserEntity",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_Groups_Teacher_GroupId",
                table: "UserEntity",
                column: "Teacher_GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_Roles_RoleId",
                table: "UserEntity",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_UserEntity_TeacherId",
                table: "UserEntity",
                column: "TeacherId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
