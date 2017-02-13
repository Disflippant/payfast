﻿namespace PayFast.UnitTests
{
    using Xunit;

    public class NotifyTests
    {
        [Fact]
        public void Can_Verify_Signature()
        {
            // Arrange
            var passPhrase = "salt";
            var notifyViewModel = new PayFastNotify();
            notifyViewModel.SetPassPhrase(passPhrase);
            notifyViewModel.amount_fee = "0.00";
            notifyViewModel.amount_gross = "20.00";
            notifyViewModel.amount_net = "20.00";
            notifyViewModel.billing_date = "2017-02-13";
            notifyViewModel.email_address = "sbtu01@payfast.co.za";
            notifyViewModel.item_description = "Some details about option 2";
            notifyViewModel.item_name = "Option 2";
            notifyViewModel.m_payment_id = "8d00bf49-e979-4004-228c-08d452b86380";
            notifyViewModel.merchant_id = "10004241";
            notifyViewModel.name_first = "Test";
            notifyViewModel.name_last = "User 01";
            notifyViewModel.payment_status = "COMPLETE";
            notifyViewModel.pf_payment_id = "327767";
            notifyViewModel.signature = "c5cce9e08316373ca2ba6b427e39772e";
            notifyViewModel.token = "01c3f68f-5802-4760-c0a5-85d658ccff99";

            // Act
            var calculatedSignature = notifyViewModel.GetCalculatedSignature();

            // Assert
            Assert.Equal(notifyViewModel.signature, calculatedSignature);
        }
    }
}
