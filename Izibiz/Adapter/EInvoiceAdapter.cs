using Izibiz.EInvoiceWS;

namespace Izibiz.Adapter
{
    public class EInvoiceAdapter
    {

        public LoginResponse login(LoginRequest loginRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.Login(loginRequest);
        }

        public LoadInvoiceResponse loadInvoice(LoadInvoiceRequest loadInvoiceRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.LoadInvoice(loadInvoiceRequest);

        }

        public SendInvoiceResponse sendInvoice(SendInvoiceRequest sendInvoiceRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.SendInvoice(sendInvoiceRequest);

        }

        public SendInvoiceResponseWithServerSignResponse sendInvoiceResponseWithServerSign(SendInvoiceResponseWithServerSignRequest serverSignRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.SendInvoiceResponseWithServerSign(serverSignRequest);
        }

        public GetInvoiceResponse getInvoice(GetInvoiceRequest singleInvoiceRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.GetInvoice(singleInvoiceRequest);

        }
        //PDF GET�NVO�CEW�THTYPE
        public GetInvoiceWithTypeResponse getInvoiceWTpDF(GetInvoiceWithTypeRequest invoiceWtPdfRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.GetInvoiceWithType(invoiceWtPdfRequest);
        }
        //
        //HTML GET�NVO�CEW�THTYPE
        public GetInvoiceWithTypeResponse getInvoiceWThtml(GetInvoiceWithTypeRequest invoiceWthtmlRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.GetInvoiceWithType(invoiceWthtmlRequest);
        }

        //HTML GET�NVO�CEW�THTYPE
        public GetInvoiceWithTypeResponse getInvoiceWThtmlOut(GetInvoiceWithTypeRequest invoiceWthtmlOutRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.GetInvoiceWithType(invoiceWthtmlOutRequest);
        }

        //PDF GET�NVO�CEW�THTYPE
        public GetInvoiceWithTypeResponse getInvoiceWTpdfOut(GetInvoiceWithTypeRequest invoiceWtpdfOutRequest)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.GetInvoiceWithType(invoiceWtpdfOutRequest);
        }
        //GETINVO�CESTATUSALL--->DURUM SORGULAMA   

        public GetInvoiceStatusAllResponse getInvoiceStatusAll(GetInvoiceStatusAllRequest getInvoiceStatusAllreq)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.GetInvoiceStatusAll(getInvoiceStatusAllreq);
        }

        public MarkInvoiceResponse markInvoice(MarkInvoiceRequest markInvoiceReq)
        {
            EInvoiceWSPortClient eInvoiceWSPort = new EInvoiceWSPortClient();
            return eInvoiceWSPort.MarkInvoice(markInvoiceReq);
        }


    }
}