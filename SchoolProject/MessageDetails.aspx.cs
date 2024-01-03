using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MessageDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // QueryString'den gelen ID'yi al
            if (Request.QueryString["ID"] != null)
            {
                int findId;
                // ID değerini sayıya çevirebiliyor muyuz kontrol et
                if (int.TryParse(Request.QueryString["ID"], out findId))
                {
                    // ID'ye göre mesajı veritabanından bul
                    List<EntityContact> contact = BLLContact.BLLContactDetails(findId);

                    // Eğer mesaj bulunduysa
                    if (contact != null && contact.Count > 0)
                    {
                        // Mesajın özelliklerini TextBox'lara atama
                        txtNameSurname.Text = contact[0].NAMESURNAME?.ToString();
                        txtMail.Text = contact[0].MAIL?.ToString();
                        txtSubject.Text = contact[0].SUBJECT?.ToString();
                        txtMessage.Text = contact[0].MESSAGE?.ToString();
                    }
                    else
                    {
                        // Belirtilen ID ile bir mesaj bulunamadı
                        // Uygun bir işlem yapabilirsiniz, örneğin bir hata mesajı gösterme
                    }
                }
                else
                {
                    // QueryString'den alınan ID değeri sayıya çevrilemiyor
                    // Uygun bir işlem yapabilirsiniz, örneğin bir hata mesajı gösterme
                }
            }
            else
            {
                // QueryString'de ID bulunamadı
                // Uygun bir işlem yapabilirsiniz, örneğin bir hata mesajı gösterme
            }
        }
    }
}