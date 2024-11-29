using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Doanvat.Module.Doanvat
{

    public partial class Hanghoa
    {
        public Hanghoa(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
