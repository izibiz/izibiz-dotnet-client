﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Izibiz_dotnet_soap_client.Operations;
using Izibiz_dotnet_soap_client.UblCreate;
using Izibiz_dotnet_soap_client.UblSerializer;
using UblInvoice;
using UblDespatch;
using UblCreditNote;
using UblReceipt;

namespace Izibiz_dotnet_soap_client.Operations
{
   public class XmlSerializerr
    {
        public static String xmlString = null;

        public static string XmlSerializeInvoice(InvoiceType invoiceType)
        {                
                using (var stringwriter = new Utf8StringWriter())
                {
                    var serializer = new XmlSerializer(invoiceType.GetType());
                    serializer.Serialize(stringwriter, invoiceType, InvoiceSerializer.GetXmlSerializerNamespace());
                    xmlString = stringwriter.ToString();
                }
                return xmlString; 
        }

        public static string XmlSerializeDespatch(DespatchAdviceType despatchType)
        {
            using (var stringwriter = new Utf8StringWriter())
            {
                var serializer = new XmlSerializer(despatchType.GetType());
                serializer.Serialize(stringwriter, despatchType, DespatchSerializer.GetXmlSerializerNamespace());
                xmlString = stringwriter.ToString();
            }
            return xmlString;
        }

        public static string XmlSerializeCreditNote(CreditNoteType creditNoteType)
        {
            using (var stringwriter = new Utf8StringWriter())
            {
                var serializer = new XmlSerializer(creditNoteType.GetType());
                serializer.Serialize(stringwriter, creditNoteType, CreditNoteSerializer.GetXmlSerializerNamespace());
                xmlString = stringwriter.ToString();
            }
            return xmlString;
        }


    }
}
