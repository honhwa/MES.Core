using DigiERP.Forms;
using System.Windows.Forms;

namespace DigiERP.Common
{
    /// <summary>
    /// 所有表單的共用基底類別。新表單請繼承 BaseForm 取代 Form。
    /// 注意：套用 UIStyle 樣式不是靠繼承自動生效——OnLoad／OnCreateControl 都不會在
    /// VS 設計器畫布上觸發，會導致 Designer 看到的畫面和實際執行結果不一致。
    /// 因此請在建構子的 InitializeComponent() 之後，自行加一行：
    ///     DigiERP.Common.UIStyle.ApplyControlStyle(this);
    /// 這是唯一能讓 Designer 畫布跟 Runtime 執行結果一致的做法，因為 Designer
    /// 只保證會執行到建構子本身。
    /// </summary>
    public class BaseForm : CommonForm
    {
    }
}
