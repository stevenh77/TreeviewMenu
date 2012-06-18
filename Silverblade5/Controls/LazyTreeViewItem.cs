using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Silverblade5.Controls
{
    public class LazyTreeViewItem : TreeViewItem
    {
        public event EventHandler ItemExpanded;
        public event EventHandler ItemClicked;

        protected override DependencyObject GetContainerForItemOverride()
        {
            LazyTreeViewItem item = new LazyTreeViewItem();

            // Expanded
            item.ItemExpanded += (s, e) => this.RaiseEvent(this.ItemExpanded, s);
            // Clicked
            item.ItemClicked += (s, e) => this.RaiseEvent(this.ItemClicked, s);

            return item;
        }

        protected override void OnExpanded(RoutedEventArgs e)
        {
            this.RaiseEvent(this.ItemExpanded, this);
            base.OnExpanded(e);
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            this.RaiseEvent(this.ItemClicked, this);
            e.Handled = true;
            base.OnMouseLeftButtonUp(e);
        }

        private void RaiseEvent(EventHandler handler, object sender)
        {
            if (handler != null)
                handler(sender, EventArgs.Empty);
        }
    }
}
