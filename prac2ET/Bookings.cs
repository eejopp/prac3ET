//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prac2ET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        public int ID_Bookings { get; set; }
        public int Client_ID { get; set; }
        public int Servicess_ID { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Servicess Servicess { get; set; }
    }
}
