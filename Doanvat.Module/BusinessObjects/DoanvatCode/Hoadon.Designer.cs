﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Doanvat.Module.Doanvat
{

    [DefaultProperty("Khach_ID")]
    public partial class Hoadon : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Khachhang fKhach_ID;
        [Association(@"HoadonReferencesKhachhang")]
        public Khachhang Khach_ID
        {
            get { return fKhach_ID; }
            set { SetPropertyValue<Khachhang>(nameof(Khach_ID), ref fKhach_ID, value); }
        }
        DateTime fNgaylaphoadon;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask","dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat","{0:dd/MM/yyyy HH:mm}")
]
        public DateTime Ngaylaphoadon
        {
            get { return fNgaylaphoadon; }
            set { SetPropertyValue<DateTime>(nameof(Ngaylaphoadon), ref fNgaylaphoadon, value); }
        }
        DateTime fNgayinhoadon;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask","dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat","{0:dd/MM/yyyy HH:mm}")
]
        public DateTime Ngayinhoadon
        {
            get { return fNgayinhoadon; }
            set { SetPropertyValue<DateTime>(nameof(Ngayinhoadon), ref fNgayinhoadon, value); }
        }
        [Association(@"HD_HHReferencesHoadon")]
        public XPCollection<HD_HH> HD_HHs { get { return GetCollection<HD_HH>(nameof(HD_HHs)); } }
    }

}
