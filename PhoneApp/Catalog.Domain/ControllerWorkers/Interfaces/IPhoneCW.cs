using Catalog.Domain.DTO;
using Catalog.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.ControllerWorkers
{
    public interface IPhoneCW 
    {
        List<PhoneDTO> getPhones();

        PhoneDTO getPhoneByIdentifier(int id);

        List<PhonePriceDTO> getPricesByIdentifiers(List<int> ids);
    }
}
