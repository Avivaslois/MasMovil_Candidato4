using Catalog.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.DTO.Mappers
{
    public static partial class DTOMapper
    {
        //Possible improvement: Use Automapper or make the mappers with reflection and anonymous types.
        public static PhoneDTO Phone_To_PhoneDto(Phone entity)
        {
            PhoneDTO mappedEntity = new PhoneDTO();

            mappedEntity.Id = entity.Id;
            mappedEntity.Name = entity.Name;
            mappedEntity.Descrip = entity.Description;
            mappedEntity.Price = entity.Price;
            mappedEntity.ImgUrl = entity.ImgUrl;

            return mappedEntity;
        }

        public static Phone PhoneDto_To_Phone(PhoneDTO entity)
        {
            Phone mappedEntity = new Phone();

            mappedEntity.Id = entity.Id;
            mappedEntity.Name = entity.Name;
            mappedEntity.Description = entity.Descrip;
            mappedEntity.Price = entity.Price;
            mappedEntity.ImgUrl = entity.ImgUrl;

            return mappedEntity;
        }



    }
}
