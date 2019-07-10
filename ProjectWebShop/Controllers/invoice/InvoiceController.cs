using System;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using ProjectWebShop.Interface.invoice;
using ProjectWebShop.Model;
using ProjectWebShop.WebSockets;

namespace ProjectWebShop.Controllers.invoice
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        private IInvoiceResponsitory m_invoiceResponcitory;
        private ObjectHandler m_objectHandler { get; set; }
        public InvoiceController(IInvoiceResponsitory invoiceResponcitory,ObjectHandler objectHandler)
        {
            m_invoiceResponcitory = invoiceResponcitory;
            m_objectHandler = objectHandler;
        }
        //insert invoice
        [HttpPost("InsertInvoive")]
        public async Task<IActionResult> InsertInvoiveAsync([FromForm] InvoiceRequest invoice)
        {
            DataRespond data = new DataRespond();
            try
            {
                Invoices inv = new Invoices();
                inv.namecustomer = invoice.namecustomer;
                inv.gender = invoice.gender;
                inv.phonenumber = invoice.phonenumber;
                inv.email = invoice.email;
                inv.province = invoice.province;
                inv.district = invoice.district;
                inv.adress = invoice.adress;
                inv.adressdelviver = invoice.adressdelviver;
                inv.timedeliver = invoice.timedeliver;
                inv.typepay = invoice.typepay;
                inv.totalmoney = invoice.totalmoney;
                inv.money = invoice.money;
                inv.codediscount = invoice.codediscount;
                inv.note = invoice.note;
                inv.usid = invoice.usid;
                inv.codeinvoice = RandomString(20);
                Invoices newinv= m_invoiceResponcitory.InsetInvoice(inv);

                foreach (var i in invoice.invoiceproduct)
                {
                    InvoiceProductRequest invprd = new InvoiceProductRequest(i);
                    InvoiceProduct invoicers = new InvoiceProduct();
                    invoicers.prid = invprd.prid;
                    invoicers.total = invprd.total;
                    invoicers.ivid = newinv.ivid;
                    m_invoiceResponcitory.InsertInvoiceProduct(invoicers);
                }
                await sendInvoidBySocket(newinv);
                //sendEmail(invoice.email,inv.codeinvoice);
                data.success = true;
                data.data = newinv;
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return Ok(new { data });
        }
        //get invoice by id
        [HttpGet("GetInvoicebyId")]
        public DataRespond GetInvoicebyId(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_invoiceResponcitory.GetInvoiceById(id);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        //send email to customer 
        public void sendEmail(string email, string code)
        {
            var mess = new MimeMessage();
            mess.From.Add(new MailboxAddress("KhanhShop", "donkihote2305@gmail.com"));
            mess.To.Add(new MailboxAddress("Dotnet tranning", email));
            mess.Subject = "Thông tin về đơn hàng của bạn trên KhanhShop";
            mess.Body = new TextPart("Plain")
            {
                Text = "Chúng tôi đã ghi nhận đơn hàng của bạn. Mã đơn hàng của bạn là " + code +
                ". Nếu có thắc mắc vui lòng liên hệ KhanhShop số 17 km17 QL27 Cukuin Dak Lak hoặc sdt: 0983975408"+
                "Cảm ơn bạn đã mua hàng!"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("donkihote2305@gmail.com", "");
                client.Send(mess);
                client.Disconnect(true);
            }
        }
        //random code invoice 
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghiklmnopqrstwz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //emit data using socket.io
        public async Task sendInvoidBySocket(Invoices invoice)
        {
            var context = ControllerContext.HttpContext;
            var isSocketRequest = context.WebSockets.IsWebSocketRequest;
            if (isSocketRequest)
            {
                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
            }
            else
            {
                context.Response.StatusCode = 400;
            }
            var inv = new { data = invoice, success = true,key="invoice" };
           await m_objectHandler.SendMessageToAllAsync(inv);
        }
    }
}