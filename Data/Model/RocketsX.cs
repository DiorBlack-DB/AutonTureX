//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFUIKitProfessional.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RocketsX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RocketsX()
        {
            this.RocketsXFavorite = new HashSet<RocketsXFavorite>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string active { get; set; }
        public string cost_per_launch { get; set; }
        public string first_flight { get; set; }
        public string HeightMeters { get; set; }
        public string DiameterMeters { get; set; }
        public string mass { get; set; }
        public string boosters { get; set; }
        public string engines { get; set; }
        public Nullable<int> idImage { get; set; }
    
        public virtual imageRocketsX imageRocketsX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RocketsXFavorite> RocketsXFavorite { get; set; }
    }
}
