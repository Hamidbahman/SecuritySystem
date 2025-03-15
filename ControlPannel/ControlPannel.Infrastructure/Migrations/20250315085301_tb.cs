using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlPannel.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actees_ApplicationPackages_ApplicationPackageId",
                table: "Actees");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationPackages_Applications_ApplicationId",
                table: "ApplicationPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_LoginPolicies_Users_UserId",
                table: "LoginPolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_Masks_Permissions_PermissionId",
                table: "Masks");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Actees_ActeeId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Actees_ActeeId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Applications_ApplicationId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbConfigurationLock_Applications_ApplicationId",
                table: "tbConfigurationLock");

            migrationBuilder.DropForeignKey(
                name: "FK_tbConfigurationPassword_Applications_ApplicationId",
                table: "tbConfigurationPassword");

            migrationBuilder.DropForeignKey(
                name: "FK_tbConfigurationSession_Applications_ApplicationId",
                table: "tbConfigurationSession");

            migrationBuilder.DropForeignKey(
                name: "FK_tbService_Actees_ActeeId",
                table: "tbService");

            migrationBuilder.DropForeignKey(
                name: "FK_tbUserBiometric_Users_UserId",
                table: "tbUserBiometric");

            migrationBuilder.DropForeignKey(
                name: "FK_tbUserProperty_Users_UserId1",
                table: "tbUserProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Masks",
                table: "Masks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginPolicies",
                table: "LoginPolicies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationPackages",
                table: "ApplicationPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actees",
                table: "Actees");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tbUser");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "tbUserRole");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "tbRole");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "tbPermission");

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "tbMenu");

            migrationBuilder.RenameTable(
                name: "Masks",
                newName: "tbMask");

            migrationBuilder.RenameTable(
                name: "LoginPolicies",
                newName: "tbLoginPolicy");

            migrationBuilder.RenameTable(
                name: "Applications",
                newName: "tbApplications");

            migrationBuilder.RenameTable(
                name: "ApplicationPackages",
                newName: "tbApplicationPackage");

            migrationBuilder.RenameTable(
                name: "Actees",
                newName: "tbActee");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "tbUser",
                newName: "IX_tbUser_Email");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "tbUserRole",
                newName: "IX_tbUserRole_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "tbUserRole",
                newName: "IX_tbUserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_ApplicationId",
                table: "tbRole",
                newName: "IX_tbRole_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_RoleId",
                table: "tbPermission",
                newName: "IX_tbPermission_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_ActeeId",
                table: "tbPermission",
                newName: "IX_tbPermission_ActeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_ActeeId",
                table: "tbMenu",
                newName: "IX_tbMenu_ActeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Masks_PermissionId",
                table: "tbMask",
                newName: "IX_tbMask_PermissionId");

            migrationBuilder.RenameIndex(
                name: "IX_LoginPolicies_UserId",
                table: "tbLoginPolicy",
                newName: "IX_tbLoginPolicy_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationPackages_ApplicationId",
                table: "tbApplicationPackage",
                newName: "IX_tbApplicationPackage_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Actees_ApplicationPackageId",
                table: "tbActee",
                newName: "IX_tbActee_ApplicationPackageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbUser",
                table: "tbUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbUserRole",
                table: "tbUserRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbRole",
                table: "tbRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbPermission",
                table: "tbPermission",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbMenu",
                table: "tbMenu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbMask",
                table: "tbMask",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbLoginPolicy",
                table: "tbLoginPolicy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbApplications",
                table: "tbApplications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbApplicationPackage",
                table: "tbApplicationPackage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbActee",
                table: "tbActee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbActee_tbApplicationPackage_ApplicationPackageId",
                table: "tbActee",
                column: "ApplicationPackageId",
                principalTable: "tbApplicationPackage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbApplicationPackage_tbApplications_ApplicationId",
                table: "tbApplicationPackage",
                column: "ApplicationId",
                principalTable: "tbApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbConfigurationLock_tbApplications_ApplicationId",
                table: "tbConfigurationLock",
                column: "ApplicationId",
                principalTable: "tbApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbConfigurationPassword_tbApplications_ApplicationId",
                table: "tbConfigurationPassword",
                column: "ApplicationId",
                principalTable: "tbApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbConfigurationSession_tbApplications_ApplicationId",
                table: "tbConfigurationSession",
                column: "ApplicationId",
                principalTable: "tbApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbLoginPolicy_tbUser_UserId",
                table: "tbLoginPolicy",
                column: "UserId",
                principalTable: "tbUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbMask_tbPermission_PermissionId",
                table: "tbMask",
                column: "PermissionId",
                principalTable: "tbPermission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbMenu_tbActee_ActeeId",
                table: "tbMenu",
                column: "ActeeId",
                principalTable: "tbActee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbPermission_tbActee_ActeeId",
                table: "tbPermission",
                column: "ActeeId",
                principalTable: "tbActee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbPermission_tbRole_RoleId",
                table: "tbPermission",
                column: "RoleId",
                principalTable: "tbRole",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbRole_tbApplications_ApplicationId",
                table: "tbRole",
                column: "ApplicationId",
                principalTable: "tbApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbService_tbActee_ActeeId",
                table: "tbService",
                column: "ActeeId",
                principalTable: "tbActee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbUserBiometric_tbUser_UserId",
                table: "tbUserBiometric",
                column: "UserId",
                principalTable: "tbUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbUserProperty_tbUser_UserId1",
                table: "tbUserProperty",
                column: "UserId1",
                principalTable: "tbUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbUserRole_tbRole_RoleId",
                table: "tbUserRole",
                column: "RoleId",
                principalTable: "tbRole",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbUserRole_tbUser_UserId",
                table: "tbUserRole",
                column: "UserId",
                principalTable: "tbUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbActee_tbApplicationPackage_ApplicationPackageId",
                table: "tbActee");

            migrationBuilder.DropForeignKey(
                name: "FK_tbApplicationPackage_tbApplications_ApplicationId",
                table: "tbApplicationPackage");

            migrationBuilder.DropForeignKey(
                name: "FK_tbConfigurationLock_tbApplications_ApplicationId",
                table: "tbConfigurationLock");

            migrationBuilder.DropForeignKey(
                name: "FK_tbConfigurationPassword_tbApplications_ApplicationId",
                table: "tbConfigurationPassword");

            migrationBuilder.DropForeignKey(
                name: "FK_tbConfigurationSession_tbApplications_ApplicationId",
                table: "tbConfigurationSession");

            migrationBuilder.DropForeignKey(
                name: "FK_tbLoginPolicy_tbUser_UserId",
                table: "tbLoginPolicy");

            migrationBuilder.DropForeignKey(
                name: "FK_tbMask_tbPermission_PermissionId",
                table: "tbMask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbMenu_tbActee_ActeeId",
                table: "tbMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_tbPermission_tbActee_ActeeId",
                table: "tbPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_tbPermission_tbRole_RoleId",
                table: "tbPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_tbRole_tbApplications_ApplicationId",
                table: "tbRole");

            migrationBuilder.DropForeignKey(
                name: "FK_tbService_tbActee_ActeeId",
                table: "tbService");

            migrationBuilder.DropForeignKey(
                name: "FK_tbUserBiometric_tbUser_UserId",
                table: "tbUserBiometric");

            migrationBuilder.DropForeignKey(
                name: "FK_tbUserProperty_tbUser_UserId1",
                table: "tbUserProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_tbUserRole_tbRole_RoleId",
                table: "tbUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_tbUserRole_tbUser_UserId",
                table: "tbUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbUserRole",
                table: "tbUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbUser",
                table: "tbUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbRole",
                table: "tbRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbPermission",
                table: "tbPermission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbMenu",
                table: "tbMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbMask",
                table: "tbMask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbLoginPolicy",
                table: "tbLoginPolicy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbApplications",
                table: "tbApplications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbApplicationPackage",
                table: "tbApplicationPackage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbActee",
                table: "tbActee");

            migrationBuilder.RenameTable(
                name: "tbUserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "tbUser",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "tbRole",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "tbPermission",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "tbMenu",
                newName: "Menus");

            migrationBuilder.RenameTable(
                name: "tbMask",
                newName: "Masks");

            migrationBuilder.RenameTable(
                name: "tbLoginPolicy",
                newName: "LoginPolicies");

            migrationBuilder.RenameTable(
                name: "tbApplications",
                newName: "Applications");

            migrationBuilder.RenameTable(
                name: "tbApplicationPackage",
                newName: "ApplicationPackages");

            migrationBuilder.RenameTable(
                name: "tbActee",
                newName: "Actees");

            migrationBuilder.RenameIndex(
                name: "IX_tbUserRole_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tbUserRole_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_tbUser_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_tbRole_ApplicationId",
                table: "Roles",
                newName: "IX_Roles_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_tbPermission_RoleId",
                table: "Permissions",
                newName: "IX_Permissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_tbPermission_ActeeId",
                table: "Permissions",
                newName: "IX_Permissions_ActeeId");

            migrationBuilder.RenameIndex(
                name: "IX_tbMenu_ActeeId",
                table: "Menus",
                newName: "IX_Menus_ActeeId");

            migrationBuilder.RenameIndex(
                name: "IX_tbMask_PermissionId",
                table: "Masks",
                newName: "IX_Masks_PermissionId");

            migrationBuilder.RenameIndex(
                name: "IX_tbLoginPolicy_UserId",
                table: "LoginPolicies",
                newName: "IX_LoginPolicies_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tbApplicationPackage_ApplicationId",
                table: "ApplicationPackages",
                newName: "IX_ApplicationPackages_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_tbActee_ApplicationPackageId",
                table: "Actees",
                newName: "IX_Actees_ApplicationPackageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Masks",
                table: "Masks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginPolicies",
                table: "LoginPolicies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationPackages",
                table: "ApplicationPackages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actees",
                table: "Actees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actees_ApplicationPackages_ApplicationPackageId",
                table: "Actees",
                column: "ApplicationPackageId",
                principalTable: "ApplicationPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationPackages_Applications_ApplicationId",
                table: "ApplicationPackages",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginPolicies_Users_UserId",
                table: "LoginPolicies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Masks_Permissions_PermissionId",
                table: "Masks",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Actees_ActeeId",
                table: "Menus",
                column: "ActeeId",
                principalTable: "Actees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Actees_ActeeId",
                table: "Permissions",
                column: "ActeeId",
                principalTable: "Actees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Applications_ApplicationId",
                table: "Roles",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbConfigurationLock_Applications_ApplicationId",
                table: "tbConfigurationLock",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbConfigurationPassword_Applications_ApplicationId",
                table: "tbConfigurationPassword",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbConfigurationSession_Applications_ApplicationId",
                table: "tbConfigurationSession",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbService_Actees_ActeeId",
                table: "tbService",
                column: "ActeeId",
                principalTable: "Actees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbUserBiometric_Users_UserId",
                table: "tbUserBiometric",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbUserProperty_Users_UserId1",
                table: "tbUserProperty",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
