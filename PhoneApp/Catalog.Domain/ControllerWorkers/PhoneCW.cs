using Catalog.Domain.DTO;
using Catalog.Infrastructure.DTO;
using Catalog.Infrastructure.DTO.Mappers;
using Catalog.Infrastructure.Factories;
using Catalog.Infrastructure.Models;
using Catalog.Infrastructure.Models.Catalog.Infrastructure.Models;
using Catalog.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Domain.ControllerWorkers
{
    public class PhoneCW: IPhoneCW
    {
        private UnitOfWork<PhoneContext> Uow = new UnitOfWork<PhoneContext>(new PhoneContextFactory());
        private readonly IRepository<Phone> _phoneRepository;

        public PhoneCW()
        {
            _phoneRepository = Uow.GetRepository<Phone>();
        }

        public PhoneCW(IRepository<Phone> mockRepository)
        {
            _phoneRepository = mockRepository;
        }

        public PhoneDTO getPhoneByIdentifier(int identifier)
        {
            try
            {
                PhoneDTO returns = null;
                var data = _phoneRepository.FindById(identifier);
                if (data != null) { returns = DTOMapper.Phone_To_PhoneDto(data); }
                return returns;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<PhoneDTO> getPhones()
        {
            try
            {
                List<PhoneDTO> returns;

                returns = _phoneRepository.FindAll().Select(x => DTOMapper.Phone_To_PhoneDto(x)).ToList();

                return returns;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        public List<PhonePriceDTO> getPricesByIdentifiers(List<int> identifiers)
        {
            try
            {
                List<PhonePriceDTO> data = _phoneRepository.FindAll(x => identifiers.Any(y => y == x.Id))
                                                                 .Select(z => new PhonePriceDTO { PhoneId= z.Id, PhonePrice= z.Price }).ToList();
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
