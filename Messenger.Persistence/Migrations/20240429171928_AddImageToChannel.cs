﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messenger.Persistence.Migrations;

/// <inheritdoc />
public partial class AddImageToChannel : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "Image",
            table: "Channels",
            type: "nvarchar(max)",
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Image",
            table: "Channels");
    }
}
