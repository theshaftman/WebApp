using EAGetMail;
using KTConstruction.Model.DataViews;
using System.Collections.Generic;

namespace KTConstruction.Model.Interfaces
{
    public interface IMailModel
    {
        bool SendMail(string emailFrom, string emailContent);
    }
}