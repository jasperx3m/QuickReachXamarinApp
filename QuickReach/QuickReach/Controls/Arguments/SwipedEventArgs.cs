using SwipeCards.Controls.Arguments;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickReach.Controls.Arguments
{
    public class SwipedEventArgs
    {
        public readonly object Item;
        public readonly SwipeDirection Direction;

        public SwipedEventArgs(object item, SwipeDirection direction)
        {
            this.Item = item;
            this.Direction = direction;
        }
        public enum SwipeDirection
        {
            Left,Right
        }
    }
}
