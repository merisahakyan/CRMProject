using DatabaseAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Data.Interfaces
{
    public interface IEmailTemplate
    {
        Task<EmailTemplate> GetEmailTemplateIdAsync(int id);
        Task<List<EmailTemplate>> GetEmailTemplatesAsync();
        Task<int> CreateEmailTemplateAsync(EmailTemplate emailTemplate);
        Task UpdateEmailTemplate(int id, EmailTemplate emailTemplate);
        Task DeleteEmailTemplate(int id);

    }
}
