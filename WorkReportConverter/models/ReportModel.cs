using System;
using System.Collections.Generic;
using System.Text;

namespace WorkReportConverter.models
{
    public class ReportModel
    {
        public string WriteDate { get; set; }       // 작성일
        public string MenuName { get; set; }        // 메뉴명
        public string CompleteDate { get; set; }     // 완료예정일
        public string Contents { get; set; }         // 내용
        public int Progress { get; set; }           // 진행도
        public string Customer { get; set; }

        public ReportModel(string menu, string compDate, string contents, string progress, string customer)
        {
            MenuName = menu;
            CompleteDate = compDate;
            Contents = contents;
            Progress = string.IsNullOrEmpty(progress) ? 0 : int.Parse(progress.Replace("%", ""));
            Customer = string.IsNullOrEmpty(customer)? "패키지" : customer;
        }
    }

}
