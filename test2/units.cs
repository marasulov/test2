//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test2
{
    using System;
    using System.Collections.Generic;
    
    public partial class units
    {
        public int id { get; set; }
        public Nullable<int> subfacility_id { get; set; }
        public string name { get; set; }
        public System.DateTime created_at { get; set; }
    
        public virtual subfacilities subfacilities { get; set; }
    }
}
