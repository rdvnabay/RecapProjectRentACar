﻿using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.Languages.Commands
{
    public class DeleteLanguageCommand : IRequest<IResult>
    {
        private int Id { get; set; }

        public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommand, IResult>
        {
            private readonly ILanguageRepository _languageDal;
            private readonly IMediator _mediator;
            public DeleteLanguageCommandHandler(ILanguageRepository languageDal,IMediator mediator)
            {
                _languageDal = languageDal;
                _mediator = mediator;
            }


            public async Task<IResult> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
            {
                var languageToDelete = _languageDal.Get(x => x.Id == request.Id);

                _languageDal.Delete(languageToDelete);
                return new SuccessResult(Messages.Deleted);
            }
        }
    }
}


