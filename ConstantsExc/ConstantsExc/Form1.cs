namespace ConstantsExc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class PrintLog
    {
        const double pricePerPage = 0.05;
        private int pagesPrinted;

        public PrintLog()
        { this.pagesPrinted = 0; }

        // Increase count of printed pages and return the print cost
        public double PrintPage()
        {
            this.pagesPrinted++;
            return pricePerPage;
        }
        // Increase count of printed pages and return the print cost
        public double PrintPage(int pageCount)
        {
            this.pagesPrinted += pageCount;
            return pricePerPage * pageCount;
        }
        // Calculate total revenue based on total printed pages
        public double GetCurrentRevenue()
        { return pricePerPage * this.pagesPrinted; }
    }

}