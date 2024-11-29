using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Doanvat.Module.Doanvat
{

    public partial class HD_HH
    {
        public HD_HH(Session session) : base(session) { }
        public override void AfterConstruction() {
            base.AfterConstruction();
            if (Session.IsNewObject(This))
            {

            }
        }
    }

}
