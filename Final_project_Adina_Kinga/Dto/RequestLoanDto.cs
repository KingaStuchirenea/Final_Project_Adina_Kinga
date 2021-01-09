using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project_Adina_Kinga.Dto
{
    public class RequestLoanDto
    {
        public int LoanAmount { get; set; }
        public int DownPayment { get; set; }
        public string FromAccount { get; set; }

        public RequestLoanDto()
        {
            SetRequestLoanData();
        }

        public void SetRequestLoanData()
        {
            LoanAmount = 500;
            DownPayment = 100;
            FromAccount = "14454";
        }
    }
}
