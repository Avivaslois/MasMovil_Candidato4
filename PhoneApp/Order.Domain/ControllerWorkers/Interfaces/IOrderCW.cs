using Order.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.ControllerWorkers
{
    public interface IOrderCW
    {
        Task<bool> submitOrder(OrderDto order);
        Task<List<OrderDetailResultDto>> getPhonePrices(List<OrderDetailDto> details);
        List<OrderDetailResultDto> completeResultInformation(OrderDto order, List<OrderDetailResultDto> detailsResults);
        string getBudgetMessage(CustomerDto customer, List<OrderDetailResultDto> detailsResults);
    }
}
