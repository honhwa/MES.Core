using System.Drawing;

namespace DigiERP.Common
{
    /// <summary>
    /// 全專案共用的表單設計常數（字體、顏色、標準尺寸）。
    /// 新表單與既有表單的修正皆應從此處取值，取代個別表單各自硬編碼的做法。
    /// </summary>
    public static class UIStyle
    {
        // 欄位取得焦點時的提示色，沿用 CommonTextBox/CommonComboBox/CommonDateTimePicker/CommonNumericUpDown/CommonCheckBox 既有行為。
        public static readonly Color FocusBackColor = Color.LightYellow;

        // 唯讀欄位底色：專案中最多表單已採用的顏色（WhiteSmoke），做為往後補色的統一標準。
        public static readonly Color ReadOnlyBackColor = Color.WhiteSmoke;

        // 可編輯欄位底色（沿用系統預設）。
        public static readonly Color EditableBackColor = SystemColors.Window;

        // 標準輸入欄位／按鈕尺寸，供新表單排版參考。
        public const int InputHeight = 32;
        public const int ButtonWidth = 100;
        public const int ButtonHeight = 32;

        // 按鈕語意顏色，供新表單排版參考。
        public static readonly Color ButtonSaveColor = Color.SteelBlue;
        public static readonly Color ButtonDeleteColor = Color.IndianRed;
        public static readonly Color ButtonApproveColor = Color.SeaGreen;
        public static readonly Color ButtonCancelApproveColor = Color.Orange;
        public static readonly Color ButtonNeutralColor = Color.Gainsboro;
        public static readonly Color ButtonExitColor = Color.DimGray;
        public static readonly Color ButtonForeColor = Color.White;

        // 表單標準字體。
        public static readonly Font FormFont = new Font("Microsoft JhengHei UI", 10F);
        public static readonly Font TitleFont = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
    }
}
