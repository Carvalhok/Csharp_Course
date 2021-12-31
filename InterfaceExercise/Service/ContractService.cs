using System;
using InterfaceExercise.Entity;

namespace InterfaceExercise.Service
{
    class ContractService
    {
        public int NumberOfInstallment { get; set; }

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(int numberOfInstallment, IOnlinePaymentService onlinePaymentService)
        {
            NumberOfInstallment = numberOfInstallment;
            _onlinePaymentService = onlinePaymentService;
        }

        
        public void ProcessContract(Contract contract)
        {
            double basicInstallment = contract.TotalValue / NumberOfInstallment;

            for(int month = 1; month <= NumberOfInstallment; month++)
            {
                double interestInstallmente = _onlinePaymentService.Interest(basicInstallment, month);
                double feeInstallment = _onlinePaymentService.PaymentFee(interestInstallmente);
                DateTime dateMonth = contract.Date.AddMonths(month);

                contract.listOfInstallmente.Add(new Installment(dateMonth, feeInstallment));
            }
        }
    }
}
