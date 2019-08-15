using System;
using System.Collections.Generic;
using System.Text;

namespace QuickReach.Controls.Arguments
{
    public class DraggingEventArgs : EventArgs
    {
        public readonly object Item;
        public DraggingEventArgs(object item)
        {
            this.Item = item;
        }
    }
}
