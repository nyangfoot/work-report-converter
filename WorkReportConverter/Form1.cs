using WorkReportConverter.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkReportConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var wa = Screen.FromControl(this).WorkingArea;

            int w = (int)(wa.Width * 0.4);
            int h = (int)(wa.Height * 0.6);
            this.Size = new Size(w, h);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // 변환 버튼 클릭 이벤트
        private void btnConvert_Click(object sender, EventArgs e)
        {
            DataConverter();
        }

        private void DataConverter()
        {
            reportForm.Clear();
            mdForm.Clear();

            var progressItems = new List<ReportModel>();            // 진행중
            var pkgCompItems = new List<ReportModel>();            // 완료_패키지
            var cusCompItems = new List<ReportModel>();            // 완료_전용
            var nextItems = new List<ReportModel>();            // 익일

            // 그리드 데이터 기준으로 양식 생성
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                var menu = row.Cells["MenuName"].Value?.ToString()?.Trim();
                // 디자이너가 만든 행 제외
                if (row.IsNewRow) continue;
                else if (string.IsNullOrEmpty(menu)) continue;

                var item = ModelConverter(row);
                if (item.Progress == 0)
                {
                    nextItems.Add(item);
                }
                else if (item.Progress == 100)
                {
                    if (item.Customer == "패키지")
                    {
                        pkgCompItems.Add(item);
                    }
                    else
                    {
                        cusCompItems.Add(item);
                    }
                }
                else
                {
                    progressItems.Add(item);
                }
            }

            // 텍스트 생성하기
            reportForm.AppendText("1. 진행중인 업무\r\n");
            foreach (var item in progressItems)
            {
                reportForm.AppendText($"-(개발) {item.MenuName}({item.CompleteDate}) : {item.Contents}({item.Progress}%) - {item.Customer}\r\n");
                AppendMdForm(item, false);
            }

            reportForm.AppendText("\r\n");
            reportForm.AppendText("2. 진행완료 업무(핌스 기준)\r\n");
            reportForm.AppendText("■ 패키지 메뉴\r\n");
            foreach (var item in pkgCompItems)
            {
                var contents = item.Contents;
                if (item.Contents.EndsWith("완료") == false) contents = contents + " 완료";
                reportForm.AppendText($"-(개발) {item.MenuName} : {contents}\r\n");
                AppendMdForm(item, true);
            }

            reportForm.AppendText("\r\n");
            reportForm.AppendText("■ 전용 메뉴\r\n");
            foreach (var item in cusCompItems)
            {
                var contents = item.Contents;
                if (item.Contents.EndsWith("완료") == false) contents = contents + " 완료";
                reportForm.AppendText($"-(개발) {item.MenuName} : {contents} - {item.Customer}\r\n");
                AppendMdForm(item, true);
            }

            reportForm.AppendText("\r\n");
            reportForm.AppendText("3. 익일 업무\r\n");
            foreach (var item in nextItems)
            {
                reportForm.AppendText($"-(개발) {item.MenuName} : {item.Contents} - {item.Customer}\r\n");
            }
        }

        // 모델변환
        private ReportModel ModelConverter(DataGridViewRow row)
        {
            return new ReportModel(
                row.Cells["MenuName"].Value?.ToString(),
                row.Cells["CompleteDate"].Value?.ToString(),
                row.Cells["Contents"].Value?.ToString(),
                row.Cells["Progress"].Value?.ToString(),
                row.Cells["Customer"].Value?.ToString()
            );
        }

        private void AppendMdForm(ReportModel item, bool complete)
        {
            var contents = item.Contents;
            if (complete)
            {
                if (item.Contents.EndsWith("완료") == false) contents = contents + " 완료";
            }
            else
            {
                contents = $"{contents}({item.Progress}%)";
            }
            mdForm.AppendText($"[{item.MenuName} : {contents}]_[{item.Customer}]_[강촌]\r\n");

        }

        // 그리드 keydown이벤트
        private void dataGrid_Keydown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                PasteToDataGrid();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                ClearCell();
            }
        }
        private void PasteToDataGrid()
        {
            var text = Clipboard.GetText();
            dataGrid.CurrentCell.Value = text;
        }
        private void ClearCell()
        {
            dataGrid.CurrentCell.Value = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reportForm.Clear();
            mdForm.Clear();
            dataGrid.Rows.Clear();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
