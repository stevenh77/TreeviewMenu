using System;
using System.Collections.Generic;
using Silverblade5.Web.Interfaces;

namespace Silverblade5.Models
{
    public class MenuItem : IMenuItem
    {
        public string Id { get; set; }
        public Uri IconUri { get; set; }
        public string DisplayText { get; set; }
        public Uri Uri { get; set; }
        public string ParentId { get; set; }
        public IList<IMenuItem> Children { get; set; }

        public MenuItem(string id, string displayText, Uri iconUri, Uri uri)
        {
            this.Id = id;
            this.DisplayText = displayText;
            this.IconUri = iconUri;
            this.Uri = uri;
            this.Children = new List<IMenuItem>();
        }    

        public void Add(params IMenuItem[] children)
        {
            foreach (var child in children)
            {
                child.ParentId = this.Id;
                this.Children.Add(child);
            }
        }

        public void Remove(IMenuItem child)
        {
            child.ParentId = null;
            this.Children.Remove(child);
        }
    }
}
