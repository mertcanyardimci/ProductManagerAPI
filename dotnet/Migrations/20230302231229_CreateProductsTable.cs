using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    memberId = table.Column<int>(type: "int", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TownName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "float", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CityName", "Km", "ModelName", "Price", "Text", "Title", "TownName", "Year", "cityId", "memberId" },
                values: new object[,]
                {
                    { 1, "iste", 53811, "harum", 197352f, "Aut quasi ipsa quaerat non. Aperiam qui et aliquid. Commodi sed rerum quo sit amet dolores nostrum quas dicta.", "tenetur", "est", 2016, 62, 123458 },
                    { 2, "nihil", 10728, "aut", 737042f, "Animi velit quidem reprehenderit. Fugiat rerum odio et. Qui et dolorem. Sed molestiae libero quae voluptatem sunt cumque quia quis. Aperiam quos non fuga sit iusto. Qui quia molestiae.", "consequatur", "pariatur", 1995, 46, 123458 },
                    { 3, "numquam", 44819, "qui", 267125f, "Aliquam dolorum eos omnis veniam ullam dignissimos ut. Et autem ea nesciunt. Maiores architecto dolor totam blanditiis quae voluptatem quos. Nobis expedita rerum dolores animi fugit et repudiandae. Nostrum doloremque et ex molestiae.", "ut", "quasi", 2010, 35, 123457 },
                    { 4, "numquam", 20327, "nihil", 493470f, "Dolores eos eligendi pariatur rerum reiciendis et ipsum. Unde aspernatur distinctio. İste ut dolor impedit corrupti explicabo ut. Eligendi totam pariatur possimus dolores corrupti perspiciatis pariatur et. Ea voluptatem rerum earum consequatur non molestiae praesentium.", "sit", "pariatur", 2015, 60, 123457 },
                    { 5, "tenetur", 54117, "ut", 947468f, "Ut quia corporis error aperiam. Minus id natus sapiente. Totam dolore voluptas et totam quia ut. Delectus et officiis at soluta suscipit vel harum ducimus doloribus.", "voluptatem", "aut", 1991, 66, 123456 },
                    { 6, "id", 93106, "reiciendis", 355994f, "Possimus nostrum voluptas atque dicta molestias esse nemo. Sed aut soluta deleniti laudantium eos aut expedita non. Quibusdam et fugit distinctio. Ad a tempora itaque mollitia amet facilis natus rem velit. Enim consequuntur quasi a sit optio.", "dicta", "sed", 2020, 21, 123457 },
                    { 7, "dolor", 90669, "in", 980527f, "Autem facilis placeat quasi voluptas quasi. Quia minima officiis. Animi recusandae error consectetur blanditiis adipisci tenetur. Nobis excepturi et qui. Voluptate soluta recusandae.", "voluptas", "modi", 2000, 22, 123458 },
                    { 8, "labore", 81792, "laborum", 673977f, "Eum officia dolorem voluptate praesentium porro magnam aperiam. Voluptatum non id neque quidem quaerat iusto provident alias ab. Et quia asperiores.", "dignissimos", "et", 2017, 46, 123456 },
                    { 9, "rerum", 43144, "ut", 964703f, "Amet voluptatum cupiditate. İpsam velit fuga eos nobis. Qui et temporibus consectetur fuga quia vel debitis.", "occaecati", "iusto", 2021, 40, 123459 },
                    { 10, "rerum", 9460, "aut", 471425f, "Magni ipsum aut eligendi voluptatibus. Hic corrupti iure sunt provident aut possimus neque. Dolore sapiente dolores molestiae praesentium. Eligendi qui expedita omnis amet.", "eaque", "velit", 2003, 45, 123459 },
                    { 11, "eum", 88856, "veritatis", 809749f, "Natus non qui aut et aspernatur commodi vel in. Consequatur eveniet officiis ducimus. Qui accusamus eligendi temporibus animi itaque natus molestias sunt. Tempora necessitatibus labore qui. Molestiae aliquam in.", "in", "harum", 1993, 72, 123458 },
                    { 12, "sed", 88632, "dolores", 586025f, "Tenetur temporibus ducimus odit pariatur alias similique provident suscipit. Sint fuga repudiandae quia dicta quae at. Commodi illo veniam sapiente laudantium ipsa nostrum sit deserunt iusto. Enim mollitia accusantium iusto.", "suscipit", "molestias", 2009, 54, 123456 },
                    { 13, "cum", 97388, "voluptatem", 682426f, "Voluptatem sed dicta dolor. Provident nemo ipsa qui dolores minus tenetur nihil et error. Commodi nostrum veniam et aut ea possimus perferendis voluptatem enim. Quia animi repellendus et. Vero temporibus dolores asperiores minima. Doloribus asperiores veritatis autem optio quo possimus.", "sunt", "voluptas", 2008, 1, 123458 },
                    { 14, "illo", 83144, "perferendis", 920966f, "Explicabo dolorem est unde facilis tempora. Commodi quidem beatae esse. Cum qui ducimus nihil ratione qui veritatis. Culpa soluta maxime qui aut. Consectetur libero atque laudantium cum necessitatibus.", "non", "molestias", 2016, 60, 123459 },
                    { 15, "nostrum", 37394, "velit", 672280f, "Quas voluptatem aliquid et quidem sit consectetur assumenda. Similique et ut omnis sequi aut est nemo. Sit dolor est quia rem. Magni nesciunt deleniti suscipit quos quae est itaque.", "dignissimos", "autem", 2015, 70, 123457 },
                    { 16, "reiciendis", 41499, "aliquid", 593563f, "Alias reprehenderit maxime voluptatem et. Repellendus atque culpa veritatis velit inventore facere eius veritatis. Et magnam aliquam eum minus delectus. Quia nemo sunt quos et modi expedita dolore placeat.", "dolor", "doloremque", 1999, 71, 123457 },
                    { 17, "qui", 37924, "omnis", 446983f, "Omnis repellendus blanditiis consequuntur consequatur et impedit. Officiis sint expedita tenetur saepe nemo enim sed porro. Ut doloremque qui. Explicabo quo est vero ratione laudantium at.", "molestiae", "perspiciatis", 2008, 7, 123456 },
                    { 18, "nam", 91780, "et", 839286f, "Consequatur cupiditate sed dolor veritatis quaerat velit. Consequatur occaecati dolor tenetur ea libero accusantium. Vel aut perferendis magni vel est optio maiores hic. Et sunt tenetur fugiat impedit odit aspernatur ut.", "sint", "voluptate", 1994, 44, 123459 },
                    { 19, "ipsam", 5627, "saepe", 127928f, "Ullam sit nihil. Et neque maxime. Veniam modi voluptatum est dolorem voluptatibus maxime. Qui quo inventore.", "incidunt", "maiores", 1990, 23, 123457 },
                    { 20, "earum", 96931, "et", 675750f, "Rerum ullam vel ut aut. İste non incidunt delectus. İnventore aut neque repudiandae est molestiae omnis repudiandae voluptatum nam. Culpa consequuntur eos est temporibus qui fuga incidunt illo nulla. Qui itaque nulla nemo eum sed et temporibus dicta reiciendis. Quibusdam ut iure ut odio ipsam mollitia et et.", "quia", "omnis", 1995, 27, 123459 },
                    { 21, "nesciunt", 5266, "sint", 191766f, "Soluta repellat voluptas aut temporibus repellat. Commodi adipisci quibusdam blanditiis. Ut delectus molestiae autem consequatur quia voluptatem ut et.", "consequatur", "libero", 2013, 12, 123459 },
                    { 22, "vel", 5853, "fugit", 540304f, "Ex aut in facilis et amet blanditiis officiis. Possimus ad veritatis qui. Rerum vitae nobis molestias dolorum. Est praesentium eaque doloremque voluptatem reprehenderit occaecati ut quia fugiat. Eveniet vero est harum. Et pariatur consequatur rerum minima doloribus et et.", "voluptatem", "provident", 2007, 81, 123458 },
                    { 23, "unde", 81344, "sit", 917966f, "Omnis deleniti ut commodi. Nemo eligendi distinctio vel occaecati non necessitatibus aut totam quo. Delectus veritatis est suscipit consequatur. Quas quisquam et. Est sint totam et quisquam sit minus deserunt est quis.", "laudantium", "et", 2012, 8, 123456 },
                    { 24, "non", 32074, "voluptatem", 710828f, "Maiores quis quas eum. Dolorum sequi voluptatem eveniet aut. Cum non fuga.", "repudiandae", "officia", 2004, 67, 123459 },
                    { 25, "doloribus", 63499, "nobis", 527854f, "Et ea molestiae voluptatem atque. Sapiente assumenda est et dolore. Sed quam illo ut a. Et similique blanditiis fugit et nostrum. Consequatur eligendi quidem enim animi odit eum.", "atque", "praesentium", 2013, 46, 123457 },
                    { 26, "ullam", 30566, "nobis", 971980f, "Dolor eos nam ipsa necessitatibus. Totam eligendi possimus necessitatibus aut quod. Occaecati neque omnis non omnis totam odit deserunt facere. İd consequatur cum. Eveniet neque laborum iste.", "et", "id", 2023, 51, 123456 },
                    { 27, "est", 87857, "iste", 674284f, "Rerum dolore fuga. Earum dolore assumenda dignissimos qui ex explicabo laborum maxime accusantium. Debitis doloribus asperiores qui ut blanditiis illum ut soluta perferendis. Assumenda recusandae amet amet.", "et", "optio", 1994, 43, 123456 },
                    { 28, "illo", 477, "sit", 676000f, "At nemo officiis consequuntur similique rerum voluptatibus assumenda. Optio voluptates aliquam sunt nesciunt quidem. Molestiae provident totam error voluptates. Quod repellendus omnis deleniti. Laudantium dolores fugiat et accusamus atque. Est voluptatibus qui at beatae doloremque id.", "veniam", "sed", 2021, 2, 123457 },
                    { 29, "aut", 53434, "esse", 223917f, "Reiciendis pariatur odit iure eaque ut. Ut quo nihil quibusdam nihil ut quia qui. Reiciendis distinctio ducimus ipsa dolorem.", "sequi", "distinctio", 2009, 69, 123457 },
                    { 30, "laudantium", 56607, "atque", 323377f, "Eum dolor quasi sed maiores eum quam deserunt fugit rerum. Dolorem autem labore ipsa. Officiis distinctio veritatis dolore facere pariatur et.", "autem", "ex", 1997, 68, 123459 },
                    { 31, "sed", 29149, "iste", 110346f, "Voluptatem placeat autem ducimus rem dolores commodi ex provident. Ut necessitatibus aliquam iusto non earum. Voluptatem qui et deserunt delectus voluptatum. Qui nostrum et est sed autem. Et corrupti repudiandae aperiam et.", "ratione", "odio", 1994, 77, 123457 },
                    { 32, "aut", 32108, "quam", 618210f, "Architecto consequuntur quia aperiam qui molestiae sit illum blanditiis. Cumque iste voluptas veritatis fuga. Aut et non sint qui repudiandae modi maxime vel omnis.", "cum", "ipsa", 2001, 68, 123457 },
                    { 33, "dolores", 56773, "iste", 394007f, "Voluptatem suscipit rerum vel laboriosam beatae facilis consequatur dolores. Qui vel voluptatem. Laboriosam cum corrupti. Eum repellat et repellat aut est repudiandae. Nam voluptatem et labore tempore et voluptatem corporis veniam.", "modi", "consequatur", 2022, 31, 123459 },
                    { 34, "architecto", 74564, "voluptas", 476262f, "Dolores asperiores officia eum. Nobis minus iure molestiae. Error rerum iure amet enim assumenda occaecati perspiciatis debitis. Et aut expedita praesentium non possimus similique. Repudiandae explicabo magnam. Eius soluta ex quidem sunt ut id deserunt.", "mollitia", "enim", 1997, 18, 123456 },
                    { 35, "ut", 51458, "repellendus", 399616f, "Omnis at voluptatem sed voluptatem explicabo. Accusamus et facere laborum fuga rem. Voluptatem id non nulla ut. Consequatur illo aspernatur explicabo. Corporis ut soluta enim est eos quisquam ut eos. Veritatis quia possimus et aliquam.", "aut", "est", 2023, 3, 123459 },
                    { 36, "rem", 50404, "vero", 512855f, "Dicta aperiam sed rerum iste sed. Voluptate dolor in saepe omnis perspiciatis minima temporibus. Consequatur aliquid enim impedit necessitatibus ipsum in sed in. Quia sint incidunt. Ut quo autem non error.", "vitae", "dolor", 2021, 69, 123456 },
                    { 37, "vero", 85897, "est", 463067f, "Natus quibusdam reprehenderit ut quo corrupti laborum repellat voluptas. Harum rem fugit nesciunt hic distinctio praesentium. Modi deleniti dolores qui autem quae temporibus temporibus facilis vel. İpsum vel non nam. Cupiditate laboriosam eligendi officiis. Sed dignissimos sed quisquam nihil esse tempora.", "nemo", "explicabo", 1991, 68, 123457 },
                    { 38, "recusandae", 68511, "voluptates", 948467f, "Magnam delectus dolor doloremque omnis voluptatem. İusto et incidunt eaque voluptatum explicabo omnis facilis odit. Ad necessitatibus dolorem explicabo natus nihil inventore doloribus quibusdam. Rerum inventore et nihil vel quia et. Dolore quibusdam minus sit iusto eligendi quo est soluta. Deserunt pariatur reprehenderit aut.", "possimus", "et", 2010, 21, 123459 },
                    { 39, "facilis", 68018, "nesciunt", 610152f, "Labore quod ut sed veniam quis laborum aliquam. İn vitae maxime voluptatibus expedita. Mollitia voluptates et eum tenetur.", "voluptatibus", "omnis", 2023, 77, 123459 },
                    { 40, "sequi", 78222, "debitis", 695431f, "Sed amet occaecati provident velit. Beatae et earum aperiam ad sint porro ex laborum dolores. Corrupti quia laboriosam dolor officia consequatur repellat necessitatibus iste. Quidem nostrum dolorem nobis occaecati. Voluptas aut dolores eum beatae. Laudantium eaque odit facere ut.", "et", "tempora", 2010, 58, 123458 },
                    { 41, "excepturi", 59758, "adipisci", 486407f, "Ullam distinctio aut eligendi architecto et provident aut. Non ut nisi perferendis et at. At molestiae iusto. Magni quaerat quas consequatur rerum.", "accusamus", "pariatur", 2016, 30, 123457 },
                    { 42, "ut", 79479, "quam", 837297f, "Libero ut velit et omnis excepturi non cumque tenetur quos. Autem et illum. Eos hic omnis aliquam omnis. İusto neque culpa et fugiat. Voluptas quis ex iusto accusantium sit adipisci officiis.", "nam", "autem", 2010, 57, 123458 },
                    { 43, "quo", 85347, "voluptatem", 140612f, "Quisquam neque tenetur. Dignissimos aut quaerat. Aut dolor sit iure asperiores asperiores vero quasi assumenda. Autem enim quaerat dicta eius ea rerum quo suscipit voluptatibus.", "dicta", "voluptatem", 2003, 45, 123458 },
                    { 44, "blanditiis", 15400, "facilis", 708177f, "Consectetur possimus eos. Alias magni ut. Ut molestiae non necessitatibus iure aspernatur doloribus et. Qui qui ipsam voluptatem. Et sit omnis eius laudantium enim magnam. Et magni facere facere quae ut consectetur quaerat.", "laboriosam", "consequatur", 1995, 72, 123459 },
                    { 45, "asperiores", 60103, "quod", 533449f, "Magnam magnam et doloribus molestiae atque magnam architecto. Autem laudantium rerum dolores enim sequi aliquid. Qui illum quo repellat.", "veniam", "provident", 1999, 56, 123459 },
                    { 46, "ipsa", 6859, "dignissimos", 398877f, "Amet veritatis ut. Accusamus qui ipsa cupiditate nostrum harum aut exercitationem perspiciatis quia. Porro odit ipsa dolorem enim incidunt inventore.", "commodi", "a", 2023, 1, 123456 },
                    { 47, "hic", 64020, "saepe", 585416f, "Dolore qui corporis sit consequuntur distinctio. Nihil ut repellat quidem et et ea. Neque reprehenderit rem laudantium tempore fuga.", "odio", "non", 2017, 18, 123458 },
                    { 48, "voluptatum", 472, "cumque", 543627f, "Recusandae tempora dolorem enim. Praesentium culpa libero accusantium rerum quaerat. Quia cupiditate non asperiores.", "vero", "dolorem", 2019, 79, 123459 },
                    { 49, "vitae", 14342, "laboriosam", 578547f, "Officia sapiente odit corrupti nihil quisquam est quam repellendus earum. Cupiditate a quia consectetur nisi natus. Eum nisi sit voluptatem impedit et aliquam laborum illo ea. Porro atque et omnis earum quas voluptatum.", "qui", "eaque", 2018, 66, 123457 },
                    { 50, "aut", 82175, "id", 294331f, "Autem eligendi commodi. Vel aliquam ea exercitationem illo. Qui dolores reiciendis architecto cumque voluptates. Deserunt facilis debitis totam eveniet facere earum quia. İpsum vero aperiam dolorum dolor et odit est placeat. Nisi molestiae libero et.", "magni", "animi", 2000, 9, 123457 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
