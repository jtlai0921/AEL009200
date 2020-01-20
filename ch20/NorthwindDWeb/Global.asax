<%@ Application Language="C#" %>
<%@ Import Namespace="System.ComponentModel.DataAnnotations" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Web.DynamicData" %>

<script RunAt="server">
    private static MetaModel s_defaultModel = new MetaModel();
    public static MetaModel DefaultModel {
        get {
            return s_defaultModel;
        }
    }

    public static void RegisterRoutes(RouteCollection routes) {
        //                    重要資訊: 資料模型註冊 
        // 取消註解此行可註冊使用於 ASP.NET Dynamic Data 的 LINQ to SQL 模型。
        // 您確定要讓此資料模型中的所有資料表都支援 Scaffold (即樣板) 檢視，
        // 才可設定 ScaffoldAllTables = true。若要控制個別資料表的 Scaffolding，
        // 請建立該資料表的部分類別，並且套用
        // [ScaffoldTable(true)] 屬性到此部分類別。
        // 注意: 請確定您將 "YourDataContextType" 變更為
        // 應用程式中資料內容類別的名稱。
        //DefaultModel.RegisterContext(typeof(YourDataContextType), new ContextConfiguration() { ScaffoldAllTables = false });
        
        DefaultModel.RegisterContext(typeof(NorthwindDataContext),
            new ContextConfiguration() { ScaffoldAllTables = true });
        
        // 下列陳述式支援獨立頁面模式，在這種模式下，List、Detail、Insert 和 
        // Update 等工作都會使用獨立的頁面來執行。若要啟用這個模式， 
        // 請取消下列 route 定義的註解，並將後面 combined-page 模式區段中的 route 定義標記為註解。
        routes.Add(new DynamicDataRoute("{table}/{action}.aspx") {
            Constraints = new RouteValueDictionary(new { action = "List|Details|Edit|Insert" }),
            Model = DefaultModel
        });

        // 下列陳述式支援 combined-page 模式，在這種模式下，List、Detail、Insert 和
        // Update 等工作都會使用相同的頁面來執行。若要啟用這個模式，
        // 請取消下列 routes 定義的註解，並將上述獨立頁面模式區段中的 route 定義標記為註解。
        //routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
        //    Action = PageAction.List,
        //    ViewName = "ListDetails",
        //    Model = DefaultModel
        //});

        //routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
        //    Action = PageAction.Details,
        //    ViewName = "ListDetails",
        //    Model = DefaultModel
        //});
    }

    void Application_Start(object sender, EventArgs e) {
        RegisterRoutes(RouteTable.Routes);
    }

</script>
