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
    
    public partial class T_ProcurementInformation
    {
        public int ID { get; set; }
        public string NAME_PR { get; set; }
        public Nullable<int> ID_LEGISLATION { get; set; }
        public Nullable<System.DateTime> PR_APPROVAL_DATE { get; set; }
        public Nullable<int> ID_RESULT { get; set; }
        public Nullable<System.DateTime> CONTRACT_DATE_TERM { get; set; }
        public Nullable<System.DateTime> CONTRACT_DATE_FACT { get; set; }
        public Nullable<System.DateTime> RESULT_DATE_TERM { get; set; }
        public Nullable<System.DateTime> RESULT_DATE_FACT { get; set; }
        public string WIN_NAME { get; set; }
        public Nullable<decimal> WIN_VALUE { get; set; }
        public Nullable<int> ID_WINSTATUS { get; set; }
        public Nullable<System.DateTime> KRO_DATE_TERM { get; set; }
        public Nullable<System.DateTime> KRO_DATE_FACT { get; set; }
        public Nullable<System.DateTime> DATE_ACTIVE { get; set; }
        public Nullable<System.DateTime> DATE_DEACT { get; set; }
        public Nullable<bool> FLAG { get; set; }
        public string FIO_ISP { get; set; }
        public string INVITE_NUN { get; set; }
        public Nullable<int> ID_CURRENCY { get; set; }
        public Nullable<System.DateTime> CONTRACT_DATE_PROL { get; set; }
        public string CONTRACT_NUMBER { get; set; }
        public Nullable<int> ID_COUNTRY { get; set; }
        public string PURCHASE_VOLUME { get; set; }
        public string VOLUME_UNITS { get; set; }
        public string PRICE_PER_ITEM { get; set; }
        public string DELIVERY_COND { get; set; }
        public string MAIN_TEC_SPECS { get; set; }
        public string MANUFACTURER { get; set; }
        public string PRICE_PER_ITEM_NDNS { get; set; }
        public Nullable<int> ID_SUBJECTPURCHASE { get; set; }
        public Nullable<float> WIN_VALUE_BYN { get; set; }
        public Nullable<int> ID_COUNTRY_ORIGIN { get; set; }
        public Nullable<int> PARTICIPANT__VALUE { get; set; }
        public string USER_ENTER { get; set; }
        public Nullable<int> ID_SUBDIVISION { get; set; }
    
        public virtual S_Legislation S_Legislation { get; set; }
        public virtual S_Result S_Result { get; set; }
        public virtual S_WinStatus S_WinStatus { get; set; }
        public virtual S_Currency S_Currency { get; set; }
        public virtual S_Country S_Country { get; set; }
        public virtual S_SubjectPurchase S_SubjectPurchase { get; set; }
        public virtual S_SubDivision S_SubDivision { get; set; }
    }
}
