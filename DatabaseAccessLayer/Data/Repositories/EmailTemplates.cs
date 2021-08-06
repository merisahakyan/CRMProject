using DatabaseAccessLayer.Data.Interfaces;
using DatabaseAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Data.Repositories
{
    public class EmailTemplates : IEmailTemplates
    {
        public Task<int> CreateEmailTemplateAsync(EmailTemplate emailTemplate)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteEmailTemplate(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmailTemplate> GetEmailTemplateIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<EmailTemplate>> GetEmailTemplatesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateEmailTemplate(int id, EmailTemplate emailTemplate)
        {
            throw new System.NotImplementedException();
        }
    }
}
