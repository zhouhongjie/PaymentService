using System;
using EasyAbp.PaymentService.Authorization;
using EasyAbp.PaymentService.Refunds.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.PaymentService.Refunds
{
    public class RefundAppService : CrudAppService<Refund, RefundDto, Guid, PagedAndSortedResultRequestDto, object, object>,
        IRefundAppService
    {
        protected override string GetPolicyName { get; set; } = PaymentServicePermissions.Refunds.Default;
        protected override string GetListPolicyName { get; set; } = PaymentServicePermissions.Refunds.Default;
        
        private readonly IRefundRepository _repository;

        public RefundAppService(IRefundRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}