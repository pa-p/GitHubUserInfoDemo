using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubUserInfoDemo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GitHubUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitHubId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GravatarId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowersUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowingUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GistsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarredUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReposUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivedEventsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hireable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicRepos = table.Column<long>(type: "bigint", nullable: false),
                    PublicGists = table.Column<long>(type: "bigint", nullable: false),
                    Followers = table.Column<long>(type: "bigint", nullable: false),
                    Following = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitHubUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GitHubRepo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GitHubId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrivateRepo = table.Column<bool>(type: "bit", nullable: false),
                    HtmlUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fork = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForksUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeysUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollaboratorsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HooksUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueEventsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssigneesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlobsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitTagsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitRefsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguagesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StargazersUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContributorsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscribersUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommitsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitCommitsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueCommentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompareUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MergesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchiveUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PullsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MilestonesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabelsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleasesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeploymentsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PushedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GitUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SshUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloneUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WatchersCount = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Forks = table.Column<long>(type: "bigint", nullable: false),
                    Watchers = table.Column<long>(type: "bigint", nullable: false),
                    DefaultBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitHubUserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitHubRepo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitHubRepo_GitHubUsers_GitHubUserId",
                        column: x => x.GitHubUserId,
                        principalTable: "GitHubUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GitHubRepo_GitHubUserId",
                table: "GitHubRepo",
                column: "GitHubUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GitHubRepo");

            migrationBuilder.DropTable(
                name: "GitHubUsers");
        }
    }
}
