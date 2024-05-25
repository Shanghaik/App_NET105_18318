namespace TestAPIWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            
            double weight = Convert.ToDouble(tbt_weight.Text);
            double height = Convert.ToDouble(tbt_height.Text);
            // Viết đoạn code call API
            // Bước 1: Lấy đường dẫn API (APIUrl) với các tham số tương ứng nếu có
            string requestURL = @$"https://localhost:7002/get-bmi?weight={weight}&height={height}";
            // Bước 2: Từ API Url => Lấy ra response body
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(requestURL).Result;
            // Bước 3: Đưa dữ liệu lấy được về dạng mà chúng ta cần
            lb_result.Text = "Kết quả " + response;
        }
    }
}