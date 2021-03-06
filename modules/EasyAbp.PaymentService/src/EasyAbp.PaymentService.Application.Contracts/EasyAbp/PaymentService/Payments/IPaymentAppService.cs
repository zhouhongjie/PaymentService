using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.PaymentService.Payments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.PaymentService.Payments
{
    public interface IPaymentAppService :
        ICrudAppService< 
            PaymentDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            object,
            object>
    {
        Task<ListResultDto<PaymentMethodDto>> GetListPaymentMethod();
        
        Task<PaymentDto> PayAsync(PayDto input);
    }
}