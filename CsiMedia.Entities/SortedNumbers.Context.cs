﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsiMedia.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SortedNumber> SortedNumbers { get; set; }
    
        public virtual int Insert(string orderedDirection, Nullable<int> timeTakenToSort, string numbers)
        {
            var orderedDirectionParameter = orderedDirection != null ?
                new ObjectParameter("OrderedDirection", orderedDirection) :
                new ObjectParameter("OrderedDirection", typeof(string));
    
            var timeTakenToSortParameter = timeTakenToSort.HasValue ?
                new ObjectParameter("TimeTakenToSort", timeTakenToSort) :
                new ObjectParameter("TimeTakenToSort", typeof(int));
    
            var numbersParameter = numbers != null ?
                new ObjectParameter("Numbers", numbers) :
                new ObjectParameter("Numbers", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert", orderedDirectionParameter, timeTakenToSortParameter, numbersParameter);
        }
    
        public virtual ObjectResult<SelectAll_Result> SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAll_Result>("SelectAll");
        }
    }
}
