using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// WebService 的摘要描述
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下一行。
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    public WebService()  // WebService建構式
    {
        //如果使用設計的元件，請取消註解下行程式碼 
        //InitializeComponent(); 
    }
    // 宣告Add為Web服務的方法
    [WebMethod]
    public double Add(double x, double y)
    {
        return x + y;
    }
}
