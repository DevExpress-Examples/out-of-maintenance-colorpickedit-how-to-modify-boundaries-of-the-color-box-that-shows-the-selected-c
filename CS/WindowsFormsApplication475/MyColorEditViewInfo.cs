using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication475 {
    public class MyColorEditViewInfo : ColorEditViewInfo {
        public MyColorEditViewInfo(RepositoryItem item)
            : base(item) {

        }
protected override void CalcColorBoxRect() {
    fColorTextRect = MaskBoxRect;
    if (Item.ColorAlignment == HorzAlignment.Default) return;
    fColorBoxRect = Rectangle.Inflate(MaskBoxRect, 0, 0);
    fColorBoxRect.Width = MaskBoxRect.Width;
    fColorBoxRect.Height = MaskBoxRect.Height;
    if (Item.ColorAlignment == HorzAlignment.Far) fColorBoxRect.X = MaskBoxRect.Right - ColorIndent - fColorBoxRect.Width;
    if (Item.ColorAlignment == HorzAlignment.Center) fColorBoxRect.X = MaskBoxRect.Left + (MaskBoxRect.Width - fColorBoxRect.Width) / 2;
    //base.CalcColorBoxRect();
}
    }

}
