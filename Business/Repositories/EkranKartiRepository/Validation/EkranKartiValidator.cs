using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.EkranKartiRepository.Validation
{
    public class EkranKartiValidator : AbstractValidator<EkranKarti>
    {
        public EkranKartiValidator()
        {
        }
    }
}
