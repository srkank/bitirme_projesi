using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

/// <summary>
/// Summary description for MailGonder
/// </summary>
public static class MailGonder
{
    public static string MailYolla(string MailAdres,string Konu,string Mesaj)
    {
        string sonuc = "Bilgiler gönderilmiştir.";

        MailMessage mm = new MailMessage();
        mm.From = new MailAddress("mailadres@mailimiz.com");
        mm.To.Add(new MailAddress(MailAdres));
        mm.Subject = Konu;
        mm.Body = Mesaj;
        mm.IsBodyHtml = true;
        mm.BodyEncoding = System.Text.Encoding.UTF8;
        SmtpClient sc = new SmtpClient("mail.mailadrs.com", 587);
        sc.Credentials = new NetworkCredential("mailadres@mailimiz.com", "12456");
        try
        {
            sc.Send(mm);
        }
        catch (Exception ex)
        {

            sonuc = "Hata : " + ex.Message;
        }



        return sonuc;
    }
}