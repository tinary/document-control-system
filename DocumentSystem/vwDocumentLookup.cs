//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwDocumentLookup
    {
        public int invoice_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public string invoice_PO { get; set; }
        public byte[] invoice_document { get; set; }
        public string invoice_MIME { get; set; }
        public int store_id { get; set; }
        public string store_name { get; set; }
    }
}