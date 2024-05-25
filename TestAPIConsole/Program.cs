namespace TestAPIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hãy nhập cân nặng");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hãy nhập chiều cao");
            double height = Convert.ToDouble(Console.ReadLine());
            // Viết đoạn code call API
            // Bước 1: Lấy đường dẫn API (APIUrl) với các tham số tương ứng nếu có
            string requestURL = @$"https://localhost:7002/get-bmi?weight={weight}&height={height}";
            // Bước 2: Từ API Url => Lấy ra response body
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(requestURL).Result;
            // Bước 3: Đưa dữ liệu lấy được về dạng mà chúng ta cần
            Console.WriteLine(response);
            // Bước 4: Sử dụng dữ liệu
            Console.ReadKey();
        }
    }
}