//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consola
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int IDArt { get; set; }
        public int IDSuc { get; set; }
        public int StockDisp { get; set; }
    
        public virtual Articulo Articulo { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
