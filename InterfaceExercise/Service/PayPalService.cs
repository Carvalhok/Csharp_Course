namespace InterfaceExercise.Service
{
    class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }

        public double Interest(double amount, int month)
        {
            return amount * ( 1 + 0.01 * month);
        }
    }
}
