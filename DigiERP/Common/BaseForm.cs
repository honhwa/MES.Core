using DigiERP.Forms;
using System.Windows.Forms;

namespace DigiERP.Common
{
    /// <summary>
    /// 所有表單的共用基底類別，統一套用 UIStyle 定義的視覺樣式。
    /// 新表單請繼承 BaseForm 取代 Form；既有表單可逐步改為繼承此類別以套用統一樣式。
    /// 字型已透過 Program.cs 的 Application.SetDefaultFont 全域套用，此處不再重複設定。
    /// </summary>
    public class BaseForm : CommonForm
    {
        // 用 OnCreateControl 而不是 OnLoad：Designer 畫布不會觸發 Load 事件，
        // 但為了畫出控制項一定會建立 handle，OnCreateControl 兩邊都會執行，
        // 這樣 Designer 看到的和實際執行時才會一致。
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            UIStyle.ApplyControlStyle(this);
        }
    }
}
