//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PrInfoDo1000
    {
        public int ID { get; set; }
        public string NAME_PR { get; set; }
        public Nullable<int> ID_LEGISLDO1000 { get; set; }
        public string CONTRACT_NUMBER { get; set; }
        public Nullable<System.DateTime> DATE_CONCLUSION { get; set; }
        public string WIN_NAME { get; set; }
        public Nullable<decimal> WIN_VALUE { get; set; }
        public Nullable<decimal> WIN_VALUE_NDE { get; set; }
        public Nullable<decimal> WIN_VALUE_NNDS { get; set; }
        public string FIO_ISP { get; set; }
        public Nullable<int> ID_CURRENCY { get; set; }
        public Nullable<System.DateTime> DATE_ACTIVE { get; set; }
        public Nullable<System.DateTime> DATE_DEACT { get; set; }
        public Nullable<bool> FLAG { get; set; }
        public Nullable<int> ID_WINSTATUSDO1000 { get; set; }
        public Nullable<int> ID_COUNTRY_ORIGIN { get; set; }
        public Nullable<int> ID_SUBJECTPURCHASE { get; set; }
        public string USER_ENTER { get; set; }
        public Nullable<int> ID_SUBDIVISION { get; set; }
    
        public virtual S_Currency S_Currency { get; set; }
        public virtual S_LegislDo1000 S_LegislDo1000 { get; set; }
        public virtual S_WinStatusDo1000 S_WinStatusDo1000 { get; set; }
        public virtual S_SubDivision S_SubDivision { get; set; }
    }
}