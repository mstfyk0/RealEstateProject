using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstateApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductFeatureGroup",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatureGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeature",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productFeatureGroupId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeature", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductFeature_ProductFeatureGroup_productFeatureGroupId",
                        column: x => x.productFeatureGroupId,
                        principalTable: "ProductFeatureGroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    propertyTypeId = table.Column<short>(type: "smallint", nullable: false),
                    furnitureConditionId = table.Column<short>(type: "smallint", nullable: false),
                    numberOfRoomsId = table.Column<short>(type: "smallint", nullable: false),
                    floorLevelId = table.Column<short>(type: "smallint", nullable: false),
                    buildingAgeId = table.Column<short>(type: "smallint", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalSquareFootage = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowCase = table.Column<bool>(type: "bit", nullable: false),
                    productFeatureid = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_ProductFeature_productFeatureid",
                        column: x => x.productFeatureid,
                        principalTable: "ProductFeature",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "ProductFeatureGroup",
                columns: new[] { "id", "value" },
                values: new object[,]
                {
                    { (short)1, "Emlak Tipi" },
                    { (short)2, "Eşya Durumu" },
                    { (short)3, "Oda Sayısı" },
                    { (short)4, "Bulunduğu Kat" },
                    { (short)5, "Bina Yaşı" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "ImageUrl", "ShowCase", "buildingAgeId", "description", "floorLevelId", "furnitureConditionId", "numberOfRoomsId", "price", "productFeatureid", "propertyTypeId", "title", "totalSquareFootage" },
                values: new object[,]
                {
                    { 1, "/images/images1.jpg", true, (short)1, "Harika manzaralı muhteşem bir gayrimenkul. Eşsiz doğa ve deniz manzarasına sahip olan bu mülk, lüks ve konforu bir araya getiriyor.", (short)4, (short)6, (short)12, 12345678m, null, (short)19, "MUHTEŞEM DENİZ MANZARALI VİLLA", 100 },
                    { 2, "/images/images2.jpg", true, (short)2, "Geniş ve iyi tasarlanmış daire satılık. Ferah iç mekanları ve modern tasarımı ile bu daire aileler için mükemmel bir seçenek.", (short)5, (short)7, (short)13, 9875643m, null, (short)20, "SAHİLE YAKIN LÜKS DAİRE", 150 },
                    { 3, "/images/images3.jpg", true, (short)3, "Huzurlu bir mahallede şirin bir ev. Sessiz ve sakin çevresiyle bu ev, huzurlu bir yaşam tarzını arayanlar için ideal bir tercih.", (short)4, (short)8, (short)14, 333225688m, null, (short)21, "HUZURLU ŞEHİR EVDEN EVE TAŞINMAYA HAZIR", 80 },
                    { 4, "/images/images4.jpg", true, (short)1, "Zarif penthouse, üstün olanaklarla dolu. Modern ve lüks tasarımıyla bu penthouse yaşam tarzınızı yükseltiyor.", (short)5, (short)9, (short)15, 9999999m, null, (short)22, "LÜKS PENTHOUSE DAİRE", 90 },
                    { 5, "/images/images5.jpg", true, (short)2, "Şehrin kalbinde modern bir loft. Merkezi konumu ve şık tasarımıyla bu loft, şehir hayatının tadını çıkarmak isteyenler için mükemmel bir seçenek.", (short)4, (short)10, (short)16, 223344555m, null, (short)23, "ŞEHİR MERKEZİNDE MODERN LOFT", 56 },
                    { 6, "/images/images6.jpg", true, (short)3, "Deniz kenarında keyifli bir tatil evi. Kumlu plajlara yakın olan bu ev, yaz aylarında huzur dolu bir tatil imkanı sunuyor.", (short)5, (short)11, (short)17, 1240000m, null, (short)24, "BAHÇELİ MÜSTAKİL EV", 89 },
                    { 7, "/images/images7.jpg", true, (short)1, "Doğayla iç içe havuzlu bir villa. Muhteşem bahçesi ve özel havuzuyla bu villa, doğal güzelliklerle çevrili lüks bir yaşam sunuyor.", (short)4, (short)6, (short)18, 234444m, null, (short)25, "DOĞA İLE İÇ İÇE HAVUZLU VİLLA", 110 },
                    { 8, "/images/images8.jpg", true, (short)2, "Gölet manzaralı modern bir daire. Doğal güzellikleri iç mekanlara taşıyan bu daire, huzurlu ve sakin bir yaşam sunuyor.", (short)5, (short)7, (short)12, 2300000m, null, (short)26, "SUNİ GÖLET MANZARALI DAİRE", 140 },
                    { 9, "/images/images9.jpg", true, (short)3, "Köy yaşamının keyfini çıkarın. Yeşillikler arasında yer alan bu köy evi, geleneksel ve huzurlu bir yaşam tarzı sunuyor.", (short)4, (short)8, (short)13, 540000m, null, (short)27, "YEŞİL BİR CENNETTE KÖY EVİ", 70 },
                    { 10, "/images/images10.jpg", true, (short)1, "Ulaşımı kolay merkezi konum. Şehir merkezine yakın olan bu ev, iş ve sosyal aktivitelere ulaşımı kolaylaştırıyor.", (short)5, (short)9, (short)14, 100000m, null, (short)28, "ULAŞIMI KOLAY MERKEZİ KONUM", 70 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeature",
                columns: new[] { "id", "productFeatureGroupId", "value" },
                values: new object[,]
                {
                    { (short)1, (short)1, "Satılık" },
                    { (short)2, (short)1, "Kiralık" },
                    { (short)3, (short)1, "Günlük" },
                    { (short)4, (short)2, "Eşyalı" },
                    { (short)5, (short)2, "Eşyasız" },
                    { (short)6, (short)3, "1 + 0" },
                    { (short)7, (short)3, "1 + 1" },
                    { (short)8, (short)3, "2 + 1" },
                    { (short)9, (short)3, "3 + 1" },
                    { (short)10, (short)3, "3 + 2" },
                    { (short)11, (short)3, "4 + 2" },
                    { (short)12, (short)4, "Bahçe Katı" },
                    { (short)13, (short)4, "Giriş Katı" },
                    { (short)14, (short)4, "1. Kat" },
                    { (short)15, (short)4, "2. Kat" },
                    { (short)16, (short)4, "3. Kat" },
                    { (short)17, (short)4, "4 Kat" },
                    { (short)18, (short)4, "5. Kat" },
                    { (short)19, (short)5, "0" },
                    { (short)20, (short)5, "1" },
                    { (short)21, (short)5, "2" },
                    { (short)22, (short)5, "3" },
                    { (short)23, (short)5, "4" },
                    { (short)24, (short)5, "5" },
                    { (short)25, (short)5, "5-10" },
                    { (short)26, (short)5, "10-15" },
                    { (short)27, (short)5, "15-20" },
                    { (short)28, (short)5, "20>" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeature_productFeatureGroupId",
                table: "ProductFeature",
                column: "productFeatureGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_productFeatureid",
                table: "Products",
                column: "productFeatureid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductFeature");

            migrationBuilder.DropTable(
                name: "ProductFeatureGroup");
        }
    }
}
