//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    
    public partial class SurveyQuestion_Result
    {
        public string SurveyCode { get; set; }
        public int SurveySectionNumber { get; set; }
        public int QuestionNumber { get; set; }
        public bool DescriptionRequired { get; set; }
        public bool DescriptionRequiredForYes { get; set; }
        public bool DescriptionRequiredForNo { get; set; }
        public byte QuestionInputTypeCode { get; set; }
        public bool IsRequired { get; set; }
        public bool IsBlocked { get; set; }
        public string LangCode { get; set; }
        public string SurveyQuestionDescription { get; set; }
    }
}
