using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Common
{
    // ── 共用分頁開啟輔助：開啟(或切換至)指定名稱的分頁時，記住開啟當下所在的
    //    「來源分頁」(存於新分頁的 Tag)；該分頁日後被關閉(TabPages.Remove)時，
    //    透過掛在 TabControl 上的 ControlRemoved 事件自動切回來源分頁，取代
    //    TabControl 預設「回到清單第一個分頁」的行為。呼叫端的關閉按鈕/方法完全
    //    不需修改，只要開啟分頁時改呼叫 Open() 即可 ─────────────────────────
    public static class TabNavigator
    {
        private static readonly HashSet<TabControl> _wired = new HashSet<TabControl>();

        public static void Open(TabControl tabControl, string tabName, string tabTitle, Func<Control> createControl)
        {
            EnsureWired(tabControl);

            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }

            var originTab = tabControl.SelectedTab;
            var ctrl = createControl();
            if (ctrl == null) return; // 建立失敗(例如建構子因權限不足自我 Dispose)，比照原邏輯不開新分頁
            var tab = new TabPage(tabTitle) { Name = tabName, Tag = originTab };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }

        private static void EnsureWired(TabControl tabControl)
        {
            if (!_wired.Add(tabControl)) return;
            tabControl.ControlRemoved += (s, e) =>
            {
                if (e.Control is TabPage removedPage && removedPage.Tag is TabPage originTab && tabControl.TabPages.Contains(originTab))
                {
                    tabControl.SelectedTab = originTab;
                }
            };
        }
    }
}
