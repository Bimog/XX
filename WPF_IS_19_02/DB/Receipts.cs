//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_IS_19_02.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipts
    {
        public int Id { get; set; }
        public int Id_Sklad { get; set; }
        public int Id_Material { get; set; }
        public int Id_Supplier { get; set; }
        public Nullable<int> MaterialsCount { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Skladi Skladi { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
