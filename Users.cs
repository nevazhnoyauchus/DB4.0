//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace database2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public Nullable<int> idGender { get; set; }
        public Nullable<int> idRole { get; set; }
        public Nullable<int> password { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
        public virtual UsersPhoto UsersPhoto { get; set; }
    }
}
