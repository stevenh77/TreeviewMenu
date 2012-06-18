using System;
using System.Collections.Generic;

namespace Silverblade5.Web.Interfaces
{
    public interface IMenuItem
    {
        string Id { get; set; }
        Uri IconUri { get; set; }
        string DisplayText { get; set; }
        Uri Uri { get; set; }
        string ParentId { get; set; }
        IList<IMenuItem> Children { get; set; }
        void Add(params IMenuItem[] child);
        void Remove(IMenuItem child);
    }
}
